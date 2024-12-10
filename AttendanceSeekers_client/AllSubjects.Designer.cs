namespace AttendanceSeekers_client
{
    partial class AllSubjcets
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
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AllSubjcets));
            dgvSubject = new Bunifu.UI.WinForms.BunifuDataGridView();
            panel1 = new Panel();
            btnAdd = new Button();
            txtSearch = new TextBox();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvSubject).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // dgvSubject
            // 
            dgvSubject.AllowCustomTheming = false;
            dgvSubject.AllowUserToAddRows = false;
            dgvSubject.AllowUserToDeleteRows = false;
            dataGridViewCellStyle4.BackColor = Color.FromArgb(248, 251, 255);
            dataGridViewCellStyle4.ForeColor = Color.Black;
            dgvSubject.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            dgvSubject.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvSubject.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvSubject.BackgroundColor = SystemColors.Control;
            dgvSubject.BorderStyle = BorderStyle.None;
            dgvSubject.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvSubject.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = Color.DodgerBlue;
            dataGridViewCellStyle5.Font = new Font("Segoe UI Semibold", 11.75F, FontStyle.Bold);
            dataGridViewCellStyle5.ForeColor = Color.White;
            dataGridViewCellStyle5.SelectionBackColor = Color.FromArgb(24, 115, 204);
            dataGridViewCellStyle5.SelectionForeColor = Color.White;
            dataGridViewCellStyle5.WrapMode = DataGridViewTriState.True;
            dgvSubject.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            dgvSubject.ColumnHeadersHeight = 40;
            dgvSubject.CurrentTheme.AlternatingRowsStyle.BackColor = Color.FromArgb(248, 251, 255);
            dgvSubject.CurrentTheme.AlternatingRowsStyle.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold);
            dgvSubject.CurrentTheme.AlternatingRowsStyle.ForeColor = Color.Black;
            dgvSubject.CurrentTheme.AlternatingRowsStyle.SelectionBackColor = Color.FromArgb(210, 232, 255);
            dgvSubject.CurrentTheme.AlternatingRowsStyle.SelectionForeColor = Color.Black;
            dgvSubject.CurrentTheme.BackColor = Color.White;
            dgvSubject.CurrentTheme.GridColor = Color.FromArgb(221, 238, 255);
            dgvSubject.CurrentTheme.HeaderStyle.BackColor = Color.DodgerBlue;
            dgvSubject.CurrentTheme.HeaderStyle.Font = new Font("Segoe UI Semibold", 11.75F, FontStyle.Bold);
            dgvSubject.CurrentTheme.HeaderStyle.ForeColor = Color.White;
            dgvSubject.CurrentTheme.HeaderStyle.SelectionBackColor = Color.FromArgb(24, 115, 204);
            dgvSubject.CurrentTheme.HeaderStyle.SelectionForeColor = Color.White;
            dgvSubject.CurrentTheme.Name = null;
            dgvSubject.CurrentTheme.RowsStyle.BackColor = Color.White;
            dgvSubject.CurrentTheme.RowsStyle.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold);
            dgvSubject.CurrentTheme.RowsStyle.ForeColor = Color.Black;
            dgvSubject.CurrentTheme.RowsStyle.SelectionBackColor = Color.FromArgb(210, 232, 255);
            dgvSubject.CurrentTheme.RowsStyle.SelectionForeColor = Color.Black;
            dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = Color.White;
            dataGridViewCellStyle6.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold);
            dataGridViewCellStyle6.ForeColor = Color.Black;
            dataGridViewCellStyle6.SelectionBackColor = Color.FromArgb(210, 232, 255);
            dataGridViewCellStyle6.SelectionForeColor = Color.Black;
            dataGridViewCellStyle6.WrapMode = DataGridViewTriState.False;
            dgvSubject.DefaultCellStyle = dataGridViewCellStyle6;
            dgvSubject.EnableHeadersVisualStyles = false;
            dgvSubject.GridColor = Color.FromArgb(221, 238, 255);
            dgvSubject.HeaderBackColor = Color.DodgerBlue;
            dgvSubject.HeaderBgColor = Color.Empty;
            dgvSubject.HeaderForeColor = Color.White;
            dgvSubject.Location = new Point(0, 0);
            dgvSubject.Name = "dgvSubject";
            dgvSubject.ReadOnly = true;
            dgvSubject.RowHeadersVisible = false;
            dgvSubject.RowHeadersWidth = 51;
            dgvSubject.RowTemplate.Height = 40;
            dgvSubject.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvSubject.Size = new Size(984, 487);
            dgvSubject.TabIndex = 1;
            dgvSubject.Theme = Bunifu.UI.WinForms.BunifuDataGridView.PresetThemes.Light;
            dgvSubject.CellMouseDoubleClick += dgvClass_CellMouseDoubleClick;
            dgvSubject.RowHeaderMouseDoubleClick += dgvClass_RowHeaderMouseDoubleClick;
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel1.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            panel1.BackColor = Color.FromArgb(0, 70, 160);
            panel1.Controls.Add(btnAdd);
            panel1.Controls.Add(txtSearch);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(0, 481);
            panel1.Name = "panel1";
            panel1.Size = new Size(984, 80);
            panel1.TabIndex = 3;
            // 
            // btnAdd
            // 
            btnAdd.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnAdd.AutoSize = true;
            btnAdd.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnAdd.FlatAppearance.BorderSize = 0;
            btnAdd.FlatStyle = FlatStyle.Flat;
            btnAdd.Image = (Image)resources.GetObject("btnAdd.Image");
            btnAdd.Location = new Point(911, 26);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(36, 36);
            btnAdd.TabIndex = 2;
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // txtSearch
            // 
            txtSearch.Anchor = AnchorStyles.Bottom;
            txtSearch.Location = new Point(296, 26);
            txtSearch.Multiline = true;
            txtSearch.Name = "txtSearch";
            txtSearch.PlaceholderText = "Search Here";
            txtSearch.Size = new Size(429, 32);
            txtSearch.TabIndex = 4;
            // 
            // label1
            // 
            label1.Font = new Font("Century Gothic", 12F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.Control;
            label1.Image = Properties.Resources.Class;
            label1.ImageAlign = ContentAlignment.MiddleLeft;
            label1.Location = new Point(10, 9);
            label1.Name = "label1";
            label1.Size = new Size(234, 71);
            label1.TabIndex = 3;
            label1.Text = "Manage Subjects";
            label1.TextAlign = ContentAlignment.MiddleRight;
            // 
            // AllSubjcets
            // 
            AutoScaleDimensions = new SizeF(11F, 22F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(984, 561);
            Controls.Add(panel1);
            Controls.Add(dgvSubject);
            Font = new Font("Century Gothic", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(4);
            Name = "AllSubjcets";
            Text = "AllClasses";
            ((System.ComponentModel.ISupportInitialize)dgvSubject).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Bunifu.UI.WinForms.BunifuDataGridView dgvSubject;
        private Panel panel1;
        private TextBox txtSearch;
        private Label label1;
        private Button btnAdd;
    }
}