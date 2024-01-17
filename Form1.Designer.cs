using System.Security.Cryptography.X509Certificates;

namespace DynaDrive
{
    partial class Form1
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            MetroFramework.Controls.MetroTabPage Setup;
            MetroFramework.Controls.MetroLabel metroLabel36;
            this.setApplyBtn = new MetroFramework.Controls.MetroButton();
            this.spdAutoAdjToggle = new MetroFramework.Controls.MetroToggle();
            this.metroLabel33 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel32 = new MetroFramework.Controls.MetroLabel();
            this.accComboBox = new MetroFramework.Controls.MetroComboBox();
            this.spdRPMConvLabel = new MetroFramework.Controls.MetroLabel();
            this.metroLabel31 = new MetroFramework.Controls.MetroLabel();
            this.spdRawTxtBox = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel30 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel29 = new MetroFramework.Controls.MetroLabel();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.metroLabel25 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel26 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel27 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel28 = new MetroFramework.Controls.MetroLabel();
            this.pid1gain = new MetroFramework.Controls.MetroTextBox();
            this.pid2gain = new MetroFramework.Controls.MetroTextBox();
            this.pid3gain = new MetroFramework.Controls.MetroTextBox();
            this.pid4gain = new MetroFramework.Controls.MetroTextBox();
            this.metroComboBox1 = new MetroFramework.Controls.MetroComboBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroComboBox2 = new MetroFramework.Controls.MetroComboBox();
            this.serialOpenBtn = new MetroFramework.Controls.MetroButton();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
            this.rxLogClrBtn = new MetroFramework.Controls.MetroButton();
            this.metroTextBox1 = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel7 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel8 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel9 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel10 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel11 = new MetroFramework.Controls.MetroLabel();
            this.mt1Toggle = new MetroFramework.Controls.MetroToggle();
            this.mt2Toggle = new MetroFramework.Controls.MetroToggle();
            this.mt3Toggle = new MetroFramework.Controls.MetroToggle();
            this.mt4Toggle = new MetroFramework.Controls.MetroToggle();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.diffLabel4 = new MetroFramework.Controls.MetroLabel();
            this.currentLabel4 = new MetroFramework.Controls.MetroLabel();
            this.currentLabel1 = new MetroFramework.Controls.MetroLabel();
            this.currentLabel3 = new MetroFramework.Controls.MetroLabel();
            this.diffLabel3 = new MetroFramework.Controls.MetroLabel();
            this.diffLabel2 = new MetroFramework.Controls.MetroLabel();
            this.currentLabel2 = new MetroFramework.Controls.MetroLabel();
            this.diffLabel1 = new MetroFramework.Controls.MetroLabel();
            this.targetLabel1 = new MetroFramework.Controls.MetroLabel();
            this.targetLabel2 = new MetroFramework.Controls.MetroLabel();
            this.targetLabel3 = new MetroFramework.Controls.MetroLabel();
            this.targetLabel4 = new MetroFramework.Controls.MetroLabel();
            this.metroTabControl1 = new MetroFramework.Controls.MetroTabControl();
            this.DirectControl = new MetroFramework.Controls.MetroTabPage();
            this.metroLabel24 = new MetroFramework.Controls.MetroLabel();
            this.stepSetBtn = new MetroFramework.Controls.MetroButton();
            this.stepSizeIndLabel = new MetroFramework.Controls.MetroLabel();
            this.stepSizeTxtBox = new MetroFramework.Controls.MetroTextBox();
            this.mtCenterBtn = new MetroFramework.Controls.MetroButton();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.mt4StepDnBtn = new MetroFramework.Controls.MetroButton();
            this.mt3StepDnBtn = new MetroFramework.Controls.MetroButton();
            this.mt2StepDnBtn = new MetroFramework.Controls.MetroButton();
            this.mt2StepUpBtn = new MetroFramework.Controls.MetroButton();
            this.mt1StepDnBtn = new MetroFramework.Controls.MetroButton();
            this.metroLabel23 = new MetroFramework.Controls.MetroLabel();
            this.mt1StepUpBtn = new MetroFramework.Controls.MetroButton();
            this.metroLabel20 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel21 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel22 = new MetroFramework.Controls.MetroLabel();
            this.mt3StepUpBtn = new MetroFramework.Controls.MetroButton();
            this.mt4StepUpBtn = new MetroFramework.Controls.MetroButton();
            this.dirGoBtn = new MetroFramework.Controls.MetroButton();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.metroLabel19 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel18 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel17 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel16 = new MetroFramework.Controls.MetroLabel();
            this.mt1DirectTxtBox = new MetroFramework.Controls.MetroTextBox();
            this.mt2DirectTxtBox = new MetroFramework.Controls.MetroTextBox();
            this.mt3DirectTxtBox = new MetroFramework.Controls.MetroTextBox();
            this.mt4DirectTxtBox = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel15 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel14 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel13 = new MetroFramework.Controls.MetroLabel();
            this.MovementControl = new MetroFramework.Controls.MetroTabPage();
            this.metroLabel60 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel42 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel41 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel40 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel39 = new MetroFramework.Controls.MetroLabel();
            this.metroButton2 = new MetroFramework.Controls.MetroButton();
            this.CtrCenterBtn = new MetroFramework.Controls.MetroButton();
            this.McGoBt = new MetroFramework.Controls.MetroButton();
            this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
            this.MC_tube2_rt = new MetroFramework.Controls.MetroTextBox();
            this.MC_tube1_tr = new MetroFramework.Controls.MetroTextBox();
            this.MC_tube2_tr = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel35 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel37 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel38 = new MetroFramework.Controls.MetroLabel();
            this.MC_tube1_rt = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel43 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel12 = new MetroFramework.Controls.MetroLabel();
            this.PositionControl = new MetroFramework.Controls.MetroTabPage();
            this.metroLabel59 = new MetroFramework.Controls.MetroLabel();
            this.PcZOriTxtbox = new MetroFramework.Controls.MetroTextBox();
            this.PcYOriTxtbox = new MetroFramework.Controls.MetroTextBox();
            this.PcXOriTxtbox = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel58 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel57 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel56 = new MetroFramework.Controls.MetroLabel();
            this.PcTboToggle = new MetroFramework.Controls.MetroToggle();
            this.PcTolToggle = new MetroFramework.Controls.MetroToggle();
            this.metroLabel55 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel54 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel53 = new MetroFramework.Controls.MetroLabel();
            this.PcZPosTxtbox = new MetroFramework.Controls.MetroTextBox();
            this.PcYPosTxtbox = new MetroFramework.Controls.MetroTextBox();
            this.PcXPosTxtbox = new MetroFramework.Controls.MetroTextBox();
            this.PcGetXyzPosBtn = new MetroFramework.Controls.MetroButton();
            this.metroLabel52 = new MetroFramework.Controls.MetroLabel();
            this.PcTube2ETxtbox = new MetroFramework.Controls.MetroTextBox();
            this.PcTube2RhoTxtbox = new MetroFramework.Controls.MetroTextBox();
            this.PcTube2AngleTxtbox = new MetroFramework.Controls.MetroTextBox();
            this.PcTube2L_sTxtbox = new MetroFramework.Controls.MetroTextBox();
            this.PcTube2ODTxtbox = new MetroFramework.Controls.MetroTextBox();
            this.PcTube2IDTxtbox = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel51 = new MetroFramework.Controls.MetroLabel();
            this.PcTube1ETxtbox = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel50 = new MetroFramework.Controls.MetroLabel();
            this.PcTube1RhoTxtbox = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel49 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel48 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel47 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel46 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel45 = new MetroFramework.Controls.MetroLabel();
            this.PcTube1AngleTxtbox = new MetroFramework.Controls.MetroTextBox();
            this.PcTube1L_sTxtbox = new MetroFramework.Controls.MetroTextBox();
            this.PcTube1ODTxtbox = new MetroFramework.Controls.MetroTextBox();
            this.PcTube1IDTxtbox = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel44 = new MetroFramework.Controls.MetroLabel();
            this.About = new MetroFramework.Controls.MetroTabPage();
            this.metroLabel34 = new MetroFramework.Controls.MetroLabel();
            this.mtCenterPos1 = new MetroFramework.Controls.MetroTextBox();
            this.mtCenterPos2 = new MetroFramework.Controls.MetroTextBox();
            this.mtCenterPos3 = new MetroFramework.Controls.MetroTextBox();
            this.mtCenterPos4 = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel61 = new MetroFramework.Controls.MetroLabel();
            this.mtZeroPos4 = new MetroFramework.Controls.MetroTextBox();
            this.mtZeroPos3 = new MetroFramework.Controls.MetroTextBox();
            this.mtZeroPos2 = new MetroFramework.Controls.MetroTextBox();
            this.mtZeroPos1 = new MetroFramework.Controls.MetroTextBox();
            Setup = new MetroFramework.Controls.MetroTabPage();
            metroLabel36 = new MetroFramework.Controls.MetroLabel();
            Setup.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.metroTabControl1.SuspendLayout();
            this.DirectControl.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.MovementControl.SuspendLayout();
            this.tableLayoutPanel5.SuspendLayout();
            this.PositionControl.SuspendLayout();
            this.About.SuspendLayout();
            this.SuspendLayout();
            // 
            // Setup
            // 
            Setup.BackColor = System.Drawing.Color.Transparent;
            Setup.Controls.Add(this.setApplyBtn);
            Setup.Controls.Add(this.spdAutoAdjToggle);
            Setup.Controls.Add(this.metroLabel33);
            Setup.Controls.Add(this.metroLabel32);
            Setup.Controls.Add(this.accComboBox);
            Setup.Controls.Add(this.spdRPMConvLabel);
            Setup.Controls.Add(this.metroLabel31);
            Setup.Controls.Add(this.spdRawTxtBox);
            Setup.Controls.Add(this.metroLabel30);
            Setup.Controls.Add(this.metroLabel29);
            Setup.Controls.Add(this.tableLayoutPanel4);
            Setup.HorizontalScrollbarBarColor = true;
            Setup.HorizontalScrollbarHighlightOnWheel = false;
            Setup.HorizontalScrollbarSize = 2;
            Setup.Location = new System.Drawing.Point(4, 38);
            Setup.Name = "Setup";
            Setup.Size = new System.Drawing.Size(852, 356);
            Setup.TabIndex = 1;
            Setup.Text = "Setup";
            Setup.UseCustomBackColor = true;
            Setup.VerticalScrollbarBarColor = true;
            Setup.VerticalScrollbarHighlightOnWheel = false;
            Setup.VerticalScrollbarSize = 2;
            // 
            // setApplyBtn
            // 
            this.setApplyBtn.DisplayFocus = true;
            this.setApplyBtn.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.setApplyBtn.Location = new System.Drawing.Point(381, 147);
            this.setApplyBtn.Name = "setApplyBtn";
            this.setApplyBtn.Size = new System.Drawing.Size(101, 29);
            this.setApplyBtn.TabIndex = 35;
            this.setApplyBtn.Text = "APPLY ALL";
            this.setApplyBtn.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.setApplyBtn.UseSelectable = true;
            this.setApplyBtn.Click += new System.EventHandler(this.setApplyBtn_Click);
            // 
            // spdAutoAdjToggle
            // 
            this.spdAutoAdjToggle.AutoSize = true;
            this.spdAutoAdjToggle.Checked = true;
            this.spdAutoAdjToggle.CheckState = System.Windows.Forms.CheckState.Checked;
            this.spdAutoAdjToggle.FontSize = MetroFramework.MetroLinkSize.Medium;
            this.spdAutoAdjToggle.Location = new System.Drawing.Point(381, 81);
            this.spdAutoAdjToggle.Name = "spdAutoAdjToggle";
            this.spdAutoAdjToggle.Size = new System.Drawing.Size(80, 20);
            this.spdAutoAdjToggle.TabIndex = 41;
            this.spdAutoAdjToggle.Text = "On";
            this.spdAutoAdjToggle.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.spdAutoAdjToggle.UseSelectable = true;
            // 
            // metroLabel33
            // 
            this.metroLabel33.AutoSize = true;
            this.metroLabel33.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel33.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel33.Location = new System.Drawing.Point(354, 49);
            this.metroLabel33.Name = "metroLabel33";
            this.metroLabel33.Size = new System.Drawing.Size(162, 25);
            this.metroLabel33.Style = MetroFramework.MetroColorStyle.White;
            this.metroLabel33.TabIndex = 40;
            this.metroLabel33.Text = "Speed Auto Adjust";
            this.metroLabel33.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroLabel33.UseStyleColors = true;
            // 
            // metroLabel32
            // 
            this.metroLabel32.AutoSize = true;
            this.metroLabel32.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel32.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel32.Location = new System.Drawing.Point(198, 119);
            this.metroLabel32.Name = "metroLabel32";
            this.metroLabel32.Size = new System.Drawing.Size(108, 25);
            this.metroLabel32.Style = MetroFramework.MetroColorStyle.White;
            this.metroLabel32.TabIndex = 39;
            this.metroLabel32.Text = "Acceleration";
            this.metroLabel32.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroLabel32.UseStyleColors = true;
            // 
            // accComboBox
            // 
            this.accComboBox.FormattingEnabled = true;
            this.accComboBox.ItemHeight = 23;
            this.accComboBox.Items.AddRange(new object[] {
            "Instant",
            "Fast",
            "Medium",
            "Low"});
            this.accComboBox.Location = new System.Drawing.Point(190, 151);
            this.accComboBox.Name = "accComboBox";
            this.accComboBox.Size = new System.Drawing.Size(121, 29);
            this.accComboBox.Style = MetroFramework.MetroColorStyle.Black;
            this.accComboBox.TabIndex = 35;
            this.accComboBox.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.accComboBox.UseSelectable = true;
            // 
            // spdRPMConvLabel
            // 
            this.spdRPMConvLabel.AutoSize = true;
            this.spdRPMConvLabel.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.spdRPMConvLabel.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.spdRPMConvLabel.Location = new System.Drawing.Point(226, 75);
            this.spdRPMConvLabel.Name = "spdRPMConvLabel";
            this.spdRPMConvLabel.Size = new System.Drawing.Size(72, 25);
            this.spdRPMConvLabel.Style = MetroFramework.MetroColorStyle.White;
            this.spdRPMConvLabel.TabIndex = 38;
            this.spdRPMConvLabel.Text = "= r/min";
            this.spdRPMConvLabel.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.spdRPMConvLabel.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.spdRPMConvLabel.UseStyleColors = true;
            // 
            // metroLabel31
            // 
            this.metroLabel31.AutoSize = true;
            this.metroLabel31.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel31.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel31.Location = new System.Drawing.Point(198, 9);
            this.metroLabel31.Name = "metroLabel31";
            this.metroLabel31.Size = new System.Drawing.Size(86, 25);
            this.metroLabel31.Style = MetroFramework.MetroColorStyle.White;
            this.metroLabel31.TabIndex = 37;
            this.metroLabel31.Text = "Max. Spd";
            this.metroLabel31.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroLabel31.UseStyleColors = true;
            // 
            // spdRawTxtBox
            // 
            // 
            // 
            // 
            this.spdRawTxtBox.CustomButton.Image = null;
            this.spdRawTxtBox.CustomButton.Location = new System.Drawing.Point(61, 1);
            this.spdRawTxtBox.CustomButton.Margin = new System.Windows.Forms.Padding(2);
            this.spdRawTxtBox.CustomButton.Name = "";
            this.spdRawTxtBox.CustomButton.Size = new System.Drawing.Size(16, 16);
            this.spdRawTxtBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.spdRawTxtBox.CustomButton.TabIndex = 1;
            this.spdRawTxtBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.spdRawTxtBox.CustomButton.UseSelectable = true;
            this.spdRawTxtBox.CustomButton.Visible = false;
            this.spdRawTxtBox.Lines = new string[] {
        "300"};
            this.spdRawTxtBox.Location = new System.Drawing.Point(198, 49);
            this.spdRawTxtBox.MaxLength = 32767;
            this.spdRawTxtBox.Name = "spdRawTxtBox";
            this.spdRawTxtBox.PasswordChar = '\0';
            this.spdRawTxtBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.spdRawTxtBox.SelectedText = "";
            this.spdRawTxtBox.SelectionLength = 0;
            this.spdRawTxtBox.SelectionStart = 0;
            this.spdRawTxtBox.ShortcutsEnabled = true;
            this.spdRawTxtBox.Size = new System.Drawing.Size(100, 23);
            this.spdRawTxtBox.TabIndex = 36;
            this.spdRawTxtBox.Text = "300";
            this.spdRawTxtBox.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.spdRawTxtBox.UseSelectable = true;
            this.spdRawTxtBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.spdRawTxtBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel30
            // 
            this.metroLabel30.AutoSize = true;
            this.metroLabel30.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel30.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel30.Location = new System.Drawing.Point(27, 191);
            this.metroLabel30.Name = "metroLabel30";
            this.metroLabel30.Size = new System.Drawing.Size(129, 25);
            this.metroLabel30.Style = MetroFramework.MetroColorStyle.White;
            this.metroLabel30.TabIndex = 35;
            this.metroLabel30.Text = "default = 1200";
            this.metroLabel30.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroLabel30.UseStyleColors = true;
            // 
            // metroLabel29
            // 
            this.metroLabel29.AutoSize = true;
            this.metroLabel29.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel29.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel29.Location = new System.Drawing.Point(3, 9);
            this.metroLabel29.Name = "metroLabel29";
            this.metroLabel29.Size = new System.Drawing.Size(97, 25);
            this.metroLabel29.Style = MetroFramework.MetroColorStyle.White;
            this.metroLabel29.TabIndex = 31;
            this.metroLabel29.Text = "PID P-Gain";
            this.metroLabel29.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroLabel29.UseStyleColors = true;
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 2;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 106F));
            this.tableLayoutPanel4.Controls.Add(this.metroLabel25, 0, 3);
            this.tableLayoutPanel4.Controls.Add(this.metroLabel26, 0, 2);
            this.tableLayoutPanel4.Controls.Add(this.metroLabel27, 0, 1);
            this.tableLayoutPanel4.Controls.Add(this.metroLabel28, 0, 0);
            this.tableLayoutPanel4.Controls.Add(this.pid1gain, 1, 0);
            this.tableLayoutPanel4.Controls.Add(this.pid2gain, 1, 1);
            this.tableLayoutPanel4.Controls.Add(this.pid3gain, 1, 2);
            this.tableLayoutPanel4.Controls.Add(this.pid4gain, 1, 3);
            this.tableLayoutPanel4.Location = new System.Drawing.Point(3, 46);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 4;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(145, 142);
            this.tableLayoutPanel4.TabIndex = 30;
            // 
            // metroLabel25
            // 
            this.metroLabel25.AutoSize = true;
            this.metroLabel25.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel25.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel25.Location = new System.Drawing.Point(3, 105);
            this.metroLabel25.Name = "metroLabel25";
            this.metroLabel25.Size = new System.Drawing.Size(33, 25);
            this.metroLabel25.Style = MetroFramework.MetroColorStyle.White;
            this.metroLabel25.TabIndex = 32;
            this.metroLabel25.Text = "#4";
            this.metroLabel25.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroLabel25.UseStyleColors = true;
            // 
            // metroLabel26
            // 
            this.metroLabel26.AutoSize = true;
            this.metroLabel26.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel26.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel26.Location = new System.Drawing.Point(3, 70);
            this.metroLabel26.Name = "metroLabel26";
            this.metroLabel26.Size = new System.Drawing.Size(33, 25);
            this.metroLabel26.Style = MetroFramework.MetroColorStyle.White;
            this.metroLabel26.TabIndex = 31;
            this.metroLabel26.Text = "#3";
            this.metroLabel26.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroLabel26.UseStyleColors = true;
            // 
            // metroLabel27
            // 
            this.metroLabel27.AutoSize = true;
            this.metroLabel27.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel27.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel27.Location = new System.Drawing.Point(3, 35);
            this.metroLabel27.Name = "metroLabel27";
            this.metroLabel27.Size = new System.Drawing.Size(33, 25);
            this.metroLabel27.Style = MetroFramework.MetroColorStyle.White;
            this.metroLabel27.TabIndex = 30;
            this.metroLabel27.Text = "#2";
            this.metroLabel27.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroLabel27.UseStyleColors = true;
            // 
            // metroLabel28
            // 
            this.metroLabel28.AutoSize = true;
            this.metroLabel28.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel28.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel28.Location = new System.Drawing.Point(3, 0);
            this.metroLabel28.Name = "metroLabel28";
            this.metroLabel28.Size = new System.Drawing.Size(33, 25);
            this.metroLabel28.Style = MetroFramework.MetroColorStyle.White;
            this.metroLabel28.TabIndex = 26;
            this.metroLabel28.Text = "#1";
            this.metroLabel28.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroLabel28.UseStyleColors = true;
            // 
            // pid1gain
            // 
            // 
            // 
            // 
            this.pid1gain.CustomButton.Image = null;
            this.pid1gain.CustomButton.Location = new System.Drawing.Point(61, 1);
            this.pid1gain.CustomButton.Margin = new System.Windows.Forms.Padding(2);
            this.pid1gain.CustomButton.Name = "";
            this.pid1gain.CustomButton.Size = new System.Drawing.Size(16, 16);
            this.pid1gain.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.pid1gain.CustomButton.TabIndex = 1;
            this.pid1gain.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.pid1gain.CustomButton.UseSelectable = true;
            this.pid1gain.CustomButton.Visible = false;
            this.pid1gain.Lines = new string[0];
            this.pid1gain.Location = new System.Drawing.Point(42, 3);
            this.pid1gain.MaxLength = 32767;
            this.pid1gain.Name = "pid1gain";
            this.pid1gain.PasswordChar = '\0';
            this.pid1gain.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.pid1gain.SelectedText = "";
            this.pid1gain.SelectionLength = 0;
            this.pid1gain.SelectionStart = 0;
            this.pid1gain.ShortcutsEnabled = true;
            this.pid1gain.Size = new System.Drawing.Size(100, 23);
            this.pid1gain.TabIndex = 26;
            this.pid1gain.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.pid1gain.UseSelectable = true;
            this.pid1gain.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.pid1gain.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // pid2gain
            // 
            // 
            // 
            // 
            this.pid2gain.CustomButton.Image = null;
            this.pid2gain.CustomButton.Location = new System.Drawing.Point(61, 1);
            this.pid2gain.CustomButton.Margin = new System.Windows.Forms.Padding(2);
            this.pid2gain.CustomButton.Name = "";
            this.pid2gain.CustomButton.Size = new System.Drawing.Size(16, 16);
            this.pid2gain.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.pid2gain.CustomButton.TabIndex = 1;
            this.pid2gain.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.pid2gain.CustomButton.UseSelectable = true;
            this.pid2gain.CustomButton.Visible = false;
            this.pid2gain.Lines = new string[0];
            this.pid2gain.Location = new System.Drawing.Point(42, 38);
            this.pid2gain.MaxLength = 32767;
            this.pid2gain.Name = "pid2gain";
            this.pid2gain.PasswordChar = '\0';
            this.pid2gain.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.pid2gain.SelectedText = "";
            this.pid2gain.SelectionLength = 0;
            this.pid2gain.SelectionStart = 0;
            this.pid2gain.ShortcutsEnabled = true;
            this.pid2gain.Size = new System.Drawing.Size(100, 23);
            this.pid2gain.TabIndex = 27;
            this.pid2gain.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.pid2gain.UseSelectable = true;
            this.pid2gain.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.pid2gain.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // pid3gain
            // 
            // 
            // 
            // 
            this.pid3gain.CustomButton.Image = null;
            this.pid3gain.CustomButton.Location = new System.Drawing.Point(61, 1);
            this.pid3gain.CustomButton.Margin = new System.Windows.Forms.Padding(2);
            this.pid3gain.CustomButton.Name = "";
            this.pid3gain.CustomButton.Size = new System.Drawing.Size(16, 16);
            this.pid3gain.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.pid3gain.CustomButton.TabIndex = 1;
            this.pid3gain.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.pid3gain.CustomButton.UseSelectable = true;
            this.pid3gain.CustomButton.Visible = false;
            this.pid3gain.Lines = new string[0];
            this.pid3gain.Location = new System.Drawing.Point(42, 73);
            this.pid3gain.MaxLength = 32767;
            this.pid3gain.Name = "pid3gain";
            this.pid3gain.PasswordChar = '\0';
            this.pid3gain.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.pid3gain.SelectedText = "";
            this.pid3gain.SelectionLength = 0;
            this.pid3gain.SelectionStart = 0;
            this.pid3gain.ShortcutsEnabled = true;
            this.pid3gain.Size = new System.Drawing.Size(100, 23);
            this.pid3gain.TabIndex = 28;
            this.pid3gain.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.pid3gain.UseSelectable = true;
            this.pid3gain.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.pid3gain.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // pid4gain
            // 
            // 
            // 
            // 
            this.pid4gain.CustomButton.Image = null;
            this.pid4gain.CustomButton.Location = new System.Drawing.Point(61, 1);
            this.pid4gain.CustomButton.Margin = new System.Windows.Forms.Padding(2);
            this.pid4gain.CustomButton.Name = "";
            this.pid4gain.CustomButton.Size = new System.Drawing.Size(16, 16);
            this.pid4gain.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.pid4gain.CustomButton.TabIndex = 1;
            this.pid4gain.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.pid4gain.CustomButton.UseSelectable = true;
            this.pid4gain.CustomButton.Visible = false;
            this.pid4gain.Lines = new string[0];
            this.pid4gain.Location = new System.Drawing.Point(42, 108);
            this.pid4gain.MaxLength = 32767;
            this.pid4gain.Name = "pid4gain";
            this.pid4gain.PasswordChar = '\0';
            this.pid4gain.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.pid4gain.SelectedText = "";
            this.pid4gain.SelectionLength = 0;
            this.pid4gain.SelectionStart = 0;
            this.pid4gain.ShortcutsEnabled = true;
            this.pid4gain.Size = new System.Drawing.Size(100, 23);
            this.pid4gain.TabIndex = 29;
            this.pid4gain.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.pid4gain.UseSelectable = true;
            this.pid4gain.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.pid4gain.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel36
            // 
            metroLabel36.AutoSize = true;
            metroLabel36.FontSize = MetroFramework.MetroLabelSize.Tall;
            metroLabel36.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            metroLabel36.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            metroLabel36.Location = new System.Drawing.Point(259, 0);
            metroLabel36.Name = "metroLabel36";
            metroLabel36.Size = new System.Drawing.Size(67, 25);
            metroLabel36.Style = MetroFramework.MetroColorStyle.White;
            metroLabel36.TabIndex = 40;
            metroLabel36.Text = "TUBE 2";
            metroLabel36.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            metroLabel36.Theme = MetroFramework.MetroThemeStyle.Dark;
            metroLabel36.UseStyleColors = true;
            // 
            // metroComboBox1
            // 
            this.metroComboBox1.ItemHeight = 23;
            this.metroComboBox1.Location = new System.Drawing.Point(146, 88);
            this.metroComboBox1.Name = "metroComboBox1";
            this.metroComboBox1.Size = new System.Drawing.Size(121, 29);
            this.metroComboBox1.Style = MetroFramework.MetroColorStyle.Black;
            this.metroComboBox1.TabIndex = 0;
            this.metroComboBox1.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroComboBox1.UseSelectable = true;
            this.metroComboBox1.DropDown += new System.EventHandler(this.metroComboBox1_DropDown);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel1.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel1.Location = new System.Drawing.Point(96, 88);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(44, 25);
            this.metroLabel1.Style = MetroFramework.MetroColorStyle.White;
            this.metroLabel1.TabIndex = 1;
            this.metroLabel1.Text = "Port";
            this.metroLabel1.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroLabel1.UseStyleColors = true;
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel2.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel2.Location = new System.Drawing.Point(322, 88);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(87, 25);
            this.metroLabel2.Style = MetroFramework.MetroColorStyle.White;
            this.metroLabel2.TabIndex = 2;
            this.metroLabel2.Text = "BaudRate";
            this.metroLabel2.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroLabel2.UseStyleColors = true;
            // 
            // metroComboBox2
            // 
            this.metroComboBox2.FormattingEnabled = true;
            this.metroComboBox2.ItemHeight = 23;
            this.metroComboBox2.Items.AddRange(new object[] {
            "9600",
            "57600",
            "115200"});
            this.metroComboBox2.Location = new System.Drawing.Point(415, 88);
            this.metroComboBox2.Name = "metroComboBox2";
            this.metroComboBox2.Size = new System.Drawing.Size(121, 29);
            this.metroComboBox2.Style = MetroFramework.MetroColorStyle.Black;
            this.metroComboBox2.TabIndex = 3;
            this.metroComboBox2.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroComboBox2.UseSelectable = true;
            // 
            // serialOpenBtn
            // 
            this.serialOpenBtn.DisplayFocus = true;
            this.serialOpenBtn.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.serialOpenBtn.Location = new System.Drawing.Point(564, 88);
            this.serialOpenBtn.Name = "serialOpenBtn";
            this.serialOpenBtn.Size = new System.Drawing.Size(101, 29);
            this.serialOpenBtn.TabIndex = 4;
            this.serialOpenBtn.Text = "SERIAL SET";
            this.serialOpenBtn.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.serialOpenBtn.UseSelectable = true;
            this.serialOpenBtn.Click += new System.EventHandler(this.serialOpenBtn_Click);
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel3.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel3.Location = new System.Drawing.Point(3, 30);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(33, 25);
            this.metroLabel3.Style = MetroFramework.MetroColorStyle.White;
            this.metroLabel3.TabIndex = 5;
            this.metroLabel3.Text = "#1";
            this.metroLabel3.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroLabel3.UseStyleColors = true;
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel4.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel4.Location = new System.Drawing.Point(3, 60);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(33, 25);
            this.metroLabel4.Style = MetroFramework.MetroColorStyle.White;
            this.metroLabel4.TabIndex = 6;
            this.metroLabel4.Text = "#2";
            this.metroLabel4.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroLabel4.UseStyleColors = true;
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel5.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel5.Location = new System.Drawing.Point(3, 90);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(33, 25);
            this.metroLabel5.Style = MetroFramework.MetroColorStyle.White;
            this.metroLabel5.TabIndex = 7;
            this.metroLabel5.Text = "#3";
            this.metroLabel5.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroLabel5.UseStyleColors = true;
            // 
            // metroLabel6
            // 
            this.metroLabel6.AutoSize = true;
            this.metroLabel6.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel6.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel6.Location = new System.Drawing.Point(3, 120);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(33, 25);
            this.metroLabel6.Style = MetroFramework.MetroColorStyle.White;
            this.metroLabel6.TabIndex = 8;
            this.metroLabel6.Text = "#4";
            this.metroLabel6.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroLabel6.UseStyleColors = true;
            // 
            // rxLogClrBtn
            // 
            this.rxLogClrBtn.DisplayFocus = true;
            this.rxLogClrBtn.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.rxLogClrBtn.Location = new System.Drawing.Point(920, 111);
            this.rxLogClrBtn.Name = "rxLogClrBtn";
            this.rxLogClrBtn.Size = new System.Drawing.Size(101, 29);
            this.rxLogClrBtn.TabIndex = 9;
            this.rxLogClrBtn.Text = "Clear";
            this.rxLogClrBtn.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.rxLogClrBtn.UseSelectable = true;
            this.rxLogClrBtn.Click += new System.EventHandler(this.rxLogClrBtn_Click);
            // 
            // metroTextBox1
            // 
            // 
            // 
            // 
            this.metroTextBox1.CustomButton.Image = null;
            this.metroTextBox1.CustomButton.Location = new System.Drawing.Point(116, 2);
            this.metroTextBox1.CustomButton.Name = "";
            this.metroTextBox1.CustomButton.Size = new System.Drawing.Size(127, 127);
            this.metroTextBox1.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroTextBox1.CustomButton.TabIndex = 1;
            this.metroTextBox1.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroTextBox1.CustomButton.UseSelectable = true;
            this.metroTextBox1.CustomButton.Visible = false;
            this.metroTextBox1.Lines = new string[0];
            this.metroTextBox1.Location = new System.Drawing.Point(775, 139);
            this.metroTextBox1.MaxLength = 32767;
            this.metroTextBox1.Multiline = true;
            this.metroTextBox1.Name = "metroTextBox1";
            this.metroTextBox1.PasswordChar = '\0';
            this.metroTextBox1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.metroTextBox1.SelectedText = "";
            this.metroTextBox1.SelectionLength = 0;
            this.metroTextBox1.SelectionStart = 0;
            this.metroTextBox1.ShortcutsEnabled = true;
            this.metroTextBox1.Size = new System.Drawing.Size(246, 132);
            this.metroTextBox1.TabIndex = 13;
            this.metroTextBox1.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroTextBox1.UseSelectable = true;
            this.metroTextBox1.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.metroTextBox1.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel7
            // 
            this.metroLabel7.AutoSize = true;
            this.metroLabel7.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel7.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel7.Location = new System.Drawing.Point(775, 111);
            this.metroLabel7.Name = "metroLabel7";
            this.metroLabel7.Size = new System.Drawing.Size(95, 25);
            this.metroLabel7.Style = MetroFramework.MetroColorStyle.White;
            this.metroLabel7.TabIndex = 14;
            this.metroLabel7.Text = "RX Logger";
            this.metroLabel7.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroLabel7.UseStyleColors = true;
            // 
            // metroLabel8
            // 
            this.metroLabel8.AutoSize = true;
            this.metroLabel8.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel8.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel8.Location = new System.Drawing.Point(43, 0);
            this.metroLabel8.Name = "metroLabel8";
            this.metroLabel8.Size = new System.Drawing.Size(60, 25);
            this.metroLabel8.Style = MetroFramework.MetroColorStyle.White;
            this.metroLabel8.TabIndex = 15;
            this.metroLabel8.Text = "Active";
            this.metroLabel8.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroLabel8.UseStyleColors = true;
            // 
            // metroLabel9
            // 
            this.metroLabel9.AutoSize = true;
            this.metroLabel9.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel9.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel9.Location = new System.Drawing.Point(143, 0);
            this.metroLabel9.Name = "metroLabel9";
            this.metroLabel9.Size = new System.Drawing.Size(60, 25);
            this.metroLabel9.Style = MetroFramework.MetroColorStyle.White;
            this.metroLabel9.TabIndex = 16;
            this.metroLabel9.Text = "Target";
            this.metroLabel9.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroLabel9.UseStyleColors = true;
            // 
            // metroLabel10
            // 
            this.metroLabel10.AutoSize = true;
            this.metroLabel10.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel10.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel10.Location = new System.Drawing.Point(293, 0);
            this.metroLabel10.Name = "metroLabel10";
            this.metroLabel10.Size = new System.Drawing.Size(70, 25);
            this.metroLabel10.Style = MetroFramework.MetroColorStyle.White;
            this.metroLabel10.TabIndex = 17;
            this.metroLabel10.Text = "Current";
            this.metroLabel10.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroLabel10.UseStyleColors = true;
            // 
            // metroLabel11
            // 
            this.metroLabel11.AutoSize = true;
            this.metroLabel11.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel11.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel11.Location = new System.Drawing.Point(443, 0);
            this.metroLabel11.Name = "metroLabel11";
            this.metroLabel11.Size = new System.Drawing.Size(41, 25);
            this.metroLabel11.Style = MetroFramework.MetroColorStyle.White;
            this.metroLabel11.TabIndex = 18;
            this.metroLabel11.Text = "Diff";
            this.metroLabel11.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroLabel11.UseStyleColors = true;
            // 
            // mt1Toggle
            // 
            this.mt1Toggle.AutoSize = true;
            this.mt1Toggle.Checked = true;
            this.mt1Toggle.CheckState = System.Windows.Forms.CheckState.Checked;
            this.mt1Toggle.FontSize = MetroFramework.MetroLinkSize.Medium;
            this.mt1Toggle.Location = new System.Drawing.Point(43, 33);
            this.mt1Toggle.Name = "mt1Toggle";
            this.mt1Toggle.Size = new System.Drawing.Size(80, 20);
            this.mt1Toggle.TabIndex = 20;
            this.mt1Toggle.Text = "On";
            this.mt1Toggle.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.mt1Toggle.UseSelectable = true;
            // 
            // mt2Toggle
            // 
            this.mt2Toggle.AutoSize = true;
            this.mt2Toggle.Checked = true;
            this.mt2Toggle.CheckState = System.Windows.Forms.CheckState.Checked;
            this.mt2Toggle.FontSize = MetroFramework.MetroLinkSize.Medium;
            this.mt2Toggle.Location = new System.Drawing.Point(43, 63);
            this.mt2Toggle.Name = "mt2Toggle";
            this.mt2Toggle.Size = new System.Drawing.Size(80, 20);
            this.mt2Toggle.TabIndex = 21;
            this.mt2Toggle.Text = "On";
            this.mt2Toggle.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.mt2Toggle.UseSelectable = true;
            // 
            // mt3Toggle
            // 
            this.mt3Toggle.AutoSize = true;
            this.mt3Toggle.Checked = true;
            this.mt3Toggle.CheckState = System.Windows.Forms.CheckState.Checked;
            this.mt3Toggle.FontSize = MetroFramework.MetroLinkSize.Medium;
            this.mt3Toggle.Location = new System.Drawing.Point(43, 93);
            this.mt3Toggle.Name = "mt3Toggle";
            this.mt3Toggle.Size = new System.Drawing.Size(80, 20);
            this.mt3Toggle.TabIndex = 22;
            this.mt3Toggle.Text = "On";
            this.mt3Toggle.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.mt3Toggle.UseSelectable = true;
            // 
            // mt4Toggle
            // 
            this.mt4Toggle.AutoSize = true;
            this.mt4Toggle.Checked = true;
            this.mt4Toggle.CheckState = System.Windows.Forms.CheckState.Checked;
            this.mt4Toggle.FontSize = MetroFramework.MetroLinkSize.Medium;
            this.mt4Toggle.Location = new System.Drawing.Point(43, 123);
            this.mt4Toggle.Name = "mt4Toggle";
            this.mt4Toggle.Size = new System.Drawing.Size(80, 20);
            this.mt4Toggle.TabIndex = 23;
            this.mt4Toggle.Text = "On";
            this.mt4Toggle.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.mt4Toggle.UseSelectable = true;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 5;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 150F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 150F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 146F));
            this.tableLayoutPanel1.Controls.Add(this.diffLabel4, 4, 4);
            this.tableLayoutPanel1.Controls.Add(this.currentLabel4, 3, 4);
            this.tableLayoutPanel1.Controls.Add(this.currentLabel1, 3, 1);
            this.tableLayoutPanel1.Controls.Add(this.currentLabel3, 3, 3);
            this.tableLayoutPanel1.Controls.Add(this.diffLabel3, 4, 3);
            this.tableLayoutPanel1.Controls.Add(this.diffLabel2, 4, 2);
            this.tableLayoutPanel1.Controls.Add(this.metroLabel8, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.currentLabel2, 3, 2);
            this.tableLayoutPanel1.Controls.Add(this.mt4Toggle, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.metroLabel3, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.diffLabel1, 4, 1);
            this.tableLayoutPanel1.Controls.Add(this.metroLabel10, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.mt3Toggle, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.metroLabel9, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.mt1Toggle, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.mt2Toggle, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.metroLabel4, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.metroLabel5, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.metroLabel6, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.metroLabel11, 4, 0);
            this.tableLayoutPanel1.Controls.Add(this.targetLabel1, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.targetLabel2, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.targetLabel3, 2, 3);
            this.tableLayoutPanel1.Controls.Add(this.targetLabel4, 2, 4);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(79, 158);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 5;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(586, 156);
            this.tableLayoutPanel1.TabIndex = 24;
            // 
            // diffLabel4
            // 
            this.diffLabel4.AutoSize = true;
            this.diffLabel4.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.diffLabel4.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.diffLabel4.Location = new System.Drawing.Point(443, 120);
            this.diffLabel4.Name = "diffLabel4";
            this.diffLabel4.Size = new System.Drawing.Size(22, 25);
            this.diffLabel4.Style = MetroFramework.MetroColorStyle.White;
            this.diffLabel4.TabIndex = 36;
            this.diffLabel4.Text = "0";
            this.diffLabel4.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.diffLabel4.UseStyleColors = true;
            // 
            // currentLabel4
            // 
            this.currentLabel4.AutoSize = true;
            this.currentLabel4.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.currentLabel4.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.currentLabel4.Location = new System.Drawing.Point(293, 120);
            this.currentLabel4.Name = "currentLabel4";
            this.currentLabel4.Size = new System.Drawing.Size(22, 25);
            this.currentLabel4.Style = MetroFramework.MetroColorStyle.White;
            this.currentLabel4.TabIndex = 32;
            this.currentLabel4.Text = "0";
            this.currentLabel4.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.currentLabel4.UseStyleColors = true;
            // 
            // currentLabel1
            // 
            this.currentLabel1.AutoSize = true;
            this.currentLabel1.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.currentLabel1.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.currentLabel1.Location = new System.Drawing.Point(293, 30);
            this.currentLabel1.Name = "currentLabel1";
            this.currentLabel1.Size = new System.Drawing.Size(22, 25);
            this.currentLabel1.Style = MetroFramework.MetroColorStyle.White;
            this.currentLabel1.TabIndex = 29;
            this.currentLabel1.Text = "0";
            this.currentLabel1.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.currentLabel1.UseStyleColors = true;
            // 
            // currentLabel3
            // 
            this.currentLabel3.AutoSize = true;
            this.currentLabel3.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.currentLabel3.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.currentLabel3.Location = new System.Drawing.Point(293, 90);
            this.currentLabel3.Name = "currentLabel3";
            this.currentLabel3.Size = new System.Drawing.Size(22, 25);
            this.currentLabel3.Style = MetroFramework.MetroColorStyle.White;
            this.currentLabel3.TabIndex = 31;
            this.currentLabel3.Text = "0";
            this.currentLabel3.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.currentLabel3.UseStyleColors = true;
            // 
            // diffLabel3
            // 
            this.diffLabel3.AutoSize = true;
            this.diffLabel3.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.diffLabel3.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.diffLabel3.Location = new System.Drawing.Point(443, 90);
            this.diffLabel3.Name = "diffLabel3";
            this.diffLabel3.Size = new System.Drawing.Size(22, 25);
            this.diffLabel3.Style = MetroFramework.MetroColorStyle.White;
            this.diffLabel3.TabIndex = 35;
            this.diffLabel3.Text = "0";
            this.diffLabel3.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.diffLabel3.UseStyleColors = true;
            // 
            // diffLabel2
            // 
            this.diffLabel2.AutoSize = true;
            this.diffLabel2.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.diffLabel2.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.diffLabel2.Location = new System.Drawing.Point(443, 60);
            this.diffLabel2.Name = "diffLabel2";
            this.diffLabel2.Size = new System.Drawing.Size(22, 25);
            this.diffLabel2.Style = MetroFramework.MetroColorStyle.White;
            this.diffLabel2.TabIndex = 33;
            this.diffLabel2.Text = "0";
            this.diffLabel2.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.diffLabel2.UseStyleColors = true;
            // 
            // currentLabel2
            // 
            this.currentLabel2.AutoSize = true;
            this.currentLabel2.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.currentLabel2.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.currentLabel2.Location = new System.Drawing.Point(293, 60);
            this.currentLabel2.Name = "currentLabel2";
            this.currentLabel2.Size = new System.Drawing.Size(22, 25);
            this.currentLabel2.Style = MetroFramework.MetroColorStyle.White;
            this.currentLabel2.TabIndex = 30;
            this.currentLabel2.Text = "0";
            this.currentLabel2.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.currentLabel2.UseStyleColors = true;
            // 
            // diffLabel1
            // 
            this.diffLabel1.AutoSize = true;
            this.diffLabel1.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.diffLabel1.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.diffLabel1.Location = new System.Drawing.Point(443, 30);
            this.diffLabel1.Name = "diffLabel1";
            this.diffLabel1.Size = new System.Drawing.Size(22, 25);
            this.diffLabel1.Style = MetroFramework.MetroColorStyle.White;
            this.diffLabel1.TabIndex = 34;
            this.diffLabel1.Text = "0";
            this.diffLabel1.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.diffLabel1.UseStyleColors = true;
            // 
            // targetLabel1
            // 
            this.targetLabel1.AutoSize = true;
            this.targetLabel1.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.targetLabel1.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.targetLabel1.Location = new System.Drawing.Point(143, 30);
            this.targetLabel1.Name = "targetLabel1";
            this.targetLabel1.Size = new System.Drawing.Size(22, 25);
            this.targetLabel1.Style = MetroFramework.MetroColorStyle.White;
            this.targetLabel1.TabIndex = 25;
            this.targetLabel1.Text = "0";
            this.targetLabel1.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.targetLabel1.UseStyleColors = true;
            // 
            // targetLabel2
            // 
            this.targetLabel2.AutoSize = true;
            this.targetLabel2.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.targetLabel2.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.targetLabel2.Location = new System.Drawing.Point(143, 60);
            this.targetLabel2.Name = "targetLabel2";
            this.targetLabel2.Size = new System.Drawing.Size(22, 25);
            this.targetLabel2.Style = MetroFramework.MetroColorStyle.White;
            this.targetLabel2.TabIndex = 26;
            this.targetLabel2.Text = "0";
            this.targetLabel2.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.targetLabel2.UseStyleColors = true;
            // 
            // targetLabel3
            // 
            this.targetLabel3.AutoSize = true;
            this.targetLabel3.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.targetLabel3.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.targetLabel3.Location = new System.Drawing.Point(143, 90);
            this.targetLabel3.Name = "targetLabel3";
            this.targetLabel3.Size = new System.Drawing.Size(22, 25);
            this.targetLabel3.Style = MetroFramework.MetroColorStyle.White;
            this.targetLabel3.TabIndex = 27;
            this.targetLabel3.Text = "0";
            this.targetLabel3.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.targetLabel3.UseStyleColors = true;
            // 
            // targetLabel4
            // 
            this.targetLabel4.AutoSize = true;
            this.targetLabel4.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.targetLabel4.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.targetLabel4.Location = new System.Drawing.Point(143, 120);
            this.targetLabel4.Name = "targetLabel4";
            this.targetLabel4.Size = new System.Drawing.Size(22, 25);
            this.targetLabel4.Style = MetroFramework.MetroColorStyle.White;
            this.targetLabel4.TabIndex = 28;
            this.targetLabel4.Text = "0";
            this.targetLabel4.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.targetLabel4.UseStyleColors = true;
            // 
            // metroTabControl1
            // 
            this.metroTabControl1.Controls.Add(this.DirectControl);
            this.metroTabControl1.Controls.Add(this.MovementControl);
            this.metroTabControl1.Controls.Add(this.PositionControl);
            this.metroTabControl1.Controls.Add(this.About);
            this.metroTabControl1.Controls.Add(Setup);
            this.metroTabControl1.Location = new System.Drawing.Point(78, 320);
            this.metroTabControl1.Name = "metroTabControl1";
            this.metroTabControl1.SelectedIndex = 1;
            this.metroTabControl1.Size = new System.Drawing.Size(860, 398);
            this.metroTabControl1.TabIndex = 25;
            this.metroTabControl1.TabStop = false;
            this.metroTabControl1.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroTabControl1.UseSelectable = true;
            // 
            // DirectControl
            // 
            this.DirectControl.BackColor = System.Drawing.Color.Transparent;
            this.DirectControl.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.DirectControl.Controls.Add(this.metroLabel24);
            this.DirectControl.Controls.Add(this.stepSetBtn);
            this.DirectControl.Controls.Add(this.stepSizeIndLabel);
            this.DirectControl.Controls.Add(this.stepSizeTxtBox);
            this.DirectControl.Controls.Add(this.mtCenterBtn);
            this.DirectControl.Controls.Add(this.tableLayoutPanel3);
            this.DirectControl.Controls.Add(this.dirGoBtn);
            this.DirectControl.Controls.Add(this.tableLayoutPanel2);
            this.DirectControl.Controls.Add(this.metroLabel15);
            this.DirectControl.Controls.Add(this.metroLabel14);
            this.DirectControl.Controls.Add(this.metroLabel13);
            this.DirectControl.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.DirectControl.HorizontalScrollbarBarColor = true;
            this.DirectControl.HorizontalScrollbarHighlightOnWheel = false;
            this.DirectControl.HorizontalScrollbarSize = 2;
            this.DirectControl.ImageKey = "(없음)";
            this.DirectControl.Location = new System.Drawing.Point(4, 38);
            this.DirectControl.Name = "DirectControl";
            this.DirectControl.Size = new System.Drawing.Size(852, 356);
            this.DirectControl.TabIndex = 0;
            this.DirectControl.Text = "DirectControl";
            this.DirectControl.UseCustomBackColor = true;
            this.DirectControl.VerticalScrollbarBarColor = true;
            this.DirectControl.VerticalScrollbarHighlightOnWheel = false;
            this.DirectControl.VerticalScrollbarSize = 2;
            // 
            // metroLabel24
            // 
            this.metroLabel24.AutoSize = true;
            this.metroLabel24.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel24.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel24.Location = new System.Drawing.Point(380, 151);
            this.metroLabel24.Name = "metroLabel24";
            this.metroLabel24.Size = new System.Drawing.Size(194, 25);
            this.metroLabel24.Style = MetroFramework.MetroColorStyle.White;
            this.metroLabel24.TabIndex = 34;
            this.metroLabel24.Text = "default = 256(22.5deg)";
            this.metroLabel24.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroLabel24.UseStyleColors = true;
            // 
            // stepSetBtn
            // 
            this.stepSetBtn.DisplayFocus = true;
            this.stepSetBtn.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.stepSetBtn.Location = new System.Drawing.Point(496, 81);
            this.stepSetBtn.Name = "stepSetBtn";
            this.stepSetBtn.Size = new System.Drawing.Size(59, 29);
            this.stepSetBtn.TabIndex = 26;
            this.stepSetBtn.Text = "SET";
            this.stepSetBtn.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.stepSetBtn.UseSelectable = true;
            this.stepSetBtn.Click += new System.EventHandler(this.stepSetBtn_Click);
            // 
            // stepSizeIndLabel
            // 
            this.stepSizeIndLabel.AutoSize = true;
            this.stepSizeIndLabel.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.stepSizeIndLabel.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.stepSizeIndLabel.Location = new System.Drawing.Point(380, 110);
            this.stepSizeIndLabel.Name = "stepSizeIndLabel";
            this.stepSizeIndLabel.Size = new System.Drawing.Size(22, 25);
            this.stepSizeIndLabel.Style = MetroFramework.MetroColorStyle.White;
            this.stepSizeIndLabel.TabIndex = 26;
            this.stepSizeIndLabel.Text = "0";
            this.stepSizeIndLabel.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.stepSizeIndLabel.UseStyleColors = true;
            // 
            // stepSizeTxtBox
            // 
            // 
            // 
            // 
            this.stepSizeTxtBox.CustomButton.Image = null;
            this.stepSizeTxtBox.CustomButton.Location = new System.Drawing.Point(61, 1);
            this.stepSizeTxtBox.CustomButton.Margin = new System.Windows.Forms.Padding(2);
            this.stepSizeTxtBox.CustomButton.Name = "";
            this.stepSizeTxtBox.CustomButton.Size = new System.Drawing.Size(16, 16);
            this.stepSizeTxtBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.stepSizeTxtBox.CustomButton.TabIndex = 1;
            this.stepSizeTxtBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.stepSizeTxtBox.CustomButton.UseSelectable = true;
            this.stepSizeTxtBox.CustomButton.Visible = false;
            this.stepSizeTxtBox.Lines = new string[0];
            this.stepSizeTxtBox.Location = new System.Drawing.Point(380, 84);
            this.stepSizeTxtBox.MaxLength = 32767;
            this.stepSizeTxtBox.Name = "stepSizeTxtBox";
            this.stepSizeTxtBox.PasswordChar = '\0';
            this.stepSizeTxtBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.stepSizeTxtBox.SelectedText = "";
            this.stepSizeTxtBox.SelectionLength = 0;
            this.stepSizeTxtBox.SelectionStart = 0;
            this.stepSizeTxtBox.ShortcutsEnabled = true;
            this.stepSizeTxtBox.Size = new System.Drawing.Size(100, 23);
            this.stepSizeTxtBox.TabIndex = 33;
            this.stepSizeTxtBox.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.stepSizeTxtBox.UseSelectable = true;
            this.stepSizeTxtBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.stepSizeTxtBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // mtCenterBtn
            // 
            this.mtCenterBtn.DisplayFocus = true;
            this.mtCenterBtn.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.mtCenterBtn.Location = new System.Drawing.Point(205, 194);
            this.mtCenterBtn.Name = "mtCenterBtn";
            this.mtCenterBtn.Size = new System.Drawing.Size(151, 29);
            this.mtCenterBtn.TabIndex = 32;
            this.mtCenterBtn.Text = "CENTER";
            this.mtCenterBtn.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.mtCenterBtn.UseSelectable = true;
            this.mtCenterBtn.Click += new System.EventHandler(this.mtCenterBtn_Click);
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 3;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tableLayoutPanel3.Controls.Add(this.mt4StepDnBtn, 2, 3);
            this.tableLayoutPanel3.Controls.Add(this.mt3StepDnBtn, 2, 2);
            this.tableLayoutPanel3.Controls.Add(this.mt2StepDnBtn, 2, 1);
            this.tableLayoutPanel3.Controls.Add(this.mt2StepUpBtn, 1, 1);
            this.tableLayoutPanel3.Controls.Add(this.mt1StepDnBtn, 2, 0);
            this.tableLayoutPanel3.Controls.Add(this.metroLabel23, 0, 3);
            this.tableLayoutPanel3.Controls.Add(this.mt1StepUpBtn, 1, 0);
            this.tableLayoutPanel3.Controls.Add(this.metroLabel20, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.metroLabel21, 0, 1);
            this.tableLayoutPanel3.Controls.Add(this.metroLabel22, 0, 2);
            this.tableLayoutPanel3.Controls.Add(this.mt3StepUpBtn, 1, 2);
            this.tableLayoutPanel3.Controls.Add(this.mt4StepUpBtn, 1, 3);
            this.tableLayoutPanel3.Location = new System.Drawing.Point(163, 46);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 4;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(196, 142);
            this.tableLayoutPanel3.TabIndex = 31;
            // 
            // mt4StepDnBtn
            // 
            this.mt4StepDnBtn.DisplayFocus = true;
            this.mt4StepDnBtn.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.mt4StepDnBtn.Location = new System.Drawing.Point(120, 108);
            this.mt4StepDnBtn.Name = "mt4StepDnBtn";
            this.mt4StepDnBtn.Size = new System.Drawing.Size(73, 29);
            this.mt4StepDnBtn.TabIndex = 36;
            this.mt4StepDnBtn.Text = "DN";
            this.mt4StepDnBtn.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.mt4StepDnBtn.UseSelectable = true;
            this.mt4StepDnBtn.Click += new System.EventHandler(this.mt4StepDnBtn_Click);
            // 
            // mt3StepDnBtn
            // 
            this.mt3StepDnBtn.DisplayFocus = true;
            this.mt3StepDnBtn.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.mt3StepDnBtn.Location = new System.Drawing.Point(120, 73);
            this.mt3StepDnBtn.Name = "mt3StepDnBtn";
            this.mt3StepDnBtn.Size = new System.Drawing.Size(73, 29);
            this.mt3StepDnBtn.TabIndex = 35;
            this.mt3StepDnBtn.Text = "DN";
            this.mt3StepDnBtn.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.mt3StepDnBtn.UseSelectable = true;
            this.mt3StepDnBtn.Click += new System.EventHandler(this.mt3StepDnBtn_Click);
            // 
            // mt2StepDnBtn
            // 
            this.mt2StepDnBtn.DisplayFocus = true;
            this.mt2StepDnBtn.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.mt2StepDnBtn.Location = new System.Drawing.Point(120, 38);
            this.mt2StepDnBtn.Name = "mt2StepDnBtn";
            this.mt2StepDnBtn.Size = new System.Drawing.Size(73, 29);
            this.mt2StepDnBtn.TabIndex = 34;
            this.mt2StepDnBtn.Text = "DN";
            this.mt2StepDnBtn.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.mt2StepDnBtn.UseSelectable = true;
            this.mt2StepDnBtn.Click += new System.EventHandler(this.mt2StepDnBtn_Click);
            // 
            // mt2StepUpBtn
            // 
            this.mt2StepUpBtn.DisplayFocus = true;
            this.mt2StepUpBtn.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.mt2StepUpBtn.Location = new System.Drawing.Point(42, 38);
            this.mt2StepUpBtn.Name = "mt2StepUpBtn";
            this.mt2StepUpBtn.Size = new System.Drawing.Size(72, 29);
            this.mt2StepUpBtn.TabIndex = 31;
            this.mt2StepUpBtn.Text = "UP";
            this.mt2StepUpBtn.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.mt2StepUpBtn.UseSelectable = true;
            this.mt2StepUpBtn.Click += new System.EventHandler(this.mt2StepUpBtn_Click);
            // 
            // mt1StepDnBtn
            // 
            this.mt1StepDnBtn.DisplayFocus = true;
            this.mt1StepDnBtn.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.mt1StepDnBtn.Location = new System.Drawing.Point(120, 3);
            this.mt1StepDnBtn.Name = "mt1StepDnBtn";
            this.mt1StepDnBtn.Size = new System.Drawing.Size(73, 29);
            this.mt1StepDnBtn.TabIndex = 27;
            this.mt1StepDnBtn.Text = "DN";
            this.mt1StepDnBtn.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.mt1StepDnBtn.UseSelectable = true;
            this.mt1StepDnBtn.Click += new System.EventHandler(this.mt1StepDnBtn_Click);
            // 
            // metroLabel23
            // 
            this.metroLabel23.AutoSize = true;
            this.metroLabel23.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel23.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel23.Location = new System.Drawing.Point(3, 105);
            this.metroLabel23.Name = "metroLabel23";
            this.metroLabel23.Size = new System.Drawing.Size(33, 25);
            this.metroLabel23.Style = MetroFramework.MetroColorStyle.White;
            this.metroLabel23.TabIndex = 30;
            this.metroLabel23.Text = "#4";
            this.metroLabel23.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroLabel23.UseStyleColors = true;
            // 
            // mt1StepUpBtn
            // 
            this.mt1StepUpBtn.DisplayFocus = true;
            this.mt1StepUpBtn.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.mt1StepUpBtn.Location = new System.Drawing.Point(42, 3);
            this.mt1StepUpBtn.Name = "mt1StepUpBtn";
            this.mt1StepUpBtn.Size = new System.Drawing.Size(72, 29);
            this.mt1StepUpBtn.TabIndex = 26;
            this.mt1StepUpBtn.Text = "UP";
            this.mt1StepUpBtn.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.mt1StepUpBtn.UseSelectable = true;
            this.mt1StepUpBtn.Click += new System.EventHandler(this.mt1StepUpBtn_Click);
            // 
            // metroLabel20
            // 
            this.metroLabel20.AutoSize = true;
            this.metroLabel20.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel20.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel20.Location = new System.Drawing.Point(3, 0);
            this.metroLabel20.Name = "metroLabel20";
            this.metroLabel20.Size = new System.Drawing.Size(33, 25);
            this.metroLabel20.Style = MetroFramework.MetroColorStyle.White;
            this.metroLabel20.TabIndex = 27;
            this.metroLabel20.Text = "#1";
            this.metroLabel20.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroLabel20.UseStyleColors = true;
            // 
            // metroLabel21
            // 
            this.metroLabel21.AutoSize = true;
            this.metroLabel21.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel21.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel21.Location = new System.Drawing.Point(3, 35);
            this.metroLabel21.Name = "metroLabel21";
            this.metroLabel21.Size = new System.Drawing.Size(33, 25);
            this.metroLabel21.Style = MetroFramework.MetroColorStyle.White;
            this.metroLabel21.TabIndex = 28;
            this.metroLabel21.Text = "#2";
            this.metroLabel21.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroLabel21.UseStyleColors = true;
            // 
            // metroLabel22
            // 
            this.metroLabel22.AutoSize = true;
            this.metroLabel22.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel22.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel22.Location = new System.Drawing.Point(3, 70);
            this.metroLabel22.Name = "metroLabel22";
            this.metroLabel22.Size = new System.Drawing.Size(33, 25);
            this.metroLabel22.Style = MetroFramework.MetroColorStyle.White;
            this.metroLabel22.TabIndex = 29;
            this.metroLabel22.Text = "#3";
            this.metroLabel22.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroLabel22.UseStyleColors = true;
            // 
            // mt3StepUpBtn
            // 
            this.mt3StepUpBtn.DisplayFocus = true;
            this.mt3StepUpBtn.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.mt3StepUpBtn.Location = new System.Drawing.Point(42, 73);
            this.mt3StepUpBtn.Name = "mt3StepUpBtn";
            this.mt3StepUpBtn.Size = new System.Drawing.Size(72, 29);
            this.mt3StepUpBtn.TabIndex = 32;
            this.mt3StepUpBtn.Text = "UP";
            this.mt3StepUpBtn.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.mt3StepUpBtn.UseSelectable = true;
            this.mt3StepUpBtn.Click += new System.EventHandler(this.mt3StepUpBtn_Click);
            // 
            // mt4StepUpBtn
            // 
            this.mt4StepUpBtn.DisplayFocus = true;
            this.mt4StepUpBtn.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.mt4StepUpBtn.Location = new System.Drawing.Point(42, 108);
            this.mt4StepUpBtn.Name = "mt4StepUpBtn";
            this.mt4StepUpBtn.Size = new System.Drawing.Size(72, 29);
            this.mt4StepUpBtn.TabIndex = 33;
            this.mt4StepUpBtn.Text = "UP";
            this.mt4StepUpBtn.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.mt4StepUpBtn.UseSelectable = true;
            this.mt4StepUpBtn.Click += new System.EventHandler(this.mt4StepUpBtn_Click);
            // 
            // dirGoBtn
            // 
            this.dirGoBtn.DisplayFocus = true;
            this.dirGoBtn.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.dirGoBtn.Location = new System.Drawing.Point(3, 194);
            this.dirGoBtn.Name = "dirGoBtn";
            this.dirGoBtn.Size = new System.Drawing.Size(145, 29);
            this.dirGoBtn.TabIndex = 30;
            this.dirGoBtn.Text = "GO";
            this.dirGoBtn.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.dirGoBtn.UseSelectable = true;
            this.dirGoBtn.Click += new System.EventHandler(this.dirGoBtn_Click);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 106F));
            this.tableLayoutPanel2.Controls.Add(this.metroLabel19, 0, 3);
            this.tableLayoutPanel2.Controls.Add(this.metroLabel18, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.metroLabel17, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.metroLabel16, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.mt1DirectTxtBox, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.mt2DirectTxtBox, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.mt3DirectTxtBox, 1, 2);
            this.tableLayoutPanel2.Controls.Add(this.mt4DirectTxtBox, 1, 3);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 46);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 4;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(145, 142);
            this.tableLayoutPanel2.TabIndex = 29;
            // 
            // metroLabel19
            // 
            this.metroLabel19.AutoSize = true;
            this.metroLabel19.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel19.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel19.Location = new System.Drawing.Point(3, 105);
            this.metroLabel19.Name = "metroLabel19";
            this.metroLabel19.Size = new System.Drawing.Size(33, 25);
            this.metroLabel19.Style = MetroFramework.MetroColorStyle.White;
            this.metroLabel19.TabIndex = 32;
            this.metroLabel19.Text = "#4";
            this.metroLabel19.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroLabel19.UseStyleColors = true;
            // 
            // metroLabel18
            // 
            this.metroLabel18.AutoSize = true;
            this.metroLabel18.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel18.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel18.Location = new System.Drawing.Point(3, 70);
            this.metroLabel18.Name = "metroLabel18";
            this.metroLabel18.Size = new System.Drawing.Size(33, 25);
            this.metroLabel18.Style = MetroFramework.MetroColorStyle.White;
            this.metroLabel18.TabIndex = 31;
            this.metroLabel18.Text = "#3";
            this.metroLabel18.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroLabel18.UseStyleColors = true;
            // 
            // metroLabel17
            // 
            this.metroLabel17.AutoSize = true;
            this.metroLabel17.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel17.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel17.Location = new System.Drawing.Point(3, 35);
            this.metroLabel17.Name = "metroLabel17";
            this.metroLabel17.Size = new System.Drawing.Size(33, 25);
            this.metroLabel17.Style = MetroFramework.MetroColorStyle.White;
            this.metroLabel17.TabIndex = 30;
            this.metroLabel17.Text = "#2";
            this.metroLabel17.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroLabel17.UseStyleColors = true;
            // 
            // metroLabel16
            // 
            this.metroLabel16.AutoSize = true;
            this.metroLabel16.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel16.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel16.Location = new System.Drawing.Point(3, 0);
            this.metroLabel16.Name = "metroLabel16";
            this.metroLabel16.Size = new System.Drawing.Size(33, 25);
            this.metroLabel16.Style = MetroFramework.MetroColorStyle.White;
            this.metroLabel16.TabIndex = 26;
            this.metroLabel16.Text = "#1";
            this.metroLabel16.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroLabel16.UseStyleColors = true;
            // 
            // mt1DirectTxtBox
            // 
            // 
            // 
            // 
            this.mt1DirectTxtBox.CustomButton.Image = null;
            this.mt1DirectTxtBox.CustomButton.Location = new System.Drawing.Point(61, 1);
            this.mt1DirectTxtBox.CustomButton.Margin = new System.Windows.Forms.Padding(2);
            this.mt1DirectTxtBox.CustomButton.Name = "";
            this.mt1DirectTxtBox.CustomButton.Size = new System.Drawing.Size(16, 16);
            this.mt1DirectTxtBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.mt1DirectTxtBox.CustomButton.TabIndex = 1;
            this.mt1DirectTxtBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.mt1DirectTxtBox.CustomButton.UseSelectable = true;
            this.mt1DirectTxtBox.CustomButton.Visible = false;
            this.mt1DirectTxtBox.Lines = new string[0];
            this.mt1DirectTxtBox.Location = new System.Drawing.Point(42, 3);
            this.mt1DirectTxtBox.MaxLength = 32767;
            this.mt1DirectTxtBox.Name = "mt1DirectTxtBox";
            this.mt1DirectTxtBox.PasswordChar = '\0';
            this.mt1DirectTxtBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.mt1DirectTxtBox.SelectedText = "";
            this.mt1DirectTxtBox.SelectionLength = 0;
            this.mt1DirectTxtBox.SelectionStart = 0;
            this.mt1DirectTxtBox.ShortcutsEnabled = true;
            this.mt1DirectTxtBox.Size = new System.Drawing.Size(100, 23);
            this.mt1DirectTxtBox.TabIndex = 26;
            this.mt1DirectTxtBox.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.mt1DirectTxtBox.UseSelectable = true;
            this.mt1DirectTxtBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.mt1DirectTxtBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // mt2DirectTxtBox
            // 
            // 
            // 
            // 
            this.mt2DirectTxtBox.CustomButton.Image = null;
            this.mt2DirectTxtBox.CustomButton.Location = new System.Drawing.Point(61, 1);
            this.mt2DirectTxtBox.CustomButton.Margin = new System.Windows.Forms.Padding(2);
            this.mt2DirectTxtBox.CustomButton.Name = "";
            this.mt2DirectTxtBox.CustomButton.Size = new System.Drawing.Size(16, 16);
            this.mt2DirectTxtBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.mt2DirectTxtBox.CustomButton.TabIndex = 1;
            this.mt2DirectTxtBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.mt2DirectTxtBox.CustomButton.UseSelectable = true;
            this.mt2DirectTxtBox.CustomButton.Visible = false;
            this.mt2DirectTxtBox.Lines = new string[0];
            this.mt2DirectTxtBox.Location = new System.Drawing.Point(42, 38);
            this.mt2DirectTxtBox.MaxLength = 32767;
            this.mt2DirectTxtBox.Name = "mt2DirectTxtBox";
            this.mt2DirectTxtBox.PasswordChar = '\0';
            this.mt2DirectTxtBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.mt2DirectTxtBox.SelectedText = "";
            this.mt2DirectTxtBox.SelectionLength = 0;
            this.mt2DirectTxtBox.SelectionStart = 0;
            this.mt2DirectTxtBox.ShortcutsEnabled = true;
            this.mt2DirectTxtBox.Size = new System.Drawing.Size(100, 23);
            this.mt2DirectTxtBox.TabIndex = 27;
            this.mt2DirectTxtBox.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.mt2DirectTxtBox.UseSelectable = true;
            this.mt2DirectTxtBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.mt2DirectTxtBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // mt3DirectTxtBox
            // 
            // 
            // 
            // 
            this.mt3DirectTxtBox.CustomButton.Image = null;
            this.mt3DirectTxtBox.CustomButton.Location = new System.Drawing.Point(61, 1);
            this.mt3DirectTxtBox.CustomButton.Margin = new System.Windows.Forms.Padding(2);
            this.mt3DirectTxtBox.CustomButton.Name = "";
            this.mt3DirectTxtBox.CustomButton.Size = new System.Drawing.Size(16, 16);
            this.mt3DirectTxtBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.mt3DirectTxtBox.CustomButton.TabIndex = 1;
            this.mt3DirectTxtBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.mt3DirectTxtBox.CustomButton.UseSelectable = true;
            this.mt3DirectTxtBox.CustomButton.Visible = false;
            this.mt3DirectTxtBox.Lines = new string[0];
            this.mt3DirectTxtBox.Location = new System.Drawing.Point(42, 73);
            this.mt3DirectTxtBox.MaxLength = 32767;
            this.mt3DirectTxtBox.Name = "mt3DirectTxtBox";
            this.mt3DirectTxtBox.PasswordChar = '\0';
            this.mt3DirectTxtBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.mt3DirectTxtBox.SelectedText = "";
            this.mt3DirectTxtBox.SelectionLength = 0;
            this.mt3DirectTxtBox.SelectionStart = 0;
            this.mt3DirectTxtBox.ShortcutsEnabled = true;
            this.mt3DirectTxtBox.Size = new System.Drawing.Size(100, 23);
            this.mt3DirectTxtBox.TabIndex = 28;
            this.mt3DirectTxtBox.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.mt3DirectTxtBox.UseSelectable = true;
            this.mt3DirectTxtBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.mt3DirectTxtBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // mt4DirectTxtBox
            // 
            // 
            // 
            // 
            this.mt4DirectTxtBox.CustomButton.Image = null;
            this.mt4DirectTxtBox.CustomButton.Location = new System.Drawing.Point(61, 1);
            this.mt4DirectTxtBox.CustomButton.Margin = new System.Windows.Forms.Padding(2);
            this.mt4DirectTxtBox.CustomButton.Name = "";
            this.mt4DirectTxtBox.CustomButton.Size = new System.Drawing.Size(16, 16);
            this.mt4DirectTxtBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.mt4DirectTxtBox.CustomButton.TabIndex = 1;
            this.mt4DirectTxtBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.mt4DirectTxtBox.CustomButton.UseSelectable = true;
            this.mt4DirectTxtBox.CustomButton.Visible = false;
            this.mt4DirectTxtBox.Lines = new string[0];
            this.mt4DirectTxtBox.Location = new System.Drawing.Point(42, 108);
            this.mt4DirectTxtBox.MaxLength = 32767;
            this.mt4DirectTxtBox.Name = "mt4DirectTxtBox";
            this.mt4DirectTxtBox.PasswordChar = '\0';
            this.mt4DirectTxtBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.mt4DirectTxtBox.SelectedText = "";
            this.mt4DirectTxtBox.SelectionLength = 0;
            this.mt4DirectTxtBox.SelectionStart = 0;
            this.mt4DirectTxtBox.ShortcutsEnabled = true;
            this.mt4DirectTxtBox.Size = new System.Drawing.Size(100, 23);
            this.mt4DirectTxtBox.TabIndex = 29;
            this.mt4DirectTxtBox.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.mt4DirectTxtBox.UseSelectable = true;
            this.mt4DirectTxtBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.mt4DirectTxtBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel15
            // 
            this.metroLabel15.AutoSize = true;
            this.metroLabel15.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel15.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel15.Location = new System.Drawing.Point(439, 53);
            this.metroLabel15.Name = "metroLabel15";
            this.metroLabel15.Size = new System.Drawing.Size(78, 25);
            this.metroLabel15.Style = MetroFramework.MetroColorStyle.White;
            this.metroLabel15.TabIndex = 28;
            this.metroLabel15.Text = "StepSize";
            this.metroLabel15.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroLabel15.UseStyleColors = true;
            // 
            // metroLabel14
            // 
            this.metroLabel14.AutoSize = true;
            this.metroLabel14.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel14.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel14.Location = new System.Drawing.Point(163, 9);
            this.metroLabel14.Name = "metroLabel14";
            this.metroLabel14.Size = new System.Drawing.Size(47, 25);
            this.metroLabel14.Style = MetroFramework.MetroColorStyle.White;
            this.metroLabel14.TabIndex = 27;
            this.metroLabel14.Text = "Step";
            this.metroLabel14.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroLabel14.UseStyleColors = true;
            // 
            // metroLabel13
            // 
            this.metroLabel13.AutoSize = true;
            this.metroLabel13.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel13.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel13.Location = new System.Drawing.Point(3, 9);
            this.metroLabel13.Name = "metroLabel13";
            this.metroLabel13.Size = new System.Drawing.Size(58, 25);
            this.metroLabel13.Style = MetroFramework.MetroColorStyle.White;
            this.metroLabel13.TabIndex = 26;
            this.metroLabel13.Text = "Direct";
            this.metroLabel13.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroLabel13.UseStyleColors = true;
            // 
            // MovementControl
            // 
            this.MovementControl.BackColor = System.Drawing.Color.Transparent;
            this.MovementControl.Controls.Add(this.mtZeroPos4);
            this.MovementControl.Controls.Add(this.mtZeroPos3);
            this.MovementControl.Controls.Add(this.mtZeroPos2);
            this.MovementControl.Controls.Add(this.mtZeroPos1);
            this.MovementControl.Controls.Add(this.metroLabel61);
            this.MovementControl.Controls.Add(this.mtCenterPos4);
            this.MovementControl.Controls.Add(this.mtCenterPos3);
            this.MovementControl.Controls.Add(this.mtCenterPos2);
            this.MovementControl.Controls.Add(this.mtCenterPos1);
            this.MovementControl.Controls.Add(this.metroLabel60);
            this.MovementControl.Controls.Add(this.metroLabel42);
            this.MovementControl.Controls.Add(this.metroLabel41);
            this.MovementControl.Controls.Add(this.metroLabel40);
            this.MovementControl.Controls.Add(this.metroLabel39);
            this.MovementControl.Controls.Add(this.metroButton2);
            this.MovementControl.Controls.Add(this.CtrCenterBtn);
            this.MovementControl.Controls.Add(this.McGoBt);
            this.MovementControl.Controls.Add(this.tableLayoutPanel5);
            this.MovementControl.Controls.Add(this.metroLabel12);
            this.MovementControl.HorizontalScrollbar = true;
            this.MovementControl.HorizontalScrollbarBarColor = false;
            this.MovementControl.HorizontalScrollbarHighlightOnWheel = false;
            this.MovementControl.HorizontalScrollbarSize = 2;
            this.MovementControl.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.MovementControl.Location = new System.Drawing.Point(4, 38);
            this.MovementControl.Name = "MovementControl";
            this.MovementControl.Size = new System.Drawing.Size(852, 356);
            this.MovementControl.TabIndex = 3;
            this.MovementControl.Text = "MovementControl";
            this.MovementControl.UseCustomBackColor = true;
            this.MovementControl.VerticalScrollbarBarColor = true;
            this.MovementControl.VerticalScrollbarHighlightOnWheel = false;
            this.MovementControl.VerticalScrollbarSize = 2;
            // 
            // mtZeroPos4
            // 
            // 
            // 
            // 
            this.mtZeroPos4.CustomButton.Image = null;
            this.mtZeroPos4.CustomButton.Location = new System.Drawing.Point(42, 1);
            this.mtZeroPos4.CustomButton.Margin = new System.Windows.Forms.Padding(2);
            this.mtZeroPos4.CustomButton.Name = "";
            this.mtZeroPos4.CustomButton.Size = new System.Drawing.Size(16, 16);
            this.mtZeroPos4.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.mtZeroPos4.CustomButton.TabIndex = 1;
            this.mtZeroPos4.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.mtZeroPos4.CustomButton.UseSelectable = true;
            this.mtZeroPos4.CustomButton.Visible = false;
            this.mtZeroPos4.Lines = new string[] {
        "5038"};
            this.mtZeroPos4.Location = new System.Drawing.Point(731, 116);
            this.mtZeroPos4.MaxLength = 32767;
            this.mtZeroPos4.Name = "mtZeroPos4";
            this.mtZeroPos4.PasswordChar = '\0';
            this.mtZeroPos4.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.mtZeroPos4.SelectedText = "";
            this.mtZeroPos4.SelectionLength = 0;
            this.mtZeroPos4.SelectionStart = 0;
            this.mtZeroPos4.ShortcutsEnabled = true;
            this.mtZeroPos4.Size = new System.Drawing.Size(76, 23);
            this.mtZeroPos4.TabIndex = 57;
            this.mtZeroPos4.Text = "5038";
            this.mtZeroPos4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.mtZeroPos4.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.mtZeroPos4.UseSelectable = true;
            this.mtZeroPos4.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.mtZeroPos4.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // mtZeroPos3
            // 
            // 
            // 
            // 
            this.mtZeroPos3.CustomButton.Image = null;
            this.mtZeroPos3.CustomButton.Location = new System.Drawing.Point(42, 1);
            this.mtZeroPos3.CustomButton.Margin = new System.Windows.Forms.Padding(2);
            this.mtZeroPos3.CustomButton.Name = "";
            this.mtZeroPos3.CustomButton.Size = new System.Drawing.Size(16, 16);
            this.mtZeroPos3.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.mtZeroPos3.CustomButton.TabIndex = 1;
            this.mtZeroPos3.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.mtZeroPos3.CustomButton.UseSelectable = true;
            this.mtZeroPos3.CustomButton.Visible = false;
            this.mtZeroPos3.Lines = new string[] {
        "-762"};
            this.mtZeroPos3.Location = new System.Drawing.Point(649, 116);
            this.mtZeroPos3.MaxLength = 32767;
            this.mtZeroPos3.Name = "mtZeroPos3";
            this.mtZeroPos3.PasswordChar = '\0';
            this.mtZeroPos3.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.mtZeroPos3.SelectedText = "";
            this.mtZeroPos3.SelectionLength = 0;
            this.mtZeroPos3.SelectionStart = 0;
            this.mtZeroPos3.ShortcutsEnabled = true;
            this.mtZeroPos3.Size = new System.Drawing.Size(76, 23);
            this.mtZeroPos3.TabIndex = 56;
            this.mtZeroPos3.Text = "-762";
            this.mtZeroPos3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.mtZeroPos3.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.mtZeroPos3.UseSelectable = true;
            this.mtZeroPos3.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.mtZeroPos3.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // mtZeroPos2
            // 
            // 
            // 
            // 
            this.mtZeroPos2.CustomButton.Image = null;
            this.mtZeroPos2.CustomButton.Location = new System.Drawing.Point(42, 1);
            this.mtZeroPos2.CustomButton.Margin = new System.Windows.Forms.Padding(2);
            this.mtZeroPos2.CustomButton.Name = "";
            this.mtZeroPos2.CustomButton.Size = new System.Drawing.Size(16, 16);
            this.mtZeroPos2.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.mtZeroPos2.CustomButton.TabIndex = 1;
            this.mtZeroPos2.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.mtZeroPos2.CustomButton.UseSelectable = true;
            this.mtZeroPos2.CustomButton.Visible = false;
            this.mtZeroPos2.Lines = new string[] {
        "1243"};
            this.mtZeroPos2.Location = new System.Drawing.Point(567, 116);
            this.mtZeroPos2.MaxLength = 32767;
            this.mtZeroPos2.Name = "mtZeroPos2";
            this.mtZeroPos2.PasswordChar = '\0';
            this.mtZeroPos2.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.mtZeroPos2.SelectedText = "";
            this.mtZeroPos2.SelectionLength = 0;
            this.mtZeroPos2.SelectionStart = 0;
            this.mtZeroPos2.ShortcutsEnabled = true;
            this.mtZeroPos2.Size = new System.Drawing.Size(76, 23);
            this.mtZeroPos2.TabIndex = 55;
            this.mtZeroPos2.Text = "1243";
            this.mtZeroPos2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.mtZeroPos2.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.mtZeroPos2.UseSelectable = true;
            this.mtZeroPos2.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.mtZeroPos2.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // mtZeroPos1
            // 
            // 
            // 
            // 
            this.mtZeroPos1.CustomButton.Image = null;
            this.mtZeroPos1.CustomButton.Location = new System.Drawing.Point(42, 1);
            this.mtZeroPos1.CustomButton.Margin = new System.Windows.Forms.Padding(2);
            this.mtZeroPos1.CustomButton.Name = "";
            this.mtZeroPos1.CustomButton.Size = new System.Drawing.Size(16, 16);
            this.mtZeroPos1.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.mtZeroPos1.CustomButton.TabIndex = 1;
            this.mtZeroPos1.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.mtZeroPos1.CustomButton.UseSelectable = true;
            this.mtZeroPos1.CustomButton.Visible = false;
            this.mtZeroPos1.Lines = new string[] {
        "1218"};
            this.mtZeroPos1.Location = new System.Drawing.Point(485, 116);
            this.mtZeroPos1.MaxLength = 32767;
            this.mtZeroPos1.Name = "mtZeroPos1";
            this.mtZeroPos1.PasswordChar = '\0';
            this.mtZeroPos1.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.mtZeroPos1.SelectedText = "";
            this.mtZeroPos1.SelectionLength = 0;
            this.mtZeroPos1.SelectionStart = 0;
            this.mtZeroPos1.ShortcutsEnabled = true;
            this.mtZeroPos1.Size = new System.Drawing.Size(76, 23);
            this.mtZeroPos1.TabIndex = 54;
            this.mtZeroPos1.Text = "1218";
            this.mtZeroPos1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.mtZeroPos1.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.mtZeroPos1.UseSelectable = true;
            this.mtZeroPos1.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.mtZeroPos1.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel61
            // 
            this.metroLabel61.AutoSize = true;
            this.metroLabel61.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel61.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel61.Location = new System.Drawing.Point(482, 88);
            this.metroLabel61.Name = "metroLabel61";
            this.metroLabel61.Size = new System.Drawing.Size(98, 25);
            this.metroLabel61.Style = MetroFramework.MetroColorStyle.White;
            this.metroLabel61.TabIndex = 53;
            this.metroLabel61.Text = "MotorZero";
            this.metroLabel61.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroLabel61.UseStyleColors = true;
            // 
            // mtCenterPos4
            // 
            // 
            // 
            // 
            this.mtCenterPos4.CustomButton.Image = null;
            this.mtCenterPos4.CustomButton.Location = new System.Drawing.Point(42, 1);
            this.mtCenterPos4.CustomButton.Margin = new System.Windows.Forms.Padding(2);
            this.mtCenterPos4.CustomButton.Name = "";
            this.mtCenterPos4.CustomButton.Size = new System.Drawing.Size(16, 16);
            this.mtCenterPos4.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.mtCenterPos4.CustomButton.TabIndex = 1;
            this.mtCenterPos4.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.mtCenterPos4.CustomButton.UseSelectable = true;
            this.mtCenterPos4.CustomButton.Visible = false;
            this.mtCenterPos4.Lines = new string[] {
        "1290"};
            this.mtCenterPos4.Location = new System.Drawing.Point(731, 37);
            this.mtCenterPos4.MaxLength = 32767;
            this.mtCenterPos4.Name = "mtCenterPos4";
            this.mtCenterPos4.PasswordChar = '\0';
            this.mtCenterPos4.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.mtCenterPos4.SelectedText = "";
            this.mtCenterPos4.SelectionLength = 0;
            this.mtCenterPos4.SelectionStart = 0;
            this.mtCenterPos4.ShortcutsEnabled = true;
            this.mtCenterPos4.Size = new System.Drawing.Size(76, 23);
            this.mtCenterPos4.TabIndex = 52;
            this.mtCenterPos4.Text = "1290";
            this.mtCenterPos4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.mtCenterPos4.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.mtCenterPos4.UseSelectable = true;
            this.mtCenterPos4.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.mtCenterPos4.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // mtCenterPos3
            // 
            // 
            // 
            // 
            this.mtCenterPos3.CustomButton.Image = null;
            this.mtCenterPos3.CustomButton.Location = new System.Drawing.Point(42, 1);
            this.mtCenterPos3.CustomButton.Margin = new System.Windows.Forms.Padding(2);
            this.mtCenterPos3.CustomButton.Name = "";
            this.mtCenterPos3.CustomButton.Size = new System.Drawing.Size(16, 16);
            this.mtCenterPos3.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.mtCenterPos3.CustomButton.TabIndex = 1;
            this.mtCenterPos3.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.mtCenterPos3.CustomButton.UseSelectable = true;
            this.mtCenterPos3.CustomButton.Visible = false;
            this.mtCenterPos3.Lines = new string[] {
        "-762"};
            this.mtCenterPos3.Location = new System.Drawing.Point(649, 37);
            this.mtCenterPos3.MaxLength = 32767;
            this.mtCenterPos3.Name = "mtCenterPos3";
            this.mtCenterPos3.PasswordChar = '\0';
            this.mtCenterPos3.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.mtCenterPos3.SelectedText = "";
            this.mtCenterPos3.SelectionLength = 0;
            this.mtCenterPos3.SelectionStart = 0;
            this.mtCenterPos3.ShortcutsEnabled = true;
            this.mtCenterPos3.Size = new System.Drawing.Size(76, 23);
            this.mtCenterPos3.TabIndex = 51;
            this.mtCenterPos3.Text = "-762";
            this.mtCenterPos3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.mtCenterPos3.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.mtCenterPos3.UseSelectable = true;
            this.mtCenterPos3.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.mtCenterPos3.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // mtCenterPos2
            // 
            // 
            // 
            // 
            this.mtCenterPos2.CustomButton.Image = null;
            this.mtCenterPos2.CustomButton.Location = new System.Drawing.Point(42, 1);
            this.mtCenterPos2.CustomButton.Margin = new System.Windows.Forms.Padding(2);
            this.mtCenterPos2.CustomButton.Name = "";
            this.mtCenterPos2.CustomButton.Size = new System.Drawing.Size(16, 16);
            this.mtCenterPos2.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.mtCenterPos2.CustomButton.TabIndex = 1;
            this.mtCenterPos2.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.mtCenterPos2.CustomButton.UseSelectable = true;
            this.mtCenterPos2.CustomButton.Visible = false;
            this.mtCenterPos2.Lines = new string[] {
        "-1533"};
            this.mtCenterPos2.Location = new System.Drawing.Point(567, 37);
            this.mtCenterPos2.MaxLength = 32767;
            this.mtCenterPos2.Name = "mtCenterPos2";
            this.mtCenterPos2.PasswordChar = '\0';
            this.mtCenterPos2.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.mtCenterPos2.SelectedText = "";
            this.mtCenterPos2.SelectionLength = 0;
            this.mtCenterPos2.SelectionStart = 0;
            this.mtCenterPos2.ShortcutsEnabled = true;
            this.mtCenterPos2.Size = new System.Drawing.Size(76, 23);
            this.mtCenterPos2.TabIndex = 50;
            this.mtCenterPos2.Text = "-1533";
            this.mtCenterPos2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.mtCenterPos2.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.mtCenterPos2.UseSelectable = true;
            this.mtCenterPos2.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.mtCenterPos2.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // mtCenterPos1
            // 
            // 
            // 
            // 
            this.mtCenterPos1.CustomButton.Image = null;
            this.mtCenterPos1.CustomButton.Location = new System.Drawing.Point(42, 1);
            this.mtCenterPos1.CustomButton.Margin = new System.Windows.Forms.Padding(2);
            this.mtCenterPos1.CustomButton.Name = "";
            this.mtCenterPos1.CustomButton.Size = new System.Drawing.Size(16, 16);
            this.mtCenterPos1.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.mtCenterPos1.CustomButton.TabIndex = 1;
            this.mtCenterPos1.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.mtCenterPos1.CustomButton.UseSelectable = true;
            this.mtCenterPos1.CustomButton.Visible = false;
            this.mtCenterPos1.Lines = new string[] {
        "1218"};
            this.mtCenterPos1.Location = new System.Drawing.Point(485, 37);
            this.mtCenterPos1.MaxLength = 32767;
            this.mtCenterPos1.Name = "mtCenterPos1";
            this.mtCenterPos1.PasswordChar = '\0';
            this.mtCenterPos1.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.mtCenterPos1.SelectedText = "";
            this.mtCenterPos1.SelectionLength = 0;
            this.mtCenterPos1.SelectionStart = 0;
            this.mtCenterPos1.ShortcutsEnabled = true;
            this.mtCenterPos1.Size = new System.Drawing.Size(76, 23);
            this.mtCenterPos1.TabIndex = 49;
            this.mtCenterPos1.Text = "1218";
            this.mtCenterPos1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.mtCenterPos1.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.mtCenterPos1.UseSelectable = true;
            this.mtCenterPos1.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.mtCenterPos1.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel60
            // 
            this.metroLabel60.AutoSize = true;
            this.metroLabel60.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel60.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel60.Location = new System.Drawing.Point(482, 6);
            this.metroLabel60.Name = "metroLabel60";
            this.metroLabel60.Size = new System.Drawing.Size(113, 25);
            this.metroLabel60.Style = MetroFramework.MetroColorStyle.White;
            this.metroLabel60.TabIndex = 48;
            this.metroLabel60.Text = "MotorCenter";
            this.metroLabel60.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroLabel60.UseStyleColors = true;
            // 
            // metroLabel42
            // 
            this.metroLabel42.AutoSize = true;
            this.metroLabel42.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel42.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel42.Location = new System.Drawing.Point(290, 211);
            this.metroLabel42.Name = "metroLabel42";
            this.metroLabel42.Size = new System.Drawing.Size(101, 25);
            this.metroLabel42.Style = MetroFramework.MetroColorStyle.White;
            this.metroLabel42.TabIndex = 47;
            this.metroLabel42.Text = "0~75 (mm)";
            this.metroLabel42.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroLabel42.UseStyleColors = true;
            // 
            // metroLabel41
            // 
            this.metroLabel41.AutoSize = true;
            this.metroLabel41.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel41.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel41.Location = new System.Drawing.Point(280, 175);
            this.metroLabel41.Name = "metroLabel41";
            this.metroLabel41.Size = new System.Drawing.Size(111, 25);
            this.metroLabel41.Style = MetroFramework.MetroColorStyle.White;
            this.metroLabel41.TabIndex = 46;
            this.metroLabel41.Text = "0~150 (mm)";
            this.metroLabel41.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroLabel41.UseStyleColors = true;
            // 
            // metroLabel40
            // 
            this.metroLabel40.AutoSize = true;
            this.metroLabel40.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel40.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel40.Location = new System.Drawing.Point(64, 211);
            this.metroLabel40.Name = "metroLabel40";
            this.metroLabel40.Size = new System.Drawing.Size(208, 25);
            this.metroLabel40.Style = MetroFramework.MetroColorStyle.White;
            this.metroLabel40.TabIndex = 45;
            this.metroLabel40.Text = "Tube2 translation range :";
            this.metroLabel40.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroLabel40.UseStyleColors = true;
            // 
            // metroLabel39
            // 
            this.metroLabel39.AutoSize = true;
            this.metroLabel39.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel39.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel39.Location = new System.Drawing.Point(64, 175);
            this.metroLabel39.Name = "metroLabel39";
            this.metroLabel39.Size = new System.Drawing.Size(208, 25);
            this.metroLabel39.Style = MetroFramework.MetroColorStyle.White;
            this.metroLabel39.TabIndex = 43;
            this.metroLabel39.Text = "Tube1 translation range :";
            this.metroLabel39.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroLabel39.UseStyleColors = true;
            // 
            // metroButton2
            // 
            this.metroButton2.DisplayFocus = true;
            this.metroButton2.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.metroButton2.Location = new System.Drawing.Point(349, 116);
            this.metroButton2.Name = "metroButton2";
            this.metroButton2.Size = new System.Drawing.Size(105, 29);
            this.metroButton2.TabIndex = 44;
            this.metroButton2.Text = "ZERO";
            this.metroButton2.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroButton2.UseSelectable = true;
            this.metroButton2.Click += new System.EventHandler(this.McZeroBtn_Click);
            // 
            // CtrCenterBtn
            // 
            this.CtrCenterBtn.DisplayFocus = true;
            this.CtrCenterBtn.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.CtrCenterBtn.Location = new System.Drawing.Point(349, 81);
            this.CtrCenterBtn.Name = "CtrCenterBtn";
            this.CtrCenterBtn.Size = new System.Drawing.Size(105, 29);
            this.CtrCenterBtn.TabIndex = 43;
            this.CtrCenterBtn.Text = "CTR CENTER";
            this.CtrCenterBtn.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.CtrCenterBtn.UseSelectable = true;
            this.CtrCenterBtn.Click += new System.EventHandler(this.McCenterBtn_Click);
            // 
            // McGoBt
            // 
            this.McGoBt.DisplayFocus = true;
            this.McGoBt.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.McGoBt.Location = new System.Drawing.Point(349, 46);
            this.McGoBt.Name = "McGoBt";
            this.McGoBt.Size = new System.Drawing.Size(105, 29);
            this.McGoBt.TabIndex = 41;
            this.McGoBt.Text = "GO";
            this.McGoBt.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.McGoBt.UseSelectable = true;
            this.McGoBt.Click += new System.EventHandler(this.McGoBt_Click);
            // 
            // tableLayoutPanel5
            // 
            this.tableLayoutPanel5.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel5.ColumnCount = 3;
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel5.Controls.Add(this.MC_tube2_rt, 2, 1);
            this.tableLayoutPanel5.Controls.Add(this.MC_tube1_tr, 1, 2);
            this.tableLayoutPanel5.Controls.Add(this.MC_tube2_tr, 2, 2);
            this.tableLayoutPanel5.Controls.Add(this.metroLabel35, 0, 2);
            this.tableLayoutPanel5.Controls.Add(this.metroLabel37, 0, 1);
            this.tableLayoutPanel5.Controls.Add(metroLabel36, 2, 0);
            this.tableLayoutPanel5.Controls.Add(this.metroLabel38, 1, 0);
            this.tableLayoutPanel5.Controls.Add(this.MC_tube1_rt, 1, 1);
            this.tableLayoutPanel5.Controls.Add(this.metroLabel43, 0, 0);
            this.tableLayoutPanel5.Location = new System.Drawing.Point(0, 37);
            this.tableLayoutPanel5.Name = "tableLayoutPanel5";
            this.tableLayoutPanel5.RowCount = 3;
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel5.Size = new System.Drawing.Size(343, 135);
            this.tableLayoutPanel5.TabIndex = 40;
            // 
            // MC_tube2_rt
            // 
            // 
            // 
            // 
            this.MC_tube2_rt.CustomButton.Image = null;
            this.MC_tube2_rt.CustomButton.Location = new System.Drawing.Point(42, 1);
            this.MC_tube2_rt.CustomButton.Margin = new System.Windows.Forms.Padding(2);
            this.MC_tube2_rt.CustomButton.Name = "";
            this.MC_tube2_rt.CustomButton.Size = new System.Drawing.Size(16, 16);
            this.MC_tube2_rt.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.MC_tube2_rt.CustomButton.TabIndex = 1;
            this.MC_tube2_rt.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.MC_tube2_rt.CustomButton.UseSelectable = true;
            this.MC_tube2_rt.CustomButton.Visible = false;
            this.MC_tube2_rt.Lines = new string[0];
            this.MC_tube2_rt.Location = new System.Drawing.Point(259, 48);
            this.MC_tube2_rt.MaxLength = 32767;
            this.MC_tube2_rt.Name = "MC_tube2_rt";
            this.MC_tube2_rt.PasswordChar = '\0';
            this.MC_tube2_rt.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.MC_tube2_rt.SelectedText = "";
            this.MC_tube2_rt.SelectionLength = 0;
            this.MC_tube2_rt.SelectionStart = 0;
            this.MC_tube2_rt.ShortcutsEnabled = true;
            this.MC_tube2_rt.Size = new System.Drawing.Size(76, 23);
            this.MC_tube2_rt.TabIndex = 28;
            this.MC_tube2_rt.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.MC_tube2_rt.UseSelectable = true;
            this.MC_tube2_rt.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.MC_tube2_rt.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.MC_tube2_rt.KeyDown += new System.Windows.Forms.KeyEventHandler(this.MC_TextBox_KeyDown);
            // 
            // MC_tube1_tr
            // 
            // 
            // 
            // 
            this.MC_tube1_tr.CustomButton.Image = null;
            this.MC_tube1_tr.CustomButton.Location = new System.Drawing.Point(42, 1);
            this.MC_tube1_tr.CustomButton.Margin = new System.Windows.Forms.Padding(2);
            this.MC_tube1_tr.CustomButton.Name = "";
            this.MC_tube1_tr.CustomButton.Size = new System.Drawing.Size(16, 16);
            this.MC_tube1_tr.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.MC_tube1_tr.CustomButton.TabIndex = 1;
            this.MC_tube1_tr.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.MC_tube1_tr.CustomButton.UseSelectable = true;
            this.MC_tube1_tr.CustomButton.Visible = false;
            this.MC_tube1_tr.Lines = new string[0];
            this.MC_tube1_tr.Location = new System.Drawing.Point(174, 93);
            this.MC_tube1_tr.MaxLength = 32767;
            this.MC_tube1_tr.Name = "MC_tube1_tr";
            this.MC_tube1_tr.PasswordChar = '\0';
            this.MC_tube1_tr.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.MC_tube1_tr.SelectedText = "";
            this.MC_tube1_tr.SelectionLength = 0;
            this.MC_tube1_tr.SelectionStart = 0;
            this.MC_tube1_tr.ShortcutsEnabled = true;
            this.MC_tube1_tr.Size = new System.Drawing.Size(76, 23);
            this.MC_tube1_tr.TabIndex = 29;
            this.MC_tube1_tr.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.MC_tube1_tr.UseSelectable = true;
            this.MC_tube1_tr.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.MC_tube1_tr.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.MC_tube1_tr.KeyDown += new System.Windows.Forms.KeyEventHandler(this.MC_TextBox_KeyDown);
            // 
            // MC_tube2_tr
            // 
            // 
            // 
            // 
            this.MC_tube2_tr.CustomButton.Image = null;
            this.MC_tube2_tr.CustomButton.Location = new System.Drawing.Point(42, 1);
            this.MC_tube2_tr.CustomButton.Margin = new System.Windows.Forms.Padding(2);
            this.MC_tube2_tr.CustomButton.Name = "";
            this.MC_tube2_tr.CustomButton.Size = new System.Drawing.Size(16, 16);
            this.MC_tube2_tr.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.MC_tube2_tr.CustomButton.TabIndex = 1;
            this.MC_tube2_tr.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.MC_tube2_tr.CustomButton.UseSelectable = true;
            this.MC_tube2_tr.CustomButton.Visible = false;
            this.MC_tube2_tr.Lines = new string[0];
            this.MC_tube2_tr.Location = new System.Drawing.Point(259, 93);
            this.MC_tube2_tr.MaxLength = 32767;
            this.MC_tube2_tr.Name = "MC_tube2_tr";
            this.MC_tube2_tr.PasswordChar = '\0';
            this.MC_tube2_tr.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.MC_tube2_tr.SelectedText = "";
            this.MC_tube2_tr.SelectionLength = 0;
            this.MC_tube2_tr.SelectionStart = 0;
            this.MC_tube2_tr.ShortcutsEnabled = true;
            this.MC_tube2_tr.Size = new System.Drawing.Size(76, 23);
            this.MC_tube2_tr.TabIndex = 30;
            this.MC_tube2_tr.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.MC_tube2_tr.UseSelectable = true;
            this.MC_tube2_tr.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.MC_tube2_tr.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.MC_tube2_tr.KeyDown += new System.Windows.Forms.KeyEventHandler(this.MC_TextBox_KeyDown);
            // 
            // metroLabel35
            // 
            this.metroLabel35.AutoSize = true;
            this.metroLabel35.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel35.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel35.Location = new System.Drawing.Point(3, 90);
            this.metroLabel35.Name = "metroLabel35";
            this.metroLabel35.Size = new System.Drawing.Size(138, 25);
            this.metroLabel35.Style = MetroFramework.MetroColorStyle.White;
            this.metroLabel35.TabIndex = 37;
            this.metroLabel35.Text = "Translation(mm)";
            this.metroLabel35.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroLabel35.UseStyleColors = true;
            // 
            // metroLabel37
            // 
            this.metroLabel37.AutoSize = true;
            this.metroLabel37.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel37.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel37.Location = new System.Drawing.Point(3, 45);
            this.metroLabel37.Name = "metroLabel37";
            this.metroLabel37.Size = new System.Drawing.Size(123, 25);
            this.metroLabel37.Style = MetroFramework.MetroColorStyle.White;
            this.metroLabel37.TabIndex = 39;
            this.metroLabel37.Text = "Rotation(DEG)";
            this.metroLabel37.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroLabel37.UseStyleColors = true;
            // 
            // metroLabel38
            // 
            this.metroLabel38.AutoSize = true;
            this.metroLabel38.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel38.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel38.Location = new System.Drawing.Point(174, 0);
            this.metroLabel38.Name = "metroLabel38";
            this.metroLabel38.Size = new System.Drawing.Size(67, 25);
            this.metroLabel38.Style = MetroFramework.MetroColorStyle.White;
            this.metroLabel38.TabIndex = 41;
            this.metroLabel38.Text = "TUBE 1";
            this.metroLabel38.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroLabel38.UseStyleColors = true;
            // 
            // MC_tube1_rt
            // 
            // 
            // 
            // 
            this.MC_tube1_rt.CustomButton.Image = null;
            this.MC_tube1_rt.CustomButton.Location = new System.Drawing.Point(42, 1);
            this.MC_tube1_rt.CustomButton.Margin = new System.Windows.Forms.Padding(2);
            this.MC_tube1_rt.CustomButton.Name = "";
            this.MC_tube1_rt.CustomButton.Size = new System.Drawing.Size(16, 16);
            this.MC_tube1_rt.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.MC_tube1_rt.CustomButton.TabIndex = 1;
            this.MC_tube1_rt.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.MC_tube1_rt.CustomButton.UseSelectable = true;
            this.MC_tube1_rt.CustomButton.Visible = false;
            this.MC_tube1_rt.Lines = new string[0];
            this.MC_tube1_rt.Location = new System.Drawing.Point(174, 48);
            this.MC_tube1_rt.MaxLength = 32767;
            this.MC_tube1_rt.Name = "MC_tube1_rt";
            this.MC_tube1_rt.PasswordChar = '\0';
            this.MC_tube1_rt.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.MC_tube1_rt.SelectedText = "";
            this.MC_tube1_rt.SelectionLength = 0;
            this.MC_tube1_rt.SelectionStart = 0;
            this.MC_tube1_rt.ShortcutsEnabled = true;
            this.MC_tube1_rt.Size = new System.Drawing.Size(76, 23);
            this.MC_tube1_rt.TabIndex = 27;
            this.MC_tube1_rt.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.MC_tube1_rt.UseSelectable = true;
            this.MC_tube1_rt.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.MC_tube1_rt.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.MC_tube1_rt.KeyDown += new System.Windows.Forms.KeyEventHandler(this.MC_TextBox_KeyDown);
            // 
            // metroLabel43
            // 
            this.metroLabel43.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.metroLabel43.AutoSize = true;
            this.metroLabel43.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel43.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel43.Location = new System.Drawing.Point(3, 0);
            this.metroLabel43.Name = "metroLabel43";
            this.metroLabel43.Size = new System.Drawing.Size(165, 45);
            this.metroLabel43.Style = MetroFramework.MetroColorStyle.White;
            this.metroLabel43.TabIndex = 48;
            this.metroLabel43.Text = "(mm)";
            this.metroLabel43.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroLabel43.UseStyleColors = true;
            // 
            // metroLabel12
            // 
            this.metroLabel12.AutoSize = true;
            this.metroLabel12.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel12.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel12.Location = new System.Drawing.Point(0, 6);
            this.metroLabel12.Name = "metroLabel12";
            this.metroLabel12.Size = new System.Drawing.Size(157, 25);
            this.metroLabel12.Style = MetroFramework.MetroColorStyle.White;
            this.metroLabel12.TabIndex = 39;
            this.metroLabel12.Text = "MovementControl";
            this.metroLabel12.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroLabel12.UseStyleColors = true;
            // 
            // PositionControl
            // 
            this.PositionControl.BackColor = System.Drawing.Color.Transparent;
            this.PositionControl.Controls.Add(this.metroLabel59);
            this.PositionControl.Controls.Add(this.PcZOriTxtbox);
            this.PositionControl.Controls.Add(this.PcYOriTxtbox);
            this.PositionControl.Controls.Add(this.PcXOriTxtbox);
            this.PositionControl.Controls.Add(this.metroLabel58);
            this.PositionControl.Controls.Add(this.metroLabel57);
            this.PositionControl.Controls.Add(this.metroLabel56);
            this.PositionControl.Controls.Add(this.PcTboToggle);
            this.PositionControl.Controls.Add(this.PcTolToggle);
            this.PositionControl.Controls.Add(this.metroLabel55);
            this.PositionControl.Controls.Add(this.metroLabel54);
            this.PositionControl.Controls.Add(this.metroLabel53);
            this.PositionControl.Controls.Add(this.PcZPosTxtbox);
            this.PositionControl.Controls.Add(this.PcYPosTxtbox);
            this.PositionControl.Controls.Add(this.PcXPosTxtbox);
            this.PositionControl.Controls.Add(this.PcGetXyzPosBtn);
            this.PositionControl.Controls.Add(this.metroLabel52);
            this.PositionControl.Controls.Add(this.PcTube2ETxtbox);
            this.PositionControl.Controls.Add(this.PcTube2RhoTxtbox);
            this.PositionControl.Controls.Add(this.PcTube2AngleTxtbox);
            this.PositionControl.Controls.Add(this.PcTube2L_sTxtbox);
            this.PositionControl.Controls.Add(this.PcTube2ODTxtbox);
            this.PositionControl.Controls.Add(this.PcTube2IDTxtbox);
            this.PositionControl.Controls.Add(this.metroLabel51);
            this.PositionControl.Controls.Add(this.PcTube1ETxtbox);
            this.PositionControl.Controls.Add(this.metroLabel50);
            this.PositionControl.Controls.Add(this.PcTube1RhoTxtbox);
            this.PositionControl.Controls.Add(this.metroLabel49);
            this.PositionControl.Controls.Add(this.metroLabel48);
            this.PositionControl.Controls.Add(this.metroLabel47);
            this.PositionControl.Controls.Add(this.metroLabel46);
            this.PositionControl.Controls.Add(this.metroLabel45);
            this.PositionControl.Controls.Add(this.PcTube1AngleTxtbox);
            this.PositionControl.Controls.Add(this.PcTube1L_sTxtbox);
            this.PositionControl.Controls.Add(this.PcTube1ODTxtbox);
            this.PositionControl.Controls.Add(this.PcTube1IDTxtbox);
            this.PositionControl.Controls.Add(this.metroLabel44);
            this.PositionControl.HorizontalScrollbarBarColor = true;
            this.PositionControl.HorizontalScrollbarHighlightOnWheel = false;
            this.PositionControl.HorizontalScrollbarSize = 2;
            this.PositionControl.Location = new System.Drawing.Point(4, 38);
            this.PositionControl.Name = "PositionControl";
            this.PositionControl.Size = new System.Drawing.Size(852, 356);
            this.PositionControl.TabIndex = 4;
            this.PositionControl.Text = "PositionControl";
            this.PositionControl.UseCustomBackColor = true;
            this.PositionControl.VerticalScrollbarBarColor = true;
            this.PositionControl.VerticalScrollbarHighlightOnWheel = false;
            this.PositionControl.VerticalScrollbarSize = 2;
            // 
            // metroLabel59
            // 
            this.metroLabel59.AutoSize = true;
            this.metroLabel59.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel59.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel59.Location = new System.Drawing.Point(362, 103);
            this.metroLabel59.Name = "metroLabel59";
            this.metroLabel59.Size = new System.Drawing.Size(99, 25);
            this.metroLabel59.Style = MetroFramework.MetroColorStyle.White;
            this.metroLabel59.TabIndex = 63;
            this.metroLabel59.Text = "Current Ori";
            this.metroLabel59.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroLabel59.UseStyleColors = true;
            // 
            // PcZOriTxtbox
            // 
            // 
            // 
            // 
            this.PcZOriTxtbox.CustomButton.Image = null;
            this.PcZOriTxtbox.CustomButton.Location = new System.Drawing.Point(42, 1);
            this.PcZOriTxtbox.CustomButton.Margin = new System.Windows.Forms.Padding(2);
            this.PcZOriTxtbox.CustomButton.Name = "";
            this.PcZOriTxtbox.CustomButton.Size = new System.Drawing.Size(16, 16);
            this.PcZOriTxtbox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.PcZOriTxtbox.CustomButton.TabIndex = 1;
            this.PcZOriTxtbox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.PcZOriTxtbox.CustomButton.UseSelectable = true;
            this.PcZOriTxtbox.CustomButton.Visible = false;
            this.PcZOriTxtbox.Lines = new string[0];
            this.PcZOriTxtbox.Location = new System.Drawing.Point(645, 105);
            this.PcZOriTxtbox.MaxLength = 32767;
            this.PcZOriTxtbox.Name = "PcZOriTxtbox";
            this.PcZOriTxtbox.PasswordChar = '\0';
            this.PcZOriTxtbox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.PcZOriTxtbox.SelectedText = "";
            this.PcZOriTxtbox.SelectionLength = 0;
            this.PcZOriTxtbox.SelectionStart = 0;
            this.PcZOriTxtbox.ShortcutsEnabled = true;
            this.PcZOriTxtbox.Size = new System.Drawing.Size(76, 23);
            this.PcZOriTxtbox.TabIndex = 62;
            this.PcZOriTxtbox.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.PcZOriTxtbox.UseSelectable = true;
            this.PcZOriTxtbox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.PcZOriTxtbox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // PcYOriTxtbox
            // 
            // 
            // 
            // 
            this.PcYOriTxtbox.CustomButton.Image = null;
            this.PcYOriTxtbox.CustomButton.Location = new System.Drawing.Point(42, 1);
            this.PcYOriTxtbox.CustomButton.Margin = new System.Windows.Forms.Padding(2);
            this.PcYOriTxtbox.CustomButton.Name = "";
            this.PcYOriTxtbox.CustomButton.Size = new System.Drawing.Size(16, 16);
            this.PcYOriTxtbox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.PcYOriTxtbox.CustomButton.TabIndex = 1;
            this.PcYOriTxtbox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.PcYOriTxtbox.CustomButton.UseSelectable = true;
            this.PcYOriTxtbox.CustomButton.Visible = false;
            this.PcYOriTxtbox.Lines = new string[0];
            this.PcYOriTxtbox.Location = new System.Drawing.Point(563, 105);
            this.PcYOriTxtbox.MaxLength = 32767;
            this.PcYOriTxtbox.Name = "PcYOriTxtbox";
            this.PcYOriTxtbox.PasswordChar = '\0';
            this.PcYOriTxtbox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.PcYOriTxtbox.SelectedText = "";
            this.PcYOriTxtbox.SelectionLength = 0;
            this.PcYOriTxtbox.SelectionStart = 0;
            this.PcYOriTxtbox.ShortcutsEnabled = true;
            this.PcYOriTxtbox.Size = new System.Drawing.Size(76, 23);
            this.PcYOriTxtbox.TabIndex = 61;
            this.PcYOriTxtbox.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.PcYOriTxtbox.UseSelectable = true;
            this.PcYOriTxtbox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.PcYOriTxtbox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // PcXOriTxtbox
            // 
            // 
            // 
            // 
            this.PcXOriTxtbox.CustomButton.Image = null;
            this.PcXOriTxtbox.CustomButton.Location = new System.Drawing.Point(42, 1);
            this.PcXOriTxtbox.CustomButton.Margin = new System.Windows.Forms.Padding(2);
            this.PcXOriTxtbox.CustomButton.Name = "";
            this.PcXOriTxtbox.CustomButton.Size = new System.Drawing.Size(16, 16);
            this.PcXOriTxtbox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.PcXOriTxtbox.CustomButton.TabIndex = 1;
            this.PcXOriTxtbox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.PcXOriTxtbox.CustomButton.UseSelectable = true;
            this.PcXOriTxtbox.CustomButton.Visible = false;
            this.PcXOriTxtbox.Lines = new string[0];
            this.PcXOriTxtbox.Location = new System.Drawing.Point(481, 105);
            this.PcXOriTxtbox.MaxLength = 32767;
            this.PcXOriTxtbox.Name = "PcXOriTxtbox";
            this.PcXOriTxtbox.PasswordChar = '\0';
            this.PcXOriTxtbox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.PcXOriTxtbox.SelectedText = "";
            this.PcXOriTxtbox.SelectionLength = 0;
            this.PcXOriTxtbox.SelectionStart = 0;
            this.PcXOriTxtbox.ShortcutsEnabled = true;
            this.PcXOriTxtbox.Size = new System.Drawing.Size(76, 23);
            this.PcXOriTxtbox.TabIndex = 60;
            this.PcXOriTxtbox.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.PcXOriTxtbox.UseSelectable = true;
            this.PcXOriTxtbox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.PcXOriTxtbox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel58
            // 
            this.metroLabel58.AutoSize = true;
            this.metroLabel58.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel58.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel58.Location = new System.Drawing.Point(362, 74);
            this.metroLabel58.Name = "metroLabel58";
            this.metroLabel58.Size = new System.Drawing.Size(103, 25);
            this.metroLabel58.Style = MetroFramework.MetroColorStyle.White;
            this.metroLabel58.TabIndex = 58;
            this.metroLabel58.Text = "Current Pos";
            this.metroLabel58.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroLabel58.UseStyleColors = true;
            // 
            // metroLabel57
            // 
            this.metroLabel57.AutoSize = true;
            this.metroLabel57.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel57.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel57.Location = new System.Drawing.Point(47, 315);
            this.metroLabel57.Name = "metroLabel57";
            this.metroLabel57.Size = new System.Drawing.Size(115, 25);
            this.metroLabel57.Style = MetroFramework.MetroColorStyle.White;
            this.metroLabel57.TabIndex = 57;
            this.metroLabel57.Text = "Tol base only";
            this.metroLabel57.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroLabel57.UseStyleColors = true;
            // 
            // metroLabel56
            // 
            this.metroLabel56.AutoSize = true;
            this.metroLabel56.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel56.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel56.Location = new System.Drawing.Point(47, 279);
            this.metroLabel56.Name = "metroLabel56";
            this.metroLabel56.Size = new System.Drawing.Size(34, 25);
            this.metroLabel56.Style = MetroFramework.MetroColorStyle.White;
            this.metroLabel56.TabIndex = 56;
            this.metroLabel56.Text = "Tol";
            this.metroLabel56.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroLabel56.UseStyleColors = true;
            // 
            // PcTboToggle
            // 
            this.PcTboToggle.AutoSize = true;
            this.PcTboToggle.FontSize = MetroFramework.MetroLinkSize.Medium;
            this.PcTboToggle.Location = new System.Drawing.Point(189, 318);
            this.PcTboToggle.Name = "PcTboToggle";
            this.PcTboToggle.Size = new System.Drawing.Size(80, 20);
            this.PcTboToggle.TabIndex = 55;
            this.PcTboToggle.Text = "Off";
            this.PcTboToggle.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.PcTboToggle.UseSelectable = true;
            // 
            // PcTolToggle
            // 
            this.PcTolToggle.AutoSize = true;
            this.PcTolToggle.FontSize = MetroFramework.MetroLinkSize.Medium;
            this.PcTolToggle.Location = new System.Drawing.Point(189, 284);
            this.PcTolToggle.Name = "PcTolToggle";
            this.PcTolToggle.Size = new System.Drawing.Size(80, 20);
            this.PcTolToggle.TabIndex = 54;
            this.PcTolToggle.Text = "Off";
            this.PcTolToggle.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.PcTolToggle.UseSelectable = true;
            // 
            // metroLabel55
            // 
            this.metroLabel55.AutoSize = true;
            this.metroLabel55.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel55.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel55.Location = new System.Drawing.Point(645, 48);
            this.metroLabel55.Name = "metroLabel55";
            this.metroLabel55.Size = new System.Drawing.Size(22, 25);
            this.metroLabel55.Style = MetroFramework.MetroColorStyle.White;
            this.metroLabel55.TabIndex = 53;
            this.metroLabel55.Text = "Z";
            this.metroLabel55.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroLabel55.UseStyleColors = true;
            // 
            // metroLabel54
            // 
            this.metroLabel54.AutoSize = true;
            this.metroLabel54.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel54.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel54.Location = new System.Drawing.Point(563, 48);
            this.metroLabel54.Name = "metroLabel54";
            this.metroLabel54.Size = new System.Drawing.Size(22, 25);
            this.metroLabel54.Style = MetroFramework.MetroColorStyle.White;
            this.metroLabel54.TabIndex = 52;
            this.metroLabel54.Text = "Y";
            this.metroLabel54.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroLabel54.UseStyleColors = true;
            // 
            // metroLabel53
            // 
            this.metroLabel53.AutoSize = true;
            this.metroLabel53.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel53.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel53.Location = new System.Drawing.Point(481, 48);
            this.metroLabel53.Name = "metroLabel53";
            this.metroLabel53.Size = new System.Drawing.Size(23, 25);
            this.metroLabel53.Style = MetroFramework.MetroColorStyle.White;
            this.metroLabel53.TabIndex = 51;
            this.metroLabel53.Text = "X";
            this.metroLabel53.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroLabel53.UseStyleColors = true;
            // 
            // PcZPosTxtbox
            // 
            // 
            // 
            // 
            this.PcZPosTxtbox.CustomButton.Image = null;
            this.PcZPosTxtbox.CustomButton.Location = new System.Drawing.Point(42, 1);
            this.PcZPosTxtbox.CustomButton.Margin = new System.Windows.Forms.Padding(2);
            this.PcZPosTxtbox.CustomButton.Name = "";
            this.PcZPosTxtbox.CustomButton.Size = new System.Drawing.Size(16, 16);
            this.PcZPosTxtbox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.PcZPosTxtbox.CustomButton.TabIndex = 1;
            this.PcZPosTxtbox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.PcZPosTxtbox.CustomButton.UseSelectable = true;
            this.PcZPosTxtbox.CustomButton.Visible = false;
            this.PcZPosTxtbox.Lines = new string[0];
            this.PcZPosTxtbox.Location = new System.Drawing.Point(645, 76);
            this.PcZPosTxtbox.MaxLength = 32767;
            this.PcZPosTxtbox.Name = "PcZPosTxtbox";
            this.PcZPosTxtbox.PasswordChar = '\0';
            this.PcZPosTxtbox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.PcZPosTxtbox.SelectedText = "";
            this.PcZPosTxtbox.SelectionLength = 0;
            this.PcZPosTxtbox.SelectionStart = 0;
            this.PcZPosTxtbox.ShortcutsEnabled = true;
            this.PcZPosTxtbox.Size = new System.Drawing.Size(76, 23);
            this.PcZPosTxtbox.TabIndex = 50;
            this.PcZPosTxtbox.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.PcZPosTxtbox.UseSelectable = true;
            this.PcZPosTxtbox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.PcZPosTxtbox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // PcYPosTxtbox
            // 
            // 
            // 
            // 
            this.PcYPosTxtbox.CustomButton.Image = null;
            this.PcYPosTxtbox.CustomButton.Location = new System.Drawing.Point(42, 1);
            this.PcYPosTxtbox.CustomButton.Margin = new System.Windows.Forms.Padding(2);
            this.PcYPosTxtbox.CustomButton.Name = "";
            this.PcYPosTxtbox.CustomButton.Size = new System.Drawing.Size(16, 16);
            this.PcYPosTxtbox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.PcYPosTxtbox.CustomButton.TabIndex = 1;
            this.PcYPosTxtbox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.PcYPosTxtbox.CustomButton.UseSelectable = true;
            this.PcYPosTxtbox.CustomButton.Visible = false;
            this.PcYPosTxtbox.Lines = new string[0];
            this.PcYPosTxtbox.Location = new System.Drawing.Point(563, 76);
            this.PcYPosTxtbox.MaxLength = 32767;
            this.PcYPosTxtbox.Name = "PcYPosTxtbox";
            this.PcYPosTxtbox.PasswordChar = '\0';
            this.PcYPosTxtbox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.PcYPosTxtbox.SelectedText = "";
            this.PcYPosTxtbox.SelectionLength = 0;
            this.PcYPosTxtbox.SelectionStart = 0;
            this.PcYPosTxtbox.ShortcutsEnabled = true;
            this.PcYPosTxtbox.Size = new System.Drawing.Size(76, 23);
            this.PcYPosTxtbox.TabIndex = 49;
            this.PcYPosTxtbox.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.PcYPosTxtbox.UseSelectable = true;
            this.PcYPosTxtbox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.PcYPosTxtbox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // PcXPosTxtbox
            // 
            // 
            // 
            // 
            this.PcXPosTxtbox.CustomButton.Image = null;
            this.PcXPosTxtbox.CustomButton.Location = new System.Drawing.Point(42, 1);
            this.PcXPosTxtbox.CustomButton.Margin = new System.Windows.Forms.Padding(2);
            this.PcXPosTxtbox.CustomButton.Name = "";
            this.PcXPosTxtbox.CustomButton.Size = new System.Drawing.Size(16, 16);
            this.PcXPosTxtbox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.PcXPosTxtbox.CustomButton.TabIndex = 1;
            this.PcXPosTxtbox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.PcXPosTxtbox.CustomButton.UseSelectable = true;
            this.PcXPosTxtbox.CustomButton.Visible = false;
            this.PcXPosTxtbox.Lines = new string[0];
            this.PcXPosTxtbox.Location = new System.Drawing.Point(481, 76);
            this.PcXPosTxtbox.MaxLength = 32767;
            this.PcXPosTxtbox.Name = "PcXPosTxtbox";
            this.PcXPosTxtbox.PasswordChar = '\0';
            this.PcXPosTxtbox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.PcXPosTxtbox.SelectedText = "";
            this.PcXPosTxtbox.SelectionLength = 0;
            this.PcXPosTxtbox.SelectionStart = 0;
            this.PcXPosTxtbox.ShortcutsEnabled = true;
            this.PcXPosTxtbox.Size = new System.Drawing.Size(76, 23);
            this.PcXPosTxtbox.TabIndex = 48;
            this.PcXPosTxtbox.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.PcXPosTxtbox.UseSelectable = true;
            this.PcXPosTxtbox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.PcXPosTxtbox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // PcGetXyzPosBtn
            // 
            this.PcGetXyzPosBtn.DisplayFocus = true;
            this.PcGetXyzPosBtn.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.PcGetXyzPosBtn.Location = new System.Drawing.Point(727, 74);
            this.PcGetXyzPosBtn.Name = "PcGetXyzPosBtn";
            this.PcGetXyzPosBtn.Size = new System.Drawing.Size(98, 54);
            this.PcGetXyzPosBtn.TabIndex = 47;
            this.PcGetXyzPosBtn.Text = "Get XYZ";
            this.PcGetXyzPosBtn.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.PcGetXyzPosBtn.UseSelectable = true;
            this.PcGetXyzPosBtn.Click += new System.EventHandler(this.PcGetXyzPosBtn_Click);
            // 
            // metroLabel52
            // 
            this.metroLabel52.AutoSize = true;
            this.metroLabel52.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel52.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel52.Location = new System.Drawing.Point(206, 48);
            this.metroLabel52.Name = "metroLabel52";
            this.metroLabel52.Size = new System.Drawing.Size(66, 25);
            this.metroLabel52.Style = MetroFramework.MetroColorStyle.White;
            this.metroLabel52.TabIndex = 46;
            this.metroLabel52.Text = "Tube 2";
            this.metroLabel52.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroLabel52.UseStyleColors = true;
            // 
            // PcTube2ETxtbox
            // 
            // 
            // 
            // 
            this.PcTube2ETxtbox.CustomButton.Image = null;
            this.PcTube2ETxtbox.CustomButton.Location = new System.Drawing.Point(42, 1);
            this.PcTube2ETxtbox.CustomButton.Margin = new System.Windows.Forms.Padding(2);
            this.PcTube2ETxtbox.CustomButton.Name = "";
            this.PcTube2ETxtbox.CustomButton.Size = new System.Drawing.Size(16, 16);
            this.PcTube2ETxtbox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.PcTube2ETxtbox.CustomButton.TabIndex = 1;
            this.PcTube2ETxtbox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.PcTube2ETxtbox.CustomButton.UseSelectable = true;
            this.PcTube2ETxtbox.CustomButton.Visible = false;
            this.PcTube2ETxtbox.Lines = new string[] {
        "1"};
            this.PcTube2ETxtbox.Location = new System.Drawing.Point(207, 221);
            this.PcTube2ETxtbox.MaxLength = 32767;
            this.PcTube2ETxtbox.Name = "PcTube2ETxtbox";
            this.PcTube2ETxtbox.PasswordChar = '\0';
            this.PcTube2ETxtbox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.PcTube2ETxtbox.SelectedText = "";
            this.PcTube2ETxtbox.SelectionLength = 0;
            this.PcTube2ETxtbox.SelectionStart = 0;
            this.PcTube2ETxtbox.ShortcutsEnabled = true;
            this.PcTube2ETxtbox.Size = new System.Drawing.Size(76, 23);
            this.PcTube2ETxtbox.TabIndex = 45;
            this.PcTube2ETxtbox.Text = "1";
            this.PcTube2ETxtbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.PcTube2ETxtbox.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.PcTube2ETxtbox.UseSelectable = true;
            this.PcTube2ETxtbox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.PcTube2ETxtbox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // PcTube2RhoTxtbox
            // 
            // 
            // 
            // 
            this.PcTube2RhoTxtbox.CustomButton.Image = null;
            this.PcTube2RhoTxtbox.CustomButton.Location = new System.Drawing.Point(42, 1);
            this.PcTube2RhoTxtbox.CustomButton.Margin = new System.Windows.Forms.Padding(2);
            this.PcTube2RhoTxtbox.CustomButton.Name = "";
            this.PcTube2RhoTxtbox.CustomButton.Size = new System.Drawing.Size(16, 16);
            this.PcTube2RhoTxtbox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.PcTube2RhoTxtbox.CustomButton.TabIndex = 1;
            this.PcTube2RhoTxtbox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.PcTube2RhoTxtbox.CustomButton.UseSelectable = true;
            this.PcTube2RhoTxtbox.CustomButton.Visible = false;
            this.PcTube2RhoTxtbox.Lines = new string[] {
        "52"};
            this.PcTube2RhoTxtbox.Location = new System.Drawing.Point(207, 192);
            this.PcTube2RhoTxtbox.MaxLength = 32767;
            this.PcTube2RhoTxtbox.Name = "PcTube2RhoTxtbox";
            this.PcTube2RhoTxtbox.PasswordChar = '\0';
            this.PcTube2RhoTxtbox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.PcTube2RhoTxtbox.SelectedText = "";
            this.PcTube2RhoTxtbox.SelectionLength = 0;
            this.PcTube2RhoTxtbox.SelectionStart = 0;
            this.PcTube2RhoTxtbox.ShortcutsEnabled = true;
            this.PcTube2RhoTxtbox.Size = new System.Drawing.Size(76, 23);
            this.PcTube2RhoTxtbox.TabIndex = 44;
            this.PcTube2RhoTxtbox.Text = "52";
            this.PcTube2RhoTxtbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.PcTube2RhoTxtbox.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.PcTube2RhoTxtbox.UseSelectable = true;
            this.PcTube2RhoTxtbox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.PcTube2RhoTxtbox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // PcTube2AngleTxtbox
            // 
            // 
            // 
            // 
            this.PcTube2AngleTxtbox.CustomButton.Image = null;
            this.PcTube2AngleTxtbox.CustomButton.Location = new System.Drawing.Point(42, 1);
            this.PcTube2AngleTxtbox.CustomButton.Margin = new System.Windows.Forms.Padding(2);
            this.PcTube2AngleTxtbox.CustomButton.Name = "";
            this.PcTube2AngleTxtbox.CustomButton.Size = new System.Drawing.Size(16, 16);
            this.PcTube2AngleTxtbox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.PcTube2AngleTxtbox.CustomButton.TabIndex = 1;
            this.PcTube2AngleTxtbox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.PcTube2AngleTxtbox.CustomButton.UseSelectable = true;
            this.PcTube2AngleTxtbox.CustomButton.Visible = false;
            this.PcTube2AngleTxtbox.Lines = new string[] {
        "82.638"};
            this.PcTube2AngleTxtbox.Location = new System.Drawing.Point(207, 163);
            this.PcTube2AngleTxtbox.MaxLength = 32767;
            this.PcTube2AngleTxtbox.Name = "PcTube2AngleTxtbox";
            this.PcTube2AngleTxtbox.PasswordChar = '\0';
            this.PcTube2AngleTxtbox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.PcTube2AngleTxtbox.SelectedText = "";
            this.PcTube2AngleTxtbox.SelectionLength = 0;
            this.PcTube2AngleTxtbox.SelectionStart = 0;
            this.PcTube2AngleTxtbox.ShortcutsEnabled = true;
            this.PcTube2AngleTxtbox.Size = new System.Drawing.Size(76, 23);
            this.PcTube2AngleTxtbox.TabIndex = 43;
            this.PcTube2AngleTxtbox.Text = "82.638";
            this.PcTube2AngleTxtbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.PcTube2AngleTxtbox.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.PcTube2AngleTxtbox.UseSelectable = true;
            this.PcTube2AngleTxtbox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.PcTube2AngleTxtbox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // PcTube2L_sTxtbox
            // 
            // 
            // 
            // 
            this.PcTube2L_sTxtbox.CustomButton.Image = null;
            this.PcTube2L_sTxtbox.CustomButton.Location = new System.Drawing.Point(42, 1);
            this.PcTube2L_sTxtbox.CustomButton.Margin = new System.Windows.Forms.Padding(2);
            this.PcTube2L_sTxtbox.CustomButton.Name = "";
            this.PcTube2L_sTxtbox.CustomButton.Size = new System.Drawing.Size(16, 16);
            this.PcTube2L_sTxtbox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.PcTube2L_sTxtbox.CustomButton.TabIndex = 1;
            this.PcTube2L_sTxtbox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.PcTube2L_sTxtbox.CustomButton.UseSelectable = true;
            this.PcTube2L_sTxtbox.CustomButton.Visible = false;
            this.PcTube2L_sTxtbox.Lines = new string[] {
        "10"};
            this.PcTube2L_sTxtbox.Location = new System.Drawing.Point(207, 134);
            this.PcTube2L_sTxtbox.MaxLength = 32767;
            this.PcTube2L_sTxtbox.Name = "PcTube2L_sTxtbox";
            this.PcTube2L_sTxtbox.PasswordChar = '\0';
            this.PcTube2L_sTxtbox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.PcTube2L_sTxtbox.SelectedText = "";
            this.PcTube2L_sTxtbox.SelectionLength = 0;
            this.PcTube2L_sTxtbox.SelectionStart = 0;
            this.PcTube2L_sTxtbox.ShortcutsEnabled = true;
            this.PcTube2L_sTxtbox.Size = new System.Drawing.Size(76, 23);
            this.PcTube2L_sTxtbox.TabIndex = 42;
            this.PcTube2L_sTxtbox.Text = "10";
            this.PcTube2L_sTxtbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.PcTube2L_sTxtbox.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.PcTube2L_sTxtbox.UseSelectable = true;
            this.PcTube2L_sTxtbox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.PcTube2L_sTxtbox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // PcTube2ODTxtbox
            // 
            // 
            // 
            // 
            this.PcTube2ODTxtbox.CustomButton.Image = null;
            this.PcTube2ODTxtbox.CustomButton.Location = new System.Drawing.Point(42, 1);
            this.PcTube2ODTxtbox.CustomButton.Margin = new System.Windows.Forms.Padding(2);
            this.PcTube2ODTxtbox.CustomButton.Name = "";
            this.PcTube2ODTxtbox.CustomButton.Size = new System.Drawing.Size(16, 16);
            this.PcTube2ODTxtbox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.PcTube2ODTxtbox.CustomButton.TabIndex = 1;
            this.PcTube2ODTxtbox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.PcTube2ODTxtbox.CustomButton.UseSelectable = true;
            this.PcTube2ODTxtbox.CustomButton.Visible = false;
            this.PcTube2ODTxtbox.Lines = new string[] {
        "6.7"};
            this.PcTube2ODTxtbox.Location = new System.Drawing.Point(207, 105);
            this.PcTube2ODTxtbox.MaxLength = 32767;
            this.PcTube2ODTxtbox.Name = "PcTube2ODTxtbox";
            this.PcTube2ODTxtbox.PasswordChar = '\0';
            this.PcTube2ODTxtbox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.PcTube2ODTxtbox.SelectedText = "";
            this.PcTube2ODTxtbox.SelectionLength = 0;
            this.PcTube2ODTxtbox.SelectionStart = 0;
            this.PcTube2ODTxtbox.ShortcutsEnabled = true;
            this.PcTube2ODTxtbox.Size = new System.Drawing.Size(76, 23);
            this.PcTube2ODTxtbox.TabIndex = 41;
            this.PcTube2ODTxtbox.Text = "6.7";
            this.PcTube2ODTxtbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.PcTube2ODTxtbox.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.PcTube2ODTxtbox.UseSelectable = true;
            this.PcTube2ODTxtbox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.PcTube2ODTxtbox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // PcTube2IDTxtbox
            // 
            // 
            // 
            // 
            this.PcTube2IDTxtbox.CustomButton.Image = null;
            this.PcTube2IDTxtbox.CustomButton.Location = new System.Drawing.Point(42, 1);
            this.PcTube2IDTxtbox.CustomButton.Margin = new System.Windows.Forms.Padding(2);
            this.PcTube2IDTxtbox.CustomButton.Name = "";
            this.PcTube2IDTxtbox.CustomButton.Size = new System.Drawing.Size(16, 16);
            this.PcTube2IDTxtbox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.PcTube2IDTxtbox.CustomButton.TabIndex = 1;
            this.PcTube2IDTxtbox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.PcTube2IDTxtbox.CustomButton.UseSelectable = true;
            this.PcTube2IDTxtbox.CustomButton.Visible = false;
            this.PcTube2IDTxtbox.Lines = new string[] {
        "4.7"};
            this.PcTube2IDTxtbox.Location = new System.Drawing.Point(207, 76);
            this.PcTube2IDTxtbox.MaxLength = 32767;
            this.PcTube2IDTxtbox.Name = "PcTube2IDTxtbox";
            this.PcTube2IDTxtbox.PasswordChar = '\0';
            this.PcTube2IDTxtbox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.PcTube2IDTxtbox.SelectedText = "";
            this.PcTube2IDTxtbox.SelectionLength = 0;
            this.PcTube2IDTxtbox.SelectionStart = 0;
            this.PcTube2IDTxtbox.ShortcutsEnabled = true;
            this.PcTube2IDTxtbox.Size = new System.Drawing.Size(76, 23);
            this.PcTube2IDTxtbox.TabIndex = 40;
            this.PcTube2IDTxtbox.Text = "4.7";
            this.PcTube2IDTxtbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.PcTube2IDTxtbox.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.PcTube2IDTxtbox.UseSelectable = true;
            this.PcTube2IDTxtbox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.PcTube2IDTxtbox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel51
            // 
            this.metroLabel51.AutoSize = true;
            this.metroLabel51.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel51.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel51.Location = new System.Drawing.Point(123, 48);
            this.metroLabel51.Name = "metroLabel51";
            this.metroLabel51.Size = new System.Drawing.Size(66, 25);
            this.metroLabel51.Style = MetroFramework.MetroColorStyle.White;
            this.metroLabel51.TabIndex = 39;
            this.metroLabel51.Text = "Tube 1";
            this.metroLabel51.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroLabel51.UseStyleColors = true;
            // 
            // PcTube1ETxtbox
            // 
            // 
            // 
            // 
            this.PcTube1ETxtbox.CustomButton.Image = null;
            this.PcTube1ETxtbox.CustomButton.Location = new System.Drawing.Point(42, 1);
            this.PcTube1ETxtbox.CustomButton.Margin = new System.Windows.Forms.Padding(2);
            this.PcTube1ETxtbox.CustomButton.Name = "";
            this.PcTube1ETxtbox.CustomButton.Size = new System.Drawing.Size(16, 16);
            this.PcTube1ETxtbox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.PcTube1ETxtbox.CustomButton.TabIndex = 1;
            this.PcTube1ETxtbox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.PcTube1ETxtbox.CustomButton.UseSelectable = true;
            this.PcTube1ETxtbox.CustomButton.Visible = false;
            this.PcTube1ETxtbox.Lines = new string[] {
        "10.81"};
            this.PcTube1ETxtbox.Location = new System.Drawing.Point(124, 221);
            this.PcTube1ETxtbox.MaxLength = 32767;
            this.PcTube1ETxtbox.Name = "PcTube1ETxtbox";
            this.PcTube1ETxtbox.PasswordChar = '\0';
            this.PcTube1ETxtbox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.PcTube1ETxtbox.SelectedText = "";
            this.PcTube1ETxtbox.SelectionLength = 0;
            this.PcTube1ETxtbox.SelectionStart = 0;
            this.PcTube1ETxtbox.ShortcutsEnabled = true;
            this.PcTube1ETxtbox.Size = new System.Drawing.Size(76, 23);
            this.PcTube1ETxtbox.TabIndex = 38;
            this.PcTube1ETxtbox.Text = "10.81";
            this.PcTube1ETxtbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.PcTube1ETxtbox.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.PcTube1ETxtbox.UseSelectable = true;
            this.PcTube1ETxtbox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.PcTube1ETxtbox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel50
            // 
            this.metroLabel50.AutoSize = true;
            this.metroLabel50.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel50.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel50.Location = new System.Drawing.Point(0, 221);
            this.metroLabel50.Name = "metroLabel50";
            this.metroLabel50.Size = new System.Drawing.Size(72, 25);
            this.metroLabel50.Style = MetroFramework.MetroColorStyle.White;
            this.metroLabel50.TabIndex = 37;
            this.metroLabel50.Text = "E (ratio)";
            this.metroLabel50.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroLabel50.UseStyleColors = true;
            // 
            // PcTube1RhoTxtbox
            // 
            // 
            // 
            // 
            this.PcTube1RhoTxtbox.CustomButton.Image = null;
            this.PcTube1RhoTxtbox.CustomButton.Location = new System.Drawing.Point(42, 1);
            this.PcTube1RhoTxtbox.CustomButton.Margin = new System.Windows.Forms.Padding(2);
            this.PcTube1RhoTxtbox.CustomButton.Name = "";
            this.PcTube1RhoTxtbox.CustomButton.Size = new System.Drawing.Size(16, 16);
            this.PcTube1RhoTxtbox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.PcTube1RhoTxtbox.CustomButton.TabIndex = 1;
            this.PcTube1RhoTxtbox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.PcTube1RhoTxtbox.CustomButton.UseSelectable = true;
            this.PcTube1RhoTxtbox.CustomButton.Visible = false;
            this.PcTube1RhoTxtbox.Lines = new string[] {
        "80"};
            this.PcTube1RhoTxtbox.Location = new System.Drawing.Point(124, 192);
            this.PcTube1RhoTxtbox.MaxLength = 32767;
            this.PcTube1RhoTxtbox.Name = "PcTube1RhoTxtbox";
            this.PcTube1RhoTxtbox.PasswordChar = '\0';
            this.PcTube1RhoTxtbox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.PcTube1RhoTxtbox.SelectedText = "";
            this.PcTube1RhoTxtbox.SelectionLength = 0;
            this.PcTube1RhoTxtbox.SelectionStart = 0;
            this.PcTube1RhoTxtbox.ShortcutsEnabled = true;
            this.PcTube1RhoTxtbox.Size = new System.Drawing.Size(76, 23);
            this.PcTube1RhoTxtbox.TabIndex = 36;
            this.PcTube1RhoTxtbox.Text = "80";
            this.PcTube1RhoTxtbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.PcTube1RhoTxtbox.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.PcTube1RhoTxtbox.UseSelectable = true;
            this.PcTube1RhoTxtbox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.PcTube1RhoTxtbox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel49
            // 
            this.metroLabel49.AutoSize = true;
            this.metroLabel49.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel49.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel49.Location = new System.Drawing.Point(0, 192);
            this.metroLabel49.Name = "metroLabel49";
            this.metroLabel49.Size = new System.Drawing.Size(86, 25);
            this.metroLabel49.Style = MetroFramework.MetroColorStyle.White;
            this.metroLabel49.TabIndex = 35;
            this.metroLabel49.Text = "rho (mm)";
            this.metroLabel49.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroLabel49.UseStyleColors = true;
            // 
            // metroLabel48
            // 
            this.metroLabel48.AutoSize = true;
            this.metroLabel48.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel48.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel48.Location = new System.Drawing.Point(0, 161);
            this.metroLabel48.Name = "metroLabel48";
            this.metroLabel48.Size = new System.Drawing.Size(101, 25);
            this.metroLabel48.Style = MetroFramework.MetroColorStyle.White;
            this.metroLabel48.TabIndex = 34;
            this.metroLabel48.Text = "angle (deg)";
            this.metroLabel48.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroLabel48.UseStyleColors = true;
            // 
            // metroLabel47
            // 
            this.metroLabel47.AutoSize = true;
            this.metroLabel47.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel47.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel47.Location = new System.Drawing.Point(0, 132);
            this.metroLabel47.Name = "metroLabel47";
            this.metroLabel47.Size = new System.Drawing.Size(82, 25);
            this.metroLabel47.Style = MetroFramework.MetroColorStyle.White;
            this.metroLabel47.TabIndex = 33;
            this.metroLabel47.Text = "L_s (mm)";
            this.metroLabel47.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroLabel47.UseStyleColors = true;
            // 
            // metroLabel46
            // 
            this.metroLabel46.AutoSize = true;
            this.metroLabel46.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel46.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel46.Location = new System.Drawing.Point(0, 103);
            this.metroLabel46.Name = "metroLabel46";
            this.metroLabel46.Size = new System.Drawing.Size(86, 25);
            this.metroLabel46.Style = MetroFramework.MetroColorStyle.White;
            this.metroLabel46.TabIndex = 32;
            this.metroLabel46.Text = "OD (mm)";
            this.metroLabel46.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroLabel46.UseStyleColors = true;
            // 
            // metroLabel45
            // 
            this.metroLabel45.AutoSize = true;
            this.metroLabel45.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel45.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel45.Location = new System.Drawing.Point(0, 72);
            this.metroLabel45.Name = "metroLabel45";
            this.metroLabel45.Size = new System.Drawing.Size(77, 25);
            this.metroLabel45.Style = MetroFramework.MetroColorStyle.White;
            this.metroLabel45.TabIndex = 26;
            this.metroLabel45.Text = "ID (mm)";
            this.metroLabel45.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroLabel45.UseStyleColors = true;
            // 
            // PcTube1AngleTxtbox
            // 
            // 
            // 
            // 
            this.PcTube1AngleTxtbox.CustomButton.Image = null;
            this.PcTube1AngleTxtbox.CustomButton.Location = new System.Drawing.Point(42, 1);
            this.PcTube1AngleTxtbox.CustomButton.Margin = new System.Windows.Forms.Padding(2);
            this.PcTube1AngleTxtbox.CustomButton.Name = "";
            this.PcTube1AngleTxtbox.CustomButton.Size = new System.Drawing.Size(16, 16);
            this.PcTube1AngleTxtbox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.PcTube1AngleTxtbox.CustomButton.TabIndex = 1;
            this.PcTube1AngleTxtbox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.PcTube1AngleTxtbox.CustomButton.UseSelectable = true;
            this.PcTube1AngleTxtbox.CustomButton.Visible = false;
            this.PcTube1AngleTxtbox.Lines = new string[] {
        "53.715"};
            this.PcTube1AngleTxtbox.Location = new System.Drawing.Point(124, 163);
            this.PcTube1AngleTxtbox.MaxLength = 32767;
            this.PcTube1AngleTxtbox.Name = "PcTube1AngleTxtbox";
            this.PcTube1AngleTxtbox.PasswordChar = '\0';
            this.PcTube1AngleTxtbox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.PcTube1AngleTxtbox.SelectedText = "";
            this.PcTube1AngleTxtbox.SelectionLength = 0;
            this.PcTube1AngleTxtbox.SelectionStart = 0;
            this.PcTube1AngleTxtbox.ShortcutsEnabled = true;
            this.PcTube1AngleTxtbox.Size = new System.Drawing.Size(76, 23);
            this.PcTube1AngleTxtbox.TabIndex = 31;
            this.PcTube1AngleTxtbox.Text = "53.715";
            this.PcTube1AngleTxtbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.PcTube1AngleTxtbox.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.PcTube1AngleTxtbox.UseSelectable = true;
            this.PcTube1AngleTxtbox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.PcTube1AngleTxtbox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // PcTube1L_sTxtbox
            // 
            // 
            // 
            // 
            this.PcTube1L_sTxtbox.CustomButton.Image = null;
            this.PcTube1L_sTxtbox.CustomButton.Location = new System.Drawing.Point(42, 1);
            this.PcTube1L_sTxtbox.CustomButton.Margin = new System.Windows.Forms.Padding(2);
            this.PcTube1L_sTxtbox.CustomButton.Name = "";
            this.PcTube1L_sTxtbox.CustomButton.Size = new System.Drawing.Size(16, 16);
            this.PcTube1L_sTxtbox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.PcTube1L_sTxtbox.CustomButton.TabIndex = 1;
            this.PcTube1L_sTxtbox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.PcTube1L_sTxtbox.CustomButton.UseSelectable = true;
            this.PcTube1L_sTxtbox.CustomButton.Visible = false;
            this.PcTube1L_sTxtbox.Lines = new string[] {
        "75"};
            this.PcTube1L_sTxtbox.Location = new System.Drawing.Point(124, 134);
            this.PcTube1L_sTxtbox.MaxLength = 32767;
            this.PcTube1L_sTxtbox.Name = "PcTube1L_sTxtbox";
            this.PcTube1L_sTxtbox.PasswordChar = '\0';
            this.PcTube1L_sTxtbox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.PcTube1L_sTxtbox.SelectedText = "";
            this.PcTube1L_sTxtbox.SelectionLength = 0;
            this.PcTube1L_sTxtbox.SelectionStart = 0;
            this.PcTube1L_sTxtbox.ShortcutsEnabled = true;
            this.PcTube1L_sTxtbox.Size = new System.Drawing.Size(76, 23);
            this.PcTube1L_sTxtbox.TabIndex = 30;
            this.PcTube1L_sTxtbox.Text = "75";
            this.PcTube1L_sTxtbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.PcTube1L_sTxtbox.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.PcTube1L_sTxtbox.UseSelectable = true;
            this.PcTube1L_sTxtbox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.PcTube1L_sTxtbox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // PcTube1ODTxtbox
            // 
            // 
            // 
            // 
            this.PcTube1ODTxtbox.CustomButton.Image = null;
            this.PcTube1ODTxtbox.CustomButton.Location = new System.Drawing.Point(42, 1);
            this.PcTube1ODTxtbox.CustomButton.Margin = new System.Windows.Forms.Padding(2);
            this.PcTube1ODTxtbox.CustomButton.Name = "";
            this.PcTube1ODTxtbox.CustomButton.Size = new System.Drawing.Size(16, 16);
            this.PcTube1ODTxtbox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.PcTube1ODTxtbox.CustomButton.TabIndex = 1;
            this.PcTube1ODTxtbox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.PcTube1ODTxtbox.CustomButton.UseSelectable = true;
            this.PcTube1ODTxtbox.CustomButton.Visible = false;
            this.PcTube1ODTxtbox.Lines = new string[] {
        "4"};
            this.PcTube1ODTxtbox.Location = new System.Drawing.Point(124, 105);
            this.PcTube1ODTxtbox.MaxLength = 32767;
            this.PcTube1ODTxtbox.Name = "PcTube1ODTxtbox";
            this.PcTube1ODTxtbox.PasswordChar = '\0';
            this.PcTube1ODTxtbox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.PcTube1ODTxtbox.SelectedText = "";
            this.PcTube1ODTxtbox.SelectionLength = 0;
            this.PcTube1ODTxtbox.SelectionStart = 0;
            this.PcTube1ODTxtbox.ShortcutsEnabled = true;
            this.PcTube1ODTxtbox.Size = new System.Drawing.Size(76, 23);
            this.PcTube1ODTxtbox.TabIndex = 29;
            this.PcTube1ODTxtbox.Text = "4";
            this.PcTube1ODTxtbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.PcTube1ODTxtbox.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.PcTube1ODTxtbox.UseSelectable = true;
            this.PcTube1ODTxtbox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.PcTube1ODTxtbox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // PcTube1IDTxtbox
            // 
            // 
            // 
            // 
            this.PcTube1IDTxtbox.CustomButton.Image = null;
            this.PcTube1IDTxtbox.CustomButton.Location = new System.Drawing.Point(42, 1);
            this.PcTube1IDTxtbox.CustomButton.Margin = new System.Windows.Forms.Padding(2);
            this.PcTube1IDTxtbox.CustomButton.Name = "";
            this.PcTube1IDTxtbox.CustomButton.Size = new System.Drawing.Size(16, 16);
            this.PcTube1IDTxtbox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.PcTube1IDTxtbox.CustomButton.TabIndex = 1;
            this.PcTube1IDTxtbox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.PcTube1IDTxtbox.CustomButton.UseSelectable = true;
            this.PcTube1IDTxtbox.CustomButton.Visible = false;
            this.PcTube1IDTxtbox.Lines = new string[] {
        "2.5"};
            this.PcTube1IDTxtbox.Location = new System.Drawing.Point(124, 76);
            this.PcTube1IDTxtbox.MaxLength = 32767;
            this.PcTube1IDTxtbox.Name = "PcTube1IDTxtbox";
            this.PcTube1IDTxtbox.PasswordChar = '\0';
            this.PcTube1IDTxtbox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.PcTube1IDTxtbox.SelectedText = "";
            this.PcTube1IDTxtbox.SelectionLength = 0;
            this.PcTube1IDTxtbox.SelectionStart = 0;
            this.PcTube1IDTxtbox.ShortcutsEnabled = true;
            this.PcTube1IDTxtbox.Size = new System.Drawing.Size(76, 23);
            this.PcTube1IDTxtbox.TabIndex = 28;
            this.PcTube1IDTxtbox.Text = "2.5";
            this.PcTube1IDTxtbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.PcTube1IDTxtbox.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.PcTube1IDTxtbox.UseSelectable = true;
            this.PcTube1IDTxtbox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.PcTube1IDTxtbox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel44
            // 
            this.metroLabel44.AutoSize = true;
            this.metroLabel44.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel44.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel44.Location = new System.Drawing.Point(3, 9);
            this.metroLabel44.Name = "metroLabel44";
            this.metroLabel44.Size = new System.Drawing.Size(104, 25);
            this.metroLabel44.Style = MetroFramework.MetroColorStyle.White;
            this.metroLabel44.TabIndex = 26;
            this.metroLabel44.Text = "Tube Preset";
            this.metroLabel44.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroLabel44.UseStyleColors = true;
            // 
            // About
            // 
            this.About.BackColor = System.Drawing.Color.Transparent;
            this.About.Controls.Add(this.metroLabel34);
            this.About.HorizontalScrollbarBarColor = true;
            this.About.HorizontalScrollbarHighlightOnWheel = false;
            this.About.HorizontalScrollbarSize = 2;
            this.About.Location = new System.Drawing.Point(4, 38);
            this.About.Name = "About";
            this.About.Size = new System.Drawing.Size(852, 356);
            this.About.TabIndex = 2;
            this.About.Text = "About";
            this.About.UseCustomBackColor = true;
            this.About.VerticalScrollbarBarColor = true;
            this.About.VerticalScrollbarHighlightOnWheel = false;
            this.About.VerticalScrollbarSize = 2;
            // 
            // metroLabel34
            // 
            this.metroLabel34.AutoSize = true;
            this.metroLabel34.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel34.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel34.Location = new System.Drawing.Point(3, 13);
            this.metroLabel34.Name = "metroLabel34";
            this.metroLabel34.Size = new System.Drawing.Size(288, 100);
            this.metroLabel34.Style = MetroFramework.MetroColorStyle.White;
            this.metroLabel34.TabIndex = 20;
            this.metroLabel34.Text = "Beta Version with MetroFramework\r\n\r\ndeveloped by S.J.Lee\r\ngithub.com/GuitarMechan" +
    "ics";
            this.metroLabel34.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroLabel34.UseStyleColors = true;
            // 
            // mtCenterPos1
            // 
            // 
            // 
            // 
            this.mtCenterPos1.CustomButton.Image = null;
            this.mtCenterPos1.CustomButton.Location = new System.Drawing.Point(54, 1);
            this.mtCenterPos1.CustomButton.Margin = new System.Windows.Forms.Padding(2);
            this.mtCenterPos1.CustomButton.Name = "";
            this.mtCenterPos1.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.mtCenterPos1.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.mtCenterPos1.CustomButton.TabIndex = 1;
            this.mtCenterPos1.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.mtCenterPos1.CustomButton.UseSelectable = true;
            this.mtCenterPos1.CustomButton.Visible = false;
            this.mtCenterPos1.Lines = new string[] {
        "1218"};
            this.mtCenterPos1.Location = new System.Drawing.Point(485, 37);
            this.mtCenterPos1.MaxLength = 32767;
            this.mtCenterPos1.Name = "mtCenterPos1";
            this.mtCenterPos1.PasswordChar = '\0';
            this.mtCenterPos1.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.mtCenterPos1.SelectedText = "";
            this.mtCenterPos1.SelectionLength = 0;
            this.mtCenterPos1.SelectionStart = 0;
            this.mtCenterPos1.ShortcutsEnabled = true;
            this.mtCenterPos1.Size = new System.Drawing.Size(76, 23);
            this.mtCenterPos1.TabIndex = 49;
            this.mtCenterPos1.Text = "1218";
            this.mtCenterPos1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.mtCenterPos1.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.mtCenterPos1.UseSelectable = true;
            this.mtCenterPos1.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.mtCenterPos1.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // mtCenterPos2
            // 
            // 
            // 
            // 
            this.mtCenterPos2.CustomButton.Image = null;
            this.mtCenterPos2.CustomButton.Location = new System.Drawing.Point(54, 1);
            this.mtCenterPos2.CustomButton.Margin = new System.Windows.Forms.Padding(2);
            this.mtCenterPos2.CustomButton.Name = "";
            this.mtCenterPos2.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.mtCenterPos2.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.mtCenterPos2.CustomButton.TabIndex = 1;
            this.mtCenterPos2.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.mtCenterPos2.CustomButton.UseSelectable = true;
            this.mtCenterPos2.CustomButton.Visible = false;
            this.mtCenterPos2.Lines = new string[] {
        "-1533"};
            this.mtCenterPos2.Location = new System.Drawing.Point(567, 37);
            this.mtCenterPos2.MaxLength = 32767;
            this.mtCenterPos2.Name = "mtCenterPos2";
            this.mtCenterPos2.PasswordChar = '\0';
            this.mtCenterPos2.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.mtCenterPos2.SelectedText = "";
            this.mtCenterPos2.SelectionLength = 0;
            this.mtCenterPos2.SelectionStart = 0;
            this.mtCenterPos2.ShortcutsEnabled = true;
            this.mtCenterPos2.Size = new System.Drawing.Size(76, 23);
            this.mtCenterPos2.TabIndex = 50;
            this.mtCenterPos2.Text = "-1533";
            this.mtCenterPos2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.mtCenterPos2.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.mtCenterPos2.UseSelectable = true;
            this.mtCenterPos2.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.mtCenterPos2.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // mtCenterPos3
            // 
            // 
            // 
            // 
            this.mtCenterPos3.CustomButton.Image = null;
            this.mtCenterPos3.CustomButton.Location = new System.Drawing.Point(54, 1);
            this.mtCenterPos3.CustomButton.Margin = new System.Windows.Forms.Padding(2);
            this.mtCenterPos3.CustomButton.Name = "";
            this.mtCenterPos3.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.mtCenterPos3.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.mtCenterPos3.CustomButton.TabIndex = 1;
            this.mtCenterPos3.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.mtCenterPos3.CustomButton.UseSelectable = true;
            this.mtCenterPos3.CustomButton.Visible = false;
            this.mtCenterPos3.Lines = new string[] {
        "-762"};
            this.mtCenterPos3.Location = new System.Drawing.Point(649, 37);
            this.mtCenterPos3.MaxLength = 32767;
            this.mtCenterPos3.Name = "mtCenterPos3";
            this.mtCenterPos3.PasswordChar = '\0';
            this.mtCenterPos3.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.mtCenterPos3.SelectedText = "";
            this.mtCenterPos3.SelectionLength = 0;
            this.mtCenterPos3.SelectionStart = 0;
            this.mtCenterPos3.ShortcutsEnabled = true;
            this.mtCenterPos3.Size = new System.Drawing.Size(76, 23);
            this.mtCenterPos3.TabIndex = 51;
            this.mtCenterPos3.Text = "-762";
            this.mtCenterPos3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.mtCenterPos3.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.mtCenterPos3.UseSelectable = true;
            this.mtCenterPos3.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.mtCenterPos3.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // mtCenterPos4
            // 
            // 
            // 
            // 
            this.mtCenterPos4.CustomButton.Image = null;
            this.mtCenterPos4.CustomButton.Location = new System.Drawing.Point(54, 1);
            this.mtCenterPos4.CustomButton.Margin = new System.Windows.Forms.Padding(2);
            this.mtCenterPos4.CustomButton.Name = "";
            this.mtCenterPos4.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.mtCenterPos4.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.mtCenterPos4.CustomButton.TabIndex = 1;
            this.mtCenterPos4.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.mtCenterPos4.CustomButton.UseSelectable = true;
            this.mtCenterPos4.CustomButton.Visible = false;
            this.mtCenterPos4.Lines = new string[] {
        "1290"};
            this.mtCenterPos4.Location = new System.Drawing.Point(731, 37);
            this.mtCenterPos4.MaxLength = 32767;
            this.mtCenterPos4.Name = "mtCenterPos4";
            this.mtCenterPos4.PasswordChar = '\0';
            this.mtCenterPos4.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.mtCenterPos4.SelectedText = "";
            this.mtCenterPos4.SelectionLength = 0;
            this.mtCenterPos4.SelectionStart = 0;
            this.mtCenterPos4.ShortcutsEnabled = true;
            this.mtCenterPos4.Size = new System.Drawing.Size(76, 23);
            this.mtCenterPos4.TabIndex = 52;
            this.mtCenterPos4.Text = "1290";
            this.mtCenterPos4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.mtCenterPos4.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.mtCenterPos4.UseSelectable = true;
            this.mtCenterPos4.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.mtCenterPos4.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel61
            // 
            this.metroLabel61.AutoSize = true;
            this.metroLabel61.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel61.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel61.Location = new System.Drawing.Point(482, 88);
            this.metroLabel61.Name = "metroLabel61";
            this.metroLabel61.Size = new System.Drawing.Size(98, 25);
            this.metroLabel61.Style = MetroFramework.MetroColorStyle.White;
            this.metroLabel61.TabIndex = 53;
            this.metroLabel61.Text = "MotorZero";
            this.metroLabel61.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroLabel61.UseStyleColors = true;
            // 
            // mtZeroPos4
            // 
            // 
            // 
            // 
            this.mtZeroPos4.CustomButton.Image = null;
            this.mtZeroPos4.CustomButton.Location = new System.Drawing.Point(54, 1);
            this.mtZeroPos4.CustomButton.Margin = new System.Windows.Forms.Padding(2);
            this.mtZeroPos4.CustomButton.Name = "";
            this.mtZeroPos4.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.mtZeroPos4.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.mtZeroPos4.CustomButton.TabIndex = 1;
            this.mtZeroPos4.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.mtZeroPos4.CustomButton.UseSelectable = true;
            this.mtZeroPos4.CustomButton.Visible = false;
            this.mtZeroPos4.Lines = new string[] {
        "5038"};
            this.mtZeroPos4.Location = new System.Drawing.Point(731, 116);
            this.mtZeroPos4.MaxLength = 32767;
            this.mtZeroPos4.Name = "mtZeroPos4";
            this.mtZeroPos4.PasswordChar = '\0';
            this.mtZeroPos4.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.mtZeroPos4.SelectedText = "";
            this.mtZeroPos4.SelectionLength = 0;
            this.mtZeroPos4.SelectionStart = 0;
            this.mtZeroPos4.ShortcutsEnabled = true;
            this.mtZeroPos4.Size = new System.Drawing.Size(76, 23);
            this.mtZeroPos4.TabIndex = 57;
            this.mtZeroPos4.Text = "5038";
            this.mtZeroPos4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.mtZeroPos4.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.mtZeroPos4.UseSelectable = true;
            this.mtZeroPos4.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.mtZeroPos4.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // mtZeroPos3
            // 
            // 
            // 
            // 
            this.mtZeroPos3.CustomButton.Image = null;
            this.mtZeroPos3.CustomButton.Location = new System.Drawing.Point(54, 1);
            this.mtZeroPos3.CustomButton.Margin = new System.Windows.Forms.Padding(2);
            this.mtZeroPos3.CustomButton.Name = "";
            this.mtZeroPos3.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.mtZeroPos3.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.mtZeroPos3.CustomButton.TabIndex = 1;
            this.mtZeroPos3.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.mtZeroPos3.CustomButton.UseSelectable = true;
            this.mtZeroPos3.CustomButton.Visible = false;
            this.mtZeroPos3.Lines = new string[] {
        "-762"};
            this.mtZeroPos3.Location = new System.Drawing.Point(649, 116);
            this.mtZeroPos3.MaxLength = 32767;
            this.mtZeroPos3.Name = "mtZeroPos3";
            this.mtZeroPos3.PasswordChar = '\0';
            this.mtZeroPos3.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.mtZeroPos3.SelectedText = "";
            this.mtZeroPos3.SelectionLength = 0;
            this.mtZeroPos3.SelectionStart = 0;
            this.mtZeroPos3.ShortcutsEnabled = true;
            this.mtZeroPos3.Size = new System.Drawing.Size(76, 23);
            this.mtZeroPos3.TabIndex = 56;
            this.mtZeroPos3.Text = "-762";
            this.mtZeroPos3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.mtZeroPos3.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.mtZeroPos3.UseSelectable = true;
            this.mtZeroPos3.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.mtZeroPos3.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // mtZeroPos2
            // 
            // 
            // 
            // 
            this.mtZeroPos2.CustomButton.Image = null;
            this.mtZeroPos2.CustomButton.Location = new System.Drawing.Point(54, 1);
            this.mtZeroPos2.CustomButton.Margin = new System.Windows.Forms.Padding(2);
            this.mtZeroPos2.CustomButton.Name = "";
            this.mtZeroPos2.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.mtZeroPos2.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.mtZeroPos2.CustomButton.TabIndex = 1;
            this.mtZeroPos2.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.mtZeroPos2.CustomButton.UseSelectable = true;
            this.mtZeroPos2.CustomButton.Visible = false;
            this.mtZeroPos2.Lines = new string[] {
        "1243"};
            this.mtZeroPos2.Location = new System.Drawing.Point(567, 116);
            this.mtZeroPos2.MaxLength = 32767;
            this.mtZeroPos2.Name = "mtZeroPos2";
            this.mtZeroPos2.PasswordChar = '\0';
            this.mtZeroPos2.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.mtZeroPos2.SelectedText = "";
            this.mtZeroPos2.SelectionLength = 0;
            this.mtZeroPos2.SelectionStart = 0;
            this.mtZeroPos2.ShortcutsEnabled = true;
            this.mtZeroPos2.Size = new System.Drawing.Size(76, 23);
            this.mtZeroPos2.TabIndex = 55;
            this.mtZeroPos2.Text = "1243";
            this.mtZeroPos2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.mtZeroPos2.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.mtZeroPos2.UseSelectable = true;
            this.mtZeroPos2.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.mtZeroPos2.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // mtZeroPos1
            // 
            // 
            // 
            // 
            this.mtZeroPos1.CustomButton.Image = null;
            this.mtZeroPos1.CustomButton.Location = new System.Drawing.Point(54, 1);
            this.mtZeroPos1.CustomButton.Margin = new System.Windows.Forms.Padding(2);
            this.mtZeroPos1.CustomButton.Name = "";
            this.mtZeroPos1.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.mtZeroPos1.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.mtZeroPos1.CustomButton.TabIndex = 1;
            this.mtZeroPos1.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.mtZeroPos1.CustomButton.UseSelectable = true;
            this.mtZeroPos1.CustomButton.Visible = false;
            this.mtZeroPos1.Lines = new string[] {
        "1218"};
            this.mtZeroPos1.Location = new System.Drawing.Point(485, 116);
            this.mtZeroPos1.MaxLength = 32767;
            this.mtZeroPos1.Name = "mtZeroPos1";
            this.mtZeroPos1.PasswordChar = '\0';
            this.mtZeroPos1.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.mtZeroPos1.SelectedText = "";
            this.mtZeroPos1.SelectionLength = 0;
            this.mtZeroPos1.SelectionStart = 0;
            this.mtZeroPos1.ShortcutsEnabled = true;
            this.mtZeroPos1.Size = new System.Drawing.Size(76, 23);
            this.mtZeroPos1.TabIndex = 54;
            this.mtZeroPos1.Text = "1218";
            this.mtZeroPos1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.mtZeroPos1.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.mtZeroPos1.UseSelectable = true;
            this.mtZeroPos1.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.mtZeroPos1.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1093, 760);
            this.Controls.Add(this.metroTabControl1);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.metroLabel7);
            this.Controls.Add(this.metroTextBox1);
            this.Controls.Add(this.rxLogClrBtn);
            this.Controls.Add(this.serialOpenBtn);
            this.Controls.Add(this.metroComboBox2);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.metroComboBox1);
            this.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Padding = new System.Windows.Forms.Padding(26, 80, 26, 27);
            this.Style = MetroFramework.MetroColorStyle.White;
            this.Text = "DynaDrive beta";
            this.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            Setup.ResumeLayout(false);
            Setup.PerformLayout();
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel4.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.metroTabControl1.ResumeLayout(false);
            this.DirectControl.ResumeLayout(false);
            this.DirectControl.PerformLayout();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.MovementControl.ResumeLayout(false);
            this.MovementControl.PerformLayout();
            this.tableLayoutPanel5.ResumeLayout(false);
            this.tableLayoutPanel5.PerformLayout();
            this.PositionControl.ResumeLayout(false);
            this.PositionControl.PerformLayout();
            this.About.ResumeLayout(false);
            this.About.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroComboBox metroComboBox1;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroComboBox metroComboBox2;
        private MetroFramework.Controls.MetroButton serialOpenBtn;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroLabel metroLabel6;
        private MetroFramework.Controls.MetroButton rxLogClrBtn;
        private MetroFramework.Controls.MetroTextBox metroTextBox1;
        private MetroFramework.Controls.MetroLabel metroLabel7;
        private MetroFramework.Controls.MetroLabel metroLabel8;
        private MetroFramework.Controls.MetroLabel metroLabel9;
        private MetroFramework.Controls.MetroLabel metroLabel10;
        private MetroFramework.Controls.MetroLabel metroLabel11;
        private MetroFramework.Controls.MetroToggle mt1Toggle;
        private MetroFramework.Controls.MetroToggle mt2Toggle;
        private MetroFramework.Controls.MetroToggle mt3Toggle;
        private MetroFramework.Controls.MetroToggle mt4Toggle;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private MetroFramework.Controls.MetroLabel targetLabel1;
        private MetroFramework.Controls.MetroLabel targetLabel2;
        private MetroFramework.Controls.MetroLabel targetLabel3;
        private MetroFramework.Controls.MetroLabel targetLabel4;
        private MetroFramework.Controls.MetroLabel diffLabel4;
        private MetroFramework.Controls.MetroLabel currentLabel4;
        private MetroFramework.Controls.MetroLabel currentLabel1;
        private MetroFramework.Controls.MetroLabel currentLabel3;
        private MetroFramework.Controls.MetroLabel diffLabel3;
        private MetroFramework.Controls.MetroLabel diffLabel2;
        private MetroFramework.Controls.MetroLabel currentLabel2;
        private MetroFramework.Controls.MetroLabel diffLabel1;
        private MetroFramework.Controls.MetroTabControl metroTabControl1;
        private MetroFramework.Controls.MetroTabPage DirectControl;
        private MetroFramework.Controls.MetroTabPage About;
        private MetroFramework.Controls.MetroLabel metroLabel15;
        private MetroFramework.Controls.MetroLabel metroLabel14;
        private MetroFramework.Controls.MetroLabel metroLabel13;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private MetroFramework.Controls.MetroLabel metroLabel19;
        private MetroFramework.Controls.MetroLabel metroLabel18;
        private MetroFramework.Controls.MetroLabel metroLabel17;
        private MetroFramework.Controls.MetroLabel metroLabel16;
        private MetroFramework.Controls.MetroTextBox mt1DirectTxtBox;
        private MetroFramework.Controls.MetroTextBox mt2DirectTxtBox;
        private MetroFramework.Controls.MetroTextBox mt3DirectTxtBox;
        private MetroFramework.Controls.MetroTextBox mt4DirectTxtBox;
        private MetroFramework.Controls.MetroButton dirGoBtn;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private MetroFramework.Controls.MetroLabel metroLabel23;
        private MetroFramework.Controls.MetroLabel metroLabel20;
        private MetroFramework.Controls.MetroLabel metroLabel21;
        private MetroFramework.Controls.MetroLabel metroLabel22;
        private MetroFramework.Controls.MetroButton mt4StepDnBtn;
        private MetroFramework.Controls.MetroButton mt3StepDnBtn;
        private MetroFramework.Controls.MetroButton mt2StepDnBtn;
        private MetroFramework.Controls.MetroButton mt2StepUpBtn;
        private MetroFramework.Controls.MetroButton mt1StepDnBtn;
        private MetroFramework.Controls.MetroButton mt1StepUpBtn;
        private MetroFramework.Controls.MetroButton mt3StepUpBtn;
        private MetroFramework.Controls.MetroButton mt4StepUpBtn;
        private MetroFramework.Controls.MetroButton mtCenterBtn;
        private MetroFramework.Controls.MetroButton stepSetBtn;
        private MetroFramework.Controls.MetroLabel stepSizeIndLabel;
        private MetroFramework.Controls.MetroTextBox stepSizeTxtBox;
        private MetroFramework.Controls.MetroLabel metroLabel24;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private MetroFramework.Controls.MetroLabel metroLabel25;
        private MetroFramework.Controls.MetroLabel metroLabel26;
        private MetroFramework.Controls.MetroLabel metroLabel27;
        private MetroFramework.Controls.MetroLabel metroLabel28;
        private MetroFramework.Controls.MetroTextBox pid1gain;
        private MetroFramework.Controls.MetroTextBox pid2gain;
        private MetroFramework.Controls.MetroTextBox pid3gain;
        private MetroFramework.Controls.MetroLabel metroLabel29;
        private MetroFramework.Controls.MetroLabel metroLabel30;
        private MetroFramework.Controls.MetroLabel spdRPMConvLabel;
        private MetroFramework.Controls.MetroLabel metroLabel31;
        private MetroFramework.Controls.MetroTextBox spdRawTxtBox;
        private MetroFramework.Controls.MetroTextBox pid4gain;
        private MetroFramework.Controls.MetroLabel metroLabel32;
        private MetroFramework.Controls.MetroComboBox accComboBox;
        private MetroFramework.Controls.MetroLabel metroLabel33;
        private MetroFramework.Controls.MetroToggle spdAutoAdjToggle;
        private MetroFramework.Controls.MetroButton setApplyBtn;
        private MetroFramework.Controls.MetroLabel metroLabel34;
        private MetroFramework.Controls.MetroTabPage MovementControl;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel5;
        public MetroFramework.Controls.MetroTextBox MC_tube2_rt;        // public 으로 수정됨
        public MetroFramework.Controls.MetroTextBox MC_tube1_tr;        //
        public MetroFramework.Controls.MetroTextBox MC_tube2_tr;        //
        public MetroFramework.Controls.MetroTextBox MC_tube1_rt;        //
        private MetroFramework.Controls.MetroLabel metroLabel35;
        private MetroFramework.Controls.MetroLabel metroLabel37;
        private MetroFramework.Controls.MetroLabel metroLabel38;
        private MetroFramework.Controls.MetroLabel metroLabel12;
        private MetroFramework.Controls.MetroButton metroButton2;
        private MetroFramework.Controls.MetroButton CtrCenterBtn;
        private MetroFramework.Controls.MetroButton McGoBt;
        private MetroFramework.Controls.MetroLabel metroLabel42;
        private MetroFramework.Controls.MetroLabel metroLabel41;
        private MetroFramework.Controls.MetroLabel metroLabel40;
        private MetroFramework.Controls.MetroLabel metroLabel39;
        private MetroFramework.Controls.MetroLabel metroLabel43;
        private MetroFramework.Controls.MetroTabPage PositionControl;
        private MetroFramework.Controls.MetroLabel metroLabel44;
        private MetroFramework.Controls.MetroLabel metroLabel48;
        private MetroFramework.Controls.MetroLabel metroLabel47;
        private MetroFramework.Controls.MetroLabel metroLabel46;
        private MetroFramework.Controls.MetroLabel metroLabel45;
        public MetroFramework.Controls.MetroTextBox PcTube1AngleTxtbox;
        public MetroFramework.Controls.MetroTextBox PcTube1L_sTxtbox;
        public MetroFramework.Controls.MetroTextBox PcTube1ODTxtbox;
        public MetroFramework.Controls.MetroTextBox PcTube1IDTxtbox;
        private MetroFramework.Controls.MetroLabel metroLabel52;
        public MetroFramework.Controls.MetroTextBox PcTube2ETxtbox;
        public MetroFramework.Controls.MetroTextBox PcTube2RhoTxtbox;
        public MetroFramework.Controls.MetroTextBox PcTube2AngleTxtbox;
        public MetroFramework.Controls.MetroTextBox PcTube2L_sTxtbox;
        public MetroFramework.Controls.MetroTextBox PcTube2ODTxtbox;
        public MetroFramework.Controls.MetroTextBox PcTube2IDTxtbox;
        private MetroFramework.Controls.MetroLabel metroLabel51;
        public MetroFramework.Controls.MetroTextBox PcTube1ETxtbox;
        private MetroFramework.Controls.MetroLabel metroLabel50;
        public MetroFramework.Controls.MetroTextBox PcTube1RhoTxtbox;
        private MetroFramework.Controls.MetroLabel metroLabel49;
        private MetroFramework.Controls.MetroButton PcGetXyzPosBtn;
        public MetroFramework.Controls.MetroTextBox PcZPosTxtbox;
        public MetroFramework.Controls.MetroTextBox PcYPosTxtbox;
        public MetroFramework.Controls.MetroTextBox PcXPosTxtbox;
        private MetroFramework.Controls.MetroLabel metroLabel55;
        private MetroFramework.Controls.MetroLabel metroLabel54;
        private MetroFramework.Controls.MetroLabel metroLabel53;
        private MetroFramework.Controls.MetroLabel metroLabel57;
        private MetroFramework.Controls.MetroLabel metroLabel56;
        public MetroFramework.Controls.MetroToggle PcTboToggle;
        public MetroFramework.Controls.MetroToggle PcTolToggle;
        private MetroFramework.Controls.MetroLabel metroLabel58;
        public MetroFramework.Controls.MetroTextBox PcZOriTxtbox;
        public MetroFramework.Controls.MetroTextBox PcYOriTxtbox;
        public MetroFramework.Controls.MetroTextBox PcXOriTxtbox;
        private MetroFramework.Controls.MetroLabel metroLabel59;
        private MetroFramework.Controls.MetroLabel metroLabel60;
        public MetroFramework.Controls.MetroTextBox mtCenterPos4;
        public MetroFramework.Controls.MetroTextBox mtCenterPos3;
        public MetroFramework.Controls.MetroTextBox mtCenterPos2;
        public MetroFramework.Controls.MetroTextBox mtCenterPos1;
        public MetroFramework.Controls.MetroTextBox mtZeroPos4;
        public MetroFramework.Controls.MetroTextBox mtZeroPos3;
        public MetroFramework.Controls.MetroTextBox mtZeroPos2;
        public MetroFramework.Controls.MetroTextBox mtZeroPos1;
        private MetroFramework.Controls.MetroLabel metroLabel61;
    }
}

