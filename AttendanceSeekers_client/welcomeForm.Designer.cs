namespace AttendanceSeekers_client
{
    partial class welcomeForm
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
            admin_button = new Button();
            teacher_button = new Button();
            parent_button = new Button();
            student_button = new Button();
            label1 = new Label();
            SuspendLayout();
            // 
            // admin_button
            // 
            admin_button.BackColor = Color.Black;
            admin_button.Font = new Font("Showcard Gothic", 22.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            admin_button.ForeColor = Color.Transparent;
            admin_button.Location = new Point(64, 550);
            admin_button.Name = "admin_button";
            admin_button.Size = new Size(276, 93);
            admin_button.TabIndex = 1;
            admin_button.Text = "Admin";
            admin_button.UseVisualStyleBackColor = false;
            admin_button.Click += admin_button_Click;
            // 
            // teacher_button
            // 
            teacher_button.BackColor = Color.Black;
            teacher_button.Font = new Font("Showcard Gothic", 22.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            teacher_button.ForeColor = Color.Transparent;
            teacher_button.Location = new Point(384, 550);
            teacher_button.Name = "teacher_button";
            teacher_button.Size = new Size(276, 93);
            teacher_button.TabIndex = 2;
            teacher_button.Text = "Teacher";
            teacher_button.UseVisualStyleBackColor = false;
            teacher_button.Click += teacher_button_Click;
            // 
            // parent_button
            // 
            parent_button.BackColor = Color.Black;
            parent_button.Font = new Font("Showcard Gothic", 22.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            parent_button.ForeColor = Color.Transparent;
            parent_button.Location = new Point(703, 550);
            parent_button.Name = "parent_button";
            parent_button.Size = new Size(276, 93);
            parent_button.TabIndex = 3;
            parent_button.Text = "Parent";
            parent_button.UseVisualStyleBackColor = false;
            parent_button.Click += parent_button_Click;
            // 
            // student_button
            // 
            student_button.BackColor = Color.Black;
            student_button.Font = new Font("Showcard Gothic", 22.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            student_button.ForeColor = Color.Transparent;
            student_button.Location = new Point(1033, 550);
            student_button.Name = "student_button";
            student_button.Size = new Size(276, 93);
            student_button.TabIndex = 4;
            student_button.Text = "Student";
            student_button.UseVisualStyleBackColor = false;
            student_button.Click += student_button_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Showcard Gothic", 36F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Transparent;
            label1.Location = new Point(181, 142);
            label1.Name = "label1";
            label1.Size = new Size(1032, 222);
            label1.TabIndex = 5;
            label1.Text = "Welcom To Attendance Seekers\n\n                      Who Are You?\n";
            // 
            // welcomeForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BackColor = Color.Black;
            ClientSize = new Size(1348, 721);
            Controls.Add(label1);
            Controls.Add(student_button);
            Controls.Add(parent_button);
            Controls.Add(teacher_button);
            Controls.Add(admin_button);
            Name = "welcomeForm";
            Text = "welcomeForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button admin_button;
        private Button teacher_button;
        private Button parent_button;
        private Button student_button;
        private Label label1;
    }
}