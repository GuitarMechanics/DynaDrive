using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;
using System.Linq.Expressions;
using MetroFramework.Controls;
using System.CodeDom;
using System.Runtime.InteropServices;

// 솔루션용 nuget 설치 필요: metroui
// https://luckygg.tistory.com/302

namespace DynaDrive
{
    public partial class Form1 : MetroFramework.Forms.MetroForm
    {
        private SerialPort mySerial = new SerialPort();
        private string ReceiveData;
        public MetroLabel[] targetLabels = new MetroLabel[4];
        public MetroLabel[] currentLabels = new MetroLabel[4];
        public MetroLabel[] diffLabels = new MetroLabel[4];
        public MetroToggle[] mtToggles = new MetroToggle[4];
        public MetroTextBox[] mtDirTargets = new MetroTextBox[4];
        public MetroTextBox[] pidPGains = new MetroTextBox[4];
        public MetroTextBox[] PGFroms = new MetroTextBox[4];
        public MetroTextBox[] PGTos = new MetroTextBox[4];
        public MetroTextBox[] PGSteps = new MetroTextBox[4];
        public MetroToggle[] PGToggles = new MetroToggle[4];

        public MetroTextBox[,] bendCtrs = new MetroTextBox[2,2];
        public MetroTextBox[] bendSets = new MetroTextBox[3];

        private OpenRBSerialGen openRB = new OpenRBSerialGen();
        private int stepsize = 0;
        private bool stepRun = false;

        private float leadLength = 10;
        private leadscrew_drive screwDrive;
        private bool transConv = false;

        private DualbendCalc dualBend;

        Timer SteppingTimer = new Timer();
        Timer BendingTimer = new Timer();
        private int stepTimerCnt = 0;
        private int stepRepeatTarget = 0;
        private int stepRepeatCurrent = 0;
        private int[,] stepdataArray;
        private double[,] bendDataArray;
        private int bendTimerCnt = 0;

        private bool autoBendRunning = false;
        private int autobendsteps = 0;


        public Form1()
        {
            InitializeComponent();
            updateSerialPort();
            targetLabels[0] = targetLabel1; targetLabels[1] = targetLabel2;
            targetLabels[2] = targetLabel3; targetLabels[3] = targetLabel4;

            currentLabels[0] = currentLabel1; currentLabels[1] = currentLabel2;
            currentLabels[2] = currentLabel3; currentLabels[3] = currentLabel4;

            diffLabels[0] = diffLabel1; diffLabels[1] = diffLabel2;
            diffLabels[2] = diffLabel3; diffLabels[3] = diffLabel4;

            mtToggles[0] = mt1Toggle; mtToggles[1] = mt2Toggle;
            mtToggles[2] = mt3Toggle; mtToggles[3] = mt4Toggle;

            mtDirTargets[0] = mt1DirectTxtBox; mtDirTargets[1] = mt2DirectTxtBox;
            mtDirTargets[2] = mt3DirectTxtBox; mtDirTargets[3] = mt4DirectTxtBox;

            pidPGains[0] = pid1gain; pidPGains[1] = pid2gain;
            pidPGains[2] = pid3gain; pidPGains[3] = pid4gain;

            PGFroms[0] = PGmt1FromTxtBox; PGFroms[1] = PGmt2FromTxtBox;
            PGFroms[2] = PGmt3FromTxtBox; PGFroms[3] = PGmt4FromTxtBox;

            PGTos[0] = PGmt1ToTxtBox; PGTos[1] = PGmt2ToTxtBox;
            PGTos[2] = PGmt3ToTxtBox; PGTos[3] = PGmt4ToTxtBox;

            PGSteps[0] = PGmt1StepTxtBox; PGSteps[1] = PGmt2StepTxtBox;
            PGSteps[2] = PGmt3StepTxtBox; PGSteps[3] = PGmt4StepTxtBox;

            PGToggles[0] = PGmt1Toggle; PGToggles[1] = PGmt2Toggle;
            PGToggles[2] = PGmt3Toggle; PGToggles[3] = PGmt4Toggle;

            bendCtrs[0,0] = seg1BendTxtBox; bendCtrs[0, 1] = seg1DirTxtBox;
            bendCtrs[1, 0] = seg2BendTxtBox; bendCtrs[1, 1] = seg2DirTxtBox;

            bendSets[0] = bendDiskRadTxtBox; bendSets[1] = bendTotLengthTxtBox;
            bendSets[2] = bendProxLenTxtBox;

            SteppingTimer.Tick += new EventHandler(stepTimerTick);
            //updateSerialPort();
            BendingTimer.Tick += new EventHandler(bendTimerTick);

            screwDrive = new leadscrew_drive(leadLength, openRB);
            dualBend = new DualbendCalc(bendSets);
        }

