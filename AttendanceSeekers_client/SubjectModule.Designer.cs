namespace AttendanceSeekers_client
{
    partial class SubjectModule
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
            textSubjectName = new TextBox();
            subjectDuration = new NumericUpDown();
            deptId = new NumericUpDown();
            label3 = new Label();
            label6 = new Label();
            btnSave = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picClose).BeginInit();
            ((System.ComponentModel.ISupportInitialize)subjectDuration).BeginInit();
            ((System.ComponentModel.ISupportInitialize)deptId).BeginInit();
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
            labelName.Font = new Font("Century Gothic", 18F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, 0);
            labelName.ForeColor = SystemColors.Control;
            labelName.Location = new Point(12, 5);
            labelName.Name = "labelName";
            labelName.Size = new Size(244, 37);
            labelName.TabIndex = 0;
            labelName.Text = "Subject Module";
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
            btnCancel.Location = new Point(741, 238);
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
            btnUpdate.Location = new Point(641, 238);
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
            label2.Location = new Point(22, 93);
            label2.Name = "label2";
            label2.Size = new Size(144, 22);
            label2.TabIndex = 10;
            label2.Text = "Subject Name:";
            // 
            // textSubjectName
            // 
            textSubjectName.Location = new Point(179, 87);
            textSubjectName.Name = "textSubjectName";
            textSubjectName.Size = new Size(195, 30);
            textSubjectName.TabIndex = 8;
            // 
            // subjectDuration
            // 
            subjectDuration.ImeMode = ImeMode.NoControl;
            subjectDuration.Location = new Point(607, 93);
            subjectDuration.Maximum = new decimal(new int[] { 9999, 0, 0, 0 });
            subjectDuration.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            subjectDuration.Name = "subjectDuration";
            subjectDuration.Size = new Size(168, 30);
            subjectDuration.TabIndex = 26;
            subjectDuration.TextAlign = HorizontalAlignment.Center;
            subjectDuration.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // deptId
            // 
            deptId.ImeMode = ImeMode.NoControl;
            deptId.Location = new Point(386, 171);
            deptId.Maximum = new decimal(new int[] { 9999, 0, 0, 0 });
            deptId.Name = "deptId";
            deptId.Size = new Size(168, 30);
            deptId.TabIndex = 30;
            deptId.TextAlign = HorizontalAlignment.Center;
            deptId.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(213, 175);
            label3.Name = "label3";
            label3.RightToLeft = RightToLeft.No;
            label3.Size = new Size(151, 22);
            label3.TabIndex = 29;
            label3.Text = "Department Id:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(434, 96);
            label6.Name = "label6";
            label6.RightToLeft = RightToLeft.No;
            label6.Size = new Size(167, 22);
            label6.TabIndex = 35;
            label6.Text = "Subject Duration:";
            // 
            // btnSave
            // 
            btnSave.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnSave.BackColor = Color.FromArgb(0, 70, 160);
            btnSave.FlatAppearance.BorderSize = 0;
            btnSave.FlatStyle = FlatStyle.Flat;
            btnSave.ForeColor = SystemColors.Control;
            btnSave.Location = new Point(541, 238);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(94, 35);
            btnSave.TabIndex = 36;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click;
            // 
            // SubjectModule
            // 
            AutoScaleDimensions = new SizeF(11F, 22F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(877, 294);
            ControlBox = false;
            Controls.Add(btnSave);
            Controls.Add(label6);
            Controls.Add(deptId);
            Controls.Add(label3);
            Controls.Add(panel1);
            Controls.Add(subjectDuration);
            Controls.Add(btnCancel);
            Controls.Add(btnUpdate);
            Controls.Add(label2);
            Controls.Add(textSubjectName);
            Font = new Font("Century Gothic", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4);
            Name = "SubjectModule";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ProductModule";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)picClose).EndInit();
            ((System.ComponentModel.ISupportInitialize)subjectDuration).EndInit();
            ((System.ComponentModel.ISupportInitialize)deptId).EndInit();
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
        private TextBox textSubjectName;
        private NumericUpDown subjectDuration;
        public Button btnSave;
     
        private PictureBox pictureBox;
        private NumericUpDown deptId;
        public TextBox textBox1;
        public NumericUpDown numericUpDown1;
        private Label label3;
        public TextBox textBox2;
        private Label label6;
    }
}