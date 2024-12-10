namespace AttendanceSeekers_client
{
    partial class DepartmentModule
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DepartmentModule));
            panel1 = new Panel();
            labelName = new Label();
            pictureBox = new PictureBox();
            picClose = new PictureBox();
            btnCancel = new Button();
            btnUpdate = new Button();
            label2 = new Label();
            btnSave = new Button();
            textName = new TextBox();
            Class_Size = new Label();
            bunifuLabel1 = new Bunifu.UI.WinForms.BunifuLabel();
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
            panel1.Size = new Size(881, 50);
            panel1.TabIndex = 7;
            // 
            // labelName
            // 
            labelName.AutoSize = true;
            labelName.Font = new Font("Century Gothic", 18F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, 0);
            labelName.ForeColor = SystemColors.Control;
            labelName.Location = new Point(12, 5);
            labelName.Name = "labelName";
            labelName.Size = new Size(308, 37);
            labelName.TabIndex = 0;
            labelName.Text = "Department Module";
            // 
            // pictureBox
            // 
            pictureBox.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            pictureBox.BackgroundImage = Properties.Resources.Close_Window;
            pictureBox.Location = new Point(853, 5);
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
            picClose.Location = new Point(1368, 0);
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
            btnCancel.Location = new Point(744, 132);
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
            btnUpdate.Location = new Point(644, 132);
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
            label2.Size = new Size(0, 22);
            label2.TabIndex = 10;
            // 
            // btnSave
            // 
            btnSave.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnSave.BackColor = Color.FromArgb(0, 70, 160);
            btnSave.FlatAppearance.BorderSize = 0;
            btnSave.FlatStyle = FlatStyle.Flat;
            btnSave.ForeColor = SystemColors.Control;
            btnSave.Location = new Point(544, 133);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(94, 35);
            btnSave.TabIndex = 9;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click;
            // 
            // textName
            // 
            textName.Location = new Point(278, 87);
            textName.Name = "textName";
            textName.Size = new Size(195, 30);
            textName.TabIndex = 8;
            // 
            // Class_Size
            // 
            Class_Size.AutoSize = true;
            Class_Size.Location = new Point(566, 87);
            Class_Size.Name = "Class_Size";
            Class_Size.RightToLeft = RightToLeft.No;
            Class_Size.Size = new Size(0, 22);
            Class_Size.TabIndex = 14;
            // 
            // bunifuLabel1
            // 
            bunifuLabel1.AllowParentOverrides = false;
            bunifuLabel1.AutoEllipsis = false;
            bunifuLabel1.CursorType = Cursors.Default;
            bunifuLabel1.Font = new Font("Century Gothic", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            bunifuLabel1.Location = new Point(30, 90);
            bunifuLabel1.Name = "bunifuLabel1";
            bunifuLabel1.RightToLeft = RightToLeft.No;
            bunifuLabel1.Size = new Size(220, 27);
            bunifuLabel1.TabIndex = 15;
            bunifuLabel1.Text = "Department Name:";
            bunifuLabel1.TextAlignment = ContentAlignment.TopLeft;
            bunifuLabel1.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // DepartmentModule
            // 
            AutoScaleDimensions = new SizeF(11F, 22F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(880, 188);
            ControlBox = false;
            Controls.Add(bunifuLabel1);
            Controls.Add(panel1);
            Controls.Add(Class_Size);
            Controls.Add(btnCancel);
            Controls.Add(btnUpdate);
            Controls.Add(label2);
            Controls.Add(btnSave);
            Controls.Add(textName);
            Font = new Font("Century Gothic", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4);
            Name = "DepartmentModule";
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
        public Button btnUpdate;
        private Label label2;
        public Button btnSave;
        public TextBox textName;
        private PictureBox pictureBox;
        private Label Class_Size;
        private Bunifu.UI.WinForms.BunifuLabel bunifuLabel1;
    }
}