        private void updateSerialPort()
        {
            metroComboBox1.Items.Clear();
            foreach (var item in SerialPort.GetPortNames()) metroComboBox1.Items.Add(item);
            if(metroComboBox1.Items.Count == 1) // automatically opens serial port if only one active port exists
            {
                metroComboBox1.SelectedIndex = 0;
                metroComboBox2.SelectedIndex = 0;
                mySerial.PortName = metroComboBox1.SelectedItem.ToString();
                mySerial.BaudRate = Convert.ToInt32(metroComboBox2.SelectedItem.ToString());
                mySerial.Parity = Parity.None;
                mySerial.StopBits = StopBits.One;
                mySerial.DataBits = 8;
                mySerial.ReadBufferSize = 20000000;
                mySerial.DataReceived += PortDataReceived;
                try { mySerial.Open(); }
                catch (Exception ex) { MessageBox.Show(ex.Message, "Falied to open"); }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void serialOpenBtn_Click(object sender, EventArgs e)
        {
            if (!mySerial.IsOpen)
            {
                mySerial.PortName = metroComboBox1.SelectedItem.ToString();
                mySerial.BaudRate = Convert.ToInt32(metroComboBox2.SelectedItem.ToString());
                mySerial.Parity = Parity.None;
                mySerial.StopBits = StopBits.One;
                mySerial.DataBits = 8;
                mySerial.ReadBufferSize = 20000000;
                mySerial.DataReceived += PortDataReceived;
                try { mySerial.Open(); }
                catch(Exception ex) { MessageBox.Show(ex.Message, "Falied to open"); }
            }
        }
        private void PortDataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            try {if(mySerial.IsOpen) ReceiveData = mySerial.ReadLine(); }
            catch (Exception ex) { MessageBox.Show(ex.Message);}
            try
            {
                  this.Invoke(new Action(ProcessingData));
            }
            catch(ObjectDisposedException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        private void ProcessingData()
        {
            string tmpStr = ReceiveData.ToString();
            if (metroTextBox1.Lines.Length > 150) metroTextBox1.Text = "";
            metroTextBox1.AppendText(tmpStr + Environment.NewLine);
            openRB.inputStrDecode(tmpStr);
            posUpdate();
        }
        private void posUpdate()
        {
            if (!transConv)
            {
                int diffMax = 0;
                for (int i = 0; i < 4; i++)
                {
                    if (mtToggles[i].Checked)
                    {
                        targetLabels[i].Text = openRB.goalPos[i].ToString();
                        currentLabels[i].Text = openRB.presPos[i].ToString();
                        int diffTemp = openRB.presPos[i] - openRB.goalPos[i];
                        if (Math.Abs(diffTemp) > diffMax) diffMax = Math.Abs(diffTemp);
                        if (diffTemp > 0) diffLabels[i].Text = "+" + diffTemp.ToString();
                        else if (diffTemp < 0) diffLabels[i].Text = diffTemp.ToString();
                        else diffLabels[i].Text = "0";
                    }
                    else
                    {
                        targetLabels[i].Text = "";
                        currentLabels[i].Text = "";
                        diffLabels[i].Text = "";
                    }
                }
                posInaccurate_labelTrigger(diffMax > 10);
                autoStepper_LabelTrigger(SteppingTimer.Enabled);
                autoStepper_LabelTrigger(BendingTimer.Enabled);
            }
            else
            {
                float diffMax = 0;
                float[] targetValues = screwDrive.rot2trans(this.openRB.goalPos);
                float[] currentValues = screwDrive.rot2trans(this.openRB.presPos);
                for(int i = 0; i<4; i++)
                {
                    if (mtToggles[i].Checked)
                    {
                        targetLabels[i].Text = targetValues[i].ToString();
                        currentLabels[i].Text = currentValues[i].ToString();
                        float diffTemp = currentValues[i] - targetValues[i];
                        if (Math.Abs(diffTemp) > diffMax) diffMax = Math.Abs(diffTemp);
                        if (diffTemp > 0) diffLabels[i].Text = "+" + diffTemp.ToString();
                        else if (diffTemp < 0) diffLabels[i].Text = diffTemp.ToString();
                        else diffLabels[i].Text = "0";
                    }
                    else
                    {
                        targetLabels[i].Text = "";
                        currentLabels[i].Text = "";
                        diffLabels[i].Text = "";
                    }
                }
                posInaccurate_labelTrigger(diffMax > 0.1);
                autoStepper_LabelTrigger(SteppingTimer.Enabled);
                autoStepper_LabelTrigger(BendingTimer.Enabled);
            }
        }
        private void posInaccurate_labelTrigger(bool isInAccurate)
        {
            if (isInAccurate) { posInAccurateLabel.Text = "Pos Inaccurate"; }
            else posInAccurateLabel.Text = "";
        }
        private void autoStepper_LabelTrigger(bool isRunning)
        {
            if (isRunning && stepRun)
            {
                AutoStepperRunLabel.Text = "AutoStep Running";
                StepCounterLabel.Text = "Step " + stepTimerCnt.ToString() + " / " + stepdataArray.GetLength(0);
            }
            else if (isRunning && autoBendRunning)
            {
                AutoStepperRunLabel.Text = "Autobend Running";
                StepCounterLabel.Text = "Step " + bendTimerCnt.ToString() + " / " + autobendsteps;
            }
            else
            {
                AutoStepperRunLabel.Text = "";
                StepCounterLabel.Text = "";
            }

        }

        private void dirGoBtn_Click(object sender, EventArgs e)
        {
            if (!transConv)
            {
                for (int i = 0; i < 4; i++)
                {
                    if (!mtToggles[i].Checked) continue;
                    try
                    {
                        openRB.goalPos[i] = Convert.ToInt32(mtDirTargets[i].Text.ToString());
                    }
                    catch (Exception) { }

                }
                mySerial.WriteLine(openRB.serialGen()[0]);
            }
            else
            {
                double[] transTargetPos = new double[mtDirTargets.Length];
                int[] mtGoalPos = new int[mtDirTargets.Length];
                for (int i = 0; i < mtDirTargets.Length; i++)
                {
                    if (!mtToggles[i].Checked) continue;
                    else
                    {
                        try
                        {
                            string tmpStr = mtDirTargets[i].Text.ToString();
                            mtGoalPos[i] = screwDrive.trans2rot(tmpStr);
                            Console.WriteLine(i+ " " + tmpStr + " " + mtGoalPos[i]);
                        }
                        catch (Exception ex)
                        {
                            mtDirTargets[i].Text = "0";
                            mtGoalPos[i] = 0;
                        }
                    }
                }
                openRB.writeGoalPos(mtGoalPos);
                serialSend();
            }
        }

        private void mtCenterBtn_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 4; i++) openRB.goalPos[i] = 0;
            serialSend();
        }

        private void stepSetBtn_Click(object sender, EventArgs e)
        {
            try
            {
                stepsize = Convert.ToInt32(stepSizeTxtBox.Text.ToString());
            }
            catch (Exception) { stepsize = 256; }
            finally
            {
                stepSizeIndLabel.Text = stepsize * 360 / 4096.0 + " deg";
            }
        }

        private void serialSend()
        {
            mySerial.WriteLine(openRB.serialGen()[0]);
        }

        private void mt1StepUpBtn_Click(object sender, EventArgs e)
        {
            openRB.goalPos[0] += stepsize; serialSend();
            
        }

        private void mt1StepDnBtn_Click(object sender, EventArgs e)
        {
            openRB.goalPos[0] -= stepsize; serialSend();
        }

        private void mt2StepUpBtn_Click(object sender, EventArgs e)
        {
            openRB.goalPos[1] += stepsize; serialSend();
        }

        private void mt2StepDnBtn_Click(object sender, EventArgs e)
        {
            openRB.goalPos[1] -= stepsize; serialSend();
        }

        private void mt3StepUpBtn_Click(object sender, EventArgs e)
        {
            openRB.goalPos[2] += stepsize; serialSend();
        }

        private void mt3StepDnBtn_Click(object sender, EventArgs e)
        {
            openRB.goalPos[2] -= stepsize; serialSend();
        }

        private void mt4StepUpBtn_Click(object sender, EventArgs e)
        {
            openRB.goalPos[3] += stepsize; serialSend();
        }

        private void mt4StepDnBtn_Click(object sender, EventArgs e)
        {
            openRB.goalPos[3] -= stepsize; serialSend();
        }


        private void setApplyBtn_Click(object sender, EventArgs e)
        {
            int[] pidTmp = new int[4];
            for(int i = 0; i<4; i++)
            {
                try { pidTmp[i] = Convert.ToInt32(pidPGains[i].Text.ToString()); }
                catch (Exception) { pidPGains[i].Text = "400"; pidTmp[i] = 400; }
            }
            openRB.writePGains(pidTmp);
            openRB.writeAccMode(4 - accComboBox.SelectedIndex);
            openRB.manageSpeed = spdAutoAdjToggle.Checked;
            try 
            { 
                openRB.maxSpd = Convert.ToInt32(spdRawTxtBox.Text.ToString());
                spdRPMConvLabel.Text = "=" + openRB.maxSpd * 0.229 + " r/min";
            }
            catch (Exception)
            {
                openRB.maxSpd = 300;
                spdRPMConvLabel.Text = "=" + 300 * 0.229 + " r/min";
            }
            serialSend();
        }

        private void rxLogClrBtn_Click(object sender, EventArgs e)
        {
            metroTextBox1.Text= string.Empty;
        }

        private void metroButton1_Click(object sender, EventArgs e) // AutoStep on
        {
            int timeIntervals;
            bool[] mtAvails = new bool[4];
            for (int i = 0; i < 4; i++)
            {
                mtAvails[i] = PGToggles[i].Checked;

            }
            try { timeIntervals = Convert.ToInt32(timeIntervalTxtBox.Text.ToString()); }
            catch (Exception) { timeIntervals = 2000; timeIntervalTxtBox.Text = "2000"; }
            try { stepRepeatTarget = Convert.ToInt32(repeatsTxtBox.Text.ToString()); }
            catch (Exception) { stepRepeatTarget = 1; repeatsTxtBox.Text = "1"; }
            AutoStepping stepDatas = new AutoStepping(PGFroms, PGTos, PGSteps, mtAvails, PGRoundTripToggle.Checked, stepRepeatTarget, transConv);
            stepdataArray = stepDatas.RunDataGen();
            SteppingTimer.Interval = timeIntervals;
            stepTimerCnt = 0;
            autostepRun();
        }

        private void autostepRun()
        {
            stepRun = true;           
            SteppingTimer.Start();
        }

        private void stepTimerTick(object sender, EventArgs e)
        {
            if(stepTimerCnt > stepdataArray.GetLength(0))
            {
                SteppingTimer.Stop();
            }
            else
            {
                stepTimerTickWritelines(stepdataArray,stepTimerCnt);
            }

        }
        private void stepTimerTickWritelines(int[,] values, int rowcount)
        {
            try
            {
                for (int i = 0; i < 4; i++) { openRB.goalPos[i] = values[rowcount, i]; }
                Console.WriteLine(openRB.serialGen()[0]);
                serialSend();
            }
            catch (Exception) { SteppingTimer.Stop(); }
            
            stepTimerCnt++;
        }

        private void serialCloseBtn_Click(object sender, EventArgs e)
        {
            mySerial.Close();
        }

        private void metroButton2_Click(object sender, EventArgs e) // AutoStep off
        {
            if(stepRun) SteppingTimer.Stop();
            stepRun= false;
        }

        private void SetupPresetComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (SetupPresetComboBox.SelectedIndex)
            {
                case 0: // HP Fast
                    foreach(var items in pidPGains) { items.Text = "1800"; }
                    spdRawTxtBox.Text = "500";
                    accComboBox.SelectedIndex = 1;
                    break;
                case 1: // HP Medium
                    foreach(var items in pidPGains) { items.Text = "1800"; }
                    spdRawTxtBox.Text = "300";
                    accComboBox.SelectedIndex = 1;
                    break;
                case 2: // HP Slow
                    foreach(var items in pidPGains) { items.Text = "1800"; }
                    spdRawTxtBox.Text = "200";
                    accComboBox.SelectedIndex = 2;
                    break;
                case 3: // ST Fast
                    foreach(var items in pidPGains) { items.Text = "1000"; }
                    spdRawTxtBox.Text = "500";
                    accComboBox.SelectedIndex = 1;
                    break;
                case 4: // ST Medium
                    foreach(var items in pidPGains) { items.Text = "1000"; }
                    spdRawTxtBox.Text = "300";
                    accComboBox.SelectedIndex = 1;
                    break;
                case 5: // ST Slow
                    foreach(var items in pidPGains) { items.Text = "1000"; }
                    spdRawTxtBox.Text = "200";
                    accComboBox.SelectedIndex = 2;
                    break;
            }
        }

