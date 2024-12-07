namespace AttendanceSeekers_client
{
    partial class LoginForm
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
            label1 = new Label();
            label2 = new Label();
            userTextBox = new RichTextBox();
            passTextBox = new RichTextBox();
            Login_button = new Button();
            label3 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Showcard Gothic", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(346, 196);
            label1.Name = "label1";
            label1.Size = new Size(180, 37);
            label1.TabIndex = 1;
            label1.Text = "UserName";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Showcard Gothic", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(336, 346);
            label2.Name = "label2";
            label2.Size = new Size(190, 37);
            label2.TabIndex = 2;
            label2.Text = "Password";
            // 
            // userTextBox
            // 
            userTextBox.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            userTextBox.ForeColor = Color.Silver;
            userTextBox.Location = new Point(543, 192);
            userTextBox.Name = "userTextBox";
            userTextBox.Size = new Size(470, 47);
            userTextBox.TabIndex = 3;
            userTextBox.Text = "Enter UserName";
            userTextBox.Click += userTextBox_Click;
            // 
            // passTextBox
            // 
            passTextBox.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            passTextBox.ForeColor = Color.Silver;
            passTextBox.Location = new Point(543, 336);
            passTextBox.Name = "passTextBox";
            passTextBox.Size = new Size(470, 47);
            passTextBox.TabIndex = 4;
            passTextBox.Text = "Enter Password";
            passTextBox.Click += passTextBox_Click;
            // 
            // Login_button
            // 
            Login_button.BackColor = Color.MidnightBlue;
            Login_button.Font = new Font("Showcard Gothic", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Login_button.ForeColor = Color.Transparent;
            Login_button.Location = new Point(477, 510);
            Login_button.Name = "Login_button";
            Login_button.Size = new Size(424, 93);
            Login_button.TabIndex = 5;
            Login_button.Text = "Login";
            Login_button.UseVisualStyleBackColor = false;
            Login_button.Click += Login_button_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Showcard Gothic", 36F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(543, 55);
            label3.Name = "label3";
            label3.Size = new Size(222, 74);
            label3.TabIndex = 6;
            label3.Text = "LOG IN";
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(1348, 721);
            Controls.Add(label3);
            Controls.Add(Login_button);
            Controls.Add(passTextBox);
            Controls.Add(userTextBox);
            Controls.Add(label2);
            Controls.Add(label1);
            ForeColor = Color.Transparent;
            Name = "LoginForm";
            Text = "LoginForm";
            FormClosing += LoginForm_FormClosing;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label1;
        private Label label2;
        private RichTextBox userTextBox;
        private RichTextBox passTextBox;
        private Button Login_button;
        private Label label3;
    }
}