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
        private OpenRBSerialGen openRB = new OpenRBSerialGen();
        private int stepsize = 0;
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
            ReceiveData = mySerial.ReadLine();
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
            for(int i = 0; i<4; i++)
            {
                if (mtToggles[i].Checked)
                {
                    targetLabels[i].Text = openRB.goalPos[i].ToString();
                    currentLabels[i].Text = openRB.presPos[i].ToString();
                    int diffTemp = openRB.presPos[i] - openRB.goalPos[i];
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
    }
}