        private void metroComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {        }

        private void metroComboBox1_DropDown(object sender, EventArgs e)
        {
            updateSerialPort();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                openRB.writeGoalCenter();
                serialSend();
            }
            catch (Exception ex) { };

        }

        private void setRotRawModeBtn_Click(object sender, EventArgs e)
        {
            this.transConv = false;
        }

        private void setTransConvBtn_Click(object sender, EventArgs e)
        {
            this.transConv = true;
        }

        private void bendCtrCenterBtn_Click(object sender, EventArgs e)
        {
            mtCenterBtn_Click(sender,e);
        }

        private void bendCtrSetBtn_Click(object sender, EventArgs e)
        {
            string[] consoleStr = new string[2];
            int[] convVal = new int[4];
            double[] outval = dualBend.getTargetTrans(bendCtrs);
            for(int i = 0; i < outval.Length; i++)
            {
                convVal[i] = screwDrive.trans2rot(outval[i]);
            }
            if (consolemonitorChkBox.Checked)
            {
                for(int i = 0 ; i < outval.Length ; i++)
                {
                    Console.Write(outval[i].ToString());
                    Console.Write(",");
                }
                Console.WriteLine("0");
            }
            else
            {
                openRB.writeGoalPos(convVal);
                serialSend();
            }             
            double[] angleVal = dualBend.getDistalOrient();
            string distalStr = "Dist Angle Vct : ";
            foreach(double var in angleVal)
            {
                distalStr += (Math.Round(var * 100) / 100).ToString() + "  ";
            }
            distalAngleLabel.Text = distalStr;
            //double[] distPos = dualBend.getDistalPos();
            //string distalPosStr = "Dist.Tip Pos : " + distPos[0] + " " + distPos[1] + " " + distPos[2];
            //Console.WriteLine("Dist Pos Debug : " + distPos[0] + " , " + distPos[1] + " , " + distPos[2]);
            //distPosLabel.Text = distalPosStr;
        }

