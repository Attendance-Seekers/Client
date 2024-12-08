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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(welcomeForm));
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
            resources.ApplyResources(admin_button, "admin_button");
            admin_button.ForeColor = Color.Transparent;
            admin_button.Name = "admin_button";
            admin_button.UseVisualStyleBackColor = false;
            admin_button.Click += admin_button_Click;
            // 
            // teacher_button
            // 
            teacher_button.BackColor = Color.Black;
            resources.ApplyResources(teacher_button, "teacher_button");
            teacher_button.ForeColor = Color.Transparent;
            teacher_button.Name = "teacher_button";
            teacher_button.UseVisualStyleBackColor = false;
            teacher_button.Click += teacher_button_Click;
            // 
            // parent_button
            // 
            parent_button.BackColor = Color.Black;
            resources.ApplyResources(parent_button, "parent_button");
            parent_button.ForeColor = Color.Transparent;
            parent_button.Name = "parent_button";
            parent_button.UseVisualStyleBackColor = false;
            parent_button.Click += parent_button_Click;
            // 
            // student_button
            // 
            student_button.BackColor = Color.Black;
            resources.ApplyResources(student_button, "student_button");
            student_button.ForeColor = Color.Transparent;
            student_button.Name = "student_button";
            student_button.UseVisualStyleBackColor = false;
            student_button.Click += student_button_Click;
            // 
            // label1
            // 
            resources.ApplyResources(label1, "label1");
            label1.ForeColor = Color.Transparent;
            label1.Name = "label1";
            // 
            // welcomeForm
            // 
            resources.ApplyResources(this, "$this");
            AutoScaleMode = AutoScaleMode.Dpi;
            BackColor = Color.Black;
            Controls.Add(label1);
            Controls.Add(student_button);
            Controls.Add(parent_button);
            Controls.Add(teacher_button);
            Controls.Add(admin_button);
            Name = "welcomeForm";
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