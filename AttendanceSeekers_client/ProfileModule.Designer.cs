namespace AttendanceSeekers_client
{
    partial class ProfileModule
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
            btnUpdate = new Button();
            label2 = new Label();
            textName = new TextBox();
            age = new NumericUpDown();
            label1 = new Label();
            textAddress = new TextBox();
            subjIDval = new NumericUpDown();
            subjIdlbl = new Label();
            label4 = new Label();
            textEmail = new TextBox();
            label5 = new Label();
            textPhone = new TextBox();
            label6 = new Label();
            usernamelbl = new Label();
            textUsername = new TextBox();
            btnChangePass = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picClose).BeginInit();
            ((System.ComponentModel.ISupportInitialize)age).BeginInit();
            ((System.ComponentModel.ISupportInitialize)subjIDval).BeginInit();
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
            labelName.Size = new Size(104, 37);
            labelName.TabIndex = 0;
            labelName.Text = "Profile";
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
            btnCancel.Location = new Point(582, 369);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(191, 35);
            btnCancel.TabIndex = 12;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = false;
            btnCancel.Click += btnCancel_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnUpdate.BackColor = Color.FromArgb(192, 192, 0);
            btnUpdate.FlatAppearance.BorderSize = 0;
            btnUpdate.FlatStyle = FlatStyle.Flat;
            btnUpdate.ForeColor = SystemColors.Control;
            btnUpdate.Location = new Point(582, 328);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(191, 35);
            btnUpdate.TabIndex = 11;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = false;
            btnUpdate.Click += btnUpdate_Click_1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(48, 95);
            label2.Name = "label2";
            label2.Size = new Size(76, 22);
            label2.TabIndex = 10;
            label2.Text = " Name:";
            // 
            // textName
            // 
            textName.Location = new Point(179, 87);
            textName.Name = "textName";
            textName.Size = new Size(195, 30);
            textName.TabIndex = 8;
            // 
            // age
            // 
            age.ImeMode = ImeMode.NoControl;
            age.Location = new Point(578, 87);
            age.Maximum = new decimal(new int[] { 9999, 0, 0, 0 });
            age.Name = "age";
            age.Size = new Size(168, 30);
            age.TabIndex = 26;
            age.TextAlign = HorizontalAlignment.Center;
            age.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(45, 159);
            label1.Name = "label1";
            label1.Size = new Size(88, 22);
            label1.TabIndex = 28;
            label1.Text = "Address:";
            // 
            // textAddress
            // 
            textAddress.Location = new Point(179, 149);
            textAddress.Name = "textAddress";
            textAddress.Size = new Size(195, 30);
            textAddress.TabIndex = 27;
            // 
            // subjIDval
            // 
            subjIDval.ImeMode = ImeMode.NoControl;
            subjIDval.Location = new Point(578, 216);
            subjIDval.Maximum = new decimal(new int[] { 9999, 0, 0, 0 });
            subjIDval.Name = "subjIDval";
            subjIDval.Size = new Size(168, 30);
            subjIDval.TabIndex = 30;
            subjIDval.TextAlign = HorizontalAlignment.Center;
            subjIDval.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // subjIdlbl
            // 
            subjIdlbl.AutoSize = true;
            subjIdlbl.Location = new Point(443, 222);
            subjIdlbl.Name = "subjIdlbl";
            subjIdlbl.RightToLeft = RightToLeft.No;
            subjIdlbl.Size = new Size(106, 22);
            subjIdlbl.TabIndex = 29;
            subjIdlbl.Text = "Subject Id:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(63, 226);
            label4.Name = "label4";
            label4.Size = new Size(61, 22);
            label4.TabIndex = 32;
            label4.Text = "Email:";
            // 
            // textEmail
            // 
            textEmail.Location = new Point(179, 216);
            textEmail.Name = "textEmail";
            textEmail.Size = new Size(195, 30);
            textEmail.TabIndex = 31;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(443, 159);
            label5.Name = "label5";
            label5.Size = new Size(110, 22);
            label5.TabIndex = 34;
            label5.Text = "Phone No.:";
            // 
            // textPhone
            // 
            textPhone.Location = new Point(582, 151);
            textPhone.Name = "textPhone";
            textPhone.Size = new Size(195, 30);
            textPhone.TabIndex = 33;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(466, 95);
            label6.Name = "label6";
            label6.RightToLeft = RightToLeft.No;
            label6.Size = new Size(55, 22);
            label6.TabIndex = 35;
            label6.Text = "Age:";
            // 
            // usernamelbl
            // 
            usernamelbl.AutoSize = true;
            usernamelbl.Location = new Point(45, 300);
            usernamelbl.Name = "usernamelbl";
            usernamelbl.Size = new Size(101, 22);
            usernamelbl.TabIndex = 37;
            usernamelbl.Text = "Username";
            // 
            // textUsername
            // 
            textUsername.Location = new Point(179, 290);
            textUsername.Name = "textUsername";
            textUsername.Size = new Size(195, 30);
            textUsername.TabIndex = 36;
            // 
            // btnChangePass
            // 
            btnChangePass.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnChangePass.BackColor = Color.FromArgb(0, 70, 160);
            btnChangePass.FlatAppearance.BorderSize = 0;
            btnChangePass.FlatStyle = FlatStyle.Flat;
            btnChangePass.ForeColor = SystemColors.Control;
            btnChangePass.Location = new Point(582, 287);
            btnChangePass.Name = "btnChangePass";
            btnChangePass.Size = new Size(191, 35);
            btnChangePass.TabIndex = 40;
            btnChangePass.Text = "Change Password";
            btnChangePass.UseVisualStyleBackColor = false;
            btnChangePass.Click += btnChangePass_Click;
            // 
            // ProfileModule
            // 
            AutoScaleDimensions = new SizeF(11F, 22F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(877, 418);
            ControlBox = false;
            Controls.Add(btnChangePass);
            Controls.Add(usernamelbl);
            Controls.Add(textUsername);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(textPhone);
            Controls.Add(label4);
            Controls.Add(textEmail);
            Controls.Add(subjIDval);
            Controls.Add(subjIdlbl);
            Controls.Add(label1);
            Controls.Add(textAddress);
            Controls.Add(panel1);
            Controls.Add(age);
            Controls.Add(btnCancel);
            Controls.Add(btnUpdate);
            Controls.Add(label2);
            Controls.Add(textName);
            Font = new Font("Century Gothic", 11.25F);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4);
            Name = "ProfileModule";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ProductModule";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)picClose).EndInit();
            ((System.ComponentModel.ISupportInitialize)age).EndInit();
            ((System.ComponentModel.ISupportInitialize)subjIDval).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        public Panel panel1;
        private PictureBox picClose;
        private Label labelName;
        public Button btnCancel;
        public Button btnUpdate;
        private Label label2;
        private TextBox textName;
        private NumericUpDown age;
        public Button btnChangePass;
     
        private PictureBox pictureBox;
        
        private Label label1;
        private TextBox textAddress;
        private NumericUpDown subjIDval;
        public TextBox textBox1;
        public NumericUpDown numericUpDown1;
        private Label subjIdlbl;
        private Label label4;
        private TextBox textEmail;
        public TextBox textBox2;
        private Label label5;
        public TextBox textPhone;
        private Label label6;
        private Label usernamelbl;
        private TextBox textUsername;
    }
}