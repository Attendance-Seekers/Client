namespace AttendanceSeekers_client
{
    partial class changePassModule
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
            panel1 = new Panel();
            labelName = new Label();
            pictureBox = new PictureBox();
            picClose = new PictureBox();
            btnCancel = new Button();
            label1 = new Label();
            oldPass = new TextBox();
            label4 = new Label();
            newPass = new TextBox();
            usernamelbl = new Label();
            confirmPass = new TextBox();
            btnSave = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picClose).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            panel1.BackColor = Color.FromArgb(0, 70, 160);
            panel1.BackgroundImageLayout = ImageLayout.None;
            panel1.Controls.Add(labelName);
            panel1.Controls.Add(pictureBox);
            panel1.Controls.Add(picClose);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.RightToLeft = RightToLeft.No;
            panel1.Size = new Size(877, 50);
            panel1.TabIndex = 7;
            // 
            // labelName
            // 
            labelName.AutoSize = true;
            labelName.Font = new Font("Century Gothic", 18F, FontStyle.Bold | FontStyle.Underline);
            labelName.ForeColor = SystemColors.Control;
            labelName.Location = new Point(12, 5);
            labelName.Name = "labelName";
            labelName.Size = new Size(279, 37);
            labelName.TabIndex = 0;
            labelName.Text = "Change Password";
            // 
            // pictureBox
            // 
            pictureBox.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            pictureBox.BackgroundImage = Properties.Resources.Close_Window;
            pictureBox.Location = new Point(849, 5);
            pictureBox.Name = "pictureBox";
            pictureBox.Size = new Size(28, 30);
            pictureBox.TabIndex = 2;
            pictureBox.TabStop = false;
            pictureBox.Click += pictureBox_Click;
            // 
            // picClose
            // 
            picClose.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            picClose.Image = Properties.Resources.Class;
            picClose.Location = new Point(1364, 0);
            picClose.Name = "picClose";
            picClose.Size = new Size(28, 30);
            picClose.TabIndex = 1;
            picClose.TabStop = false;
            // 
            // btnCancel
            // 
            btnCancel.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnCancel.BackColor = Color.LightGray;
            btnCancel.FlatAppearance.BorderSize = 0;
            btnCancel.FlatStyle = FlatStyle.Flat;
            btnCancel.ForeColor = SystemColors.ActiveCaptionText;
            btnCancel.Location = new Point(426, 357);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(94, 35);
            btnCancel.TabIndex = 12;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = false;
            btnCancel.Click += btnCancel_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(234, 104);
            label1.Name = "label1";
            label1.Size = new Size(133, 22);
            label1.TabIndex = 28;
            label1.Text = "Old Password";
            // 
            // oldPass
            // 
            oldPass.Location = new Point(426, 96);
            oldPass.Name = "oldPass";
            oldPass.PasswordChar = '*';
            oldPass.PlaceholderText = "Enter Your Old Password";
            oldPass.Size = new Size(276, 30);
            oldPass.TabIndex = 27;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(234, 171);
            label4.Name = "label4";
            label4.Size = new Size(142, 22);
            label4.TabIndex = 32;
            label4.Text = "New Password";
            // 
            // newPass
            // 
            newPass.Location = new Point(426, 163);
            newPass.Name = "newPass";
            newPass.PasswordChar = '*';
            newPass.PlaceholderText = "Enter Your New Password";
            newPass.Size = new Size(276, 30);
            newPass.TabIndex = 31;
            // 
            // usernamelbl
            // 
            usernamelbl.AutoSize = true;
            usernamelbl.Location = new Point(222, 245);
            usernamelbl.Name = "usernamelbl";
            usernamelbl.Size = new Size(171, 22);
            usernamelbl.TabIndex = 37;
            usernamelbl.Text = "Confirm Password";
            // 
            // confirmPass
            // 
            confirmPass.Location = new Point(426, 237);
            confirmPass.Name = "confirmPass";
            confirmPass.PasswordChar = '*';
            confirmPass.PlaceholderText = "Confirm New Password";
            confirmPass.Size = new Size(276, 30);
            confirmPass.TabIndex = 36;
            // 
            // btnSave
            // 
            btnSave.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnSave.BackColor = Color.FromArgb(0, 70, 160);
            btnSave.FlatAppearance.BorderSize = 0;
            btnSave.FlatStyle = FlatStyle.Flat;
            btnSave.ForeColor = SystemColors.Control;
            btnSave.Location = new Point(369, 305);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(199, 35);
            btnSave.TabIndex = 40;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click;
            // 
            // changePassModule
            // 
            AutoScaleDimensions = new SizeF(11F, 22F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(877, 418);
            ControlBox = false;
            Controls.Add(btnSave);
            Controls.Add(usernamelbl);
            Controls.Add(confirmPass);
            Controls.Add(label4);
            Controls.Add(newPass);
            Controls.Add(label1);
            Controls.Add(oldPass);
            Controls.Add(panel1);
            Controls.Add(btnCancel);
            Font = new Font("Century Gothic", 11.25F);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4);
            Name = "changePassModule";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ProductModule";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)picClose).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        public Panel panel1;
        private PictureBox picClose;
        private Label labelName;
        public Button btnCancel;
     
        private PictureBox pictureBox;
        
        private Label label1;
        private TextBox oldPass;
        public TextBox textBox1;
        public NumericUpDown numericUpDown1;
        private Label label4;
        private TextBox newPass;
        public TextBox textBox2;
        private Label usernamelbl;
        private TextBox confirmPass;
        public Button btnSave;
    }
}