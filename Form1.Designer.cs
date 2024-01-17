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
            this.metroLabel37 = new MetroFramework.Controls.MetroLabel();
            this.SetupPresetComboBox = new MetroFramework.Controls.MetroComboBox();
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
            this.metroTabPage1 = new MetroFramework.Controls.MetroTabPage();
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
            this.ProgramPage = new System.Windows.Forms.TabPage();
            this.repeatsTxtBox = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel36 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel35 = new MetroFramework.Controls.MetroLabel();
            this.timeIntervalTxtBox = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel12 = new MetroFramework.Controls.MetroLabel();
            this.PGRoundTripToggle = new MetroFramework.Controls.MetroToggle();
            this.metroButton2 = new MetroFramework.Controls.MetroButton();
            this.metroButton1 = new MetroFramework.Controls.MetroButton();
            this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
            this.metroLabel40 = new MetroFramework.Controls.MetroLabel();
            this.PGmt4Toggle = new MetroFramework.Controls.MetroToggle();
            this.metroLabel42 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel44 = new MetroFramework.Controls.MetroLabel();
            this.PGmt3Toggle = new MetroFramework.Controls.MetroToggle();
            this.metroLabel45 = new MetroFramework.Controls.MetroLabel();
            this.PGmt1Toggle = new MetroFramework.Controls.MetroToggle();
            this.PGmt2Toggle = new MetroFramework.Controls.MetroToggle();
            this.metroLabel46 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel47 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel48 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel49 = new MetroFramework.Controls.MetroLabel();
            this.PGmt1FromTxtBox = new MetroFramework.Controls.MetroTextBox();
            this.PGmt3FromTxtBox = new MetroFramework.Controls.MetroTextBox();
            this.PGmt2FromTxtBox = new MetroFramework.Controls.MetroTextBox();
            this.PGmt4FromTxtBox = new MetroFramework.Controls.MetroTextBox();
            this.PGmt1StepTxtBox = new MetroFramework.Controls.MetroTextBox();
            this.PGmt1ToTxtBox = new MetroFramework.Controls.MetroTextBox();
            this.PGmt2ToTxtBox = new MetroFramework.Controls.MetroTextBox();
            this.PGmt3ToTxtBox = new MetroFramework.Controls.MetroTextBox();
            this.PGmt4ToTxtBox = new MetroFramework.Controls.MetroTextBox();
            this.PGmt2StepTxtBox = new MetroFramework.Controls.MetroTextBox();
            this.PGmt3StepTxtBox = new MetroFramework.Controls.MetroTextBox();
            this.PGmt4StepTxtBox = new MetroFramework.Controls.MetroTextBox();
            this.AutoBend = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel9 = new System.Windows.Forms.TableLayoutPanel();
            this.AutobendRTripToggle = new MetroFramework.Controls.MetroToggle();
            this.metroLabel64 = new MetroFramework.Controls.MetroLabel();
            this.DistDirStartTxtBox = new MetroFramework.Controls.MetroTextBox();
            this.DistBendStartTxtBox = new MetroFramework.Controls.MetroTextBox();
            this.ProxDirStartTxtBox = new MetroFramework.Controls.MetroTextBox();
            this.ProxBendStartTxtBox = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel53 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel54 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel57 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel58 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel59 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel60 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel61 = new MetroFramework.Controls.MetroLabel();
            this.DistBendGoaltTxtBox = new MetroFramework.Controls.MetroTextBox();
            this.DistDirGoalTxtBox = new MetroFramework.Controls.MetroTextBox();
            this.ProxDirGoalTxtBox = new MetroFramework.Controls.MetroTextBox();
            this.ProxBendGoalTxtBox = new MetroFramework.Controls.MetroTextBox();
            this.AutobendIntTxtBox = new MetroFramework.Controls.MetroTextBox();
            this.AutobendRepeatTxtBox = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel62 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel63 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel65 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel66 = new MetroFramework.Controls.MetroLabel();
            this.AutobendBendStepTxtBox = new MetroFramework.Controls.MetroTextBox();
            this.AutobendDirStepTxtBox = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel68 = new MetroFramework.Controls.MetroLabel();
            this.AutobendDTPToggle = new MetroFramework.Controls.MetroToggle();
            this.AutobendHoldBtn = new MetroFramework.Controls.MetroButton();
            this.AutobendRunBtn = new MetroFramework.Controls.MetroButton();
            this.AutobendStopBtn = new MetroFramework.Controls.MetroButton();
            this.metroTabPage2 = new MetroFramework.Controls.MetroTabPage();
            this.distPosLabel = new MetroFramework.Controls.MetroLabel();
            this.distalAngleLabel = new MetroFramework.Controls.MetroLabel();
            this.tableLayoutPanel8 = new System.Windows.Forms.TableLayoutPanel();
            this.metroLabel52 = new MetroFramework.Controls.MetroLabel();
            this.bendDiskRadTxtBox = new MetroFramework.Controls.MetroTextBox();
            this.bendTotLengthTxtBox = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel55 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel56 = new MetroFramework.Controls.MetroLabel();
            this.bendProxLenTxtBox = new MetroFramework.Controls.MetroTextBox();
            this.BendSetupSetBtn = new MetroFramework.Controls.MetroButton();
            this.metroTabPage3 = new MetroFramework.Controls.MetroTabPage();
            this.metroLabel34 = new MetroFramework.Controls.MetroLabel();
            this.posInAccurateLabel = new MetroFramework.Controls.MetroLabel();
            this.tableLayoutPanel6 = new System.Windows.Forms.TableLayoutPanel();
            this.AutoStepperRunLabel = new MetroFramework.Controls.MetroLabel();
            this.StepCounterLabel = new MetroFramework.Controls.MetroLabel();
            this.metroLabel38 = new MetroFramework.Controls.MetroLabel();
            this.setRotRawModeBtn = new MetroFramework.Controls.MetroButton();
            this.setTransConvBtn = new MetroFramework.Controls.MetroButton();
            this.tableLayoutPanel7 = new System.Windows.Forms.TableLayoutPanel();
            this.seg2DirTxtBox = new MetroFramework.Controls.MetroTextBox();
            this.seg2BendTxtBox = new MetroFramework.Controls.MetroTextBox();
            this.seg1DirTxtBox = new MetroFramework.Controls.MetroTextBox();
            this.seg1BendTxtBox = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel50 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel39 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel41 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel43 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel51 = new MetroFramework.Controls.MetroLabel();
            this.bendCtrSetBtn = new MetroFramework.Controls.MetroButton();
            this.bendCtrCenterBtn = new MetroFramework.Controls.MetroButton();
            Setup = new MetroFramework.Controls.MetroTabPage();
            Setup.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.metroTabControl1.SuspendLayout();
            this.metroTabPage1.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.ProgramPage.SuspendLayout();
            this.tableLayoutPanel5.SuspendLayout();
            this.AutoBend.SuspendLayout();
            this.tableLayoutPanel9.SuspendLayout();
            this.metroTabPage2.SuspendLayout();
            this.tableLayoutPanel8.SuspendLayout();
            this.metroTabPage3.SuspendLayout();
            this.tableLayoutPanel6.SuspendLayout();
            this.tableLayoutPanel7.SuspendLayout();
            this.SuspendLayout();
            // 
            // Setup
            // 
            Setup.BackColor = System.Drawing.Color.Transparent;
            Setup.Controls.Add(this.metroLabel37);
            Setup.Controls.Add(this.SetupPresetComboBox);
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
            Setup.Size = new System.Drawing.Size(578, 248);
            Setup.TabIndex = 1;
            Setup.Text = "Setup";
            Setup.UseCustomBackColor = true;
            Setup.VerticalScrollbarBarColor = true;
            Setup.VerticalScrollbarHighlightOnWheel = false;
            Setup.VerticalScrollbarSize = 2;
            // 
            // metroLabel37
            // 
            this.metroLabel37.AutoSize = true;
            this.metroLabel37.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel37.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel37.Location = new System.Drawing.Point(216, 175);
            this.metroLabel37.Name = "metroLabel37";
            this.metroLabel37.Size = new System.Drawing.Size(60, 25);
            this.metroLabel37.Style = MetroFramework.MetroColorStyle.White;
            this.metroLabel37.TabIndex = 43;
            this.metroLabel37.Text = "Preset";
            this.metroLabel37.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroLabel37.UseStyleColors = true;
            // 
            // SetupPresetComboBox
            // 
            this.SetupPresetComboBox.FormattingEnabled = true;
            this.SetupPresetComboBox.ItemHeight = 23;
            this.SetupPresetComboBox.Items.AddRange(new object[] {
            "High Power Fast",
            "High Power Medium",
            "High Power Slow",
            "Standard Fast",
            "Standard Medium",
            "Standard Slow"});
            this.SetupPresetComboBox.Location = new System.Drawing.Point(189, 202);
            this.SetupPresetComboBox.Name = "SetupPresetComboBox";
            this.SetupPresetComboBox.Size = new System.Drawing.Size(121, 29);
            this.SetupPresetComboBox.Style = MetroFramework.MetroColorStyle.Black;
            this.SetupPresetComboBox.TabIndex = 42;
            this.SetupPresetComboBox.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.SetupPresetComboBox.UseSelectable = true;
            this.SetupPresetComboBox.SelectedIndexChanged += new System.EventHandler(this.SetupPresetComboBox_SelectedIndexChanged);
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
            this.metroLabel32.Location = new System.Drawing.Point(198, 107);
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
            this.accComboBox.Location = new System.Drawing.Point(190, 139);
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
            this.metroLabel30.Size = new System.Drawing.Size(119, 25);
            this.metroLabel30.Style = MetroFramework.MetroColorStyle.White;
            this.metroLabel30.TabIndex = 35;
            this.metroLabel30.Text = "default = 400";
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
            this.metroComboBox1.SelectedIndexChanged += new System.EventHandler(this.metroComboBox1_SelectedIndexChanged);
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
            this.rxLogClrBtn.Location = new System.Drawing.Point(859, 90);
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
            this.metroTextBox1.CustomButton.Location = new System.Drawing.Point(152, 1);
            this.metroTextBox1.CustomButton.Name = "";
            this.metroTextBox1.CustomButton.Size = new System.Drawing.Size(93, 93);
            this.metroTextBox1.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroTextBox1.CustomButton.TabIndex = 1;
            this.metroTextBox1.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroTextBox1.CustomButton.UseSelectable = true;
            this.metroTextBox1.CustomButton.Visible = false;
            this.metroTextBox1.Lines = new string[0];
            this.metroTextBox1.Location = new System.Drawing.Point(714, 118);
            this.metroTextBox1.MaxLength = 32767;
            this.metroTextBox1.Multiline = true;
            this.metroTextBox1.Name = "metroTextBox1";
            this.metroTextBox1.PasswordChar = '\0';
            this.metroTextBox1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.metroTextBox1.SelectedText = "";
            this.metroTextBox1.SelectionLength = 0;
            this.metroTextBox1.SelectionStart = 0;
            this.metroTextBox1.ShortcutsEnabled = true;
            this.metroTextBox1.Size = new System.Drawing.Size(246, 95);
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
            this.metroLabel7.Location = new System.Drawing.Point(714, 90);
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
            this.metroTabControl1.Controls.Add(this.metroTabPage1);
            this.metroTabControl1.Controls.Add(this.ProgramPage);
            this.metroTabControl1.Controls.Add(this.AutoBend);
            this.metroTabControl1.Controls.Add(Setup);
            this.metroTabControl1.Controls.Add(this.metroTabPage2);
            this.metroTabControl1.Controls.Add(this.metroTabPage3);
            this.metroTabControl1.Location = new System.Drawing.Point(79, 320);
            this.metroTabControl1.Name = "metroTabControl1";
            this.metroTabControl1.SelectedIndex = 4;
            this.metroTabControl1.Size = new System.Drawing.Size(586, 290);
            this.metroTabControl1.TabIndex = 25;
            this.metroTabControl1.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroTabControl1.UseSelectable = true;
            // 
            // metroTabPage1
            // 
            this.metroTabPage1.BackColor = System.Drawing.Color.Transparent;
            this.metroTabPage1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.metroTabPage1.Controls.Add(this.metroLabel24);
            this.metroTabPage1.Controls.Add(this.stepSetBtn);
            this.metroTabPage1.Controls.Add(this.stepSizeIndLabel);
            this.metroTabPage1.Controls.Add(this.stepSizeTxtBox);
            this.metroTabPage1.Controls.Add(this.mtCenterBtn);
            this.metroTabPage1.Controls.Add(this.tableLayoutPanel3);
            this.metroTabPage1.Controls.Add(this.dirGoBtn);
            this.metroTabPage1.Controls.Add(this.tableLayoutPanel2);
            this.metroTabPage1.Controls.Add(this.metroLabel15);
            this.metroTabPage1.Controls.Add(this.metroLabel14);
            this.metroTabPage1.Controls.Add(this.metroLabel13);
            this.metroTabPage1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.metroTabPage1.HorizontalScrollbarBarColor = true;
            this.metroTabPage1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroTabPage1.HorizontalScrollbarSize = 2;
            this.metroTabPage1.ImageKey = "(없음)";
            this.metroTabPage1.Location = new System.Drawing.Point(4, 38);
            this.metroTabPage1.Name = "metroTabPage1";
            this.metroTabPage1.Size = new System.Drawing.Size(578, 248);
            this.metroTabPage1.TabIndex = 0;
            this.metroTabPage1.Text = "Control";
            this.metroTabPage1.UseCustomBackColor = true;
            this.metroTabPage1.VerticalScrollbarBarColor = true;
            this.metroTabPage1.VerticalScrollbarHighlightOnWheel = false;
            this.metroTabPage1.VerticalScrollbarSize = 2;
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
            this.metroLabel14.Size = new System.Drawing.Size(152, 25);
            this.metroLabel14.Style = MetroFramework.MetroColorStyle.White;
            this.metroLabel14.TabIndex = 27;
            this.metroLabel14.Text = "Step - RAW ONLY";
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
            // ProgramPage
            // 
            this.ProgramPage.AllowDrop = true;
            this.ProgramPage.BackColor = System.Drawing.Color.Transparent;
            this.ProgramPage.Controls.Add(this.repeatsTxtBox);
            this.ProgramPage.Controls.Add(this.metroLabel36);
            this.ProgramPage.Controls.Add(this.metroLabel35);
            this.ProgramPage.Controls.Add(this.timeIntervalTxtBox);
            this.ProgramPage.Controls.Add(this.metroLabel12);
            this.ProgramPage.Controls.Add(this.PGRoundTripToggle);
            this.ProgramPage.Controls.Add(this.metroButton2);
            this.ProgramPage.Controls.Add(this.metroButton1);
            this.ProgramPage.Controls.Add(this.tableLayoutPanel5);
            this.ProgramPage.Location = new System.Drawing.Point(4, 38);
            this.ProgramPage.Name = "ProgramPage";
            this.ProgramPage.Size = new System.Drawing.Size(578, 248);
            this.ProgramPage.TabIndex = 3;
            this.ProgramPage.Text = "AutoStepper";
            // 
            // repeatsTxtBox
            // 
            // 
            // 
            // 
            this.repeatsTxtBox.CustomButton.Image = null;
            this.repeatsTxtBox.CustomButton.Location = new System.Drawing.Point(61, 1);
            this.repeatsTxtBox.CustomButton.Margin = new System.Windows.Forms.Padding(2);
            this.repeatsTxtBox.CustomButton.Name = "";
            this.repeatsTxtBox.CustomButton.Size = new System.Drawing.Size(16, 16);
            this.repeatsTxtBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.repeatsTxtBox.CustomButton.TabIndex = 1;
            this.repeatsTxtBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.repeatsTxtBox.CustomButton.UseSelectable = true;
            this.repeatsTxtBox.CustomButton.Visible = false;
            this.repeatsTxtBox.Lines = new string[0];
            this.repeatsTxtBox.Location = new System.Drawing.Point(279, 205);
            this.repeatsTxtBox.MaxLength = 32767;
            this.repeatsTxtBox.Name = "repeatsTxtBox";
            this.repeatsTxtBox.PasswordChar = '\0';
            this.repeatsTxtBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.repeatsTxtBox.SelectedText = "";
            this.repeatsTxtBox.SelectionLength = 0;
            this.repeatsTxtBox.SelectionStart = 0;
            this.repeatsTxtBox.ShortcutsEnabled = true;
            this.repeatsTxtBox.Size = new System.Drawing.Size(100, 23);
            this.repeatsTxtBox.TabIndex = 41;
            this.repeatsTxtBox.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.repeatsTxtBox.UseSelectable = true;
            this.repeatsTxtBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.repeatsTxtBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel36
            // 
            this.metroLabel36.AutoSize = true;
            this.metroLabel36.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel36.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel36.Location = new System.Drawing.Point(290, 178);
            this.metroLabel36.Name = "metroLabel36";
            this.metroLabel36.Size = new System.Drawing.Size(74, 25);
            this.metroLabel36.Style = MetroFramework.MetroColorStyle.White;
            this.metroLabel36.TabIndex = 40;
            this.metroLabel36.Text = "Repeats";
            this.metroLabel36.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroLabel36.UseStyleColors = true;
            // 
            // metroLabel35
            // 
            this.metroLabel35.AutoSize = true;
            this.metroLabel35.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel35.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel35.Location = new System.Drawing.Point(113, 176);
            this.metroLabel35.Name = "metroLabel35";
            this.metroLabel35.Size = new System.Drawing.Size(147, 25);
            this.metroLabel35.Style = MetroFramework.MetroColorStyle.White;
            this.metroLabel35.TabIndex = 39;
            this.metroLabel35.Text = "Time Interval(ms)";
            this.metroLabel35.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroLabel35.UseStyleColors = true;
            // 
            // timeIntervalTxtBox
            // 
            // 
            // 
            // 
            this.timeIntervalTxtBox.CustomButton.Image = null;
            this.timeIntervalTxtBox.CustomButton.Location = new System.Drawing.Point(61, 1);
            this.timeIntervalTxtBox.CustomButton.Margin = new System.Windows.Forms.Padding(2);
            this.timeIntervalTxtBox.CustomButton.Name = "";
            this.timeIntervalTxtBox.CustomButton.Size = new System.Drawing.Size(16, 16);
            this.timeIntervalTxtBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.timeIntervalTxtBox.CustomButton.TabIndex = 1;
            this.timeIntervalTxtBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.timeIntervalTxtBox.CustomButton.UseSelectable = true;
            this.timeIntervalTxtBox.CustomButton.Visible = false;
            this.timeIntervalTxtBox.Lines = new string[0];
            this.timeIntervalTxtBox.Location = new System.Drawing.Point(137, 205);
            this.timeIntervalTxtBox.MaxLength = 32767;
            this.timeIntervalTxtBox.Name = "timeIntervalTxtBox";
            this.timeIntervalTxtBox.PasswordChar = '\0';
            this.timeIntervalTxtBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.timeIntervalTxtBox.SelectedText = "";
            this.timeIntervalTxtBox.SelectionLength = 0;
            this.timeIntervalTxtBox.SelectionStart = 0;
            this.timeIntervalTxtBox.ShortcutsEnabled = true;
            this.timeIntervalTxtBox.Size = new System.Drawing.Size(100, 23);
            this.timeIntervalTxtBox.TabIndex = 38;
            this.timeIntervalTxtBox.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.timeIntervalTxtBox.UseSelectable = true;
            this.timeIntervalTxtBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.timeIntervalTxtBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel12
            // 
            this.metroLabel12.AutoSize = true;
            this.metroLabel12.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel12.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel12.Location = new System.Drawing.Point(9, 176);
            this.metroLabel12.Name = "metroLabel12";
            this.metroLabel12.Size = new System.Drawing.Size(97, 25);
            this.metroLabel12.Style = MetroFramework.MetroColorStyle.White;
            this.metroLabel12.TabIndex = 29;
            this.metroLabel12.Text = "Round Trip";
            this.metroLabel12.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroLabel12.UseStyleColors = true;
            // 
            // PGRoundTripToggle
            // 
            this.PGRoundTripToggle.AutoSize = true;
            this.PGRoundTripToggle.Checked = true;
            this.PGRoundTripToggle.CheckState = System.Windows.Forms.CheckState.Checked;
            this.PGRoundTripToggle.FontSize = MetroFramework.MetroLinkSize.Medium;
            this.PGRoundTripToggle.Location = new System.Drawing.Point(15, 205);
            this.PGRoundTripToggle.Name = "PGRoundTripToggle";
            this.PGRoundTripToggle.Size = new System.Drawing.Size(80, 20);
            this.PGRoundTripToggle.TabIndex = 28;
            this.PGRoundTripToggle.Text = "On";
            this.PGRoundTripToggle.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.PGRoundTripToggle.UseSelectable = true;
            // 
            // metroButton2
            // 
            this.metroButton2.DisplayFocus = true;
            this.metroButton2.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.metroButton2.Location = new System.Drawing.Point(458, 212);
            this.metroButton2.Name = "metroButton2";
            this.metroButton2.Size = new System.Drawing.Size(101, 29);
            this.metroButton2.TabIndex = 27;
            this.metroButton2.Text = "STOP";
            this.metroButton2.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroButton2.UseSelectable = true;
            this.metroButton2.Click += new System.EventHandler(this.metroButton2_Click);
            // 
            // metroButton1
            // 
            this.metroButton1.DisplayFocus = true;
            this.metroButton1.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.metroButton1.Location = new System.Drawing.Point(458, 176);
            this.metroButton1.Name = "metroButton1";
            this.metroButton1.Size = new System.Drawing.Size(101, 29);
            this.metroButton1.TabIndex = 26;
            this.metroButton1.Text = "RUN";
            this.metroButton1.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroButton1.UseSelectable = true;
            this.metroButton1.Click += new System.EventHandler(this.metroButton1_Click);
            // 
            // tableLayoutPanel5
            // 
            this.tableLayoutPanel5.ColumnCount = 5;
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 8F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 17F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel5.Controls.Add(this.metroLabel40, 1, 0);
            this.tableLayoutPanel5.Controls.Add(this.PGmt4Toggle, 1, 4);
            this.tableLayoutPanel5.Controls.Add(this.metroLabel42, 0, 1);
            this.tableLayoutPanel5.Controls.Add(this.metroLabel44, 3, 0);
            this.tableLayoutPanel5.Controls.Add(this.PGmt3Toggle, 1, 3);
            this.tableLayoutPanel5.Controls.Add(this.metroLabel45, 2, 0);
            this.tableLayoutPanel5.Controls.Add(this.PGmt1Toggle, 1, 1);
            this.tableLayoutPanel5.Controls.Add(this.PGmt2Toggle, 1, 2);
            this.tableLayoutPanel5.Controls.Add(this.metroLabel46, 0, 2);
            this.tableLayoutPanel5.Controls.Add(this.metroLabel47, 0, 3);
            this.tableLayoutPanel5.Controls.Add(this.metroLabel48, 0, 4);
            this.tableLayoutPanel5.Controls.Add(this.metroLabel49, 4, 0);
            this.tableLayoutPanel5.Controls.Add(this.PGmt1FromTxtBox, 2, 1);
            this.tableLayoutPanel5.Controls.Add(this.PGmt3FromTxtBox, 2, 3);
            this.tableLayoutPanel5.Controls.Add(this.PGmt2FromTxtBox, 2, 2);
            this.tableLayoutPanel5.Controls.Add(this.PGmt4FromTxtBox, 2, 4);
            this.tableLayoutPanel5.Controls.Add(this.PGmt1StepTxtBox, 4, 1);
            this.tableLayoutPanel5.Controls.Add(this.PGmt1ToTxtBox, 3, 1);
            this.tableLayoutPanel5.Controls.Add(this.PGmt2ToTxtBox, 3, 2);
            this.tableLayoutPanel5.Controls.Add(this.PGmt3ToTxtBox, 3, 3);
            this.tableLayoutPanel5.Controls.Add(this.PGmt4ToTxtBox, 3, 4);
            this.tableLayoutPanel5.Controls.Add(this.PGmt2StepTxtBox, 4, 2);
            this.tableLayoutPanel5.Controls.Add(this.PGmt3StepTxtBox, 4, 3);
            this.tableLayoutPanel5.Controls.Add(this.PGmt4StepTxtBox, 4, 4);
            this.tableLayoutPanel5.Location = new System.Drawing.Point(7, 15);
            this.tableLayoutPanel5.Name = "tableLayoutPanel5";
            this.tableLayoutPanel5.RowCount = 5;
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel5.Size = new System.Drawing.Size(557, 156);
            this.tableLayoutPanel5.TabIndex = 25;
            // 
            // metroLabel40
            // 
            this.metroLabel40.AutoSize = true;
            this.metroLabel40.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel40.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel40.Location = new System.Drawing.Point(47, 0);
            this.metroLabel40.Name = "metroLabel40";
            this.metroLabel40.Size = new System.Drawing.Size(60, 25);
            this.metroLabel40.Style = MetroFramework.MetroColorStyle.White;
            this.metroLabel40.TabIndex = 15;
            this.metroLabel40.Text = "Active";
            this.metroLabel40.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroLabel40.UseStyleColors = true;
            // 
            // PGmt4Toggle
            // 
            this.PGmt4Toggle.AutoSize = true;
            this.PGmt4Toggle.Checked = true;
            this.PGmt4Toggle.CheckState = System.Windows.Forms.CheckState.Checked;
            this.PGmt4Toggle.FontSize = MetroFramework.MetroLinkSize.Medium;
            this.PGmt4Toggle.Location = new System.Drawing.Point(47, 123);
            this.PGmt4Toggle.Name = "PGmt4Toggle";
            this.PGmt4Toggle.Size = new System.Drawing.Size(80, 20);
            this.PGmt4Toggle.TabIndex = 23;
            this.PGmt4Toggle.Text = "On";
            this.PGmt4Toggle.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.PGmt4Toggle.UseSelectable = true;
            // 
            // metroLabel42
            // 
            this.metroLabel42.AutoSize = true;
            this.metroLabel42.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel42.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel42.Location = new System.Drawing.Point(3, 30);
            this.metroLabel42.Name = "metroLabel42";
            this.metroLabel42.Size = new System.Drawing.Size(33, 25);
            this.metroLabel42.Style = MetroFramework.MetroColorStyle.White;
            this.metroLabel42.TabIndex = 5;
            this.metroLabel42.Text = "#1";
            this.metroLabel42.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroLabel42.UseStyleColors = true;
            // 
            // metroLabel44
            // 
            this.metroLabel44.AutoSize = true;
            this.metroLabel44.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel44.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel44.Location = new System.Drawing.Point(280, 0);
            this.metroLabel44.Name = "metroLabel44";
            this.metroLabel44.Size = new System.Drawing.Size(30, 25);
            this.metroLabel44.Style = MetroFramework.MetroColorStyle.White;
            this.metroLabel44.TabIndex = 17;
            this.metroLabel44.Text = "To";
            this.metroLabel44.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroLabel44.UseStyleColors = true;
            // 
            // PGmt3Toggle
            // 
            this.PGmt3Toggle.AutoSize = true;
            this.PGmt3Toggle.Checked = true;
            this.PGmt3Toggle.CheckState = System.Windows.Forms.CheckState.Checked;
            this.PGmt3Toggle.FontSize = MetroFramework.MetroLinkSize.Medium;
            this.PGmt3Toggle.Location = new System.Drawing.Point(47, 93);
            this.PGmt3Toggle.Name = "PGmt3Toggle";
            this.PGmt3Toggle.Size = new System.Drawing.Size(80, 20);
            this.PGmt3Toggle.TabIndex = 22;
            this.PGmt3Toggle.Text = "On";
            this.PGmt3Toggle.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.PGmt3Toggle.UseSelectable = true;
            // 
            // metroLabel45
            // 
            this.metroLabel45.AutoSize = true;
            this.metroLabel45.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel45.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel45.Location = new System.Drawing.Point(141, 0);
            this.metroLabel45.Name = "metroLabel45";
            this.metroLabel45.Size = new System.Drawing.Size(54, 25);
            this.metroLabel45.Style = MetroFramework.MetroColorStyle.White;
            this.metroLabel45.TabIndex = 16;
            this.metroLabel45.Text = "From";
            this.metroLabel45.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroLabel45.UseStyleColors = true;
            // 
            // PGmt1Toggle
            // 
            this.PGmt1Toggle.AutoSize = true;
            this.PGmt1Toggle.Checked = true;
            this.PGmt1Toggle.CheckState = System.Windows.Forms.CheckState.Checked;
            this.PGmt1Toggle.FontSize = MetroFramework.MetroLinkSize.Medium;
            this.PGmt1Toggle.Location = new System.Drawing.Point(47, 33);
            this.PGmt1Toggle.Name = "PGmt1Toggle";
            this.PGmt1Toggle.Size = new System.Drawing.Size(80, 20);
            this.PGmt1Toggle.TabIndex = 20;
            this.PGmt1Toggle.Text = "On";
            this.PGmt1Toggle.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.PGmt1Toggle.UseSelectable = true;
            // 
            // PGmt2Toggle
            // 
            this.PGmt2Toggle.AutoSize = true;
            this.PGmt2Toggle.Checked = true;
            this.PGmt2Toggle.CheckState = System.Windows.Forms.CheckState.Checked;
            this.PGmt2Toggle.FontSize = MetroFramework.MetroLinkSize.Medium;
            this.PGmt2Toggle.Location = new System.Drawing.Point(47, 63);
            this.PGmt2Toggle.Name = "PGmt2Toggle";
            this.PGmt2Toggle.Size = new System.Drawing.Size(80, 20);
            this.PGmt2Toggle.TabIndex = 21;
            this.PGmt2Toggle.Text = "On";
            this.PGmt2Toggle.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.PGmt2Toggle.UseSelectable = true;
            // 
            // metroLabel46
            // 
            this.metroLabel46.AutoSize = true;
            this.metroLabel46.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel46.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel46.Location = new System.Drawing.Point(3, 60);
            this.metroLabel46.Name = "metroLabel46";
            this.metroLabel46.Size = new System.Drawing.Size(33, 25);
            this.metroLabel46.Style = MetroFramework.MetroColorStyle.White;
            this.metroLabel46.TabIndex = 6;
            this.metroLabel46.Text = "#2";
            this.metroLabel46.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroLabel46.UseStyleColors = true;
            // 
            // metroLabel47
            // 
            this.metroLabel47.AutoSize = true;
            this.metroLabel47.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel47.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel47.Location = new System.Drawing.Point(3, 90);
            this.metroLabel47.Name = "metroLabel47";
            this.metroLabel47.Size = new System.Drawing.Size(33, 25);
            this.metroLabel47.Style = MetroFramework.MetroColorStyle.White;
            this.metroLabel47.TabIndex = 7;
            this.metroLabel47.Text = "#3";
            this.metroLabel47.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroLabel47.UseStyleColors = true;
            // 
            // metroLabel48
            // 
            this.metroLabel48.AutoSize = true;
            this.metroLabel48.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel48.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel48.Location = new System.Drawing.Point(3, 120);
            this.metroLabel48.Name = "metroLabel48";
            this.metroLabel48.Size = new System.Drawing.Size(33, 25);
            this.metroLabel48.Style = MetroFramework.MetroColorStyle.White;
            this.metroLabel48.TabIndex = 8;
            this.metroLabel48.Text = "#4";
            this.metroLabel48.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroLabel48.UseStyleColors = true;
            // 
            // metroLabel49
            // 
            this.metroLabel49.AutoSize = true;
            this.metroLabel49.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel49.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel49.Location = new System.Drawing.Point(419, 0);
            this.metroLabel49.Name = "metroLabel49";
            this.metroLabel49.Size = new System.Drawing.Size(47, 25);
            this.metroLabel49.Style = MetroFramework.MetroColorStyle.White;
            this.metroLabel49.TabIndex = 18;
            this.metroLabel49.Text = "Step";
            this.metroLabel49.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroLabel49.UseStyleColors = true;
            // 
            // PGmt1FromTxtBox
            // 
            // 
            // 
            // 
            this.PGmt1FromTxtBox.CustomButton.Image = null;
            this.PGmt1FromTxtBox.CustomButton.Location = new System.Drawing.Point(61, 1);
            this.PGmt1FromTxtBox.CustomButton.Margin = new System.Windows.Forms.Padding(2);
            this.PGmt1FromTxtBox.CustomButton.Name = "";
            this.PGmt1FromTxtBox.CustomButton.Size = new System.Drawing.Size(16, 16);
            this.PGmt1FromTxtBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.PGmt1FromTxtBox.CustomButton.TabIndex = 1;
            this.PGmt1FromTxtBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.PGmt1FromTxtBox.CustomButton.UseSelectable = true;
            this.PGmt1FromTxtBox.CustomButton.Visible = false;
            this.PGmt1FromTxtBox.Lines = new string[0];
            this.PGmt1FromTxtBox.Location = new System.Drawing.Point(141, 33);
            this.PGmt1FromTxtBox.MaxLength = 32767;
            this.PGmt1FromTxtBox.Name = "PGmt1FromTxtBox";
            this.PGmt1FromTxtBox.PasswordChar = '\0';
            this.PGmt1FromTxtBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.PGmt1FromTxtBox.SelectedText = "";
            this.PGmt1FromTxtBox.SelectionLength = 0;
            this.PGmt1FromTxtBox.SelectionStart = 0;
            this.PGmt1FromTxtBox.ShortcutsEnabled = true;
            this.PGmt1FromTxtBox.Size = new System.Drawing.Size(100, 23);
            this.PGmt1FromTxtBox.TabIndex = 27;
            this.PGmt1FromTxtBox.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.PGmt1FromTxtBox.UseSelectable = true;
            this.PGmt1FromTxtBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.PGmt1FromTxtBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // PGmt3FromTxtBox
            // 
            // 
            // 
            // 
            this.PGmt3FromTxtBox.CustomButton.Image = null;
            this.PGmt3FromTxtBox.CustomButton.Location = new System.Drawing.Point(61, 1);
            this.PGmt3FromTxtBox.CustomButton.Margin = new System.Windows.Forms.Padding(2);
            this.PGmt3FromTxtBox.CustomButton.Name = "";
            this.PGmt3FromTxtBox.CustomButton.Size = new System.Drawing.Size(16, 16);
            this.PGmt3FromTxtBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.PGmt3FromTxtBox.CustomButton.TabIndex = 1;
            this.PGmt3FromTxtBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.PGmt3FromTxtBox.CustomButton.UseSelectable = true;
            this.PGmt3FromTxtBox.CustomButton.Visible = false;
            this.PGmt3FromTxtBox.Lines = new string[0];
            this.PGmt3FromTxtBox.Location = new System.Drawing.Point(141, 93);
            this.PGmt3FromTxtBox.MaxLength = 32767;
            this.PGmt3FromTxtBox.Name = "PGmt3FromTxtBox";
            this.PGmt3FromTxtBox.PasswordChar = '\0';
            this.PGmt3FromTxtBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.PGmt3FromTxtBox.SelectedText = "";
            this.PGmt3FromTxtBox.SelectionLength = 0;
            this.PGmt3FromTxtBox.SelectionStart = 0;
            this.PGmt3FromTxtBox.ShortcutsEnabled = true;
            this.PGmt3FromTxtBox.Size = new System.Drawing.Size(100, 23);
            this.PGmt3FromTxtBox.TabIndex = 33;
            this.PGmt3FromTxtBox.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.PGmt3FromTxtBox.UseSelectable = true;
            this.PGmt3FromTxtBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.PGmt3FromTxtBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // PGmt2FromTxtBox
            // 
            // 
            // 
            // 
            this.PGmt2FromTxtBox.CustomButton.Image = null;
            this.PGmt2FromTxtBox.CustomButton.Location = new System.Drawing.Point(61, 1);
            this.PGmt2FromTxtBox.CustomButton.Margin = new System.Windows.Forms.Padding(2);
            this.PGmt2FromTxtBox.CustomButton.Name = "";
            this.PGmt2FromTxtBox.CustomButton.Size = new System.Drawing.Size(16, 16);
            this.PGmt2FromTxtBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.PGmt2FromTxtBox.CustomButton.TabIndex = 1;
            this.PGmt2FromTxtBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.PGmt2FromTxtBox.CustomButton.UseSelectable = true;
            this.PGmt2FromTxtBox.CustomButton.Visible = false;
            this.PGmt2FromTxtBox.Lines = new string[0];
            this.PGmt2FromTxtBox.Location = new System.Drawing.Point(141, 63);
            this.PGmt2FromTxtBox.MaxLength = 32767;
            this.PGmt2FromTxtBox.Name = "PGmt2FromTxtBox";
            this.PGmt2FromTxtBox.PasswordChar = '\0';
            this.PGmt2FromTxtBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.PGmt2FromTxtBox.SelectedText = "";
            this.PGmt2FromTxtBox.SelectionLength = 0;
            this.PGmt2FromTxtBox.SelectionStart = 0;
            this.PGmt2FromTxtBox.ShortcutsEnabled = true;
            this.PGmt2FromTxtBox.Size = new System.Drawing.Size(100, 23);
            this.PGmt2FromTxtBox.TabIndex = 30;
            this.PGmt2FromTxtBox.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.PGmt2FromTxtBox.UseSelectable = true;
            this.PGmt2FromTxtBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.PGmt2FromTxtBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // PGmt4FromTxtBox
            // 
            // 
            // 
            // 
            this.PGmt4FromTxtBox.CustomButton.Image = null;
            this.PGmt4FromTxtBox.CustomButton.Location = new System.Drawing.Point(61, 1);
            this.PGmt4FromTxtBox.CustomButton.Margin = new System.Windows.Forms.Padding(2);
            this.PGmt4FromTxtBox.CustomButton.Name = "";
            this.PGmt4FromTxtBox.CustomButton.Size = new System.Drawing.Size(16, 16);
            this.PGmt4FromTxtBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.PGmt4FromTxtBox.CustomButton.TabIndex = 1;
            this.PGmt4FromTxtBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.PGmt4FromTxtBox.CustomButton.UseSelectable = true;
            this.PGmt4FromTxtBox.CustomButton.Visible = false;
            this.PGmt4FromTxtBox.Lines = new string[0];
            this.PGmt4FromTxtBox.Location = new System.Drawing.Point(141, 123);
            this.PGmt4FromTxtBox.MaxLength = 32767;
            this.PGmt4FromTxtBox.Name = "PGmt4FromTxtBox";
            this.PGmt4FromTxtBox.PasswordChar = '\0';
            this.PGmt4FromTxtBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.PGmt4FromTxtBox.SelectedText = "";
            this.PGmt4FromTxtBox.SelectionLength = 0;
            this.PGmt4FromTxtBox.SelectionStart = 0;
            this.PGmt4FromTxtBox.ShortcutsEnabled = true;
            this.PGmt4FromTxtBox.Size = new System.Drawing.Size(100, 23);
            this.PGmt4FromTxtBox.TabIndex = 36;
            this.PGmt4FromTxtBox.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.PGmt4FromTxtBox.UseSelectable = true;
            this.PGmt4FromTxtBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.PGmt4FromTxtBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // PGmt1StepTxtBox
            // 
            // 
            // 
            // 
            this.PGmt1StepTxtBox.CustomButton.Image = null;
            this.PGmt1StepTxtBox.CustomButton.Location = new System.Drawing.Point(61, 1);
            this.PGmt1StepTxtBox.CustomButton.Margin = new System.Windows.Forms.Padding(2);
            this.PGmt1StepTxtBox.CustomButton.Name = "";
            this.PGmt1StepTxtBox.CustomButton.Size = new System.Drawing.Size(16, 16);
            this.PGmt1StepTxtBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.PGmt1StepTxtBox.CustomButton.TabIndex = 1;
            this.PGmt1StepTxtBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.PGmt1StepTxtBox.CustomButton.UseSelectable = true;
            this.PGmt1StepTxtBox.CustomButton.Visible = false;
            this.PGmt1StepTxtBox.Lines = new string[0];
            this.PGmt1StepTxtBox.Location = new System.Drawing.Point(419, 33);
            this.PGmt1StepTxtBox.MaxLength = 32767;
            this.PGmt1StepTxtBox.Name = "PGmt1StepTxtBox";
            this.PGmt1StepTxtBox.PasswordChar = '\0';
            this.PGmt1StepTxtBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.PGmt1StepTxtBox.SelectedText = "";
            this.PGmt1StepTxtBox.SelectionLength = 0;
            this.PGmt1StepTxtBox.SelectionStart = 0;
            this.PGmt1StepTxtBox.ShortcutsEnabled = true;
            this.PGmt1StepTxtBox.Size = new System.Drawing.Size(100, 23);
            this.PGmt1StepTxtBox.TabIndex = 29;
            this.PGmt1StepTxtBox.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.PGmt1StepTxtBox.UseSelectable = true;
            this.PGmt1StepTxtBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.PGmt1StepTxtBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // PGmt1ToTxtBox
            // 
            // 
            // 
            // 
            this.PGmt1ToTxtBox.CustomButton.Image = null;
            this.PGmt1ToTxtBox.CustomButton.Location = new System.Drawing.Point(61, 1);
            this.PGmt1ToTxtBox.CustomButton.Margin = new System.Windows.Forms.Padding(2);
            this.PGmt1ToTxtBox.CustomButton.Name = "";
            this.PGmt1ToTxtBox.CustomButton.Size = new System.Drawing.Size(16, 16);
            this.PGmt1ToTxtBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.PGmt1ToTxtBox.CustomButton.TabIndex = 1;
            this.PGmt1ToTxtBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.PGmt1ToTxtBox.CustomButton.UseSelectable = true;
            this.PGmt1ToTxtBox.CustomButton.Visible = false;
            this.PGmt1ToTxtBox.Lines = new string[0];
            this.PGmt1ToTxtBox.Location = new System.Drawing.Point(280, 33);
            this.PGmt1ToTxtBox.MaxLength = 32767;
            this.PGmt1ToTxtBox.Name = "PGmt1ToTxtBox";
            this.PGmt1ToTxtBox.PasswordChar = '\0';
            this.PGmt1ToTxtBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.PGmt1ToTxtBox.SelectedText = "";
            this.PGmt1ToTxtBox.SelectionLength = 0;
            this.PGmt1ToTxtBox.SelectionStart = 0;
            this.PGmt1ToTxtBox.ShortcutsEnabled = true;
            this.PGmt1ToTxtBox.Size = new System.Drawing.Size(100, 23);
            this.PGmt1ToTxtBox.TabIndex = 28;
            this.PGmt1ToTxtBox.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.PGmt1ToTxtBox.UseSelectable = true;
            this.PGmt1ToTxtBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.PGmt1ToTxtBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // PGmt2ToTxtBox
            // 
            // 
            // 
            // 
            this.PGmt2ToTxtBox.CustomButton.Image = null;
            this.PGmt2ToTxtBox.CustomButton.Location = new System.Drawing.Point(61, 1);
            this.PGmt2ToTxtBox.CustomButton.Margin = new System.Windows.Forms.Padding(2);
            this.PGmt2ToTxtBox.CustomButton.Name = "";
            this.PGmt2ToTxtBox.CustomButton.Size = new System.Drawing.Size(16, 16);
            this.PGmt2ToTxtBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.PGmt2ToTxtBox.CustomButton.TabIndex = 1;
            this.PGmt2ToTxtBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.PGmt2ToTxtBox.CustomButton.UseSelectable = true;
            this.PGmt2ToTxtBox.CustomButton.Visible = false;
            this.PGmt2ToTxtBox.Lines = new string[0];
            this.PGmt2ToTxtBox.Location = new System.Drawing.Point(280, 63);
            this.PGmt2ToTxtBox.MaxLength = 32767;
            this.PGmt2ToTxtBox.Name = "PGmt2ToTxtBox";
            this.PGmt2ToTxtBox.PasswordChar = '\0';
            this.PGmt2ToTxtBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.PGmt2ToTxtBox.SelectedText = "";
            this.PGmt2ToTxtBox.SelectionLength = 0;
            this.PGmt2ToTxtBox.SelectionStart = 0;
            this.PGmt2ToTxtBox.ShortcutsEnabled = true;
            this.PGmt2ToTxtBox.Size = new System.Drawing.Size(100, 23);
            this.PGmt2ToTxtBox.TabIndex = 31;
            this.PGmt2ToTxtBox.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.PGmt2ToTxtBox.UseSelectable = true;
            this.PGmt2ToTxtBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.PGmt2ToTxtBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // PGmt3ToTxtBox
            // 
            // 
            // 
            // 
            this.PGmt3ToTxtBox.CustomButton.Image = null;
            this.PGmt3ToTxtBox.CustomButton.Location = new System.Drawing.Point(61, 1);
            this.PGmt3ToTxtBox.CustomButton.Margin = new System.Windows.Forms.Padding(2);
            this.PGmt3ToTxtBox.CustomButton.Name = "";
            this.PGmt3ToTxtBox.CustomButton.Size = new System.Drawing.Size(16, 16);
            this.PGmt3ToTxtBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.PGmt3ToTxtBox.CustomButton.TabIndex = 1;
            this.PGmt3ToTxtBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.PGmt3ToTxtBox.CustomButton.UseSelectable = true;
            this.PGmt3ToTxtBox.CustomButton.Visible = false;
            this.PGmt3ToTxtBox.Lines = new string[0];
            this.PGmt3ToTxtBox.Location = new System.Drawing.Point(280, 93);
            this.PGmt3ToTxtBox.MaxLength = 32767;
            this.PGmt3ToTxtBox.Name = "PGmt3ToTxtBox";
            this.PGmt3ToTxtBox.PasswordChar = '\0';
            this.PGmt3ToTxtBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.PGmt3ToTxtBox.SelectedText = "";
            this.PGmt3ToTxtBox.SelectionLength = 0;
            this.PGmt3ToTxtBox.SelectionStart = 0;
            this.PGmt3ToTxtBox.ShortcutsEnabled = true;
            this.PGmt3ToTxtBox.Size = new System.Drawing.Size(100, 23);
            this.PGmt3ToTxtBox.TabIndex = 34;
            this.PGmt3ToTxtBox.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.PGmt3ToTxtBox.UseSelectable = true;
            this.PGmt3ToTxtBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.PGmt3ToTxtBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // PGmt4ToTxtBox
            // 
            // 
            // 
            // 
            this.PGmt4ToTxtBox.CustomButton.Image = null;
            this.PGmt4ToTxtBox.CustomButton.Location = new System.Drawing.Point(61, 1);
            this.PGmt4ToTxtBox.CustomButton.Margin = new System.Windows.Forms.Padding(2);
            this.PGmt4ToTxtBox.CustomButton.Name = "";
            this.PGmt4ToTxtBox.CustomButton.Size = new System.Drawing.Size(16, 16);
            this.PGmt4ToTxtBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.PGmt4ToTxtBox.CustomButton.TabIndex = 1;
            this.PGmt4ToTxtBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.PGmt4ToTxtBox.CustomButton.UseSelectable = true;
            this.PGmt4ToTxtBox.CustomButton.Visible = false;
            this.PGmt4ToTxtBox.Lines = new string[0];
            this.PGmt4ToTxtBox.Location = new System.Drawing.Point(280, 123);
            this.PGmt4ToTxtBox.MaxLength = 32767;
            this.PGmt4ToTxtBox.Name = "PGmt4ToTxtBox";
            this.PGmt4ToTxtBox.PasswordChar = '\0';
            this.PGmt4ToTxtBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.PGmt4ToTxtBox.SelectedText = "";
            this.PGmt4ToTxtBox.SelectionLength = 0;
            this.PGmt4ToTxtBox.SelectionStart = 0;
            this.PGmt4ToTxtBox.ShortcutsEnabled = true;
            this.PGmt4ToTxtBox.Size = new System.Drawing.Size(100, 23);
            this.PGmt4ToTxtBox.TabIndex = 37;
            this.PGmt4ToTxtBox.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.PGmt4ToTxtBox.UseSelectable = true;
            this.PGmt4ToTxtBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.PGmt4ToTxtBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // PGmt2StepTxtBox
            // 
            // 
            // 
            // 
            this.PGmt2StepTxtBox.CustomButton.Image = null;
            this.PGmt2StepTxtBox.CustomButton.Location = new System.Drawing.Point(61, 1);
            this.PGmt2StepTxtBox.CustomButton.Margin = new System.Windows.Forms.Padding(2);
            this.PGmt2StepTxtBox.CustomButton.Name = "";
            this.PGmt2StepTxtBox.CustomButton.Size = new System.Drawing.Size(16, 16);
            this.PGmt2StepTxtBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.PGmt2StepTxtBox.CustomButton.TabIndex = 1;
            this.PGmt2StepTxtBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.PGmt2StepTxtBox.CustomButton.UseSelectable = true;
            this.PGmt2StepTxtBox.CustomButton.Visible = false;
            this.PGmt2StepTxtBox.Lines = new string[0];
            this.PGmt2StepTxtBox.Location = new System.Drawing.Point(419, 63);
            this.PGmt2StepTxtBox.MaxLength = 32767;
            this.PGmt2StepTxtBox.Name = "PGmt2StepTxtBox";
            this.PGmt2StepTxtBox.PasswordChar = '\0';
            this.PGmt2StepTxtBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.PGmt2StepTxtBox.SelectedText = "";
            this.PGmt2StepTxtBox.SelectionLength = 0;
            this.PGmt2StepTxtBox.SelectionStart = 0;
            this.PGmt2StepTxtBox.ShortcutsEnabled = true;
            this.PGmt2StepTxtBox.Size = new System.Drawing.Size(100, 23);
            this.PGmt2StepTxtBox.TabIndex = 32;
            this.PGmt2StepTxtBox.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.PGmt2StepTxtBox.UseSelectable = true;
            this.PGmt2StepTxtBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.PGmt2StepTxtBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // PGmt3StepTxtBox
            // 
            // 
            // 
            // 
            this.PGmt3StepTxtBox.CustomButton.Image = null;
            this.PGmt3StepTxtBox.CustomButton.Location = new System.Drawing.Point(61, 1);
            this.PGmt3StepTxtBox.CustomButton.Margin = new System.Windows.Forms.Padding(2);
            this.PGmt3StepTxtBox.CustomButton.Name = "";
            this.PGmt3StepTxtBox.CustomButton.Size = new System.Drawing.Size(16, 16);
            this.PGmt3StepTxtBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.PGmt3StepTxtBox.CustomButton.TabIndex = 1;
            this.PGmt3StepTxtBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.PGmt3StepTxtBox.CustomButton.UseSelectable = true;
            this.PGmt3StepTxtBox.CustomButton.Visible = false;
            this.PGmt3StepTxtBox.Lines = new string[0];
            this.PGmt3StepTxtBox.Location = new System.Drawing.Point(419, 93);
            this.PGmt3StepTxtBox.MaxLength = 32767;
            this.PGmt3StepTxtBox.Name = "PGmt3StepTxtBox";
            this.PGmt3StepTxtBox.PasswordChar = '\0';
            this.PGmt3StepTxtBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.PGmt3StepTxtBox.SelectedText = "";
            this.PGmt3StepTxtBox.SelectionLength = 0;
            this.PGmt3StepTxtBox.SelectionStart = 0;
            this.PGmt3StepTxtBox.ShortcutsEnabled = true;
            this.PGmt3StepTxtBox.Size = new System.Drawing.Size(100, 23);
            this.PGmt3StepTxtBox.TabIndex = 35;
            this.PGmt3StepTxtBox.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.PGmt3StepTxtBox.UseSelectable = true;
            this.PGmt3StepTxtBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.PGmt3StepTxtBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // PGmt4StepTxtBox
            // 
            // 
            // 
            // 
            this.PGmt4StepTxtBox.CustomButton.Image = null;
            this.PGmt4StepTxtBox.CustomButton.Location = new System.Drawing.Point(61, 1);
            this.PGmt4StepTxtBox.CustomButton.Margin = new System.Windows.Forms.Padding(2);
            this.PGmt4StepTxtBox.CustomButton.Name = "";
            this.PGmt4StepTxtBox.CustomButton.Size = new System.Drawing.Size(16, 16);
            this.PGmt4StepTxtBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.PGmt4StepTxtBox.CustomButton.TabIndex = 1;
            this.PGmt4StepTxtBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.PGmt4StepTxtBox.CustomButton.UseSelectable = true;
            this.PGmt4StepTxtBox.CustomButton.Visible = false;
            this.PGmt4StepTxtBox.Lines = new string[0];
            this.PGmt4StepTxtBox.Location = new System.Drawing.Point(419, 123);
            this.PGmt4StepTxtBox.MaxLength = 32767;
            this.PGmt4StepTxtBox.Name = "PGmt4StepTxtBox";
            this.PGmt4StepTxtBox.PasswordChar = '\0';
            this.PGmt4StepTxtBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.PGmt4StepTxtBox.SelectedText = "";
            this.PGmt4StepTxtBox.SelectionLength = 0;
            this.PGmt4StepTxtBox.SelectionStart = 0;
            this.PGmt4StepTxtBox.ShortcutsEnabled = true;
            this.PGmt4StepTxtBox.Size = new System.Drawing.Size(100, 23);
            this.PGmt4StepTxtBox.TabIndex = 38;
            this.PGmt4StepTxtBox.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.PGmt4StepTxtBox.UseSelectable = true;
            this.PGmt4StepTxtBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.PGmt4StepTxtBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // AutoBend
            // 
            this.AutoBend.BackColor = System.Drawing.Color.Transparent;
            this.AutoBend.Controls.Add(this.tableLayoutPanel9);
            this.AutoBend.Location = new System.Drawing.Point(4, 38);
            this.AutoBend.Name = "AutoBend";
            this.AutoBend.Size = new System.Drawing.Size(578, 248);
            this.AutoBend.TabIndex = 5;
            this.AutoBend.Text = "AutoBend";
            // 
            // tableLayoutPanel9
            // 
            this.tableLayoutPanel9.ColumnCount = 6;
            this.tableLayoutPanel9.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel9.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel9.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel9.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel9.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel9.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel9.Controls.Add(this.AutobendRTripToggle, 4, 5);
            this.tableLayoutPanel9.Controls.Add(this.metroLabel64, 3, 5);
            this.tableLayoutPanel9.Controls.Add(this.DistDirStartTxtBox, 2, 2);
            this.tableLayoutPanel9.Controls.Add(this.DistBendStartTxtBox, 1, 2);
            this.tableLayoutPanel9.Controls.Add(this.ProxDirStartTxtBox, 2, 1);
            this.tableLayoutPanel9.Controls.Add(this.ProxBendStartTxtBox, 1, 1);
            this.tableLayoutPanel9.Controls.Add(this.metroLabel53, 0, 0);
            this.tableLayoutPanel9.Controls.Add(this.metroLabel54, 1, 0);
            this.tableLayoutPanel9.Controls.Add(this.metroLabel57, 2, 0);
            this.tableLayoutPanel9.Controls.Add(this.metroLabel58, 0, 1);
            this.tableLayoutPanel9.Controls.Add(this.metroLabel59, 0, 2);
            this.tableLayoutPanel9.Controls.Add(this.metroLabel60, 3, 0);
            this.tableLayoutPanel9.Controls.Add(this.metroLabel61, 4, 0);
            this.tableLayoutPanel9.Controls.Add(this.DistBendGoaltTxtBox, 3, 2);
            this.tableLayoutPanel9.Controls.Add(this.DistDirGoalTxtBox, 4, 2);
            this.tableLayoutPanel9.Controls.Add(this.ProxDirGoalTxtBox, 4, 1);
            this.tableLayoutPanel9.Controls.Add(this.ProxBendGoalTxtBox, 3, 1);
            this.tableLayoutPanel9.Controls.Add(this.AutobendIntTxtBox, 2, 3);
            this.tableLayoutPanel9.Controls.Add(this.AutobendRepeatTxtBox, 4, 3);
            this.tableLayoutPanel9.Controls.Add(this.metroLabel62, 1, 3);
            this.tableLayoutPanel9.Controls.Add(this.metroLabel63, 3, 3);
            this.tableLayoutPanel9.Controls.Add(this.metroLabel65, 1, 4);
            this.tableLayoutPanel9.Controls.Add(this.metroLabel66, 3, 4);
            this.tableLayoutPanel9.Controls.Add(this.AutobendBendStepTxtBox, 2, 4);
            this.tableLayoutPanel9.Controls.Add(this.AutobendDirStepTxtBox, 4, 4);
            this.tableLayoutPanel9.Controls.Add(this.metroLabel68, 1, 5);
            this.tableLayoutPanel9.Controls.Add(this.AutobendDTPToggle, 2, 5);
            this.tableLayoutPanel9.Controls.Add(this.AutobendHoldBtn, 5, 3);
            this.tableLayoutPanel9.Controls.Add(this.AutobendRunBtn, 5, 2);
            this.tableLayoutPanel9.Controls.Add(this.AutobendStopBtn, 5, 4);
            this.tableLayoutPanel9.Location = new System.Drawing.Point(3, 16);
            this.tableLayoutPanel9.Name = "tableLayoutPanel9";
            this.tableLayoutPanel9.RowCount = 6;
            this.tableLayoutPanel9.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel9.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel9.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel9.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel9.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel9.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel9.Size = new System.Drawing.Size(572, 214);
            this.tableLayoutPanel9.TabIndex = 32;
            // 
            // AutobendRTripToggle
            // 
            this.AutobendRTripToggle.AutoSize = true;
            this.AutobendRTripToggle.Checked = true;
            this.AutobendRTripToggle.CheckState = System.Windows.Forms.CheckState.Checked;
            this.AutobendRTripToggle.FontSize = MetroFramework.MetroLinkSize.Medium;
            this.AutobendRTripToggle.Location = new System.Drawing.Point(383, 193);
            this.AutobendRTripToggle.Name = "AutobendRTripToggle";
            this.AutobendRTripToggle.Size = new System.Drawing.Size(80, 18);
            this.AutobendRTripToggle.TabIndex = 33;
            this.AutobendRTripToggle.Text = "On";
            this.AutobendRTripToggle.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.AutobendRTripToggle.UseSelectable = true;
            // 
            // metroLabel64
            // 
            this.metroLabel64.AutoSize = true;
            this.metroLabel64.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel64.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel64.Location = new System.Drawing.Point(288, 190);
            this.metroLabel64.Name = "metroLabel64";
            this.metroLabel64.Size = new System.Drawing.Size(58, 24);
            this.metroLabel64.Style = MetroFramework.MetroColorStyle.White;
            this.metroLabel64.TabIndex = 34;
            this.metroLabel64.Text = "R-Trip";
            this.metroLabel64.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroLabel64.UseStyleColors = true;
            // 
            // DistDirStartTxtBox
            // 
            // 
            // 
            // 
            this.DistDirStartTxtBox.CustomButton.Image = null;
            this.DistDirStartTxtBox.CustomButton.Location = new System.Drawing.Point(52, 1);
            this.DistDirStartTxtBox.CustomButton.Margin = new System.Windows.Forms.Padding(2);
            this.DistDirStartTxtBox.CustomButton.Name = "";
            this.DistDirStartTxtBox.CustomButton.Size = new System.Drawing.Size(16, 16);
            this.DistDirStartTxtBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.DistDirStartTxtBox.CustomButton.TabIndex = 1;
            this.DistDirStartTxtBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.DistDirStartTxtBox.CustomButton.UseSelectable = true;
            this.DistDirStartTxtBox.CustomButton.Visible = false;
            this.DistDirStartTxtBox.Lines = new string[0];
            this.DistDirStartTxtBox.Location = new System.Drawing.Point(193, 79);
            this.DistDirStartTxtBox.MaxLength = 32767;
            this.DistDirStartTxtBox.Name = "DistDirStartTxtBox";
            this.DistDirStartTxtBox.PasswordChar = '\0';
            this.DistDirStartTxtBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.DistDirStartTxtBox.SelectedText = "";
            this.DistDirStartTxtBox.SelectionLength = 0;
            this.DistDirStartTxtBox.SelectionStart = 0;
            this.DistDirStartTxtBox.ShortcutsEnabled = true;
            this.DistDirStartTxtBox.Size = new System.Drawing.Size(89, 23);
            this.DistDirStartTxtBox.TabIndex = 37;
            this.DistDirStartTxtBox.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.DistDirStartTxtBox.UseSelectable = true;
            this.DistDirStartTxtBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.DistDirStartTxtBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // DistBendStartTxtBox
            // 
            // 
            // 
            // 
            this.DistBendStartTxtBox.CustomButton.Image = null;
            this.DistBendStartTxtBox.CustomButton.Location = new System.Drawing.Point(52, 1);
            this.DistBendStartTxtBox.CustomButton.Margin = new System.Windows.Forms.Padding(2);
            this.DistBendStartTxtBox.CustomButton.Name = "";
            this.DistBendStartTxtBox.CustomButton.Size = new System.Drawing.Size(16, 16);
            this.DistBendStartTxtBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.DistBendStartTxtBox.CustomButton.TabIndex = 1;
            this.DistBendStartTxtBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.DistBendStartTxtBox.CustomButton.UseSelectable = true;
            this.DistBendStartTxtBox.CustomButton.Visible = false;
            this.DistBendStartTxtBox.Lines = new string[0];
            this.DistBendStartTxtBox.Location = new System.Drawing.Point(98, 79);
            this.DistBendStartTxtBox.MaxLength = 32767;
            this.DistBendStartTxtBox.Name = "DistBendStartTxtBox";
            this.DistBendStartTxtBox.PasswordChar = '\0';
            this.DistBendStartTxtBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.DistBendStartTxtBox.SelectedText = "";
            this.DistBendStartTxtBox.SelectionLength = 0;
            this.DistBendStartTxtBox.SelectionStart = 0;
            this.DistBendStartTxtBox.ShortcutsEnabled = true;
            this.DistBendStartTxtBox.Size = new System.Drawing.Size(89, 23);
            this.DistBendStartTxtBox.TabIndex = 36;
            this.DistBendStartTxtBox.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.DistBendStartTxtBox.UseSelectable = true;
            this.DistBendStartTxtBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.DistBendStartTxtBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // ProxDirStartTxtBox
            // 
            // 
            // 
            // 
            this.ProxDirStartTxtBox.CustomButton.Image = null;
            this.ProxDirStartTxtBox.CustomButton.Location = new System.Drawing.Point(52, 1);
            this.ProxDirStartTxtBox.CustomButton.Margin = new System.Windows.Forms.Padding(2);
            this.ProxDirStartTxtBox.CustomButton.Name = "";
            this.ProxDirStartTxtBox.CustomButton.Size = new System.Drawing.Size(16, 16);
            this.ProxDirStartTxtBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.ProxDirStartTxtBox.CustomButton.TabIndex = 1;
            this.ProxDirStartTxtBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.ProxDirStartTxtBox.CustomButton.UseSelectable = true;
            this.ProxDirStartTxtBox.CustomButton.Visible = false;
            this.ProxDirStartTxtBox.Lines = new string[0];
            this.ProxDirStartTxtBox.Location = new System.Drawing.Point(193, 41);
            this.ProxDirStartTxtBox.MaxLength = 32767;
            this.ProxDirStartTxtBox.Name = "ProxDirStartTxtBox";
            this.ProxDirStartTxtBox.PasswordChar = '\0';
            this.ProxDirStartTxtBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.ProxDirStartTxtBox.SelectedText = "";
            this.ProxDirStartTxtBox.SelectionLength = 0;
            this.ProxDirStartTxtBox.SelectionStart = 0;
            this.ProxDirStartTxtBox.ShortcutsEnabled = true;
            this.ProxDirStartTxtBox.Size = new System.Drawing.Size(89, 23);
            this.ProxDirStartTxtBox.TabIndex = 35;
            this.ProxDirStartTxtBox.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.ProxDirStartTxtBox.UseSelectable = true;
            this.ProxDirStartTxtBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.ProxDirStartTxtBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // ProxBendStartTxtBox
            // 
            // 
            // 
            // 
            this.ProxBendStartTxtBox.CustomButton.Image = null;
            this.ProxBendStartTxtBox.CustomButton.Location = new System.Drawing.Point(52, 1);
            this.ProxBendStartTxtBox.CustomButton.Margin = new System.Windows.Forms.Padding(2);
            this.ProxBendStartTxtBox.CustomButton.Name = "";
            this.ProxBendStartTxtBox.CustomButton.Size = new System.Drawing.Size(16, 16);
            this.ProxBendStartTxtBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.ProxBendStartTxtBox.CustomButton.TabIndex = 1;
            this.ProxBendStartTxtBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.ProxBendStartTxtBox.CustomButton.UseSelectable = true;
            this.ProxBendStartTxtBox.CustomButton.Visible = false;
            this.ProxBendStartTxtBox.Lines = new string[0];
            this.ProxBendStartTxtBox.Location = new System.Drawing.Point(98, 41);
            this.ProxBendStartTxtBox.MaxLength = 32767;
            this.ProxBendStartTxtBox.Name = "ProxBendStartTxtBox";
            this.ProxBendStartTxtBox.PasswordChar = '\0';
            this.ProxBendStartTxtBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.ProxBendStartTxtBox.SelectedText = "";
            this.ProxBendStartTxtBox.SelectionLength = 0;
            this.ProxBendStartTxtBox.SelectionStart = 0;
            this.ProxBendStartTxtBox.ShortcutsEnabled = true;
            this.ProxBendStartTxtBox.Size = new System.Drawing.Size(89, 23);
            this.ProxBendStartTxtBox.TabIndex = 34;
            this.ProxBendStartTxtBox.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.ProxBendStartTxtBox.UseSelectable = true;
            this.ProxBendStartTxtBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.ProxBendStartTxtBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel53
            // 
            this.metroLabel53.AutoSize = true;
            this.metroLabel53.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel53.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel53.Location = new System.Drawing.Point(3, 0);
            this.metroLabel53.Name = "metroLabel53";
            this.metroLabel53.Size = new System.Drawing.Size(42, 25);
            this.metroLabel53.Style = MetroFramework.MetroColorStyle.White;
            this.metroLabel53.TabIndex = 18;
            this.metroLabel53.Text = "Seg";
            this.metroLabel53.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroLabel53.UseStyleColors = true;
            // 
            // metroLabel54
            // 
            this.metroLabel54.AutoSize = true;
            this.metroLabel54.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel54.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel54.Location = new System.Drawing.Point(98, 0);
            this.metroLabel54.Name = "metroLabel54";
            this.metroLabel54.Size = new System.Drawing.Size(88, 25);
            this.metroLabel54.Style = MetroFramework.MetroColorStyle.White;
            this.metroLabel54.TabIndex = 15;
            this.metroLabel54.Text = "BendStart";
            this.metroLabel54.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroLabel54.UseStyleColors = true;
            // 
            // metroLabel57
            // 
            this.metroLabel57.AutoSize = true;
            this.metroLabel57.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel57.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel57.Location = new System.Drawing.Point(193, 0);
            this.metroLabel57.Name = "metroLabel57";
            this.metroLabel57.Size = new System.Drawing.Size(71, 25);
            this.metroLabel57.Style = MetroFramework.MetroColorStyle.White;
            this.metroLabel57.TabIndex = 16;
            this.metroLabel57.Text = "DirStart";
            this.metroLabel57.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroLabel57.UseStyleColors = true;
            // 
            // metroLabel58
            // 
            this.metroLabel58.AutoSize = true;
            this.metroLabel58.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel58.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel58.Location = new System.Drawing.Point(3, 38);
            this.metroLabel58.Name = "metroLabel58";
            this.metroLabel58.Size = new System.Drawing.Size(47, 25);
            this.metroLabel58.Style = MetroFramework.MetroColorStyle.White;
            this.metroLabel58.TabIndex = 17;
            this.metroLabel58.Text = "Prox";
            this.metroLabel58.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroLabel58.UseStyleColors = true;
            // 
            // metroLabel59
            // 
            this.metroLabel59.AutoSize = true;
            this.metroLabel59.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel59.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel59.Location = new System.Drawing.Point(3, 76);
            this.metroLabel59.Name = "metroLabel59";
            this.metroLabel59.Size = new System.Drawing.Size(43, 25);
            this.metroLabel59.Style = MetroFramework.MetroColorStyle.White;
            this.metroLabel59.TabIndex = 19;
            this.metroLabel59.Text = "Dist";
            this.metroLabel59.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroLabel59.UseStyleColors = true;
            // 
            // metroLabel60
            // 
            this.metroLabel60.AutoSize = true;
            this.metroLabel60.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel60.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel60.Location = new System.Drawing.Point(288, 0);
            this.metroLabel60.Name = "metroLabel60";
            this.metroLabel60.Size = new System.Drawing.Size(88, 25);
            this.metroLabel60.Style = MetroFramework.MetroColorStyle.White;
            this.metroLabel60.TabIndex = 15;
            this.metroLabel60.Text = "BendGoal";
            this.metroLabel60.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroLabel60.UseStyleColors = true;
            // 
            // metroLabel61
            // 
            this.metroLabel61.AutoSize = true;
            this.metroLabel61.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel61.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel61.Location = new System.Drawing.Point(383, 0);
            this.metroLabel61.Name = "metroLabel61";
            this.metroLabel61.Size = new System.Drawing.Size(71, 25);
            this.metroLabel61.Style = MetroFramework.MetroColorStyle.White;
            this.metroLabel61.TabIndex = 16;
            this.metroLabel61.Text = "DirGoal";
            this.metroLabel61.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroLabel61.UseStyleColors = true;
            // 
            // DistBendGoaltTxtBox
            // 
            // 
            // 
            // 
            this.DistBendGoaltTxtBox.CustomButton.Image = null;
            this.DistBendGoaltTxtBox.CustomButton.Location = new System.Drawing.Point(52, 1);
            this.DistBendGoaltTxtBox.CustomButton.Margin = new System.Windows.Forms.Padding(2);
            this.DistBendGoaltTxtBox.CustomButton.Name = "";
            this.DistBendGoaltTxtBox.CustomButton.Size = new System.Drawing.Size(16, 16);
            this.DistBendGoaltTxtBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.DistBendGoaltTxtBox.CustomButton.TabIndex = 1;
            this.DistBendGoaltTxtBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.DistBendGoaltTxtBox.CustomButton.UseSelectable = true;
            this.DistBendGoaltTxtBox.CustomButton.Visible = false;
            this.DistBendGoaltTxtBox.Lines = new string[0];
            this.DistBendGoaltTxtBox.Location = new System.Drawing.Point(288, 79);
            this.DistBendGoaltTxtBox.MaxLength = 32767;
            this.DistBendGoaltTxtBox.Name = "DistBendGoaltTxtBox";
            this.DistBendGoaltTxtBox.PasswordChar = '\0';
            this.DistBendGoaltTxtBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.DistBendGoaltTxtBox.SelectedText = "";
            this.DistBendGoaltTxtBox.SelectionLength = 0;
            this.DistBendGoaltTxtBox.SelectionStart = 0;
            this.DistBendGoaltTxtBox.ShortcutsEnabled = true;
            this.DistBendGoaltTxtBox.Size = new System.Drawing.Size(89, 23);
            this.DistBendGoaltTxtBox.TabIndex = 40;
            this.DistBendGoaltTxtBox.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.DistBendGoaltTxtBox.UseSelectable = true;
            this.DistBendGoaltTxtBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.DistBendGoaltTxtBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // DistDirGoalTxtBox
            // 
            // 
            // 
            // 
            this.DistDirGoalTxtBox.CustomButton.Image = null;
            this.DistDirGoalTxtBox.CustomButton.Location = new System.Drawing.Point(52, 1);
            this.DistDirGoalTxtBox.CustomButton.Margin = new System.Windows.Forms.Padding(2);
            this.DistDirGoalTxtBox.CustomButton.Name = "";
            this.DistDirGoalTxtBox.CustomButton.Size = new System.Drawing.Size(16, 16);
            this.DistDirGoalTxtBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.DistDirGoalTxtBox.CustomButton.TabIndex = 1;
            this.DistDirGoalTxtBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.DistDirGoalTxtBox.CustomButton.UseSelectable = true;
            this.DistDirGoalTxtBox.CustomButton.Visible = false;
            this.DistDirGoalTxtBox.Lines = new string[0];
            this.DistDirGoalTxtBox.Location = new System.Drawing.Point(383, 79);
            this.DistDirGoalTxtBox.MaxLength = 32767;
            this.DistDirGoalTxtBox.Name = "DistDirGoalTxtBox";
            this.DistDirGoalTxtBox.PasswordChar = '\0';
            this.DistDirGoalTxtBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.DistDirGoalTxtBox.SelectedText = "";
            this.DistDirGoalTxtBox.SelectionLength = 0;
            this.DistDirGoalTxtBox.SelectionStart = 0;
            this.DistDirGoalTxtBox.ShortcutsEnabled = true;
            this.DistDirGoalTxtBox.Size = new System.Drawing.Size(89, 23);
            this.DistDirGoalTxtBox.TabIndex = 41;
            this.DistDirGoalTxtBox.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.DistDirGoalTxtBox.UseSelectable = true;
            this.DistDirGoalTxtBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.DistDirGoalTxtBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // ProxDirGoalTxtBox
            // 
            // 
            // 
            // 
            this.ProxDirGoalTxtBox.CustomButton.Image = null;
            this.ProxDirGoalTxtBox.CustomButton.Location = new System.Drawing.Point(52, 1);
            this.ProxDirGoalTxtBox.CustomButton.Margin = new System.Windows.Forms.Padding(2);
            this.ProxDirGoalTxtBox.CustomButton.Name = "";
            this.ProxDirGoalTxtBox.CustomButton.Size = new System.Drawing.Size(16, 16);
            this.ProxDirGoalTxtBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.ProxDirGoalTxtBox.CustomButton.TabIndex = 1;
            this.ProxDirGoalTxtBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.ProxDirGoalTxtBox.CustomButton.UseSelectable = true;
            this.ProxDirGoalTxtBox.CustomButton.Visible = false;
            this.ProxDirGoalTxtBox.Lines = new string[0];
            this.ProxDirGoalTxtBox.Location = new System.Drawing.Point(383, 41);
            this.ProxDirGoalTxtBox.MaxLength = 32767;
            this.ProxDirGoalTxtBox.Name = "ProxDirGoalTxtBox";
            this.ProxDirGoalTxtBox.PasswordChar = '\0';
            this.ProxDirGoalTxtBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.ProxDirGoalTxtBox.SelectedText = "";
            this.ProxDirGoalTxtBox.SelectionLength = 0;
            this.ProxDirGoalTxtBox.SelectionStart = 0;
            this.ProxDirGoalTxtBox.ShortcutsEnabled = true;
            this.ProxDirGoalTxtBox.Size = new System.Drawing.Size(89, 23);
            this.ProxDirGoalTxtBox.TabIndex = 39;
            this.ProxDirGoalTxtBox.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.ProxDirGoalTxtBox.UseSelectable = true;
            this.ProxDirGoalTxtBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.ProxDirGoalTxtBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // ProxBendGoalTxtBox
            // 
            // 
            // 
            // 
            this.ProxBendGoalTxtBox.CustomButton.Image = null;
            this.ProxBendGoalTxtBox.CustomButton.Location = new System.Drawing.Point(52, 1);
            this.ProxBendGoalTxtBox.CustomButton.Margin = new System.Windows.Forms.Padding(2);
            this.ProxBendGoalTxtBox.CustomButton.Name = "";
            this.ProxBendGoalTxtBox.CustomButton.Size = new System.Drawing.Size(16, 16);
            this.ProxBendGoalTxtBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.ProxBendGoalTxtBox.CustomButton.TabIndex = 1;
            this.ProxBendGoalTxtBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.ProxBendGoalTxtBox.CustomButton.UseSelectable = true;
            this.ProxBendGoalTxtBox.CustomButton.Visible = false;
            this.ProxBendGoalTxtBox.Lines = new string[0];
            this.ProxBendGoalTxtBox.Location = new System.Drawing.Point(288, 41);
            this.ProxBendGoalTxtBox.MaxLength = 32767;
            this.ProxBendGoalTxtBox.Name = "ProxBendGoalTxtBox";
            this.ProxBendGoalTxtBox.PasswordChar = '\0';
            this.ProxBendGoalTxtBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.ProxBendGoalTxtBox.SelectedText = "";
            this.ProxBendGoalTxtBox.SelectionLength = 0;
            this.ProxBendGoalTxtBox.SelectionStart = 0;
            this.ProxBendGoalTxtBox.ShortcutsEnabled = true;
            this.ProxBendGoalTxtBox.Size = new System.Drawing.Size(89, 23);
            this.ProxBendGoalTxtBox.TabIndex = 38;
            this.ProxBendGoalTxtBox.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.ProxBendGoalTxtBox.UseSelectable = true;
            this.ProxBendGoalTxtBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.ProxBendGoalTxtBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // AutobendIntTxtBox
            // 
            // 
            // 
            // 
            this.AutobendIntTxtBox.CustomButton.Image = null;
            this.AutobendIntTxtBox.CustomButton.Location = new System.Drawing.Point(52, 1);
            this.AutobendIntTxtBox.CustomButton.Margin = new System.Windows.Forms.Padding(2);
            this.AutobendIntTxtBox.CustomButton.Name = "";
            this.AutobendIntTxtBox.CustomButton.Size = new System.Drawing.Size(16, 16);
            this.AutobendIntTxtBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.AutobendIntTxtBox.CustomButton.TabIndex = 1;
            this.AutobendIntTxtBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.AutobendIntTxtBox.CustomButton.UseSelectable = true;
            this.AutobendIntTxtBox.CustomButton.Visible = false;
            this.AutobendIntTxtBox.Lines = new string[0];
            this.AutobendIntTxtBox.Location = new System.Drawing.Point(193, 117);
            this.AutobendIntTxtBox.MaxLength = 32767;
            this.AutobendIntTxtBox.Name = "AutobendIntTxtBox";
            this.AutobendIntTxtBox.PasswordChar = '\0';
            this.AutobendIntTxtBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.AutobendIntTxtBox.SelectedText = "";
            this.AutobendIntTxtBox.SelectionLength = 0;
            this.AutobendIntTxtBox.SelectionStart = 0;
            this.AutobendIntTxtBox.ShortcutsEnabled = true;
            this.AutobendIntTxtBox.Size = new System.Drawing.Size(89, 23);
            this.AutobendIntTxtBox.TabIndex = 37;
            this.AutobendIntTxtBox.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.AutobendIntTxtBox.UseSelectable = true;
            this.AutobendIntTxtBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.AutobendIntTxtBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // AutobendRepeatTxtBox
            // 
            // 
            // 
            // 
            this.AutobendRepeatTxtBox.CustomButton.Image = null;
            this.AutobendRepeatTxtBox.CustomButton.Location = new System.Drawing.Point(52, 1);
            this.AutobendRepeatTxtBox.CustomButton.Margin = new System.Windows.Forms.Padding(2);
            this.AutobendRepeatTxtBox.CustomButton.Name = "";
            this.AutobendRepeatTxtBox.CustomButton.Size = new System.Drawing.Size(16, 16);
            this.AutobendRepeatTxtBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.AutobendRepeatTxtBox.CustomButton.TabIndex = 1;
            this.AutobendRepeatTxtBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.AutobendRepeatTxtBox.CustomButton.UseSelectable = true;
            this.AutobendRepeatTxtBox.CustomButton.Visible = false;
            this.AutobendRepeatTxtBox.Lines = new string[0];
            this.AutobendRepeatTxtBox.Location = new System.Drawing.Point(383, 117);
            this.AutobendRepeatTxtBox.MaxLength = 32767;
            this.AutobendRepeatTxtBox.Name = "AutobendRepeatTxtBox";
            this.AutobendRepeatTxtBox.PasswordChar = '\0';
            this.AutobendRepeatTxtBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.AutobendRepeatTxtBox.SelectedText = "";
            this.AutobendRepeatTxtBox.SelectionLength = 0;
            this.AutobendRepeatTxtBox.SelectionStart = 0;
            this.AutobendRepeatTxtBox.ShortcutsEnabled = true;
            this.AutobendRepeatTxtBox.Size = new System.Drawing.Size(89, 23);
            this.AutobendRepeatTxtBox.TabIndex = 37;
            this.AutobendRepeatTxtBox.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.AutobendRepeatTxtBox.UseSelectable = true;
            this.AutobendRepeatTxtBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.AutobendRepeatTxtBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel62
            // 
            this.metroLabel62.AutoSize = true;
            this.metroLabel62.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel62.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel62.Location = new System.Drawing.Point(98, 114);
            this.metroLabel62.Name = "metroLabel62";
            this.metroLabel62.Size = new System.Drawing.Size(73, 25);
            this.metroLabel62.Style = MetroFramework.MetroColorStyle.White;
            this.metroLabel62.TabIndex = 15;
            this.metroLabel62.Text = "INT(ms)";
            this.metroLabel62.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroLabel62.UseStyleColors = true;
            // 
            // metroLabel63
            // 
            this.metroLabel63.AutoSize = true;
            this.metroLabel63.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel63.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel63.Location = new System.Drawing.Point(288, 114);
            this.metroLabel63.Name = "metroLabel63";
            this.metroLabel63.Size = new System.Drawing.Size(66, 25);
            this.metroLabel63.Style = MetroFramework.MetroColorStyle.White;
            this.metroLabel63.TabIndex = 15;
            this.metroLabel63.Text = "Repeat";
            this.metroLabel63.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroLabel63.UseStyleColors = true;
            // 
            // metroLabel65
            // 
            this.metroLabel65.AutoSize = true;
            this.metroLabel65.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel65.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel65.Location = new System.Drawing.Point(98, 152);
            this.metroLabel65.Name = "metroLabel65";
            this.metroLabel65.Size = new System.Drawing.Size(87, 25);
            this.metroLabel65.Style = MetroFramework.MetroColorStyle.White;
            this.metroLabel65.TabIndex = 15;
            this.metroLabel65.Text = "BendStep";
            this.metroLabel65.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroLabel65.UseStyleColors = true;
            // 
            // metroLabel66
            // 
            this.metroLabel66.AutoSize = true;
            this.metroLabel66.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel66.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel66.Location = new System.Drawing.Point(288, 152);
            this.metroLabel66.Name = "metroLabel66";
            this.metroLabel66.Size = new System.Drawing.Size(70, 25);
            this.metroLabel66.Style = MetroFramework.MetroColorStyle.White;
            this.metroLabel66.TabIndex = 15;
            this.metroLabel66.Text = "DirStep";
            this.metroLabel66.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroLabel66.UseStyleColors = true;
            // 
            // AutobendBendStepTxtBox
            // 
            // 
            // 
            // 
            this.AutobendBendStepTxtBox.CustomButton.Image = null;
            this.AutobendBendStepTxtBox.CustomButton.Location = new System.Drawing.Point(52, 1);
            this.AutobendBendStepTxtBox.CustomButton.Margin = new System.Windows.Forms.Padding(2);
            this.AutobendBendStepTxtBox.CustomButton.Name = "";
            this.AutobendBendStepTxtBox.CustomButton.Size = new System.Drawing.Size(16, 16);
            this.AutobendBendStepTxtBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.AutobendBendStepTxtBox.CustomButton.TabIndex = 1;
            this.AutobendBendStepTxtBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.AutobendBendStepTxtBox.CustomButton.UseSelectable = true;
            this.AutobendBendStepTxtBox.CustomButton.Visible = false;
            this.AutobendBendStepTxtBox.Lines = new string[0];
            this.AutobendBendStepTxtBox.Location = new System.Drawing.Point(193, 155);
            this.AutobendBendStepTxtBox.MaxLength = 32767;
            this.AutobendBendStepTxtBox.Name = "AutobendBendStepTxtBox";
            this.AutobendBendStepTxtBox.PasswordChar = '\0';
            this.AutobendBendStepTxtBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.AutobendBendStepTxtBox.SelectedText = "";
            this.AutobendBendStepTxtBox.SelectionLength = 0;
            this.AutobendBendStepTxtBox.SelectionStart = 0;
            this.AutobendBendStepTxtBox.ShortcutsEnabled = true;
            this.AutobendBendStepTxtBox.Size = new System.Drawing.Size(89, 23);
            this.AutobendBendStepTxtBox.TabIndex = 37;
            this.AutobendBendStepTxtBox.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.AutobendBendStepTxtBox.UseSelectable = true;
            this.AutobendBendStepTxtBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.AutobendBendStepTxtBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // AutobendDirStepTxtBox
            // 
            // 
            // 
            // 
            this.AutobendDirStepTxtBox.CustomButton.Image = null;
            this.AutobendDirStepTxtBox.CustomButton.Location = new System.Drawing.Point(52, 1);
            this.AutobendDirStepTxtBox.CustomButton.Margin = new System.Windows.Forms.Padding(2);
            this.AutobendDirStepTxtBox.CustomButton.Name = "";
            this.AutobendDirStepTxtBox.CustomButton.Size = new System.Drawing.Size(16, 16);
            this.AutobendDirStepTxtBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.AutobendDirStepTxtBox.CustomButton.TabIndex = 1;
            this.AutobendDirStepTxtBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.AutobendDirStepTxtBox.CustomButton.UseSelectable = true;
            this.AutobendDirStepTxtBox.CustomButton.Visible = false;
            this.AutobendDirStepTxtBox.Lines = new string[0];
            this.AutobendDirStepTxtBox.Location = new System.Drawing.Point(383, 155);
            this.AutobendDirStepTxtBox.MaxLength = 32767;
            this.AutobendDirStepTxtBox.Name = "AutobendDirStepTxtBox";
            this.AutobendDirStepTxtBox.PasswordChar = '\0';
            this.AutobendDirStepTxtBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.AutobendDirStepTxtBox.SelectedText = "";
            this.AutobendDirStepTxtBox.SelectionLength = 0;
            this.AutobendDirStepTxtBox.SelectionStart = 0;
            this.AutobendDirStepTxtBox.ShortcutsEnabled = true;
            this.AutobendDirStepTxtBox.Size = new System.Drawing.Size(89, 23);
            this.AutobendDirStepTxtBox.TabIndex = 37;
            this.AutobendDirStepTxtBox.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.AutobendDirStepTxtBox.UseSelectable = true;
            this.AutobendDirStepTxtBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.AutobendDirStepTxtBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel68
            // 
            this.metroLabel68.AutoSize = true;
            this.metroLabel68.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel68.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel68.Location = new System.Drawing.Point(98, 190);
            this.metroLabel68.Name = "metroLabel68";
            this.metroLabel68.Size = new System.Drawing.Size(58, 24);
            this.metroLabel68.Style = MetroFramework.MetroColorStyle.White;
            this.metroLabel68.TabIndex = 34;
            this.metroLabel68.Text = "D-T-P";
            this.metroLabel68.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroLabel68.UseStyleColors = true;
            // 
            // AutobendDTPToggle
            // 
            this.AutobendDTPToggle.AutoSize = true;
            this.AutobendDTPToggle.Checked = true;
            this.AutobendDTPToggle.CheckState = System.Windows.Forms.CheckState.Checked;
            this.AutobendDTPToggle.FontSize = MetroFramework.MetroLinkSize.Medium;
            this.AutobendDTPToggle.Location = new System.Drawing.Point(193, 193);
            this.AutobendDTPToggle.Name = "AutobendDTPToggle";
            this.AutobendDTPToggle.Size = new System.Drawing.Size(80, 18);
            this.AutobendDTPToggle.TabIndex = 33;
            this.AutobendDTPToggle.Text = "On";
            this.AutobendDTPToggle.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.AutobendDTPToggle.UseSelectable = true;
            // 
            // AutobendHoldBtn
            // 
            this.AutobendHoldBtn.DisplayFocus = true;
            this.AutobendHoldBtn.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.AutobendHoldBtn.Location = new System.Drawing.Point(478, 117);
            this.AutobendHoldBtn.Name = "AutobendHoldBtn";
            this.AutobendHoldBtn.Size = new System.Drawing.Size(91, 29);
            this.AutobendHoldBtn.TabIndex = 39;
            this.AutobendHoldBtn.Text = "STOP";
            this.AutobendHoldBtn.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.AutobendHoldBtn.UseSelectable = true;
            this.AutobendHoldBtn.Click += new System.EventHandler(this.AutobendHoldBtn_Click);
            // 
            // AutobendRunBtn
            // 
            this.AutobendRunBtn.DisplayFocus = true;
            this.AutobendRunBtn.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.AutobendRunBtn.Location = new System.Drawing.Point(478, 79);
            this.AutobendRunBtn.Name = "AutobendRunBtn";
            this.AutobendRunBtn.Size = new System.Drawing.Size(91, 29);
            this.AutobendRunBtn.TabIndex = 38;
            this.AutobendRunBtn.Text = "RUN";
            this.AutobendRunBtn.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.AutobendRunBtn.UseSelectable = true;
            this.AutobendRunBtn.Click += new System.EventHandler(this.AutobendRunBtn_Click);
            // 
            // AutobendStopBtn
            // 
            this.AutobendStopBtn.DisplayFocus = true;
            this.AutobendStopBtn.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.AutobendStopBtn.Location = new System.Drawing.Point(478, 155);
            this.AutobendStopBtn.Name = "AutobendStopBtn";
            this.AutobendStopBtn.Size = new System.Drawing.Size(91, 29);
            this.AutobendStopBtn.TabIndex = 39;
            this.AutobendStopBtn.Text = "STOP / CTR";
            this.AutobendStopBtn.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.AutobendStopBtn.UseSelectable = true;
            this.AutobendStopBtn.Click += new System.EventHandler(this.AutobendStopBtn_Click);
            // 
            // metroTabPage2
            // 
            this.metroTabPage2.BackColor = System.Drawing.Color.Transparent;
            this.metroTabPage2.Controls.Add(this.distPosLabel);
            this.metroTabPage2.Controls.Add(this.distalAngleLabel);
            this.metroTabPage2.Controls.Add(this.tableLayoutPanel8);
            this.metroTabPage2.HorizontalScrollbarBarColor = true;
            this.metroTabPage2.HorizontalScrollbarHighlightOnWheel = false;
            this.metroTabPage2.HorizontalScrollbarSize = 2;
            this.metroTabPage2.Location = new System.Drawing.Point(4, 38);
            this.metroTabPage2.Name = "metroTabPage2";
            this.metroTabPage2.Size = new System.Drawing.Size(578, 248);
            this.metroTabPage2.TabIndex = 4;
            this.metroTabPage2.Text = "BendSetup";
            this.metroTabPage2.UseCustomBackColor = true;
            this.metroTabPage2.UseCustomForeColor = true;
            this.metroTabPage2.VerticalScrollbarBarColor = true;
            this.metroTabPage2.VerticalScrollbarHighlightOnWheel = false;
            this.metroTabPage2.VerticalScrollbarSize = 2;
            // 
            // distPosLabel
            // 
            this.distPosLabel.AutoSize = true;
            this.distPosLabel.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.distPosLabel.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.distPosLabel.Location = new System.Drawing.Point(507, 245);
            this.distPosLabel.Name = "distPosLabel";
            this.distPosLabel.Size = new System.Drawing.Size(205, 25);
            this.distPosLabel.Style = MetroFramework.MetroColorStyle.White;
            this.distPosLabel.TabIndex = 33;
            this.distPosLabel.Text = "Dist Angle POS : 0 , 0 , 0";
            this.distPosLabel.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.distPosLabel.UseStyleColors = true;
            // 
            // distalAngleLabel
            // 
            this.distalAngleLabel.AutoSize = true;
            this.distalAngleLabel.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.distalAngleLabel.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.distalAngleLabel.Location = new System.Drawing.Point(39, 227);
            this.distalAngleLabel.Name = "distalAngleLabel";
            this.distalAngleLabel.Size = new System.Drawing.Size(195, 25);
            this.distalAngleLabel.Style = MetroFramework.MetroColorStyle.White;
            this.distalAngleLabel.TabIndex = 32;
            this.distalAngleLabel.Text = "Dist Angle Vct : 0 , 0 , 0";
            this.distalAngleLabel.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.distalAngleLabel.UseStyleColors = true;
            // 
            // tableLayoutPanel8
            // 
            this.tableLayoutPanel8.ColumnCount = 3;
            this.tableLayoutPanel8.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel8.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tableLayoutPanel8.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tableLayoutPanel8.Controls.Add(this.metroLabel52, 1, 0);
            this.tableLayoutPanel8.Controls.Add(this.bendDiskRadTxtBox, 2, 0);
            this.tableLayoutPanel8.Controls.Add(this.bendTotLengthTxtBox, 2, 1);
            this.tableLayoutPanel8.Controls.Add(this.metroLabel55, 1, 1);
            this.tableLayoutPanel8.Controls.Add(this.metroLabel56, 1, 2);
            this.tableLayoutPanel8.Controls.Add(this.bendProxLenTxtBox, 2, 2);
            this.tableLayoutPanel8.Controls.Add(this.BendSetupSetBtn, 2, 3);
            this.tableLayoutPanel8.Location = new System.Drawing.Point(13, 37);
            this.tableLayoutPanel8.Name = "tableLayoutPanel8";
            this.tableLayoutPanel8.RowCount = 4;
            this.tableLayoutPanel8.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel8.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel8.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel8.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel8.Size = new System.Drawing.Size(330, 135);
            this.tableLayoutPanel8.TabIndex = 32;
            // 
            // metroLabel52
            // 
            this.metroLabel52.AutoSize = true;
            this.metroLabel52.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel52.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel52.Location = new System.Drawing.Point(69, 0);
            this.metroLabel52.Name = "metroLabel52";
            this.metroLabel52.Size = new System.Drawing.Size(82, 25);
            this.metroLabel52.Style = MetroFramework.MetroColorStyle.White;
            this.metroLabel52.TabIndex = 39;
            this.metroLabel52.Text = "Disk Rad";
            this.metroLabel52.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroLabel52.UseStyleColors = true;
            // 
            // bendDiskRadTxtBox
            // 
            // 
            // 
            // 
            this.bendDiskRadTxtBox.CustomButton.Image = null;
            this.bendDiskRadTxtBox.CustomButton.Location = new System.Drawing.Point(61, 1);
            this.bendDiskRadTxtBox.CustomButton.Margin = new System.Windows.Forms.Padding(2);
            this.bendDiskRadTxtBox.CustomButton.Name = "";
            this.bendDiskRadTxtBox.CustomButton.Size = new System.Drawing.Size(16, 16);
            this.bendDiskRadTxtBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.bendDiskRadTxtBox.CustomButton.TabIndex = 1;
            this.bendDiskRadTxtBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.bendDiskRadTxtBox.CustomButton.UseSelectable = true;
            this.bendDiskRadTxtBox.CustomButton.Visible = false;
            this.bendDiskRadTxtBox.Lines = new string[] {
        "3.4"};
            this.bendDiskRadTxtBox.Location = new System.Drawing.Point(201, 3);
            this.bendDiskRadTxtBox.MaxLength = 32767;
            this.bendDiskRadTxtBox.Name = "bendDiskRadTxtBox";
            this.bendDiskRadTxtBox.PasswordChar = '\0';
            this.bendDiskRadTxtBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.bendDiskRadTxtBox.SelectedText = "";
            this.bendDiskRadTxtBox.SelectionLength = 0;
            this.bendDiskRadTxtBox.SelectionStart = 0;
            this.bendDiskRadTxtBox.ShortcutsEnabled = true;
            this.bendDiskRadTxtBox.Size = new System.Drawing.Size(100, 23);
            this.bendDiskRadTxtBox.TabIndex = 34;
            this.bendDiskRadTxtBox.Text = "3.4";
            this.bendDiskRadTxtBox.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.bendDiskRadTxtBox.UseSelectable = true;
            this.bendDiskRadTxtBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.bendDiskRadTxtBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // bendTotLengthTxtBox
            // 
            // 
            // 
            // 
            this.bendTotLengthTxtBox.CustomButton.Image = null;
            this.bendTotLengthTxtBox.CustomButton.Location = new System.Drawing.Point(61, 1);
            this.bendTotLengthTxtBox.CustomButton.Margin = new System.Windows.Forms.Padding(2);
            this.bendTotLengthTxtBox.CustomButton.Name = "";
            this.bendTotLengthTxtBox.CustomButton.Size = new System.Drawing.Size(16, 16);
            this.bendTotLengthTxtBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.bendTotLengthTxtBox.CustomButton.TabIndex = 1;
            this.bendTotLengthTxtBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.bendTotLengthTxtBox.CustomButton.UseSelectable = true;
            this.bendTotLengthTxtBox.CustomButton.Visible = false;
            this.bendTotLengthTxtBox.Lines = new string[] {
        "61"};
            this.bendTotLengthTxtBox.Location = new System.Drawing.Point(201, 36);
            this.bendTotLengthTxtBox.MaxLength = 32767;
            this.bendTotLengthTxtBox.Name = "bendTotLengthTxtBox";
            this.bendTotLengthTxtBox.PasswordChar = '\0';
            this.bendTotLengthTxtBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.bendTotLengthTxtBox.SelectedText = "";
            this.bendTotLengthTxtBox.SelectionLength = 0;
            this.bendTotLengthTxtBox.SelectionStart = 0;
            this.bendTotLengthTxtBox.ShortcutsEnabled = true;
            this.bendTotLengthTxtBox.Size = new System.Drawing.Size(100, 23);
            this.bendTotLengthTxtBox.TabIndex = 36;
            this.bendTotLengthTxtBox.Text = "61";
            this.bendTotLengthTxtBox.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.bendTotLengthTxtBox.UseSelectable = true;
            this.bendTotLengthTxtBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.bendTotLengthTxtBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel55
            // 
            this.metroLabel55.AutoSize = true;
            this.metroLabel55.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel55.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel55.Location = new System.Drawing.Point(69, 33);
            this.metroLabel55.Name = "metroLabel55";
            this.metroLabel55.Size = new System.Drawing.Size(99, 25);
            this.metroLabel55.Style = MetroFramework.MetroColorStyle.White;
            this.metroLabel55.TabIndex = 17;
            this.metroLabel55.Text = "Tot. Length";
            this.metroLabel55.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroLabel55.UseStyleColors = true;
            // 
            // metroLabel56
            // 
            this.metroLabel56.AutoSize = true;
            this.metroLabel56.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel56.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel56.Location = new System.Drawing.Point(69, 66);
            this.metroLabel56.Name = "metroLabel56";
            this.metroLabel56.Size = new System.Drawing.Size(105, 25);
            this.metroLabel56.Style = MetroFramework.MetroColorStyle.White;
            this.metroLabel56.TabIndex = 19;
            this.metroLabel56.Text = "Prox.Length";
            this.metroLabel56.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroLabel56.UseStyleColors = true;
            // 
            // bendProxLenTxtBox
            // 
            // 
            // 
            // 
            this.bendProxLenTxtBox.CustomButton.Image = null;
            this.bendProxLenTxtBox.CustomButton.Location = new System.Drawing.Point(61, 1);
            this.bendProxLenTxtBox.CustomButton.Margin = new System.Windows.Forms.Padding(2);
            this.bendProxLenTxtBox.CustomButton.Name = "";
            this.bendProxLenTxtBox.CustomButton.Size = new System.Drawing.Size(16, 16);
            this.bendProxLenTxtBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.bendProxLenTxtBox.CustomButton.TabIndex = 1;
            this.bendProxLenTxtBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.bendProxLenTxtBox.CustomButton.UseSelectable = true;
            this.bendProxLenTxtBox.CustomButton.Visible = false;
            this.bendProxLenTxtBox.Lines = new string[] {
        "33"};
            this.bendProxLenTxtBox.Location = new System.Drawing.Point(201, 69);
            this.bendProxLenTxtBox.MaxLength = 32767;
            this.bendProxLenTxtBox.Name = "bendProxLenTxtBox";
            this.bendProxLenTxtBox.PasswordChar = '\0';
            this.bendProxLenTxtBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.bendProxLenTxtBox.SelectedText = "";
            this.bendProxLenTxtBox.SelectionLength = 0;
            this.bendProxLenTxtBox.SelectionStart = 0;
            this.bendProxLenTxtBox.ShortcutsEnabled = true;
            this.bendProxLenTxtBox.Size = new System.Drawing.Size(100, 23);
            this.bendProxLenTxtBox.TabIndex = 40;
            this.bendProxLenTxtBox.Text = "33";
            this.bendProxLenTxtBox.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.bendProxLenTxtBox.UseSelectable = true;
            this.bendProxLenTxtBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.bendProxLenTxtBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // BendSetupSetBtn
            // 
            this.BendSetupSetBtn.DisplayFocus = true;
            this.BendSetupSetBtn.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.BendSetupSetBtn.Location = new System.Drawing.Point(201, 102);
            this.BendSetupSetBtn.Name = "BendSetupSetBtn";
            this.BendSetupSetBtn.Size = new System.Drawing.Size(124, 29);
            this.BendSetupSetBtn.TabIndex = 38;
            this.BendSetupSetBtn.Text = "SET";
            this.BendSetupSetBtn.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.BendSetupSetBtn.UseSelectable = true;
            this.BendSetupSetBtn.Click += new System.EventHandler(this.BendSetupSetBtn_Click);
            // 
            // metroTabPage3
            // 
            this.metroTabPage3.BackColor = System.Drawing.Color.Transparent;
            this.metroTabPage3.Controls.Add(this.metroLabel34);
            this.metroTabPage3.HorizontalScrollbarBarColor = true;
            this.metroTabPage3.HorizontalScrollbarHighlightOnWheel = false;
            this.metroTabPage3.HorizontalScrollbarSize = 2;
            this.metroTabPage3.Location = new System.Drawing.Point(4, 38);
            this.metroTabPage3.Name = "metroTabPage3";
            this.metroTabPage3.Size = new System.Drawing.Size(578, 248);
            this.metroTabPage3.TabIndex = 2;
            this.metroTabPage3.Text = "About";
            this.metroTabPage3.UseCustomBackColor = true;
            this.metroTabPage3.VerticalScrollbarBarColor = true;
            this.metroTabPage3.VerticalScrollbarHighlightOnWheel = false;
            this.metroTabPage3.VerticalScrollbarSize = 2;
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
            // posInAccurateLabel
            // 
            this.posInAccurateLabel.AutoSize = true;
            this.posInAccurateLabel.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.posInAccurateLabel.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.posInAccurateLabel.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.posInAccurateLabel.Location = new System.Drawing.Point(3, 0);
            this.posInAccurateLabel.Name = "posInAccurateLabel";
            this.posInAccurateLabel.Size = new System.Drawing.Size(0, 0);
            this.posInAccurateLabel.Style = MetroFramework.MetroColorStyle.Yellow;
            this.posInAccurateLabel.TabIndex = 26;
            this.posInAccurateLabel.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.posInAccurateLabel.UseStyleColors = true;
            // 
            // tableLayoutPanel6
            // 
            this.tableLayoutPanel6.ColumnCount = 2;
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel6.Controls.Add(this.posInAccurateLabel, 0, 0);
            this.tableLayoutPanel6.Controls.Add(this.AutoStepperRunLabel, 1, 0);
            this.tableLayoutPanel6.Controls.Add(this.StepCounterLabel, 1, 1);
            this.tableLayoutPanel6.Location = new System.Drawing.Point(682, 251);
            this.tableLayoutPanel6.Name = "tableLayoutPanel6";
            this.tableLayoutPanel6.RowCount = 2;
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel6.Size = new System.Drawing.Size(339, 64);
            this.tableLayoutPanel6.TabIndex = 27;
            // 
            // AutoStepperRunLabel
            // 
            this.AutoStepperRunLabel.AutoSize = true;
            this.AutoStepperRunLabel.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.AutoStepperRunLabel.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.AutoStepperRunLabel.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.AutoStepperRunLabel.Location = new System.Drawing.Point(172, 0);
            this.AutoStepperRunLabel.Name = "AutoStepperRunLabel";
            this.AutoStepperRunLabel.Size = new System.Drawing.Size(0, 0);
            this.AutoStepperRunLabel.Style = MetroFramework.MetroColorStyle.Green;
            this.AutoStepperRunLabel.TabIndex = 27;
            this.AutoStepperRunLabel.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.AutoStepperRunLabel.UseStyleColors = true;
            // 
            // StepCounterLabel
            // 
            this.StepCounterLabel.AutoSize = true;
            this.StepCounterLabel.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.StepCounterLabel.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.StepCounterLabel.Location = new System.Drawing.Point(172, 32);
            this.StepCounterLabel.Name = "StepCounterLabel";
            this.StepCounterLabel.Size = new System.Drawing.Size(0, 0);
            this.StepCounterLabel.Style = MetroFramework.MetroColorStyle.Lime;
            this.StepCounterLabel.TabIndex = 28;
            this.StepCounterLabel.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.StepCounterLabel.UseStyleColors = true;
            // 
            // metroLabel38
            // 
            this.metroLabel38.AutoSize = true;
            this.metroLabel38.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel38.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel38.Location = new System.Drawing.Point(734, 539);
            this.metroLabel38.Name = "metroLabel38";
            this.metroLabel38.Size = new System.Drawing.Size(110, 25);
            this.metroLabel38.Style = MetroFramework.MetroColorStyle.White;
            this.metroLabel38.TabIndex = 28;
            this.metroLabel38.Text = "Visual Mode";
            this.metroLabel38.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroLabel38.UseStyleColors = true;
            // 
            // setRotRawModeBtn
            // 
            this.setRotRawModeBtn.DisplayFocus = true;
            this.setRotRawModeBtn.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.setRotRawModeBtn.Location = new System.Drawing.Point(734, 573);
            this.setRotRawModeBtn.Name = "setRotRawModeBtn";
            this.setRotRawModeBtn.Size = new System.Drawing.Size(101, 29);
            this.setRotRawModeBtn.TabIndex = 29;
            this.setRotRawModeBtn.Text = "Motor RAW";
            this.setRotRawModeBtn.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.setRotRawModeBtn.UseSelectable = true;
            this.setRotRawModeBtn.Click += new System.EventHandler(this.setRotRawModeBtn_Click);
            // 
            // setTransConvBtn
            // 
            this.setTransConvBtn.DisplayFocus = true;
            this.setTransConvBtn.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.setTransConvBtn.Location = new System.Drawing.Point(853, 573);
            this.setTransConvBtn.Name = "setTransConvBtn";
            this.setTransConvBtn.Size = new System.Drawing.Size(139, 29);
            this.setTransConvBtn.TabIndex = 30;
            this.setTransConvBtn.Text = "Translation CONV";
            this.setTransConvBtn.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.setTransConvBtn.UseSelectable = true;
            this.setTransConvBtn.Click += new System.EventHandler(this.setTransConvBtn_Click);
            // 
            // tableLayoutPanel7
            // 
            this.tableLayoutPanel7.ColumnCount = 3;
            this.tableLayoutPanel7.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel7.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tableLayoutPanel7.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tableLayoutPanel7.Controls.Add(this.seg2DirTxtBox, 2, 2);
            this.tableLayoutPanel7.Controls.Add(this.seg2BendTxtBox, 1, 2);
            this.tableLayoutPanel7.Controls.Add(this.seg1DirTxtBox, 2, 1);
            this.tableLayoutPanel7.Controls.Add(this.seg1BendTxtBox, 1, 1);
            this.tableLayoutPanel7.Controls.Add(this.metroLabel50, 0, 0);
            this.tableLayoutPanel7.Controls.Add(this.metroLabel39, 1, 0);
            this.tableLayoutPanel7.Controls.Add(this.metroLabel41, 2, 0);
            this.tableLayoutPanel7.Controls.Add(this.metroLabel43, 0, 1);
            this.tableLayoutPanel7.Controls.Add(this.metroLabel51, 0, 2);
            this.tableLayoutPanel7.Controls.Add(this.bendCtrSetBtn, 2, 3);
            this.tableLayoutPanel7.Controls.Add(this.bendCtrCenterBtn, 1, 3);
            this.tableLayoutPanel7.Location = new System.Drawing.Point(691, 399);
            this.tableLayoutPanel7.Name = "tableLayoutPanel7";
            this.tableLayoutPanel7.RowCount = 4;
            this.tableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel7.Size = new System.Drawing.Size(330, 135);
            this.tableLayoutPanel7.TabIndex = 31;
            // 
            // seg2DirTxtBox
            // 
            // 
            // 
            // 
            this.seg2DirTxtBox.CustomButton.Image = null;
            this.seg2DirTxtBox.CustomButton.Location = new System.Drawing.Point(78, 1);
            this.seg2DirTxtBox.CustomButton.Margin = new System.Windows.Forms.Padding(2);
            this.seg2DirTxtBox.CustomButton.Name = "";
            this.seg2DirTxtBox.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.seg2DirTxtBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.seg2DirTxtBox.CustomButton.TabIndex = 1;
            this.seg2DirTxtBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.seg2DirTxtBox.CustomButton.UseSelectable = true;
            this.seg2DirTxtBox.CustomButton.Visible = false;
            this.seg2DirTxtBox.Lines = new string[0];
            this.seg2DirTxtBox.Location = new System.Drawing.Point(201, 69);
            this.seg2DirTxtBox.MaxLength = 32767;
            this.seg2DirTxtBox.Name = "seg2DirTxtBox";
            this.seg2DirTxtBox.PasswordChar = '\0';
            this.seg2DirTxtBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.seg2DirTxtBox.SelectedText = "";
            this.seg2DirTxtBox.SelectionLength = 0;
            this.seg2DirTxtBox.SelectionStart = 0;
            this.seg2DirTxtBox.ShortcutsEnabled = true;
            this.seg2DirTxtBox.Size = new System.Drawing.Size(100, 23);
            this.seg2DirTxtBox.TabIndex = 37;
            this.seg2DirTxtBox.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.seg2DirTxtBox.UseSelectable = true;
            this.seg2DirTxtBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.seg2DirTxtBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // seg2BendTxtBox
            // 
            // 
            // 
            // 
            this.seg2BendTxtBox.CustomButton.Image = null;
            this.seg2BendTxtBox.CustomButton.Location = new System.Drawing.Point(78, 1);
            this.seg2BendTxtBox.CustomButton.Margin = new System.Windows.Forms.Padding(2);
            this.seg2BendTxtBox.CustomButton.Name = "";
            this.seg2BendTxtBox.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.seg2BendTxtBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.seg2BendTxtBox.CustomButton.TabIndex = 1;
            this.seg2BendTxtBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.seg2BendTxtBox.CustomButton.UseSelectable = true;
            this.seg2BendTxtBox.CustomButton.Visible = false;
            this.seg2BendTxtBox.Lines = new string[0];
            this.seg2BendTxtBox.Location = new System.Drawing.Point(69, 69);
            this.seg2BendTxtBox.MaxLength = 32767;
            this.seg2BendTxtBox.Name = "seg2BendTxtBox";
            this.seg2BendTxtBox.PasswordChar = '\0';
            this.seg2BendTxtBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.seg2BendTxtBox.SelectedText = "";
            this.seg2BendTxtBox.SelectionLength = 0;
            this.seg2BendTxtBox.SelectionStart = 0;
            this.seg2BendTxtBox.ShortcutsEnabled = true;
            this.seg2BendTxtBox.Size = new System.Drawing.Size(100, 23);
            this.seg2BendTxtBox.TabIndex = 36;
            this.seg2BendTxtBox.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.seg2BendTxtBox.UseSelectable = true;
            this.seg2BendTxtBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.seg2BendTxtBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // seg1DirTxtBox
            // 
            // 
            // 
            // 
            this.seg1DirTxtBox.CustomButton.Image = null;
            this.seg1DirTxtBox.CustomButton.Location = new System.Drawing.Point(78, 1);
            this.seg1DirTxtBox.CustomButton.Margin = new System.Windows.Forms.Padding(2);
            this.seg1DirTxtBox.CustomButton.Name = "";
            this.seg1DirTxtBox.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.seg1DirTxtBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.seg1DirTxtBox.CustomButton.TabIndex = 1;
            this.seg1DirTxtBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.seg1DirTxtBox.CustomButton.UseSelectable = true;
            this.seg1DirTxtBox.CustomButton.Visible = false;
            this.seg1DirTxtBox.Lines = new string[0];
            this.seg1DirTxtBox.Location = new System.Drawing.Point(201, 36);
            this.seg1DirTxtBox.MaxLength = 32767;
            this.seg1DirTxtBox.Name = "seg1DirTxtBox";
            this.seg1DirTxtBox.PasswordChar = '\0';
            this.seg1DirTxtBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.seg1DirTxtBox.SelectedText = "";
            this.seg1DirTxtBox.SelectionLength = 0;
            this.seg1DirTxtBox.SelectionStart = 0;
            this.seg1DirTxtBox.ShortcutsEnabled = true;
            this.seg1DirTxtBox.Size = new System.Drawing.Size(100, 23);
            this.seg1DirTxtBox.TabIndex = 35;
            this.seg1DirTxtBox.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.seg1DirTxtBox.UseSelectable = true;
            this.seg1DirTxtBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.seg1DirTxtBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // seg1BendTxtBox
            // 
            // 
            // 
            // 
            this.seg1BendTxtBox.CustomButton.Image = null;
            this.seg1BendTxtBox.CustomButton.Location = new System.Drawing.Point(78, 1);
            this.seg1BendTxtBox.CustomButton.Margin = new System.Windows.Forms.Padding(2);
            this.seg1BendTxtBox.CustomButton.Name = "";
            this.seg1BendTxtBox.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.seg1BendTxtBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.seg1BendTxtBox.CustomButton.TabIndex = 1;
            this.seg1BendTxtBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.seg1BendTxtBox.CustomButton.UseSelectable = true;
            this.seg1BendTxtBox.CustomButton.Visible = false;
            this.seg1BendTxtBox.Lines = new string[0];
            this.seg1BendTxtBox.Location = new System.Drawing.Point(69, 36);
            this.seg1BendTxtBox.MaxLength = 32767;
            this.seg1BendTxtBox.Name = "seg1BendTxtBox";
            this.seg1BendTxtBox.PasswordChar = '\0';
            this.seg1BendTxtBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.seg1BendTxtBox.SelectedText = "";
            this.seg1BendTxtBox.SelectionLength = 0;
            this.seg1BendTxtBox.SelectionStart = 0;
            this.seg1BendTxtBox.ShortcutsEnabled = true;
            this.seg1BendTxtBox.Size = new System.Drawing.Size(100, 23);
            this.seg1BendTxtBox.TabIndex = 34;
            this.seg1BendTxtBox.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.seg1BendTxtBox.UseSelectable = true;
            this.seg1BendTxtBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.seg1BendTxtBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel50
            // 
            this.metroLabel50.AutoSize = true;
            this.metroLabel50.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel50.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel50.Location = new System.Drawing.Point(3, 0);
            this.metroLabel50.Name = "metroLabel50";
            this.metroLabel50.Size = new System.Drawing.Size(42, 25);
            this.metroLabel50.Style = MetroFramework.MetroColorStyle.White;
            this.metroLabel50.TabIndex = 18;
            this.metroLabel50.Text = "Seg";
            this.metroLabel50.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroLabel50.UseStyleColors = true;
            // 
            // metroLabel39
            // 
            this.metroLabel39.AutoSize = true;
            this.metroLabel39.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel39.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel39.Location = new System.Drawing.Point(69, 0);
            this.metroLabel39.Name = "metroLabel39";
            this.metroLabel39.Size = new System.Drawing.Size(93, 25);
            this.metroLabel39.Style = MetroFramework.MetroColorStyle.White;
            this.metroLabel39.TabIndex = 15;
            this.metroLabel39.Text = "Bend(deg)";
            this.metroLabel39.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroLabel39.UseStyleColors = true;
            // 
            // metroLabel41
            // 
            this.metroLabel41.AutoSize = true;
            this.metroLabel41.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel41.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel41.Location = new System.Drawing.Point(201, 0);
            this.metroLabel41.Name = "metroLabel41";
            this.metroLabel41.Size = new System.Drawing.Size(124, 25);
            this.metroLabel41.Style = MetroFramework.MetroColorStyle.White;
            this.metroLabel41.TabIndex = 16;
            this.metroLabel41.Text = "Direction(deg)";
            this.metroLabel41.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroLabel41.UseStyleColors = true;
            // 
            // metroLabel43
            // 
            this.metroLabel43.AutoSize = true;
            this.metroLabel43.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel43.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel43.Location = new System.Drawing.Point(3, 33);
            this.metroLabel43.Name = "metroLabel43";
            this.metroLabel43.Size = new System.Drawing.Size(47, 25);
            this.metroLabel43.Style = MetroFramework.MetroColorStyle.White;
            this.metroLabel43.TabIndex = 17;
            this.metroLabel43.Text = "Prox";
            this.metroLabel43.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroLabel43.UseStyleColors = true;
            // 
            // metroLabel51
            // 
            this.metroLabel51.AutoSize = true;
            this.metroLabel51.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel51.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel51.Location = new System.Drawing.Point(3, 66);
            this.metroLabel51.Name = "metroLabel51";
            this.metroLabel51.Size = new System.Drawing.Size(43, 25);
            this.metroLabel51.Style = MetroFramework.MetroColorStyle.White;
            this.metroLabel51.TabIndex = 19;
            this.metroLabel51.Text = "Dist";
            this.metroLabel51.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroLabel51.UseStyleColors = true;
            // 
            // bendCtrSetBtn
            // 
            this.bendCtrSetBtn.DisplayFocus = true;
            this.bendCtrSetBtn.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.bendCtrSetBtn.Location = new System.Drawing.Point(201, 102);
            this.bendCtrSetBtn.Name = "bendCtrSetBtn";
            this.bendCtrSetBtn.Size = new System.Drawing.Size(124, 29);
            this.bendCtrSetBtn.TabIndex = 38;
            this.bendCtrSetBtn.Text = "SET";
            this.bendCtrSetBtn.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.bendCtrSetBtn.UseSelectable = true;
            this.bendCtrSetBtn.Click += new System.EventHandler(this.bendCtrSetBtn_Click);
            // 
            // bendCtrCenterBtn
            // 
            this.bendCtrCenterBtn.DisplayFocus = true;
            this.bendCtrCenterBtn.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.bendCtrCenterBtn.Location = new System.Drawing.Point(69, 102);
            this.bendCtrCenterBtn.Name = "bendCtrCenterBtn";
            this.bendCtrCenterBtn.Size = new System.Drawing.Size(126, 29);
            this.bendCtrCenterBtn.TabIndex = 39;
            this.bendCtrCenterBtn.Text = "CENTER";
            this.bendCtrCenterBtn.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.bendCtrCenterBtn.UseSelectable = true;
            this.bendCtrCenterBtn.Click += new System.EventHandler(this.bendCtrCenterBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1147, 634);
            this.Controls.Add(this.tableLayoutPanel7);
            this.Controls.Add(this.setTransConvBtn);
            this.Controls.Add(this.setRotRawModeBtn);
            this.Controls.Add(this.metroLabel38);
            this.Controls.Add(this.tableLayoutPanel6);
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
            this.Text = "EasyTrans";
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
            this.metroTabPage1.ResumeLayout(false);
            this.metroTabPage1.PerformLayout();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.ProgramPage.ResumeLayout(false);
            this.ProgramPage.PerformLayout();
            this.tableLayoutPanel5.ResumeLayout(false);
            this.tableLayoutPanel5.PerformLayout();
            this.AutoBend.ResumeLayout(false);
            this.tableLayoutPanel9.ResumeLayout(false);
            this.tableLayoutPanel9.PerformLayout();
            this.metroTabPage2.ResumeLayout(false);
            this.metroTabPage2.PerformLayout();
            this.tableLayoutPanel8.ResumeLayout(false);
            this.tableLayoutPanel8.PerformLayout();
            this.metroTabPage3.ResumeLayout(false);
            this.metroTabPage3.PerformLayout();
            this.tableLayoutPanel6.ResumeLayout(false);
            this.tableLayoutPanel6.PerformLayout();
            this.tableLayoutPanel7.ResumeLayout(false);
            this.tableLayoutPanel7.PerformLayout();
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
        private MetroFramework.Controls.MetroTabPage metroTabPage1;
        private MetroFramework.Controls.MetroTabPage metroTabPage3;
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
        private System.Windows.Forms.TabPage ProgramPage;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel5;
        private MetroFramework.Controls.MetroLabel metroLabel40;
        private MetroFramework.Controls.MetroToggle PGmt4Toggle;
        private MetroFramework.Controls.MetroLabel metroLabel42;
        private MetroFramework.Controls.MetroLabel metroLabel44;
        private MetroFramework.Controls.MetroToggle PGmt3Toggle;
        private MetroFramework.Controls.MetroLabel metroLabel45;
        private MetroFramework.Controls.MetroToggle PGmt1Toggle;
        private MetroFramework.Controls.MetroToggle PGmt2Toggle;
        private MetroFramework.Controls.MetroLabel metroLabel46;
        private MetroFramework.Controls.MetroLabel metroLabel47;
        private MetroFramework.Controls.MetroLabel metroLabel48;
        private MetroFramework.Controls.MetroLabel metroLabel49;
        private MetroFramework.Controls.MetroTextBox PGmt1FromTxtBox;
        private MetroFramework.Controls.MetroTextBox PGmt3FromTxtBox;
        private MetroFramework.Controls.MetroTextBox PGmt2FromTxtBox;
        private MetroFramework.Controls.MetroTextBox PGmt4FromTxtBox;
        private MetroFramework.Controls.MetroTextBox PGmt1StepTxtBox;
        private MetroFramework.Controls.MetroTextBox PGmt1ToTxtBox;
        private MetroFramework.Controls.MetroTextBox PGmt2ToTxtBox;
        private MetroFramework.Controls.MetroTextBox PGmt3ToTxtBox;
        private MetroFramework.Controls.MetroTextBox PGmt4ToTxtBox;
        private MetroFramework.Controls.MetroTextBox PGmt2StepTxtBox;
        private MetroFramework.Controls.MetroTextBox PGmt3StepTxtBox;
        private MetroFramework.Controls.MetroTextBox PGmt4StepTxtBox;
        private MetroFramework.Controls.MetroButton metroButton2;
        private MetroFramework.Controls.MetroButton metroButton1;
        private MetroFramework.Controls.MetroToggle PGRoundTripToggle;
        private MetroFramework.Controls.MetroLabel metroLabel12;
        private MetroFramework.Controls.MetroLabel metroLabel35;
        private MetroFramework.Controls.MetroTextBox timeIntervalTxtBox;
        private MetroFramework.Controls.MetroLabel metroLabel36;
        private MetroFramework.Controls.MetroTextBox repeatsTxtBox;
        private MetroFramework.Controls.MetroLabel metroLabel37;
        private MetroFramework.Controls.MetroComboBox SetupPresetComboBox;
        private MetroFramework.Controls.MetroLabel posInAccurateLabel;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel6;
        private MetroFramework.Controls.MetroLabel AutoStepperRunLabel;
        private MetroFramework.Controls.MetroLabel StepCounterLabel;
        private MetroFramework.Controls.MetroLabel metroLabel38;
        private MetroFramework.Controls.MetroButton setRotRawModeBtn;
        private MetroFramework.Controls.MetroButton setTransConvBtn;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel7;
        private MetroFramework.Controls.MetroTextBox seg2DirTxtBox;
        private MetroFramework.Controls.MetroTextBox seg2BendTxtBox;
        private MetroFramework.Controls.MetroTextBox seg1DirTxtBox;
        private MetroFramework.Controls.MetroTextBox seg1BendTxtBox;
        private MetroFramework.Controls.MetroLabel metroLabel50;
        private MetroFramework.Controls.MetroLabel metroLabel39;
        private MetroFramework.Controls.MetroLabel metroLabel41;
        private MetroFramework.Controls.MetroLabel metroLabel43;
        private MetroFramework.Controls.MetroLabel metroLabel51;
        private MetroFramework.Controls.MetroButton bendCtrSetBtn;
        private MetroFramework.Controls.MetroButton bendCtrCenterBtn;
        private MetroFramework.Controls.MetroTabPage metroTabPage2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel8;
        private MetroFramework.Controls.MetroTextBox bendTotLengthTxtBox;
        private MetroFramework.Controls.MetroTextBox bendDiskRadTxtBox;
        private MetroFramework.Controls.MetroLabel metroLabel55;
        private MetroFramework.Controls.MetroLabel metroLabel56;
        private MetroFramework.Controls.MetroButton BendSetupSetBtn;
        private MetroFramework.Controls.MetroLabel metroLabel52;
        private MetroFramework.Controls.MetroTextBox bendProxLenTxtBox;
        private MetroFramework.Controls.MetroLabel distalAngleLabel;
        private MetroFramework.Controls.MetroLabel distPosLabel;
        private System.Windows.Forms.TabPage AutoBend;
        private MetroFramework.Controls.MetroLabel metroLabel64;
        private MetroFramework.Controls.MetroToggle AutobendRTripToggle;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel9;
        private MetroFramework.Controls.MetroTextBox DistDirStartTxtBox;
        private MetroFramework.Controls.MetroTextBox DistBendStartTxtBox;
        private MetroFramework.Controls.MetroTextBox ProxDirStartTxtBox;
        private MetroFramework.Controls.MetroTextBox ProxBendStartTxtBox;
        private MetroFramework.Controls.MetroLabel metroLabel53;
        private MetroFramework.Controls.MetroLabel metroLabel54;
        private MetroFramework.Controls.MetroLabel metroLabel57;
        private MetroFramework.Controls.MetroLabel metroLabel58;
        private MetroFramework.Controls.MetroLabel metroLabel59;
        private MetroFramework.Controls.MetroLabel metroLabel60;
        private MetroFramework.Controls.MetroLabel metroLabel61;
        private MetroFramework.Controls.MetroButton AutobendHoldBtn;
        private MetroFramework.Controls.MetroButton AutobendRunBtn;
        private MetroFramework.Controls.MetroTextBox DistBendGoaltTxtBox;
        private MetroFramework.Controls.MetroTextBox DistDirGoalTxtBox;
        private MetroFramework.Controls.MetroTextBox ProxDirGoalTxtBox;
        private MetroFramework.Controls.MetroTextBox ProxBendGoalTxtBox;
        private MetroFramework.Controls.MetroTextBox AutobendIntTxtBox;
        private MetroFramework.Controls.MetroTextBox AutobendRepeatTxtBox;
        private MetroFramework.Controls.MetroLabel metroLabel62;
        private MetroFramework.Controls.MetroLabel metroLabel63;
        private MetroFramework.Controls.MetroLabel metroLabel65;
        private MetroFramework.Controls.MetroLabel metroLabel66;
        private MetroFramework.Controls.MetroTextBox AutobendBendStepTxtBox;
        private MetroFramework.Controls.MetroTextBox AutobendDirStepTxtBox;
        private MetroFramework.Controls.MetroLabel metroLabel68;
        private MetroFramework.Controls.MetroToggle AutobendDTPToggle;
        private MetroFramework.Controls.MetroButton AutobendStopBtn;
    }
}

