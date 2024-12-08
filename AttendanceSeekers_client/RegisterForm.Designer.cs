namespace AttendanceSeekers_client
{
    partial class RegisterForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RegisterForm));
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            student_fullName = new TextBox();
            age_textBox = new TextBox();
            username_textbox = new TextBox();
            password_textbox = new TextBox();
            email_textbox = new TextBox();
            phone_textbox = new TextBox();
            classId_textbox = new TextBox();
            reg_button = new Button();
            label9 = new Label();
            studetnLogin_button = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            resources.ApplyResources(label1, "label1");
            label1.ForeColor = Color.DodgerBlue;
            label1.Name = "label1";
            // 
            // label2
            // 
            resources.ApplyResources(label2, "label2");
            label2.ForeColor = Color.Transparent;
            label2.Name = "label2";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            resources.ApplyResources(label3, "label3");
            label3.ForeColor = Color.Transparent;
            label3.Name = "label3";
            // 
            // label4
            // 
            resources.ApplyResources(label4, "label4");
            label4.ForeColor = Color.Transparent;
            label4.Name = "label4";
            // 
            // label5
            // 
            resources.ApplyResources(label5, "label5");
            label5.ForeColor = Color.Transparent;
            label5.Name = "label5";
            // 
            // label6
            // 
            resources.ApplyResources(label6, "label6");
            label6.ForeColor = Color.Transparent;
            label6.Name = "label6";
            // 
            // label7
            // 
            resources.ApplyResources(label7, "label7");
            label7.ForeColor = Color.Transparent;
            label7.Name = "label7";
            // 
            // label8
            // 
            resources.ApplyResources(label8, "label8");
            label8.ForeColor = Color.Transparent;
            label8.Name = "label8";
            // 
            // student_fullName
            // 
            student_fullName.BackColor = Color.White;
            resources.ApplyResources(student_fullName, "student_fullName");
            student_fullName.ForeColor = Color.Silver;
            student_fullName.Name = "student_fullName";
            student_fullName.Enter += student_fullName_Enter;
            // 
            // age_textBox
            // 
            age_textBox.BackColor = Color.White;
            resources.ApplyResources(age_textBox, "age_textBox");
            age_textBox.ForeColor = Color.Silver;
            age_textBox.Name = "age_textBox";
            age_textBox.Enter += age_textBox_Enter;
            // 
            // username_textbox
            // 
            username_textbox.BackColor = Color.White;
            resources.ApplyResources(username_textbox, "username_textbox");
            username_textbox.ForeColor = Color.Silver;
            username_textbox.Name = "username_textbox";
            username_textbox.Enter += username_textbox_Enter;
            // 
            // password_textbox
            // 
            password_textbox.BackColor = Color.White;
            resources.ApplyResources(password_textbox, "password_textbox");
            password_textbox.ForeColor = Color.Silver;
            password_textbox.Name = "password_textbox";
            password_textbox.Enter += password_textbox_Enter;
            // 
            // email_textbox
            // 
            email_textbox.BackColor = Color.White;
            resources.ApplyResources(email_textbox, "email_textbox");
            email_textbox.ForeColor = Color.Silver;
            email_textbox.Name = "email_textbox";
            email_textbox.Enter += email_textbox_Enter;
            // 
            // phone_textbox
            // 
            phone_textbox.BackColor = Color.White;
            resources.ApplyResources(phone_textbox, "phone_textbox");
            phone_textbox.ForeColor = Color.Silver;
            phone_textbox.Name = "phone_textbox";
            phone_textbox.Enter += phone_textbox_Enter;
            // 
            // classId_textbox
            // 
            classId_textbox.BackColor = Color.White;
            resources.ApplyResources(classId_textbox, "classId_textbox");
            classId_textbox.ForeColor = Color.Silver;
            classId_textbox.Name = "classId_textbox";
            classId_textbox.Enter += classId_textbox_Enter;
            // 
            // reg_button
            // 
            reg_button.BackColor = Color.MidnightBlue;
            resources.ApplyResources(reg_button, "reg_button");
            reg_button.ForeColor = Color.Transparent;
            reg_button.Name = "reg_button";
            reg_button.UseVisualStyleBackColor = false;
            reg_button.Click += reg_button_Click;
            // 
            // label9
            // 
            resources.ApplyResources(label9, "label9");
            label9.ForeColor = Color.Transparent;
            label9.Name = "label9";
            // 
            // studetnLogin_button
            // 
            studetnLogin_button.BackColor = Color.MidnightBlue;
            resources.ApplyResources(studetnLogin_button, "studetnLogin_button");
            studetnLogin_button.ForeColor = Color.Transparent;
            studetnLogin_button.Name = "studetnLogin_button";
            studetnLogin_button.UseVisualStyleBackColor = false;
            studetnLogin_button.Click += studetnLogin_button_Click;
            // 
            // RegisterForm
            // 
            resources.ApplyResources(this, "$this");
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            Controls.Add(studetnLogin_button);
            Controls.Add(label9);
            Controls.Add(reg_button);
            Controls.Add(classId_textbox);
            Controls.Add(phone_textbox);
            Controls.Add(email_textbox);
            Controls.Add(password_textbox);
            Controls.Add(username_textbox);
            Controls.Add(age_textBox);
            Controls.Add(student_fullName);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "RegisterForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private TextBox student_fullName;
        private TextBox age_textBox;
        private TextBox username_textbox;
        private TextBox password_textbox;
        private TextBox email_textbox;
        private TextBox phone_textbox;
        private TextBox classId_textbox;
        private Button reg_button;
        private Label label9;
        private Button studetnLogin_button;
    }
}