        private void BendSetupSetBtn_Click(object sender, EventArgs e)
        {
            dualBend.getProperties(bendSets);
        }

        private double txtBox2Double(MetroTextBox txtBox)
        {
            try { return Convert.ToDouble(txtBox.Text); }
            catch (Exception)
            {
                Console.WriteLine("ex in txtbox2double");
                txtBox.Text = "0";
                return 0;
            }
        }

        private void AutobendRunBtn_Click(object sender, EventArgs e)
        {
            if (bendDataArray != null) bendDataArray = null;
            double proxBendStart = txtBox2Double(ProxBendStartTxtBox);
            double proxBendGoal = txtBox2Double(ProxBendGoalTxtBox);
            double proxDirStart = txtBox2Double(ProxDirStartTxtBox);
            double proxDirGoal = txtBox2Double(ProxDirGoalTxtBox);

            double distBendStart = txtBox2Double(DistBendStartTxtBox);
            double distBendGoal = txtBox2Double(DistBendGoaltTxtBox);
            double distDirStart = txtBox2Double(DistDirStartTxtBox);
            double distDirGoal = txtBox2Double(DistDirGoalTxtBox);

            double bendStep = txtBox2Double(AutobendBendStepTxtBox);
            double dirStep = txtBox2Double(AutobendDirStepTxtBox);

            int timeInterval = 2000;
            int repeats = 1;

            double proxBendCurrent = proxBendStart;
            double proxDirCurrent = proxDirStart;
            double distBendCurrent = distBendStart;
            double distDirCurrent = distDirStart;

            double[] proxBendVals = getStepArray(proxBendStart,proxBendGoal,bendStep);
            double[] proxDirVals = getStepArray(proxDirStart,proxDirGoal,dirStep);
            double[] distBendVals = getStepArray(distBendStart, distBendGoal, bendStep);
            double[] distDirVals = getStepArray(distDirStart, distDirGoal, dirStep);

            autobendsteps = getStepCounts(proxBendStart, proxBendGoal, bendStep) * getStepCounts(proxDirStart, proxDirGoal, dirStep)
                 * getStepCounts(distBendStart, distBendGoal, bendStep) * getStepCounts(distDirStart, distDirGoal, dirStep);

            bendDataArray = new double[autobendsteps, 4];

            int indexCount = 0;
            for(int pb = 0; pb < proxBendVals.Length; pb++)
            {
                for(int pd = 0; pd < proxDirVals.Length; pd++)
                {
                    for(int db = 0; db < distBendVals.Length; db++)
                    {
                        for(int dd = 0; dd < distDirVals.Length; dd++)
                        {
                            bendDataArray[indexCount, 3] = distDirVals[dd];
                            bendDataArray[indexCount, 2] = distBendVals[db];
                            bendDataArray[indexCount, 1] = proxDirVals[pd];
                            bendDataArray[indexCount, 0] = proxBendVals[pb];
                            distDirCurrent += dirStep;
                            for (int i = 0; i < 4; i++)
                            {
                                Console.Write(bendDataArray[indexCount, i] + " , ");
                            }
                            Console.WriteLine();
                            indexCount++;

                        }
                        distBendCurrent += bendStep;
                    }
                    proxDirCurrent += dirStep;
                }
                proxBendCurrent += bendStep;
            }


            try { timeInterval = Convert.ToInt32(AutobendIntTxtBox); }
            catch(Exception) { AutobendIntTxtBox.Text = "2000"; Console.WriteLine("TimeInterval Set by Default"); }

            try { repeats = Convert.ToInt32(AutobendRepeatTxtBox);}
            catch(Exception) { AutobendRepeatTxtBox.Text = "1"; Console.WriteLine("Repeat Set by Default"); }

            BendingTimer.Interval = timeInterval;
            bendTimerCnt = 0;
            autobendRun();
        }

