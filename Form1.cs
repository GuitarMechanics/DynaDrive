using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;
using System.Linq.Expressions;
using MetroFramework.Controls;
using System.CodeDom;
using System.Runtime.InteropServices;
using System.IO;
using System.Drawing.Text;
using System.Net;
using System.Net.Sockets;
using winFormsTimer = System.Windows.Forms.Timer;
using System.Net.Http;
using System.Collections.Concurrent;
using System.Runtime.CompilerServices;

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

        winFormsTimer SteppingTimer = new winFormsTimer();
        winFormsTimer BendingTimer = new winFormsTimer();
        winFormsTimer CSVTimer = new winFormsTimer();
        private int stepTimerCnt = 0;
        private int stepRepeatTarget = 0;
        private int stepRepeatCurrent = 0;
        private int[,] stepdataArray;
        private double[,] bendDataArray;
        private int bendTimerCnt = 0;

        private bool autoBendRunning = false;
        private int autobendsteps = 0;
        private int csvAutoRowIndex = 0;

        private bool socketRunning = false;
        Task socketTask;
        TcpClient tcpClient;
        NetworkStream stream;
        Thread receiveThread;

        private ConcurrentQueue<(int v1, int v2, int v3)> receivedDataQueue = new ConcurrentQueue<(int, int, int)>();
        private CancellationTokenSource cts;

        private bool hapticEnable = false;

        private ConcurrentQueue<string> serialSendQueue = new ConcurrentQueue<string>();
        private ConcurrentQueue<string> serialReceiveQueue = new ConcurrentQueue<string>();
        private string serialReceiveBuffer = "";

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
            CSVTimer.Tick += new EventHandler(CSVTimerTick);

            screwDrive = new leadscrew_drive(leadLength, openRB);
            dualBend = new DualbendCalc(bendSets);

            var uitimer = new System.Windows.Forms.Timer();
            uitimer.Interval = 50;
            uitimer.Tick += UiTimer_Tick;
            uitimer.Start();
        }

        private void UiTimer_Tick(object sender, EventArgs e)
        {
            while (receivedDataQueue.TryDequeue(out var data))
            {
                int v1 = data.v1;
                int v2 = data.v2;
                int v3 = data.v3;

                socketRXTDLLabel.Text = (v1 / 100.0).ToString("F2") + " mm";
                socketRXDIRLabel.Text = (v2 / 100.0).ToString("F2") + " rad";
                socketRXMODELabel.Text = v3.ToString();
            }

            while (serialReceiveQueue.TryDequeue(out string serialPacket))
            {
                metroTextBox1.AppendText(serialPacket + Environment.NewLine);
                openRB.inputStrDecode(serialPacket);
                posUpdate();
            }
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
            if (mySerial == null || !mySerial.IsOpen)
            {
                mySerial.PortName = metroComboBox1.SelectedItem.ToString();
                mySerial.BaudRate = Convert.ToInt32(metroComboBox2.SelectedItem.ToString());
                mySerial.Parity = Parity.None;
                mySerial.StopBits = StopBits.One;
                mySerial.DataBits = 8;
                mySerial.ReadBufferSize = 20000000;
                //mySerial.DataReceived += PortDataReceived;
                try { mySerial.Open(); }
                catch(Exception ex) { MessageBox.Show(ex.Message, "Falied to open"); }
            }
        }

        private async Task SerialSendLoop(CancellationToken token)
        {
            while (!token.IsCancellationRequested)
            {
                if (serialSendQueue.TryDequeue(out string serialCmd))
                {
                    try
                    {
                        mySerial.WriteLine(serialCmd);
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine("Serial write failed: " + ex.Message);
                    }
                }
                else
                {
                    await Task.Delay(1);
                }
            }
        }

        // 시리얼 수신 루프 (수신 쓰레드)
        private async Task SerialReceiveLoop(CancellationToken token)
        {
            while (!token.IsCancellationRequested)
            {
                try
                {
                    string incoming = mySerial.ReadExisting(); // ★ string 그대로 수신

                    if (!string.IsNullOrEmpty(incoming))
                    {
                        serialReceiveBuffer += incoming;

                        int newlineIndex;
                        while ((newlineIndex = serialReceiveBuffer.IndexOf('\n')) >= 0)
                        {
                            string packet = serialReceiveBuffer.Substring(0, newlineIndex).Trim();
                            serialReceiveBuffer = serialReceiveBuffer.Substring(newlineIndex + 1);
                            serialReceiveQueue.Enqueue(packet);
                        }
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Serial receive error: " + ex.Message);
                }

                await Task.Delay(1); // CPU 과점유 방지
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
                serialSend();
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
            if (consolemonitorChkBox.Checked) Console.WriteLine(openRB.serialGen()[0]);
            else mySerial.WriteLine(openRB.serialGen()[0]);
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

        private List<string[]> ReadCSV(string filePath)
        {
            var csvData = new List<string[]>();
            try
            {
                using(StreamReader sr = new StreamReader(filePath))
                {
                    string line;
                    while((line = sr.ReadLine()) != null)
                    {
                        string[] row = line.Split(',');
                        csvData.Add(row);
                    }
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return csvData;
        }

        private void DisplayDataInGrid(List<string[]> csvData)
        {
            csvGrid.Rows.Clear();
            csvGrid.Columns.Clear();
            string[] headers = csvData[0];
            foreach (string header in headers) csvGrid.Columns.Add(header, header);
            for (int i = 1; i < csvData.Count; i++) csvGrid.Rows.Add(csvData[i]);
        }

        private void CSVOpenBtn_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog
            {
                Filter = "CSV Files (*.csv)|*.csv|All Files(*.*)|*.*",
                Title = "Select a CSV File"
            };
            if(openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string filePath = openFileDialog.FileName;
                List<string[]> csvData = ReadCSV(filePath);
                //console test
                //foreach (var row in csvData) Console.WriteLine(string.Join(",", row));
                DisplayDataInGrid(csvData);
            }

        }

        private void CSVRunBtn_Click(object sender, EventArgs e)
        {
            try
            {
                int interval = Convert.ToInt32(CSVIntervalTxtBox.Text);
                CSVTimer.Interval = interval;
            }
            catch (Exception)
            {
                CSVIntervalTxtBox.Text = "2000";
                CSVTimer.Interval = Convert.ToInt32(CSVIntervalTxtBox.Text);
            }
            if (csvGrid.Rows.Count > 0)
            {
                csvAutoRowIndex = 0;
                CSVTimer.Start();
            }
            else MessageBox.Show("No data imported");
        }

        private void CSVTimerTick(object sender, EventArgs e)
        {
            if (csvAutoRowIndex < csvGrid.Rows.Count)
            {
                if (!csvGrid.Rows[csvAutoRowIndex].IsNewRow)
                {
                    foreach (DataGridViewRow row in csvGrid.Rows) row.Selected = false; // clear selection
                    csvGrid.Rows[csvAutoRowIndex].Selected = true; // highlighting current row
                    csvGrid.FirstDisplayedScrollingRowIndex = csvAutoRowIndex; // auto-scroll
                    for (int i = 0; i < csvGrid.Rows[csvAutoRowIndex].Cells.Count; i++)
                    {
                        openRB.goalPos[i] = (CSVmmconvToggle.Checked) ?
                            Convert.ToInt32(screwDrive.trans2rot(csvGrid.Rows[csvAutoRowIndex].Cells[i].Value.ToString())) :
                            Convert.ToInt32(csvGrid.Rows[csvAutoRowIndex].Cells[i].Value.ToString());
                    }
                    serialSend();
                }
                else CSVTimer.Stop();
            }
            else CSVTimer.Stop();
            csvAutoRowIndex++;
        }

        private void CSVStopBtn_Click(object sender, EventArgs e)
        {
            CSVTimer.Stop();
        }

        private async void hapticSetBtn_Click(object sender, EventArgs e)
        {
            if (!socketRunning)
            {
                hapticSetBtn.Enabled = false; // 버튼 잠금 (중복 클릭 방지)

                tcpClient = new TcpClient();  // ← 여기에서 인스턴스 생성 확실히!
                try
                {
                    await tcpClient.ConnectAsync("localhost", 5000);
                    stream = tcpClient.GetStream();
                    socketRunning = true;
                    cts = new CancellationTokenSource();

                    _ = Task.Run(() => CommunicationLoop(cts.Token));
                    hapticSetBtn.Text = "DISCONNECT ";
                    hapticStatusLabel.Text = "TCP Only";
                    setTransConvBtn.PerformClick();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("error", ex.Message);
                    tcpClient?.Close();
                }
                finally
                {
                    hapticSetBtn.Enabled = true;
                }
            }

            else
            {
                StopSocket();
            }
        }

        private void StopSocket()
        {
            try
            {
                socketRunning = false;
                cts?.Cancel();
                stream?.Close();
                tcpClient?.Close();
                hapticStatusLabel.Text = "OFF";
                hapticSetBtn.Text = "CONNECT";
            }
            catch (Exception ex)
            {
                
            }
        }
        private async Task CommunicationLoop(CancellationToken token)
        {
            try
            {
                byte[] recvBuffer = new byte[12];
                byte[] sendBuffer = new byte[12];

                while (!token.IsCancellationRequested)
                {
                    // 수신 먼저
                    int totalBytesRead = 0;
                    while (totalBytesRead < 12)
                    {
                        int bytesRead = await stream.ReadAsync(recvBuffer, totalBytesRead, 12 - totalBytesRead, token);
                        if (bytesRead == 0)
                            throw new Exception("Server disconnected.");
                        totalBytesRead += bytesRead;
                    }

                    int v1 = BitConverter.ToInt32(recvBuffer, 0);
                    int v2 = BitConverter.ToInt32(recvBuffer, 4);
                    int v3 = BitConverter.ToInt32(recvBuffer, 8);

                    // 수신된 데이터를 UI 큐에 넣기
                    receivedDataQueue.Enqueue((v1, v2, v3));
                    double mt1tdrecv = v1 / 100.0 * Math.Cos(v2 / 100.0);
                    double mt2tdrecv = v1 / 100.0 * Math.Sin(v2 / 100.0);

                    int mtgoal1 = screwDrive.trans2rot(mt1tdrecv);
                    int mtgoal2 = screwDrive.trans2rot(mt2tdrecv);

                    int[] mtgoalarr = new int[4] { mtgoal1, mtgoal2, 0, 0 };

                    if (hapticEnable)
                    {
                        openRB.writeGoalPos(mtgoalarr);
                        serialSend();
                    }

                    // 송신 준비
                    int sendTDL = v1;  // 여기서는 echo만 예시
                    int sendDIR = v2;
                    int sendHLD = v3;

                    Array.Copy(BitConverter.GetBytes(sendTDL), 0, sendBuffer, 0, 4);
                    Array.Copy(BitConverter.GetBytes(sendDIR), 0, sendBuffer, 4, 4);
                    Array.Copy(BitConverter.GetBytes(sendHLD), 0, sendBuffer, 8, 4);
                    await stream.WriteAsync(sendBuffer, 0, sendBuffer.Length, token);
                }
            }
            catch (Exception ex)
            {
                this.Invoke(new Action(() =>
                {
                    MessageBox.Show(ex.Message, "Connection stopped");
                    StopSocket();
                }));
            }
        }
        private async Task ReceiveLoop()
        {
            try
            {
                byte[] recvBuffer = new byte[12];
                byte[] sendBuffer = new byte[12];

                while (socketRunning)
                {
                    // 1. 서버가 먼저 보내므로 수신 먼저
                    int totalBytesRead = 0;
                    while (totalBytesRead < 12)
                    {
                        int bytesRead = await stream.ReadAsync(recvBuffer, totalBytesRead, 12 - totalBytesRead);
                        if (bytesRead == 0)
                            throw new Exception("Server disconnected.");
                        totalBytesRead += bytesRead;
                    }

                    int v1 = BitConverter.ToInt32(recvBuffer, 0);
                    int v2 = BitConverter.ToInt32(recvBuffer, 4);
                    int v3 = BitConverter.ToInt32(recvBuffer, 8);

                    double mt1tdrecv = v1 / 100.0 * Math.Cos(v2 / 100.0);
                    double mt2tdrecv = v1 / 100.0 * Math.Sin(v2 / 100.0);

                    int mtgoal1 = screwDrive.trans2rot(mt1tdrecv);
                    int mtgoal2 = screwDrive.trans2rot(mt2tdrecv);

                    int[] mtgoalarr = new int[4] { mtgoal1, mtgoal2, 0, 0 };
                    this.Invoke(new Action(() =>
                    {
                        socketRXTDLLabel.Text = (v1 / 100.0).ToString("F2") + " mm";
                        socketRXDIRLabel.Text = (v2 / 100.0).ToString("F2") + " rad";
                        socketRXMODELabel.Text = v3.ToString();

                        if (hapticEnable)
                        {
                            openRB.writeGoalPos(mtgoalarr);
                            serialSend();
                        }
                    }));

                    // 2. 수신 후 바로 송신 (현재 상태 보내기)
                    float[] mtpos = screwDrive.rot2trans(openRB.presPos);
                    int sendTDL = (int)Math.Round(Math.Sqrt(mtpos[0] * mtpos[0] + mtpos[1] * mtpos[1]) * 100);
                    int sendDIR = (int)Math.Round(Math.Atan2(mtpos[1], mtpos[0]) * 100);
                    int sendHLD = hapticHoldToggle.Checked ? 1 : 0;

                    Array.Copy(BitConverter.GetBytes(sendTDL), 0, sendBuffer, 0, 4);
                    Array.Copy(BitConverter.GetBytes(sendDIR), 0, sendBuffer, 4, 4);
                    Array.Copy(BitConverter.GetBytes(sendHLD), 0, sendBuffer, 8, 4);

                    await stream.WriteAsync(sendBuffer, 0, sendBuffer.Length);
                }
            }
            catch (Exception ex)
            {
                this.Invoke(new Action(() =>
                {
                    MessageBox.Show(ex.Message, "Connection stopped");
                    socketRunning = false;
                    hapticSetBtn.Text = "CONNECT";
                    hapticStatusLabel.Text = "OFF";
                }));
            }
        }

        private void hapticOnOffBtn_Click(object sender, EventArgs e)
        {
            if (hapticEnable)
            {
                hapticEnable = false;
                hapticOnOffBtn.Text = "ON";
                hapticStatusLabel.Text = (socketRunning) ? "TCP Only" : "OFF";
            }
            else
            {
                hapticEnable = true;
                hapticOnOffBtn.Text = "OFF";
                hapticStatusLabel.Text = (socketRunning) ? "ON" : "CHK TCP";
            }
        }
    }
}
