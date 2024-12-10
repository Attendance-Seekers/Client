//namespace AttendanceSeekers_client
//{
//    partial class Form1
//    {
//        /// <summary>
//        ///  Required designer variable.
//        /// </summary>
//        private System.ComponentModel.IContainer components = null;

//        /// <summary>
//        ///  Clean up any resources being used.
//        /// </summary>
//        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
//        protected override void Dispose(bool disposing)
//        {
//            if (disposing && (components != null))
//            {
//                components.Dispose();
//            }
//            base.Dispose(disposing);
//        }

//        #region Windows Form Designer generated code

//        /// <summary>
//        ///  Required method for Designer support - do not modify
//        ///  the contents of this method with the code editor.
//        /// </summary>
//        private void InitializeComponent()
//        {
//            components = new System.ComponentModel.Container();
//            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
//            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
//            Bunifu.UI.WinForms.BunifuButton.BunifuIconButton.BorderEdges borderEdges1 = new Bunifu.UI.WinForms.BunifuButton.BunifuIconButton.BorderEdges();
//            dataGridView1 = new DataGridView();
//            button1 = new Button();
//            richTextBox1 = new RichTextBox();
//            studentsToolStripMenuItem = new ToolStripMenuItem();
//            registerANewStudentToolStripMenuItem = new ToolStripMenuItem();
//            retrieveStudentDetailsToolStripMenuItem = new ToolStripMenuItem();
//            retrieveAttendanceRecordForASpecificStudentToolStripMenuItem = new ToolStripMenuItem();
//            classesToolStripMenuItem = new ToolStripMenuItem();
//            createANewClassToolStripMenuItem = new ToolStripMenuItem();
//            listAllClassesToolStripMenuItem = new ToolStripMenuItem();
//            retrieveDetailsOfASpecificClassToolStripMenuItem = new ToolStripMenuItem();
//            attendanceToolStripMenuItem = new ToolStripMenuItem();
//            toolStripMenuItem1 = new ToolStripMenuItem();
//            teachersToolStripMenuItem = new ToolStripMenuItem();
//            notificationsToolStripMenuItem = new ToolStripMenuItem();
//            reportsToolStripMenuItem = new ToolStripMenuItem();
//            menuStrip1 = new MenuStrip();
//            bunifuDropdown1 = new Bunifu.UI.WinForms.BunifuDropdown();
//            bunifuDatePicker1 = new Bunifu.UI.WinForms.BunifuDatePicker();
//            dateTimePicker1 = new DateTimePicker();
//            bunifuFormResizer1 = new Bunifu.UI.WinForms.BunifuFormResizer(components);
//            bunifuIconButton1 = new Bunifu.UI.WinForms.BunifuButton.BunifuIconButton();
//            bunifuToolTip1 = new Bunifu.UI.WinForms.BunifuToolTip(components);
//            bunifuShadowPanel1 = new Bunifu.UI.WinForms.BunifuShadowPanel();
//            bunifuCircleProgress1 = new Bunifu.UI.WinForms.BunifuCircleProgress();
//            colorDialog1 = new ColorDialog();
//            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
//            menuStrip1.SuspendLayout();
//            SuspendLayout();
//            // 
//            // dataGridView1
//            // 
//            dataGridView1.BackgroundColor = SystemColors.MenuHighlight;
//            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
//            dataGridView1.Dock = DockStyle.Bottom;
//            dataGridView1.GridColor = SystemColors.MenuHighlight;
//            dataGridView1.Location = new Point(0, 535);
//            dataGridView1.Name = "dataGridView1";
//            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
//            dataGridViewCellStyle1.BackColor = SystemColors.MenuHighlight;
//            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F);
//            dataGridViewCellStyle1.ForeColor = SystemColors.HighlightText;
//            dataGridViewCellStyle1.SelectionBackColor = SystemColors.ButtonShadow;
//            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
//            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
//            dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle1;
//            dataGridView1.RowHeadersWidth = 51;
//            dataGridView1.Size = new Size(999, 58);
//            dataGridView1.TabIndex = 0;
//            bunifuToolTip1.SetToolTip(dataGridView1, "");
//            bunifuToolTip1.SetToolTipIcon(dataGridView1, null);
//            bunifuToolTip1.SetToolTipTitle(dataGridView1, "");
//            // 
//            // button1
//            // 
//            button1.Location = new Point(528, 366);
//            button1.Name = "button1";
//            button1.Size = new Size(178, 52);
//            button1.TabIndex = 1;
//            button1.Text = "GetClasses";
//            bunifuToolTip1.SetToolTip(button1, "");
//            bunifuToolTip1.SetToolTipIcon(button1, null);
//            bunifuToolTip1.SetToolTipTitle(button1, "");
//            button1.UseVisualStyleBackColor = true;
//            button1.Click += button1_Click;
//            // 
//            // richTextBox1
//            // 
//            richTextBox1.Location = new Point(0, 462);
//            richTextBox1.Name = "richTextBox1";
//            richTextBox1.Size = new Size(306, 73);
//            richTextBox1.TabIndex = 2;
//            richTextBox1.Text = "";
//            bunifuToolTip1.SetToolTip(richTextBox1, "");
//            bunifuToolTip1.SetToolTipIcon(richTextBox1, null);
//            bunifuToolTip1.SetToolTipTitle(richTextBox1, "");
//            // 
//            // studentsToolStripMenuItem
//            // 
//            studentsToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { registerANewStudentToolStripMenuItem, retrieveStudentDetailsToolStripMenuItem, retrieveAttendanceRecordForASpecificStudentToolStripMenuItem });
//            studentsToolStripMenuItem.Name = "studentsToolStripMenuItem";
//            studentsToolStripMenuItem.Size = new Size(80, 24);
//            studentsToolStripMenuItem.Text = "Students";
//            // 
//            // registerANewStudentToolStripMenuItem
//            // 
//            registerANewStudentToolStripMenuItem.Name = "registerANewStudentToolStripMenuItem";
//            registerANewStudentToolStripMenuItem.Size = new Size(413, 26);
//            registerANewStudentToolStripMenuItem.Text = " Register a new student";
//            // 
//            // retrieveStudentDetailsToolStripMenuItem
//            // 
//            retrieveStudentDetailsToolStripMenuItem.Name = "retrieveStudentDetailsToolStripMenuItem";
//            retrieveStudentDetailsToolStripMenuItem.Size = new Size(413, 26);
//            retrieveStudentDetailsToolStripMenuItem.Text = " Retrieve student details";
//            // 
//            // retrieveAttendanceRecordForASpecificStudentToolStripMenuItem
//            // 
//            retrieveAttendanceRecordForASpecificStudentToolStripMenuItem.Name = "retrieveAttendanceRecordForASpecificStudentToolStripMenuItem";
//            retrieveAttendanceRecordForASpecificStudentToolStripMenuItem.Size = new Size(413, 26);
//            retrieveAttendanceRecordForASpecificStudentToolStripMenuItem.Text = "Retrieve attendance record for a specific student";
//            // 
//            // classesToolStripMenuItem
//            // 
//            classesToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { createANewClassToolStripMenuItem, listAllClassesToolStripMenuItem, retrieveDetailsOfASpecificClassToolStripMenuItem });
//            classesToolStripMenuItem.Name = "classesToolStripMenuItem";
//            classesToolStripMenuItem.Size = new Size(70, 24);
//            classesToolStripMenuItem.Text = "Classes";
//            // 
//            // createANewClassToolStripMenuItem
//            // 
//            createANewClassToolStripMenuItem.Name = "createANewClassToolStripMenuItem";
//            createANewClassToolStripMenuItem.Size = new Size(313, 26);
//            createANewClassToolStripMenuItem.Text = "Create a new class";
//            // 
//            // listAllClassesToolStripMenuItem
//            // 
//            listAllClassesToolStripMenuItem.Name = "listAllClassesToolStripMenuItem";
//            listAllClassesToolStripMenuItem.Size = new Size(313, 26);
//            listAllClassesToolStripMenuItem.Text = " List all classes";
//            // 
//            // retrieveDetailsOfASpecificClassToolStripMenuItem
//            // 
//            retrieveDetailsOfASpecificClassToolStripMenuItem.Name = "retrieveDetailsOfASpecificClassToolStripMenuItem";
//            retrieveDetailsOfASpecificClassToolStripMenuItem.Size = new Size(313, 26);
//            retrieveDetailsOfASpecificClassToolStripMenuItem.Text = "Retrieve details of a specific class";
//            // 
//            // attendanceToolStripMenuItem
//            // 
//            attendanceToolStripMenuItem.Name = "attendanceToolStripMenuItem";
//            attendanceToolStripMenuItem.Size = new Size(99, 24);
//            attendanceToolStripMenuItem.Text = "Attendance";
//            // 
//            // toolStripMenuItem1
//            // 
//            toolStripMenuItem1.Name = "toolStripMenuItem1";
//            toolStripMenuItem1.Size = new Size(14, 24);
//            // 
//            // teachersToolStripMenuItem
//            // 
//            teachersToolStripMenuItem.Name = "teachersToolStripMenuItem";
//            teachersToolStripMenuItem.Size = new Size(80, 24);
//            teachersToolStripMenuItem.Text = "Teachers";
//            // 
//            // notificationsToolStripMenuItem
//            // 
//            notificationsToolStripMenuItem.Name = "notificationsToolStripMenuItem";
//            notificationsToolStripMenuItem.Size = new Size(108, 24);
//            notificationsToolStripMenuItem.Text = "Notifications";
//            // 
//            // reportsToolStripMenuItem
//            // 
//            reportsToolStripMenuItem.Name = "reportsToolStripMenuItem";
//            reportsToolStripMenuItem.Size = new Size(74, 24);
//            reportsToolStripMenuItem.Text = "Reports";
//            // 
//            // menuStrip1
//            // 
//            menuStrip1.ImageScalingSize = new Size(20, 20);
//            menuStrip1.Items.AddRange(new ToolStripItem[] { studentsToolStripMenuItem, classesToolStripMenuItem, attendanceToolStripMenuItem, toolStripMenuItem1, teachersToolStripMenuItem, notificationsToolStripMenuItem, reportsToolStripMenuItem });
//            menuStrip1.Location = new Point(0, 0);
//            menuStrip1.Name = "menuStrip1";
//            menuStrip1.Size = new Size(999, 28);
//            menuStrip1.TabIndex = 3;
//            menuStrip1.Text = "menuStrip1";
//            bunifuToolTip1.SetToolTip(menuStrip1, "");
//            bunifuToolTip1.SetToolTipIcon(menuStrip1, null);
//            bunifuToolTip1.SetToolTipTitle(menuStrip1, "");
//            // 
//            // bunifuDropdown1
//            // 
//            bunifuDropdown1.BackColor = Color.Transparent;
//            bunifuDropdown1.BackgroundColor = Color.White;
//            bunifuDropdown1.BorderColor = Color.Silver;
//            bunifuDropdown1.BorderRadius = 1;
//            bunifuDropdown1.Color = Color.Silver;
//            bunifuDropdown1.Direction = Bunifu.UI.WinForms.BunifuDropdown.Directions.Down;
//            bunifuDropdown1.DisabledBackColor = Color.FromArgb(240, 240, 240);
//            bunifuDropdown1.DisabledBorderColor = Color.FromArgb(204, 204, 204);
//            bunifuDropdown1.DisabledColor = Color.FromArgb(240, 240, 240);
//            bunifuDropdown1.DisabledForeColor = Color.FromArgb(109, 109, 109);
//            bunifuDropdown1.DisabledIndicatorColor = Color.DarkGray;
//            bunifuDropdown1.DrawMode = DrawMode.OwnerDrawFixed;
//            bunifuDropdown1.DropdownBorderThickness = Bunifu.UI.WinForms.BunifuDropdown.BorderThickness.Thin;
//            bunifuDropdown1.DropDownStyle = ComboBoxStyle.DropDownList;
//            bunifuDropdown1.DropDownTextAlign = Bunifu.UI.WinForms.BunifuDropdown.TextAlign.Left;
//            bunifuDropdown1.FillDropDown = true;
//            bunifuDropdown1.FillIndicator = false;
//            bunifuDropdown1.FlatStyle = FlatStyle.Flat;
//            bunifuDropdown1.Font = new Font("Segoe UI", 9F);
//            bunifuDropdown1.ForeColor = Color.Black;
//            bunifuDropdown1.FormattingEnabled = true;
//            bunifuDropdown1.Icon = null;
//            bunifuDropdown1.IndicatorAlignment = Bunifu.UI.WinForms.BunifuDropdown.Indicator.Right;
//            bunifuDropdown1.IndicatorColor = Color.DarkGray;
//            bunifuDropdown1.IndicatorLocation = Bunifu.UI.WinForms.BunifuDropdown.Indicator.Right;
//            bunifuDropdown1.IndicatorThickness = 2;
//            bunifuDropdown1.IsDropdownOpened = false;
//            bunifuDropdown1.ItemBackColor = Color.White;
//            bunifuDropdown1.ItemBorderColor = Color.White;
//            bunifuDropdown1.ItemForeColor = Color.Black;
//            bunifuDropdown1.ItemHeight = 26;
//            bunifuDropdown1.ItemHighLightColor = Color.DodgerBlue;
//            bunifuDropdown1.ItemHighLightForeColor = Color.White;
//            bunifuDropdown1.ItemTopMargin = 3;
//            bunifuDropdown1.Location = new Point(464, 76);
//            bunifuDropdown1.Name = "bunifuDropdown1";
//            bunifuDropdown1.Size = new Size(325, 32);
//            bunifuDropdown1.TabIndex = 4;
//            bunifuDropdown1.TextAlignment = Bunifu.UI.WinForms.BunifuDropdown.TextAlign.Left;
//            bunifuDropdown1.TextLeftMargin = 5;
//            bunifuToolTip1.SetToolTip(bunifuDropdown1, "");
//            bunifuToolTip1.SetToolTipIcon(bunifuDropdown1, null);
//            bunifuToolTip1.SetToolTipTitle(bunifuDropdown1, "");
//            // 
//            // bunifuDatePicker1
//            // 
//            bunifuDatePicker1.BackColor = Color.Transparent;
//            bunifuDatePicker1.BorderColor = Color.Silver;
//            bunifuDatePicker1.BorderRadius = 1;
//            bunifuDatePicker1.Color = Color.Silver;
//            bunifuDatePicker1.DateBorderThickness = Bunifu.UI.WinForms.BunifuDatePicker.BorderThickness.Thin;
//            bunifuDatePicker1.DateTextAlign = Bunifu.UI.WinForms.BunifuDatePicker.TextAlign.Left;
//            bunifuDatePicker1.DisabledColor = Color.Gray;
//            bunifuDatePicker1.DisplayWeekNumbers = false;
//            bunifuDatePicker1.DPHeight = 0;
//            bunifuDatePicker1.FillDatePicker = false;
//            bunifuDatePicker1.Font = new Font("Segoe UI", 9F);
//            bunifuDatePicker1.ForeColor = Color.Black;
//            bunifuDatePicker1.Icon = (Image)resources.GetObject("bunifuDatePicker1.Icon");
//            bunifuDatePicker1.IconColor = Color.Gray;
//            bunifuDatePicker1.IconLocation = Bunifu.UI.WinForms.BunifuDatePicker.Indicator.Right;
//            bunifuDatePicker1.LeftTextMargin = 5;
//            bunifuDatePicker1.Location = new Point(154, 76);
//            bunifuDatePicker1.MinimumSize = new Size(0, 32);
//            bunifuDatePicker1.Name = "bunifuDatePicker1";
//            bunifuDatePicker1.Size = new Size(275, 32);
//            bunifuDatePicker1.TabIndex = 5;
//            bunifuToolTip1.SetToolTip(bunifuDatePicker1, "");
//            bunifuToolTip1.SetToolTipIcon(bunifuDatePicker1, null);
//            bunifuToolTip1.SetToolTipTitle(bunifuDatePicker1, "");
//            // 
//            // dateTimePicker1
//            // 
//            dateTimePicker1.Location = new Point(179, 114);
//            dateTimePicker1.Name = "dateTimePicker1";
//            dateTimePicker1.Size = new Size(250, 27);
//            dateTimePicker1.TabIndex = 6;
//            bunifuToolTip1.SetToolTip(dateTimePicker1, "");
//            bunifuToolTip1.SetToolTipIcon(dateTimePicker1, null);
//            bunifuToolTip1.SetToolTipTitle(dateTimePicker1, "");
//            // 
//            // bunifuFormResizer1
//            // 
//            bunifuFormResizer1.ContainerControl = this;
//            bunifuFormResizer1.Enabled = true;
//            bunifuFormResizer1.ParentForm = this;
//            bunifuFormResizer1.ResizeHandlesWidth = 6;
//            // 
//            // bunifuIconButton1
//            // 
//            bunifuIconButton1.AllowAnimations = true;
//            bunifuIconButton1.AllowBorderColorChanges = true;
//            bunifuIconButton1.AllowMouseEffects = true;
//            bunifuIconButton1.AnimationSpeed = 200;
//            bunifuIconButton1.BackColor = Color.Transparent;
//            bunifuIconButton1.BackgroundColor = Color.DodgerBlue;
//            bunifuIconButton1.BorderColor = Color.DodgerBlue;
//            bunifuIconButton1.BorderRadius = 1;
//            bunifuIconButton1.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuIconButton.BorderStyles.Solid;
//            bunifuIconButton1.BorderThickness = 1;
//            bunifuIconButton1.ColorContrastOnClick = 30;
//            bunifuIconButton1.ColorContrastOnHover = 30;
//            borderEdges1.BottomLeft = true;
//            borderEdges1.BottomRight = true;
//            borderEdges1.TopLeft = true;
//            borderEdges1.TopRight = true;
//            bunifuIconButton1.CustomizableEdges = borderEdges1;
//            bunifuIconButton1.DialogResult = DialogResult.None;
//            bunifuIconButton1.Image = (Image)resources.GetObject("bunifuIconButton1.Image");
//            bunifuIconButton1.ImageMargin = new Padding(0, 0, 0, 0);
//            bunifuIconButton1.Location = new Point(559, 166);
//            bunifuIconButton1.Name = "bunifuIconButton1";
//            bunifuIconButton1.RoundBorders = true;
//            bunifuIconButton1.ShowBorders = true;
//            bunifuIconButton1.Size = new Size(44, 44);
//            bunifuIconButton1.Style = Bunifu.UI.WinForms.BunifuButton.BunifuIconButton.ButtonStyles.Round;
//            bunifuIconButton1.TabIndex = 7;
//            bunifuToolTip1.SetToolTip(bunifuIconButton1, "");
//            bunifuToolTip1.SetToolTipIcon(bunifuIconButton1, null);
//            bunifuToolTip1.SetToolTipTitle(bunifuIconButton1, "");
//            // 
//            // bunifuToolTip1
//            // 
//            bunifuToolTip1.Active = true;
//            bunifuToolTip1.AlignTextWithTitle = false;
//            bunifuToolTip1.AllowAutoClose = false;
//            bunifuToolTip1.AllowFading = true;
//            bunifuToolTip1.AutoCloseDuration = 5000;
//            bunifuToolTip1.BackColor = SystemColors.Control;
//            bunifuToolTip1.BorderColor = Color.Gainsboro;
//            bunifuToolTip1.ClickToShowDisplayControl = false;
//            bunifuToolTip1.ConvertNewlinesToBreakTags = true;
//            bunifuToolTip1.DisplayControl = null;
//            bunifuToolTip1.EntryAnimationSpeed = 350;
//            bunifuToolTip1.ExitAnimationSpeed = 200;
//            bunifuToolTip1.GenerateAutoCloseDuration = false;
//            bunifuToolTip1.IconMargin = 6;
//            bunifuToolTip1.InitialDelay = 0;
//            bunifuToolTip1.Name = "bunifuToolTip1";
//            bunifuToolTip1.Opacity = 1D;
//            bunifuToolTip1.OverrideToolTipTitles = false;
//            bunifuToolTip1.Padding = new Padding(10);
//            bunifuToolTip1.ReshowDelay = 100;
//            bunifuToolTip1.ShowAlways = true;
//            bunifuToolTip1.ShowBorders = false;
//            bunifuToolTip1.ShowIcons = true;
//            bunifuToolTip1.ShowShadows = true;
//            bunifuToolTip1.Tag = null;
//            bunifuToolTip1.TextFont = new Font("Segoe UI", 9F);
//            bunifuToolTip1.TextForeColor = Color.FromArgb(64, 64, 64);
//            bunifuToolTip1.TextMargin = 2;
//            bunifuToolTip1.TitleFont = new Font("Segoe UI", 9F, FontStyle.Bold);
//            bunifuToolTip1.TitleForeColor = Color.Black;
//            bunifuToolTip1.ToolTipPosition = new Point(0, 0);
//            bunifuToolTip1.ToolTipTitle = null;
//            // 
//            // bunifuShadowPanel1
//            // 
//            bunifuShadowPanel1.BackColor = Color.Transparent;
//            bunifuShadowPanel1.BorderColor = Color.WhiteSmoke;
//            bunifuShadowPanel1.BorderRadius = 1;
//            bunifuShadowPanel1.BorderThickness = 1;
//            bunifuShadowPanel1.FillStyle = Bunifu.UI.WinForms.BunifuShadowPanel.FillStyles.Solid;
//            bunifuShadowPanel1.GradientMode = Bunifu.UI.WinForms.BunifuShadowPanel.GradientModes.Vertical;
//            bunifuShadowPanel1.Location = new Point(54, 147);
//            bunifuShadowPanel1.Name = "bunifuShadowPanel1";
//            bunifuShadowPanel1.PanelColor = Color.WhiteSmoke;
//            bunifuShadowPanel1.PanelColor2 = Color.WhiteSmoke;
//            bunifuShadowPanel1.ShadowColor = Color.DarkGray;
//            bunifuShadowPanel1.ShadowDept = 2;
//            bunifuShadowPanel1.ShadowDepth = 5;
//            bunifuShadowPanel1.ShadowStyle = Bunifu.UI.WinForms.BunifuShadowPanel.ShadowStyles.Surrounded;
//            bunifuShadowPanel1.ShadowTopLeftVisible = false;
//            bunifuShadowPanel1.Size = new Size(375, 288);
//            bunifuShadowPanel1.Style = Bunifu.UI.WinForms.BunifuShadowPanel.BevelStyles.Flat;
//            bunifuShadowPanel1.TabIndex = 8;
//            bunifuToolTip1.SetToolTip(bunifuShadowPanel1, "");
//            bunifuToolTip1.SetToolTipIcon(bunifuShadowPanel1, null);
//            bunifuToolTip1.SetToolTipTitle(bunifuShadowPanel1, "");
//            // 
//            // bunifuCircleProgress1
//            // 
//            bunifuCircleProgress1.Animated = false;
//            bunifuCircleProgress1.AnimationInterval = 1;
//            bunifuCircleProgress1.AnimationSpeed = 1;
//            bunifuCircleProgress1.BackColor = Color.Transparent;
//            bunifuCircleProgress1.CircleMargin = 10;
//            bunifuCircleProgress1.Font = new Font("Microsoft Sans Serif", 40F, FontStyle.Bold);
//            bunifuCircleProgress1.ForeColor = Color.FromArgb(64, 64, 64);
//            bunifuCircleProgress1.IsPercentage = false;
//            bunifuCircleProgress1.LineProgressThickness = 10;
//            bunifuCircleProgress1.LineThickness = 10;
//            bunifuCircleProgress1.Location = new Point(767, 193);
//            bunifuCircleProgress1.Name = "bunifuCircleProgress1";
//            bunifuCircleProgress1.ProgressAnimationSpeed = 200;
//            bunifuCircleProgress1.ProgressBackColor = Color.Gainsboro;
//            bunifuCircleProgress1.ProgressColor = Color.DodgerBlue;
//            bunifuCircleProgress1.ProgressColor2 = Color.DodgerBlue;
//            bunifuCircleProgress1.ProgressEndCap = Bunifu.UI.WinForms.BunifuCircleProgress.CapStyles.Round;
//            bunifuCircleProgress1.ProgressFillStyle = Bunifu.UI.WinForms.BunifuCircleProgress.FillStyles.Solid;
//            bunifuCircleProgress1.ProgressStartCap = Bunifu.UI.WinForms.BunifuCircleProgress.CapStyles.Round;
//            bunifuCircleProgress1.SecondaryFont = new Font("Microsoft Sans Serif", 16F);
//            bunifuCircleProgress1.Size = new Size(230, 230);
//            bunifuCircleProgress1.SubScriptColor = Color.FromArgb(166, 166, 166);
//            bunifuCircleProgress1.SubScriptMargin = new Padding(5, -20, 0, 0);
//            bunifuCircleProgress1.SubScriptText = ".00";
//            bunifuCircleProgress1.SuperScriptColor = Color.FromArgb(166, 166, 166);
//            bunifuCircleProgress1.SuperScriptMargin = new Padding(5, 20, 0, 0);
//            bunifuCircleProgress1.SuperScriptText = "°C";
//            bunifuCircleProgress1.TabIndex = 16;
//            bunifuCircleProgress1.Text = "30";
//            bunifuCircleProgress1.TextMargin = new Padding(0, 5, 0, 0);
//            bunifuToolTip1.SetToolTip(bunifuCircleProgress1, "");
//            bunifuToolTip1.SetToolTipIcon(bunifuCircleProgress1, null);
//            bunifuToolTip1.SetToolTipTitle(bunifuCircleProgress1, "");
//            bunifuCircleProgress1.Value = 30;
//            bunifuCircleProgress1.ValueByTransition = 30;
//            bunifuCircleProgress1.ValueMargin = new Padding(0, 5, 0, 0);
//            // 
//            // Form1
//            // 
//            AutoScaleDimensions = new SizeF(8F, 20F);
//            AutoScaleMode = AutoScaleMode.Font;
//            ClientSize = new Size(999, 593);
//            Controls.Add(bunifuCircleProgress1);
//            Controls.Add(bunifuShadowPanel1);
//            Controls.Add(bunifuIconButton1);
//            Controls.Add(dateTimePicker1);
//            Controls.Add(bunifuDatePicker1);
//            Controls.Add(bunifuDropdown1);
//            Controls.Add(richTextBox1);
//            Controls.Add(button1);
//            Controls.Add(dataGridView1);
//            Controls.Add(menuStrip1);
//            MainMenuStrip = menuStrip1;
//            Name = "Form1";
//            Text = "Form1";
//            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
//            menuStrip1.ResumeLayout(false);
//            menuStrip1.PerformLayout();
//            ResumeLayout(false);
//            PerformLayout();
//        }

