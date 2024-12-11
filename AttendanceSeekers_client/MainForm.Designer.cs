namespace AttendanceSeekers_client
{
    partial class MainForm
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
            panelTitle = new Panel();
            lblTitle = new Label();
            panelMain = new Panel();
            panelSlide = new Panel();
            SubParent = new Panel();
            btnParentList = new Button();
            btnParent = new Button();
            btnLogout = new Button();
            panelSubDepartment = new Panel();
            btnDepartmentList = new Button();
            btnDepartment = new Button();
            panelSubSubject = new Panel();
            btnSubjectsList = new Button();
            btnSubject = new Button();
            panelSubTeacher = new Panel();
            btnTeacherList = new Button();
            btnTeacher = new Button();
            panelSubClass = new Panel();
            btnClassList = new Button();
            btnClass = new Button();
            btnProfile = new Button();
            panelLogo = new Panel();
            label1 = new Label();
            lblUsername = new Label();
            lblRole = new Label();
            panelTitle.SuspendLayout();
            panelSlide.SuspendLayout();
            SubParent.SuspendLayout();
            panelSubDepartment.SuspendLayout();
            panelSubSubject.SuspendLayout();
            panelSubTeacher.SuspendLayout();
            panelSubClass.SuspendLayout();
            panelLogo.SuspendLayout();
            SuspendLayout();
            // 
            // panelTitle
            // 
            panelTitle.Controls.Add(lblTitle);
            panelTitle.Dock = DockStyle.Top;
            panelTitle.Location = new Point(228, 0);
            panelTitle.Name = "panelTitle";
            panelTitle.Size = new Size(1131, 40);
            panelTitle.TabIndex = 1;
            // 
            // lblTitle
            // 
            lblTitle.Font = new Font("Simplified Arabic Fixed", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitle.ForeColor = SystemColors.ControlLight;
            lblTitle.Location = new Point(236, 9);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(351, 23);
            lblTitle.TabIndex = 1;
            lblTitle.Text = "DashBoard";
            lblTitle.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panelMain
            // 
            panelMain.AllowDrop = true;
            panelMain.AutoSize = true;
            panelMain.BackColor = Color.White;
            panelMain.Dock = DockStyle.Fill;
            panelMain.Font = new Font("Simplified Arabic Fixed", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            panelMain.Location = new Point(228, 0);
            panelMain.Name = "panelMain";
            panelMain.Padding = new Padding(0, 40, 0, 0);
            panelMain.RightToLeft = RightToLeft.No;
            panelMain.Size = new Size(1131, 817);
            panelMain.TabIndex = 2;
            // 
            // panelSlide
            // 
            panelSlide.AutoScroll = true;
            panelSlide.Controls.Add(SubParent);
            panelSlide.Controls.Add(btnParent);
            panelSlide.Controls.Add(btnLogout);
            panelSlide.Controls.Add(panelSubDepartment);
            panelSlide.Controls.Add(btnDepartment);
            panelSlide.Controls.Add(panelSubSubject);
            panelSlide.Controls.Add(btnSubject);
            panelSlide.Controls.Add(panelSubTeacher);
            panelSlide.Controls.Add(btnTeacher);
            panelSlide.Controls.Add(panelSubClass);
            panelSlide.Controls.Add(btnClass);
            panelSlide.Controls.Add(btnProfile);
            panelSlide.Controls.Add(panelLogo);
            panelSlide.Dock = DockStyle.Left;
            panelSlide.Location = new Point(0, 0);
            panelSlide.Name = "panelSlide";
            panelSlide.Size = new Size(228, 817);
            panelSlide.TabIndex = 3;
            // 
            // SubParent
            // 
            SubParent.BackColor = Color.FromArgb(0, 70, 200);
            SubParent.Controls.Add(btnParentList);
            SubParent.Dock = DockStyle.Top;
            SubParent.Location = new Point(0, 572);
            SubParent.Name = "SubParent";
            SubParent.Size = new Size(228, 54);
            SubParent.TabIndex = 12;
            SubParent.Click += SubParent_Click;
            // 
            // btnParentList
            // 
            btnParentList.Dock = DockStyle.Top;
            btnParentList.FlatAppearance.BorderSize = 0;
            btnParentList.FlatStyle = FlatStyle.Flat;
            btnParentList.ForeColor = SystemColors.Control;
            btnParentList.Location = new Point(0, 0);
            btnParentList.Name = "btnParentList";
            btnParentList.Padding = new Padding(35, 0, 0, 0);
            btnParentList.Size = new Size(228, 45);
            btnParentList.TabIndex = 4;
            btnParentList.Text = "All Parent";
            btnParentList.TextAlign = ContentAlignment.MiddleLeft;
            btnParentList.UseVisualStyleBackColor = true;
            btnParentList.Click += btnParentList_Click;
            // 
            // btnParent
            // 
            btnParent.Dock = DockStyle.Top;
            btnParent.FlatAppearance.BorderSize = 0;
            btnParent.FlatStyle = FlatStyle.Flat;
            btnParent.ForeColor = SystemColors.Control;
            btnParent.Location = new Point(0, 527);
            btnParent.Name = "btnParent";
            btnParent.Padding = new Padding(5, 0, 0, 0);
            btnParent.Size = new Size(228, 45);
            btnParent.TabIndex = 11;
            btnParent.Text = "Parent";
            btnParent.TextAlign = ContentAlignment.MiddleLeft;
            btnParent.UseVisualStyleBackColor = true;
            btnParent.Click += SubParent_Click;
            // 
            // btnLogout
            // 
            btnLogout.Dock = DockStyle.Bottom;
            btnLogout.FlatAppearance.BorderSize = 0;
            btnLogout.FlatStyle = FlatStyle.Flat;
            btnLogout.ForeColor = SystemColors.Control;
            btnLogout.Location = new Point(0, 772);
            btnLogout.Name = "btnLogout";
            btnLogout.Padding = new Padding(5, 0, 0, 0);
            btnLogout.Size = new Size(228, 45);
            btnLogout.TabIndex = 10;
            btnLogout.Text = "Logout";
            btnLogout.TextAlign = ContentAlignment.MiddleLeft;
            btnLogout.UseVisualStyleBackColor = true;
            btnLogout.Click += btnLogout_Click;
            // 
            // panelSubDepartment
            // 
            panelSubDepartment.BackColor = Color.FromArgb(0, 70, 200);
            panelSubDepartment.Controls.Add(btnDepartmentList);
            panelSubDepartment.Dock = DockStyle.Top;
            panelSubDepartment.Location = new Point(0, 478);
            panelSubDepartment.Name = "panelSubDepartment";
            panelSubDepartment.Size = new Size(228, 49);
            panelSubDepartment.TabIndex = 9;
            panelSubDepartment.Click += panelSubDepartment_Click;
            // 
            // btnDepartmentList
            // 
            btnDepartmentList.Dock = DockStyle.Top;
            btnDepartmentList.FlatAppearance.BorderSize = 0;
            btnDepartmentList.FlatStyle = FlatStyle.Flat;
            btnDepartmentList.ForeColor = SystemColors.Control;
            btnDepartmentList.Location = new Point(0, 0);
            btnDepartmentList.Name = "btnDepartmentList";
            btnDepartmentList.Padding = new Padding(35, 0, 0, 0);
            btnDepartmentList.Size = new Size(228, 45);
            btnDepartmentList.TabIndex = 4;
            btnDepartmentList.Text = "All Department";
            btnDepartmentList.TextAlign = ContentAlignment.MiddleLeft;
            btnDepartmentList.UseVisualStyleBackColor = true;
            btnDepartmentList.Click += btnDepartmentList_Click;
            // 
            // btnDepartment
            // 
            btnDepartment.Dock = DockStyle.Top;
            btnDepartment.FlatAppearance.BorderSize = 0;
            btnDepartment.FlatStyle = FlatStyle.Flat;
            btnDepartment.ForeColor = SystemColors.Control;
            btnDepartment.Location = new Point(0, 433);
            btnDepartment.Name = "btnDepartment";
            btnDepartment.Padding = new Padding(5, 0, 0, 0);
            btnDepartment.Size = new Size(228, 45);
            btnDepartment.TabIndex = 8;
            btnDepartment.Text = "Department";
            btnDepartment.TextAlign = ContentAlignment.MiddleLeft;
            btnDepartment.UseVisualStyleBackColor = true;
            btnDepartment.Click += panelSubDepartment_Click;
            // 
            // panelSubSubject
            // 
            panelSubSubject.AutoScroll = true;
            panelSubSubject.BackColor = Color.FromArgb(0, 70, 200);
            panelSubSubject.Controls.Add(btnSubjectsList);
            panelSubSubject.Dock = DockStyle.Top;
            panelSubSubject.Location = new Point(0, 383);
            panelSubSubject.Name = "panelSubSubject";
            panelSubSubject.Size = new Size(228, 50);
            panelSubSubject.TabIndex = 7;
            panelSubSubject.DoubleClick += panelSubSubject_DoubleClick;
            // 
            // btnSubjectsList
            // 
            btnSubjectsList.Dock = DockStyle.Top;
            btnSubjectsList.FlatAppearance.BorderSize = 0;
            btnSubjectsList.FlatStyle = FlatStyle.Flat;
            btnSubjectsList.ForeColor = SystemColors.Control;
            btnSubjectsList.Location = new Point(0, 0);
            btnSubjectsList.Name = "btnSubjectsList";
            btnSubjectsList.Padding = new Padding(35, 0, 0, 0);
            btnSubjectsList.Size = new Size(228, 45);
            btnSubjectsList.TabIndex = 4;
            btnSubjectsList.Text = "All Subjects";
            btnSubjectsList.TextAlign = ContentAlignment.MiddleLeft;
            btnSubjectsList.UseVisualStyleBackColor = true;
            btnSubjectsList.Click += btnSubjectsList_Click;
            // 
            // btnSubject
            // 
            btnSubject.Dock = DockStyle.Top;
            btnSubject.FlatAppearance.BorderSize = 0;
            btnSubject.FlatStyle = FlatStyle.Flat;
            btnSubject.ForeColor = SystemColors.Control;
            btnSubject.Location = new Point(0, 338);
            btnSubject.Name = "btnSubject";
            btnSubject.Padding = new Padding(5, 0, 0, 0);
            btnSubject.Size = new Size(228, 45);
            btnSubject.TabIndex = 5;
            btnSubject.Text = "Subject";
            btnSubject.TextAlign = ContentAlignment.MiddleLeft;
            btnSubject.UseVisualStyleBackColor = true;
            btnSubject.Click += panelSubSubject_DoubleClick;
            // 
            // panelSubTeacher
            // 
            panelSubTeacher.BackColor = Color.FromArgb(0, 70, 200);
            panelSubTeacher.Controls.Add(btnTeacherList);
            panelSubTeacher.Dock = DockStyle.Top;
            panelSubTeacher.Location = new Point(0, 293);
            panelSubTeacher.Name = "panelSubTeacher";
            panelSubTeacher.Size = new Size(228, 45);
            panelSubTeacher.TabIndex = 4;
            // 
            // btnTeacherList
            // 
            btnTeacherList.Dock = DockStyle.Top;
            btnTeacherList.FlatAppearance.BorderSize = 0;
            btnTeacherList.FlatStyle = FlatStyle.Flat;
            btnTeacherList.ForeColor = SystemColors.Control;
            btnTeacherList.Location = new Point(0, 0);
            btnTeacherList.Name = "btnTeacherList";
            btnTeacherList.Padding = new Padding(35, 0, 0, 0);
            btnTeacherList.Size = new Size(228, 45);
            btnTeacherList.TabIndex = 4;
            btnTeacherList.Text = "All Teachers";
            btnTeacherList.TextAlign = ContentAlignment.MiddleLeft;
            btnTeacherList.UseVisualStyleBackColor = true;
            btnTeacherList.Click += btnTeacherList_Click;
            // 
            // btnTeacher
            // 
            btnTeacher.Dock = DockStyle.Top;
            btnTeacher.FlatAppearance.BorderSize = 0;
            btnTeacher.FlatStyle = FlatStyle.Flat;
            btnTeacher.ForeColor = SystemColors.Control;
            btnTeacher.Location = new Point(0, 248);
            btnTeacher.Name = "btnTeacher";
            btnTeacher.Padding = new Padding(5, 0, 0, 0);
            btnTeacher.Size = new Size(228, 45);
            btnTeacher.TabIndex = 3;
            btnTeacher.Text = "Teacher";
            btnTeacher.TextAlign = ContentAlignment.MiddleLeft;
            btnTeacher.UseVisualStyleBackColor = true;
            btnTeacher.Click += btnTeacher_Click;
            // 
            // panelSubClass
            // 
            panelSubClass.BackColor = Color.FromArgb(0, 70, 200);
            panelSubClass.Controls.Add(btnClassList);
            panelSubClass.Dock = DockStyle.Top;
            panelSubClass.Location = new Point(0, 203);
            panelSubClass.Name = "panelSubClass";
            panelSubClass.Size = new Size(228, 45);
            panelSubClass.TabIndex = 0;
            // 
            // btnClassList
            // 
            btnClassList.Dock = DockStyle.Top;
            btnClassList.FlatAppearance.BorderSize = 0;
            btnClassList.FlatStyle = FlatStyle.Flat;
            btnClassList.ForeColor = SystemColors.Control;
            btnClassList.Location = new Point(0, 0);
            btnClassList.Name = "btnClassList";
            btnClassList.Padding = new Padding(35, 0, 0, 0);
            btnClassList.Size = new Size(228, 45);
            btnClassList.TabIndex = 3;
            btnClassList.Text = "All Classes";
            btnClassList.TextAlign = ContentAlignment.MiddleLeft;
            btnClassList.UseVisualStyleBackColor = true;
            btnClassList.Click += btnClassList_Click;
            // 
            // btnClass
            // 
            btnClass.Dock = DockStyle.Top;
            btnClass.FlatAppearance.BorderSize = 0;
            btnClass.FlatStyle = FlatStyle.Flat;
            btnClass.ForeColor = SystemColors.Control;
            btnClass.Location = new Point(0, 158);
            btnClass.Name = "btnClass";
            btnClass.Padding = new Padding(5, 0, 0, 0);
            btnClass.Size = new Size(228, 45);
            btnClass.TabIndex = 2;
            btnClass.Text = "Class";
            btnClass.TextAlign = ContentAlignment.MiddleLeft;
            btnClass.UseVisualStyleBackColor = true;
            btnClass.Click += btnClass_Click;
            // 
            // btnProfile
            // 
            btnProfile.Dock = DockStyle.Top;
            btnProfile.FlatAppearance.BorderSize = 0;
            btnProfile.FlatStyle = FlatStyle.Flat;
            btnProfile.ForeColor = SystemColors.Control;
            btnProfile.Location = new Point(0, 113);
            btnProfile.Name = "btnProfile";
            btnProfile.Padding = new Padding(5, 0, 0, 0);
            btnProfile.Size = new Size(228, 45);
            btnProfile.TabIndex = 0;
            btnProfile.Text = "Profile";
            btnProfile.TextAlign = ContentAlignment.MiddleLeft;
            btnProfile.UseVisualStyleBackColor = true;
            btnProfile.Click += btnProfile_Click;
            // 
            // panelLogo
            // 
            panelLogo.Controls.Add(label1);
            panelLogo.Controls.Add(lblUsername);
            panelLogo.Controls.Add(lblRole);
            panelLogo.Dock = DockStyle.Top;
            panelLogo.Location = new Point(0, 0);
            panelLogo.Name = "panelLogo";
            panelLogo.Size = new Size(228, 113);
            panelLogo.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = SystemColors.ControlLight;
            label1.Location = new Point(10, 114);
            label1.Name = "label1";
            label1.Size = new Size(34, 25);
            label1.TabIndex = 1;
            label1.Text = "LN";
            label1.Visible = false;
            // 
            // lblUsername
            // 
            lblUsername.AutoSize = true;
            lblUsername.ForeColor = SystemColors.ControlLight;
            lblUsername.Location = new Point(61, 48);
            lblUsername.Name = "lblUsername";
            lblUsername.Size = new Size(100, 25);
            lblUsername.TabIndex = 0;
            lblUsername.Text = "UserName";
            // 
            // lblRole
            // 
            lblRole.AutoSize = true;
            lblRole.ForeColor = SystemColors.ControlLight;
            lblRole.Location = new Point(76, 89);
            lblRole.Name = "lblRole";
            lblRole.Size = new Size(56, 25);
            lblRole.TabIndex = 0;
            lblRole.Text = "Role";
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(11F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(0, 70, 160);
            ClientSize = new Size(1359, 817);
            Controls.Add(panelTitle);
            Controls.Add(panelMain);
            Controls.Add(panelSlide);
            Font = new Font("Simplified Arabic Fixed", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(4);
            MinimumSize = new Size(1200, 700);
            Name = "MainForm";
            Text = "Point Of Sales";
            panelTitle.ResumeLayout(false);
            panelSlide.ResumeLayout(false);
            SubParent.ResumeLayout(false);
            panelSubDepartment.ResumeLayout(false);
            panelSubSubject.ResumeLayout(false);
            panelSubTeacher.ResumeLayout(false);
            panelSubClass.ResumeLayout(false);
            panelLogo.ResumeLayout(false);
            panelLogo.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Panel panelTitle;
        private Panel panelMain;
        private Label lblTitle;
        private Panel panelSlide;
        private Button btnLogout;
        private Panel panelSubDepartment;
        private Button btnDepartmentList;
        private Button btnDepartment;
        private Panel panelSubSubject;
        private Button btnSubjectsList;
        private Button btnSubject;
        private Panel panelSubTeacher;
        private Button btnTeacherList;
        private Button btnTeacher;
        private Panel panelSubClass;
        private Button btnClassList;
        private Button btnClass;
        private Panel panelLogo;
        private Label label1;
        private Label lblUsername;
        private Label lblRole;
        private Button btnProfile;
        private Panel SubParent;
        private Button btnParentList;
        private Button btnParent;
    }
}