        private void autobendRun()
        {
            autoBendRunning = true;
            BendingTimer.Start();
        }

        private void bendTimerTick(object sender, EventArgs e)
        {
            if (bendTimerCnt >= autobendsteps)
            {
                BendingTimer.Stop();
            }
            else
            {
                bendTimerTickWritelines(bendDataArray, bendTimerCnt);
            }
        }

        private void bendTimerTickWritelines(double[,] values, int rowcount)
        {
            //Console.WriteLine("bendTimerTick run");
            seg1BendTxtBox.Text = values[rowcount, 0].ToString();
            seg1DirTxtBox.Text = values[rowcount, 1].ToString();
            seg2BendTxtBox.Text = values[rowcount, 2].ToString();
            seg2DirTxtBox.Text = values[rowcount, 3].ToString();
            bendTimerCnt++;
            bendCtrSetBtn.PerformClick();
        }
        private int getStepCounts(double start, double end, double step)
        {
            if (start == end) return 1;
            else return Convert.ToInt32((end - start) / step + 1);
        }
        private double[] getStepArray(double start, double end, double step)
        {
            double[] retArr = new double[getStepCounts(start, end, step)];
            retArr[0] = start;
            for(int i = 1; i<retArr.Length; i++)
            {
                retArr[i] = retArr[i - 1] + step;
            }
            return retArr;
        }

        private void AutobendStopBtn_Click(object sender, EventArgs e)
        {
            BendingTimer.Stop();
            bendTimerCnt = 0;
            autoBendRunning= false;
            bendCtrCenterBtn.PerformClick();
        }

        private void AutobendHoldBtn_Click(object sender, EventArgs e)
        {
            BendingTimer.Stop();
            bendTimerCnt = 0;
            autoBendRunning = false;
        }
    }
}
