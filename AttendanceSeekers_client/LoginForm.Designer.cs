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
            Login_button = new Button();
            label3 = new Label();
            passTextBox = new TextBox();
            userTextBox = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            label1.AutoSize = true;
            label1.Font = new Font("Showcard Gothic", 18F, FontStyle.Bold);
            label1.Location = new Point(346, 196);
            label1.Name = "label1";
            label1.Size = new Size(180, 37);
            label1.TabIndex = 1;
            label1.Text = "UserName";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            label2.AutoSize = true;
            label2.Font = new Font("Showcard Gothic", 18F, FontStyle.Bold);
            label2.Location = new Point(336, 346);
            label2.Name = "label2";
            label2.Size = new Size(190, 37);
            label2.TabIndex = 2;
            label2.Text = "Password";
            // 
            // Login_button
            // 
            Login_button.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            Login_button.BackColor = Color.Navy;
            Login_button.Font = new Font("Showcard Gothic", 24F, FontStyle.Bold);
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
            label3.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            label3.AutoSize = true;
            label3.Font = new Font("Showcard Gothic", 36F, FontStyle.Bold);
            label3.ForeColor = Color.DodgerBlue;
            label3.Location = new Point(567, 60);
            label3.Name = "label3";
            label3.Size = new Size(222, 74);
            label3.TabIndex = 6;
            label3.Text = "LOG IN";
            // 
            // passTextBox
            // 
            passTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            passTextBox.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold);
            passTextBox.ForeColor = Color.Silver;
            passTextBox.Location = new Point(538, 336);
            passTextBox.Multiline = true;
            passTextBox.Name = "passTextBox";
            passTextBox.PasswordChar = '*';
            passTextBox.Size = new Size(475, 47);
            passTextBox.TabIndex = 7;
            passTextBox.Text = "Enter Password";
            passTextBox.Enter += passTextBox_Enter_1;
            passTextBox.KeyDown += passTextBox_KeyDown;
            // 
            // userTextBox
            // 
            userTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            userTextBox.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold);
            userTextBox.ForeColor = Color.Silver;
            userTextBox.Location = new Point(538, 186);
            userTextBox.Multiline = true;
            userTextBox.Name = "userTextBox";
            userTextBox.Size = new Size(475, 47);
            userTextBox.TabIndex = 8;
            userTextBox.Text = "Enter UserName";
            userTextBox.Enter += userTextBox_Enter_1;
            userTextBox.KeyDown += userTextBox_KeyDown;
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(120F, 120F);
            AutoScaleMode = AutoScaleMode.Dpi;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BackColor = Color.Black;
            ClientSize = new Size(1348, 721);
            Controls.Add(userTextBox);
            Controls.Add(passTextBox);
            Controls.Add(label3);
            Controls.Add(Login_button);
            Controls.Add(label2);
            Controls.Add(label1);
            ForeColor = Color.Transparent;
            Name = "LoginForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "LoginForm";
            FormClosing += LoginForm_FormClosing;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label1;
        private Label label2;
        private Button Login_button;
        private Label label3;
        private TextBox passTextBox;
        private TextBox userTextBox;
    }
}