//        #endregion

//        private DataGridView dataGridView1;
//        private Button button1;
//        private RichTextBox richTextBox1;
//        private ToolStripMenuItem studentsToolStripMenuItem;
//        private ToolStripMenuItem registerANewStudentToolStripMenuItem;
//        private ToolStripMenuItem retrieveStudentDetailsToolStripMenuItem;
//        private ToolStripMenuItem retrieveAttendanceRecordForASpecificStudentToolStripMenuItem;
//        private ToolStripMenuItem classesToolStripMenuItem;
//        private ToolStripMenuItem createANewClassToolStripMenuItem;
//        private ToolStripMenuItem listAllClassesToolStripMenuItem;
//        private ToolStripMenuItem retrieveDetailsOfASpecificClassToolStripMenuItem;
//        private ToolStripMenuItem attendanceToolStripMenuItem;
//        private ToolStripMenuItem toolStripMenuItem1;
//        private ToolStripMenuItem teachersToolStripMenuItem;
//        private ToolStripMenuItem notificationsToolStripMenuItem;
//        private ToolStripMenuItem reportsToolStripMenuItem;
//        private MenuStrip menuStrip1;
//        private Bunifu.UI.WinForms.BunifuToolTip bunifuToolTip1;
//        private Bunifu.UI.WinForms.BunifuDropdown bunifuDropdown1;
//        private Bunifu.UI.WinForms.BunifuDatePicker bunifuDatePicker1;
//        private DateTimePicker dateTimePicker1;
//        private Bunifu.UI.WinForms.BunifuFormResizer bunifuFormResizer1;
//        private Bunifu.UI.WinForms.BunifuCircleProgress bunifuCircleProgress1;
//        private Bunifu.UI.WinForms.BunifuShadowPanel bunifuShadowPanel1;
//        private Bunifu.UI.WinForms.BunifuButton.BunifuIconButton bunifuIconButton1;
//        private ColorDialog colorDialog1;
//    }
//}
