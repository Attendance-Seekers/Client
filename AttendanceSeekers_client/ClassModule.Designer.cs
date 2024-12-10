namespace AttendanceSeekers_client
{
    partial class ClassModule
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
            pictureBox = new PictureBox();
            picClose = new PictureBox();
            labelName = new Label();
            lblId = new Label();
            btnCancel = new Button();
            btnUpdate = new Button();
            label2 = new Label();
            btnSave = new Button();
            textClassName = new TextBox();
            Class_Size = new Label();
            Size = new NumericUpDown();
            Class_id = new NumericUpDown();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picClose).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Size).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Class_id).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(0, 70, 160);
            panel1.Controls.Add(pictureBox);
            panel1.Controls.Add(picClose);
            panel1.Controls.Add(labelName);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.RightToLeft = RightToLeft.No;
            panel1.Size = new Size(755, 50);
            panel1.TabIndex = 7;
            // 
            // pictureBox
            // 
            pictureBox.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            pictureBox.BackgroundImage = Properties.Resources.Close_Window;
            pictureBox.Location = new Point(724, 0);
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
            picClose.Location = new Point(1242, 0);
            picClose.Name = "picClose";
            picClose.Size = new Size(28, 30);
            picClose.TabIndex = 1;
            picClose.TabStop = false;
            // 
            // labelName
            // 
            labelName.AutoSize = true;
            labelName.Font = new Font("Century Gothic", 12F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, 0);
            labelName.ForeColor = SystemColors.Control;
            labelName.Location = new Point(12, 12);
            labelName.Name = "labelName";
            labelName.Size = new Size(142, 23);
            labelName.TabIndex = 0;
            labelName.Text = "Class Module";
            // 
            // lblId
            // 
            lblId.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            lblId.AutoSize = true;
            lblId.BorderStyle = BorderStyle.FixedSingle;
            lblId.Location = new Point(46, 139);
            lblId.Name = "lblId";
            lblId.Size = new Size(28, 24);
            lblId.TabIndex = 13;
            lblId.Text = "id";
            lblId.Visible = false;
            // 
            // btnCancel
            // 
            btnCancel.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnCancel.BackColor = Color.LightGray;
            btnCancel.FlatAppearance.BorderSize = 0;
            btnCancel.FlatStyle = FlatStyle.Flat;
            btnCancel.ForeColor = SystemColors.ActiveCaptionText;
            btnCancel.Location = new Point(619, 132);
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
            btnUpdate.Location = new Point(519, 132);
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
            label2.Location = new Point(46, 90);
            label2.Name = "label2";
            label2.Size = new Size(121, 22);
            label2.TabIndex = 10;
            label2.Text = "Class Name:";
            // 
            // btnSave
            // 
            btnSave.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnSave.BackColor = Color.FromArgb(0, 70, 160);
            btnSave.FlatAppearance.BorderSize = 0;
            btnSave.FlatStyle = FlatStyle.Flat;
            btnSave.ForeColor = SystemColors.Control;
            btnSave.Location = new Point(419, 133);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(94, 35);
            btnSave.TabIndex = 9;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click;
            // 
            // textClassName
            // 
            textClassName.Location = new Point(179, 87);
            textClassName.Name = "textClassName";
            textClassName.Size = new Size(195, 30);
            textClassName.TabIndex = 8;
            // 
            // Class_Size
            // 
            Class_Size.AutoSize = true;
            Class_Size.Location = new Point(474, 90);
            Class_Size.Name = "Class_Size";
            Class_Size.RightToLeft = RightToLeft.No;
            Class_Size.Size = new Size(47, 22);
            Class_Size.TabIndex = 14;
            Class_Size.Text = "Size:";
            // 
            // Size
            // 
            Size.ImeMode = ImeMode.NoControl;
            Size.Location = new Point(519, 90);
            Size.Maximum = new decimal(new int[] { 9999, 0, 0, 0 });
            Size.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            Size.Name = "Size";
            Size.Size = new Size(168, 30);
            Size.TabIndex = 26;
            Size.TextAlign = HorizontalAlignment.Center;
            Size.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // Class_id
            // 
            Class_id.ImeMode = ImeMode.NoControl;
            Class_id.Location = new Point(83, 137);
            Class_id.Maximum = new decimal(new int[] { 99999, 0, 0, 0 });
            Class_id.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            Class_id.Name = "Class_id";
            Class_id.Size = new Size(61, 30);
            Class_id.TabIndex = 28;
            Class_id.TextAlign = HorizontalAlignment.Center;
            Class_id.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // ClassModule
            // 
            AutoScaleDimensions = new SizeF(11F, 22F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(755, 188);
            ControlBox = false;
            Controls.Add(Class_id);
            Controls.Add(Size);
            Controls.Add(Class_Size);
            Controls.Add(panel1);
            Controls.Add(lblId);
            Controls.Add(btnCancel);
            Controls.Add(btnUpdate);
            Controls.Add(label2);
            Controls.Add(btnSave);
            Controls.Add(textClassName);
            Font = new Font("Century Gothic", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4);
            Name = "ClassModule";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ProductModule";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)picClose).EndInit();
            ((System.ComponentModel.ISupportInitialize)Size).EndInit();
            ((System.ComponentModel.ISupportInitialize)Class_id).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        public Panel panel1;
        private PictureBox picClose;
        private Label labelName;
        public Label lblId;
        public Button btnCancel;
        public Button btnUpdate;
        private Label label2;
        public Button btnSave;
        public TextBox textClassName;
        private PictureBox pictureBox;
        private Label Class_Size;
        public NumericUpDown Size;
        public NumericUpDown Class_id;
    }
}