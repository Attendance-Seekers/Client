namespace AttendanceSeekers_client
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            dataGridView1 = new DataGridView();
            button1 = new Button();
            richTextBox1 = new RichTextBox();
            studentsToolStripMenuItem = new ToolStripMenuItem();
            registerANewStudentToolStripMenuItem = new ToolStripMenuItem();
            retrieveStudentDetailsToolStripMenuItem = new ToolStripMenuItem();
            retrieveAttendanceRecordForASpecificStudentToolStripMenuItem = new ToolStripMenuItem();
            classesToolStripMenuItem = new ToolStripMenuItem();
            createANewClassToolStripMenuItem = new ToolStripMenuItem();
            listAllClassesToolStripMenuItem = new ToolStripMenuItem();
            retrieveDetailsOfASpecificClassToolStripMenuItem = new ToolStripMenuItem();
            attendanceToolStripMenuItem = new ToolStripMenuItem();
            toolStripMenuItem1 = new ToolStripMenuItem();
            teachersToolStripMenuItem = new ToolStripMenuItem();
            notificationsToolStripMenuItem = new ToolStripMenuItem();
            reportsToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1 = new MenuStrip();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = SystemColors.MenuHighlight;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Dock = DockStyle.Bottom;
            dataGridView1.GridColor = SystemColors.MenuHighlight;
            dataGridView1.Location = new Point(0, 535);
            dataGridView1.Name = "dataGridView1";
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.MenuHighlight;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle1.ForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.ButtonShadow;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(999, 58);
            dataGridView1.TabIndex = 0;
            // 
            // button1
            // 
            button1.Location = new Point(528, 366);
            button1.Name = "button1";
            button1.Size = new Size(178, 52);
            button1.TabIndex = 1;
            button1.Text = "GetClasses";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // richTextBox1
            // 
            richTextBox1.Location = new Point(0, 462);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(306, 73);
            richTextBox1.TabIndex = 2;
            richTextBox1.Text = "";
            // 
            // studentsToolStripMenuItem
            // 
            studentsToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { registerANewStudentToolStripMenuItem, retrieveStudentDetailsToolStripMenuItem, retrieveAttendanceRecordForASpecificStudentToolStripMenuItem });
            studentsToolStripMenuItem.Name = "studentsToolStripMenuItem";
            studentsToolStripMenuItem.Size = new Size(80, 24);
            studentsToolStripMenuItem.Text = "Students";
            // 
            // registerANewStudentToolStripMenuItem
            // 
            registerANewStudentToolStripMenuItem.Name = "registerANewStudentToolStripMenuItem";
            registerANewStudentToolStripMenuItem.Size = new Size(413, 26);
            registerANewStudentToolStripMenuItem.Text = " Register a new student";
            // 
            // retrieveStudentDetailsToolStripMenuItem
            // 
            retrieveStudentDetailsToolStripMenuItem.Name = "retrieveStudentDetailsToolStripMenuItem";
            retrieveStudentDetailsToolStripMenuItem.Size = new Size(413, 26);
            retrieveStudentDetailsToolStripMenuItem.Text = " Retrieve student details";
            // 
            // retrieveAttendanceRecordForASpecificStudentToolStripMenuItem
            // 
            retrieveAttendanceRecordForASpecificStudentToolStripMenuItem.Name = "retrieveAttendanceRecordForASpecificStudentToolStripMenuItem";
            retrieveAttendanceRecordForASpecificStudentToolStripMenuItem.Size = new Size(413, 26);
            retrieveAttendanceRecordForASpecificStudentToolStripMenuItem.Text = "Retrieve attendance record for a specific student";
            // 
            // classesToolStripMenuItem
            // 
            classesToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { createANewClassToolStripMenuItem, listAllClassesToolStripMenuItem, retrieveDetailsOfASpecificClassToolStripMenuItem });
            classesToolStripMenuItem.Name = "classesToolStripMenuItem";
            classesToolStripMenuItem.Size = new Size(70, 24);
            classesToolStripMenuItem.Text = "Classes";
            // 
            // createANewClassToolStripMenuItem
            // 
            createANewClassToolStripMenuItem.Name = "createANewClassToolStripMenuItem";
            createANewClassToolStripMenuItem.Size = new Size(313, 26);
            createANewClassToolStripMenuItem.Text = "Create a new class";
            // 
            // listAllClassesToolStripMenuItem
            // 
            listAllClassesToolStripMenuItem.Name = "listAllClassesToolStripMenuItem";
            listAllClassesToolStripMenuItem.Size = new Size(313, 26);
            listAllClassesToolStripMenuItem.Text = " List all classes";
            // 
            // retrieveDetailsOfASpecificClassToolStripMenuItem
            // 
            retrieveDetailsOfASpecificClassToolStripMenuItem.Name = "retrieveDetailsOfASpecificClassToolStripMenuItem";
            retrieveDetailsOfASpecificClassToolStripMenuItem.Size = new Size(313, 26);
            retrieveDetailsOfASpecificClassToolStripMenuItem.Text = "Retrieve details of a specific class";
            // 
            // attendanceToolStripMenuItem
            // 
            attendanceToolStripMenuItem.Name = "attendanceToolStripMenuItem";
            attendanceToolStripMenuItem.Size = new Size(99, 24);
            attendanceToolStripMenuItem.Text = "Attendance";
            // 
            // toolStripMenuItem1
            // 
            toolStripMenuItem1.Name = "toolStripMenuItem1";
            toolStripMenuItem1.Size = new Size(14, 24);
            // 
            // teachersToolStripMenuItem
            // 
            teachersToolStripMenuItem.Name = "teachersToolStripMenuItem";
            teachersToolStripMenuItem.Size = new Size(80, 24);
            teachersToolStripMenuItem.Text = "Teachers";
            // 
            // notificationsToolStripMenuItem
            // 
            notificationsToolStripMenuItem.Name = "notificationsToolStripMenuItem";
            notificationsToolStripMenuItem.Size = new Size(108, 24);
            notificationsToolStripMenuItem.Text = "Notifications";
            // 
            // reportsToolStripMenuItem
            // 
            reportsToolStripMenuItem.Name = "reportsToolStripMenuItem";
            reportsToolStripMenuItem.Size = new Size(74, 24);
            reportsToolStripMenuItem.Text = "Reports";
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { studentsToolStripMenuItem, classesToolStripMenuItem, attendanceToolStripMenuItem, toolStripMenuItem1, teachersToolStripMenuItem, notificationsToolStripMenuItem, reportsToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(999, 28);
            menuStrip1.TabIndex = 3;
            menuStrip1.Text = "menuStrip1";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(999, 593);
            Controls.Add(richTextBox1);
            Controls.Add(button1);
            Controls.Add(dataGridView1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private Button button1;
        private RichTextBox richTextBox1;
        private ToolStripMenuItem studentsToolStripMenuItem;
        private ToolStripMenuItem registerANewStudentToolStripMenuItem;
        private ToolStripMenuItem retrieveStudentDetailsToolStripMenuItem;
        private ToolStripMenuItem retrieveAttendanceRecordForASpecificStudentToolStripMenuItem;
        private ToolStripMenuItem classesToolStripMenuItem;
        private ToolStripMenuItem createANewClassToolStripMenuItem;
        private ToolStripMenuItem listAllClassesToolStripMenuItem;
        private ToolStripMenuItem retrieveDetailsOfASpecificClassToolStripMenuItem;
        private ToolStripMenuItem attendanceToolStripMenuItem;
        private ToolStripMenuItem toolStripMenuItem1;
        private ToolStripMenuItem teachersToolStripMenuItem;
        private ToolStripMenuItem notificationsToolStripMenuItem;
        private ToolStripMenuItem reportsToolStripMenuItem;
        private MenuStrip menuStrip1;
    }
}
