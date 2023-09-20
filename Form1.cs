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


        private OpenRBSerialGen openRB = new OpenRBSerialGen();
        private int stepsize = 0;
        private bool stepRun = false;

        Timer SteppingTimer = new Timer();
        private int stepTimerCnt = 0;
        private int stepRepeatTarget = 0;
        private int stepRepeatCurrent = 0;
        private int[,] stepdataArray;

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

            SteppingTimer.Tick += new EventHandler(stepTimerTick);
        }

        private void updateSerialPort()
        {
            metroComboBox1.Items.Clear();
            foreach (var item in SerialPort.GetPortNames()) metroComboBox1.Items.Add(item);
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
            metroTextBox1.AppendText(tmpStr + Environment.NewLine);
            openRB.inputStrDecode(tmpStr);
            posUpdate();
        }
        private void posUpdate()
        {
            int diffMax = 0;
            for(int i = 0; i<4; i++)
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
        }
        private void posInaccurate_labelTrigger(bool isInAccurate)
        {
            if (isInAccurate) { posInAccurateLabel.Text = "Pos Inaccurate"; }
            else posInAccurateLabel.Text = "";
        }
        private void autoStepper_LabelTrigger(bool isRunning)
        {
            if (isRunning)
            {
                AutoStepperRunLabel.Text = "AutoStep Running";
                StepCounterLabel.Text = "Step " + stepTimerCnt.ToString() + " / " + stepdataArray.GetLength(0);
            }
            else
            {
                AutoStepperRunLabel.Text = "";
                StepCounterLabel.Text = "";
            }

        }

        private void dirGoBtn_Click(object sender, EventArgs e)
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
            AutoStepping stepDatas = new AutoStepping(PGFroms, PGTos, PGSteps, mtAvails, PGRoundTripToggle.Checked, stepRepeatTarget);
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
            openRB.writeGoalCenter();
            serialSend();
        }
    }
}
