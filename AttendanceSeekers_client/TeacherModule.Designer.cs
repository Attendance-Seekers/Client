namespace AttendanceSeekers_client
{
    partial class TeacherModule
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
            textTeacherName = new TextBox();
            age = new NumericUpDown();
            label1 = new Label();
            textAddress = new TextBox();
            subjId = new NumericUpDown();
            label3 = new Label();
            label4 = new Label();
            textEmail = new TextBox();
            label5 = new Label();
            textPhone = new TextBox();
            label6 = new Label();
            passlbl = new Label();
            textPass = new TextBox();
            usernamelbl = new Label();
            textUsername = new TextBox();
            btnSave = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picClose).BeginInit();
            ((System.ComponentModel.ISupportInitialize)age).BeginInit();
            ((System.ComponentModel.ISupportInitialize)subjId).BeginInit();
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
            labelName.Size = new Size(253, 37);
            labelName.TabIndex = 0;
            labelName.Text = "Teacher Module";
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
            btnCancel.Location = new Point(741, 362);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(94, 35);
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
            btnUpdate.Location = new Point(641, 362);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(94, 35);
            btnUpdate.TabIndex = 11;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = false;
            btnUpdate.Click += btnUpdate_Click_1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(22, 92);
            label2.Name = "label2";
            label2.Size = new Size(151, 22);
            label2.TabIndex = 10;
            label2.Text = "Teacher Name:";
            // 
            // textTeacherName
            // 
            textTeacherName.Location = new Point(179, 87);
            textTeacherName.Name = "textTeacherName";
            textTeacherName.Size = new Size(195, 30);
            textTeacherName.TabIndex = 8;
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
            // subjId
            // 
            subjId.ImeMode = ImeMode.NoControl;
            subjId.Location = new Point(578, 155);
            subjId.Maximum = new decimal(new int[] { 9999, 0, 0, 0 });
            subjId.Name = "subjId";
            subjId.Size = new Size(168, 30);
            subjId.TabIndex = 30;
            subjId.TextAlign = HorizontalAlignment.Center;
            subjId.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(443, 159);
            label3.Name = "label3";
            label3.RightToLeft = RightToLeft.No;
            label3.Size = new Size(106, 22);
            label3.TabIndex = 29;
            label3.Text = "Subject Id:";
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
            label5.Location = new Point(443, 226);
            label5.Name = "label5";
            label5.Size = new Size(110, 22);
            label5.TabIndex = 34;
            label5.Text = "Phone No.:";
            // 
            // textPhone
            // 
            textPhone.Location = new Point(578, 216);
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
            // passlbl
            // 
            passlbl.AutoSize = true;
            passlbl.Location = new Point(443, 300);
            passlbl.Name = "passlbl";
            passlbl.Size = new Size(100, 22);
            passlbl.TabIndex = 39;
            passlbl.Text = "Password:";
            // 
            // textPass
            // 
            textPass.Location = new Point(578, 290);
            textPass.Name = "textPass";
            textPass.PasswordChar = '*';
            textPass.Size = new Size(195, 30);
            textPass.TabIndex = 38;
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
            // btnSave
            // 
            btnSave.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnSave.BackColor = Color.FromArgb(0, 70, 160);
            btnSave.FlatAppearance.BorderSize = 0;
            btnSave.FlatStyle = FlatStyle.Flat;
            btnSave.ForeColor = SystemColors.Control;
            btnSave.Location = new Point(540, 362);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(94, 35);
            btnSave.TabIndex = 40;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click;
            // 
            // TeacherModule
            // 
            AutoScaleDimensions = new SizeF(11F, 22F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(877, 418);
            ControlBox = false;
            Controls.Add(btnSave);
            Controls.Add(passlbl);
            Controls.Add(textPass);
            Controls.Add(usernamelbl);
            Controls.Add(textUsername);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(textPhone);
            Controls.Add(label4);
            Controls.Add(textEmail);
            Controls.Add(subjId);
            Controls.Add(label3);
            Controls.Add(label1);
            Controls.Add(textAddress);
            Controls.Add(panel1);
            Controls.Add(age);
            Controls.Add(btnCancel);
            Controls.Add(btnUpdate);
            Controls.Add(label2);
            Controls.Add(textTeacherName);
            Font = new Font("Century Gothic", 11.25F);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4);
            Name = "TeacherModule";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ProductModule";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)picClose).EndInit();
            ((System.ComponentModel.ISupportInitialize)age).EndInit();
            ((System.ComponentModel.ISupportInitialize)subjId).EndInit();
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
        private TextBox textTeacherName;
        private NumericUpDown age;
        public Button btnSave;
     
        private PictureBox pictureBox;
        
        private Label label1;
        private TextBox textAddress;
        private NumericUpDown subjId;
        public TextBox textBox1;
        public NumericUpDown numericUpDown1;
        private Label label3;
        private Label label4;
        private TextBox textEmail;
        public TextBox textBox2;
        private Label label5;
        public TextBox textPhone;
        private Label label6;
        private Label passlbl;
        public TextBox textPass;
        private Label usernamelbl;
        private TextBox textUsername;
    }
}