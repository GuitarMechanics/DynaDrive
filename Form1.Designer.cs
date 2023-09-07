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
            this.metroComboBox1 = new MetroFramework.Controls.MetroComboBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroComboBox2 = new MetroFramework.Controls.MetroComboBox();
            this.serialOpenBtn = new MetroFramework.Controls.MetroButton();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
            this.metroButton2 = new MetroFramework.Controls.MetroButton();
            this.metroTextBox3 = new MetroFramework.Controls.MetroTextBox();
            this.metroTextBox1 = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel7 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel8 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel9 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel10 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel11 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel12 = new MetroFramework.Controls.MetroLabel();
            this.mt1Toggle = new MetroFramework.Controls.MetroToggle();
            this.mt2Toggle = new MetroFramework.Controls.MetroToggle();
            this.mt3Toggle = new MetroFramework.Controls.MetroToggle();
            this.mt4Toggle = new MetroFramework.Controls.MetroToggle();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.targetLabel1 = new MetroFramework.Controls.MetroLabel();
            this.targetLabel2 = new MetroFramework.Controls.MetroLabel();
            this.targetLabel3 = new MetroFramework.Controls.MetroLabel();
            this.targetLabel4 = new MetroFramework.Controls.MetroLabel();
            this.currentLabel1 = new MetroFramework.Controls.MetroLabel();
            this.currentLabel2 = new MetroFramework.Controls.MetroLabel();
            this.currentLabel3 = new MetroFramework.Controls.MetroLabel();
            this.currentLabel4 = new MetroFramework.Controls.MetroLabel();
            this.diffLabel4 = new MetroFramework.Controls.MetroLabel();
            this.diffLabel2 = new MetroFramework.Controls.MetroLabel();
            this.diffLabel3 = new MetroFramework.Controls.MetroLabel();
            this.diffLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroTabControl1 = new MetroFramework.Controls.MetroTabControl();
            this.metroTabPage1 = new MetroFramework.Controls.MetroTabPage();
            this.metroTabPage3 = new MetroFramework.Controls.MetroTabPage();
            this.metroLabel13 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel14 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel15 = new MetroFramework.Controls.MetroLabel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.mt1DirectTxtBox = new MetroFramework.Controls.MetroTextBox();
            this.mt2DirectTxtBox = new MetroFramework.Controls.MetroTextBox();
            this.mt3DirectTxtBox = new MetroFramework.Controls.MetroTextBox();
            this.mt4DirectTxtBox = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel16 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel17 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel18 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel19 = new MetroFramework.Controls.MetroLabel();
            this.dirGoBtn = new MetroFramework.Controls.MetroButton();
            Setup = new MetroFramework.Controls.MetroTabPage();
            this.tableLayoutPanel1.SuspendLayout();
            this.metroTabControl1.SuspendLayout();
            this.metroTabPage1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // metroComboBox1
            // 
            this.metroComboBox1.ItemHeight = 23;
            this.metroComboBox1.Location = new System.Drawing.Point(146, 88);
            this.metroComboBox1.Name = "metroComboBox1";
            this.metroComboBox1.Size = new System.Drawing.Size(121, 29);
            this.metroComboBox1.TabIndex = 0;
            this.metroComboBox1.UseSelectable = true;
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
            this.metroComboBox2.TabIndex = 3;
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
            // metroButton2
            // 
            this.metroButton2.DisplayFocus = true;
            this.metroButton2.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.metroButton2.Location = new System.Drawing.Point(920, 111);
            this.metroButton2.Name = "metroButton2";
            this.metroButton2.Size = new System.Drawing.Size(101, 29);
            this.metroButton2.TabIndex = 9;
            this.metroButton2.Text = "metroButton2";
            this.metroButton2.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroButton2.UseSelectable = true;
            // 
            // metroTextBox3
            // 
            // 
            // 
            // 
            this.metroTextBox3.CustomButton.Image = null;
            this.metroTextBox3.CustomButton.Location = new System.Drawing.Point(224, 1);
            this.metroTextBox3.CustomButton.Name = "";
            this.metroTextBox3.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.metroTextBox3.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroTextBox3.CustomButton.TabIndex = 1;
            this.metroTextBox3.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroTextBox3.CustomButton.UseSelectable = true;
            this.metroTextBox3.CustomButton.Visible = false;
            this.metroTextBox3.Lines = new string[] {
        "metroTextBox3"};
            this.metroTextBox3.Location = new System.Drawing.Point(775, 301);
            this.metroTextBox3.MaxLength = 32767;
            this.metroTextBox3.Name = "metroTextBox3";
            this.metroTextBox3.PasswordChar = '\0';
            this.metroTextBox3.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.metroTextBox3.SelectedText = "";
            this.metroTextBox3.SelectionLength = 0;
            this.metroTextBox3.SelectionStart = 0;
            this.metroTextBox3.ShortcutsEnabled = true;
            this.metroTextBox3.Size = new System.Drawing.Size(246, 23);
            this.metroTextBox3.TabIndex = 12;
            this.metroTextBox3.Text = "metroTextBox3";
            this.metroTextBox3.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroTextBox3.UseSelectable = true;
            this.metroTextBox3.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.metroTextBox3.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
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
            this.metroTextBox1.Lines = new string[] {
        "metroTextBox1"};
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
            this.metroTextBox1.Text = "metroTextBox1";
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
            // metroLabel12
            // 
            this.metroLabel12.AutoSize = true;
            this.metroLabel12.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel12.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel12.Location = new System.Drawing.Point(775, 381);
            this.metroLabel12.Name = "metroLabel12";
            this.metroLabel12.Size = new System.Drawing.Size(121, 25);
            this.metroLabel12.Style = MetroFramework.MetroColorStyle.White;
            this.metroLabel12.TabIndex = 19;
            this.metroLabel12.Text = "metroLabel12";
            this.metroLabel12.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroLabel12.UseStyleColors = true;
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
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 80F));
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
            this.tableLayoutPanel1.Size = new System.Drawing.Size(586, 156);
            this.tableLayoutPanel1.TabIndex = 24;
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
            // metroTabControl1
            // 
            this.metroTabControl1.Controls.Add(this.metroTabPage1);
            this.metroTabControl1.Controls.Add(Setup);
            this.metroTabControl1.Controls.Add(this.metroTabPage3);
            this.metroTabControl1.Location = new System.Drawing.Point(79, 320);
            this.metroTabControl1.Name = "metroTabControl1";
            this.metroTabControl1.SelectedIndex = 0;
            this.metroTabControl1.Size = new System.Drawing.Size(586, 290);
            this.metroTabControl1.TabIndex = 25;
            this.metroTabControl1.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroTabControl1.UseSelectable = true;
            // 
            // metroTabPage1
            // 
            this.metroTabPage1.BackColor = System.Drawing.Color.Transparent;
            this.metroTabPage1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.metroTabPage1.Controls.Add(this.dirGoBtn);
            this.metroTabPage1.Controls.Add(this.tableLayoutPanel2);
            this.metroTabPage1.Controls.Add(this.metroLabel15);
            this.metroTabPage1.Controls.Add(this.metroLabel14);
            this.metroTabPage1.Controls.Add(this.metroLabel13);
            this.metroTabPage1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.metroTabPage1.HorizontalScrollbarBarColor = true;
            this.metroTabPage1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroTabPage1.HorizontalScrollbarSize = 10;
            this.metroTabPage1.ImageKey = "(없음)";
            this.metroTabPage1.Location = new System.Drawing.Point(4, 38);
            this.metroTabPage1.Name = "metroTabPage1";
            this.metroTabPage1.Size = new System.Drawing.Size(578, 248);
            this.metroTabPage1.TabIndex = 0;
            this.metroTabPage1.Text = "Control";
            this.metroTabPage1.UseCustomBackColor = true;
            this.metroTabPage1.VerticalScrollbarBarColor = true;
            this.metroTabPage1.VerticalScrollbarHighlightOnWheel = false;
            this.metroTabPage1.VerticalScrollbarSize = 10;
            // 
            // Setup
            // 
            Setup.BackColor = System.Drawing.Color.Transparent;
            Setup.HorizontalScrollbarBarColor = true;
            Setup.HorizontalScrollbarHighlightOnWheel = false;
            Setup.HorizontalScrollbarSize = 10;
            Setup.Location = new System.Drawing.Point(4, 38);
            Setup.Name = "Setup";
            Setup.Size = new System.Drawing.Size(578, 248);
            Setup.TabIndex = 1;
            Setup.Text = "Setup";
            Setup.UseCustomBackColor = true;
            Setup.VerticalScrollbarBarColor = true;
            Setup.VerticalScrollbarHighlightOnWheel = false;
            Setup.VerticalScrollbarSize = 10;
            // 
            // metroTabPage3
            // 
            this.metroTabPage3.BackColor = System.Drawing.Color.Transparent;
            this.metroTabPage3.HorizontalScrollbarBarColor = true;
            this.metroTabPage3.HorizontalScrollbarHighlightOnWheel = false;
            this.metroTabPage3.HorizontalScrollbarSize = 10;
            this.metroTabPage3.Location = new System.Drawing.Point(4, 38);
            this.metroTabPage3.Name = "metroTabPage3";
            this.metroTabPage3.Size = new System.Drawing.Size(578, 248);
            this.metroTabPage3.TabIndex = 2;
            this.metroTabPage3.Text = "About";
            this.metroTabPage3.UseCustomBackColor = true;
            this.metroTabPage3.VerticalScrollbarBarColor = true;
            this.metroTabPage3.VerticalScrollbarHighlightOnWheel = false;
            this.metroTabPage3.VerticalScrollbarSize = 10;
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
            // metroLabel14
            // 
            this.metroLabel14.AutoSize = true;
            this.metroLabel14.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel14.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel14.Location = new System.Drawing.Point(190, 9);
            this.metroLabel14.Name = "metroLabel14";
            this.metroLabel14.Size = new System.Drawing.Size(47, 25);
            this.metroLabel14.Style = MetroFramework.MetroColorStyle.White;
            this.metroLabel14.TabIndex = 27;
            this.metroLabel14.Text = "Step";
            this.metroLabel14.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroLabel14.UseStyleColors = true;
            // 
            // metroLabel15
            // 
            this.metroLabel15.AutoSize = true;
            this.metroLabel15.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel15.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel15.Location = new System.Drawing.Point(384, 9);
            this.metroLabel15.Name = "metroLabel15";
            this.metroLabel15.Size = new System.Drawing.Size(121, 25);
            this.metroLabel15.Style = MetroFramework.MetroColorStyle.White;
            this.metroLabel15.TabIndex = 28;
            this.metroLabel15.Text = "metroLabel15";
            this.metroLabel15.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroLabel15.UseStyleColors = true;
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
            // mt1DirectTxtBox
            // 
            // 
            // 
            // 
            this.mt1DirectTxtBox.CustomButton.Image = null;
            this.mt1DirectTxtBox.CustomButton.Location = new System.Drawing.Point(78, 1);
            this.mt1DirectTxtBox.CustomButton.Name = "";
            this.mt1DirectTxtBox.CustomButton.Size = new System.Drawing.Size(21, 21);
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
            this.mt2DirectTxtBox.CustomButton.Location = new System.Drawing.Point(78, 1);
            this.mt2DirectTxtBox.CustomButton.Name = "";
            this.mt2DirectTxtBox.CustomButton.Size = new System.Drawing.Size(21, 21);
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
            this.mt3DirectTxtBox.CustomButton.Location = new System.Drawing.Point(78, 1);
            this.mt3DirectTxtBox.CustomButton.Name = "";
            this.mt3DirectTxtBox.CustomButton.Size = new System.Drawing.Size(21, 21);
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
            this.mt4DirectTxtBox.CustomButton.Location = new System.Drawing.Point(78, 1);
            this.mt4DirectTxtBox.CustomButton.Name = "";
            this.mt4DirectTxtBox.CustomButton.Size = new System.Drawing.Size(21, 21);
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
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1093, 634);
            this.Controls.Add(this.metroTabControl1);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.metroLabel12);
            this.Controls.Add(this.metroLabel7);
            this.Controls.Add(this.metroTextBox1);
            this.Controls.Add(this.metroTextBox3);
            this.Controls.Add(this.metroButton2);
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
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.metroTabControl1.ResumeLayout(false);
            this.metroTabPage1.ResumeLayout(false);
            this.metroTabPage1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
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
        private MetroFramework.Controls.MetroButton metroButton2;
        private MetroFramework.Controls.MetroTextBox metroTextBox3;
        private MetroFramework.Controls.MetroTextBox metroTextBox1;
        private MetroFramework.Controls.MetroLabel metroLabel7;
        private MetroFramework.Controls.MetroLabel metroLabel8;
        private MetroFramework.Controls.MetroLabel metroLabel9;
        private MetroFramework.Controls.MetroLabel metroLabel10;
        private MetroFramework.Controls.MetroLabel metroLabel11;
        private MetroFramework.Controls.MetroLabel metroLabel12;
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
    }
}

