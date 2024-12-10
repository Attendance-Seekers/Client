namespace AttendanceSeekers_client
{
    partial class AllDepartments
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AllDepartments));
            dgvdept = new Bunifu.UI.WinForms.BunifuDataGridView();
            panel1 = new Panel();
            btnAdd = new Button();
            txtSearch = new TextBox();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvdept).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // dgvdept
            // 
            dgvdept.AllowCustomTheming = false;
            dgvdept.AllowUserToAddRows = false;
            dgvdept.AllowUserToDeleteRows = false;
            dataGridViewCellStyle4.BackColor = Color.FromArgb(248, 251, 255);
            dataGridViewCellStyle4.ForeColor = Color.Black;
            dgvdept.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            dgvdept.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvdept.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvdept.BackgroundColor = SystemColors.Control;
            dgvdept.BorderStyle = BorderStyle.None;
            dgvdept.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvdept.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = Color.DodgerBlue;
            dataGridViewCellStyle5.Font = new Font("Segoe UI Semibold", 11.75F, FontStyle.Bold);
            dataGridViewCellStyle5.ForeColor = Color.White;
            dataGridViewCellStyle5.SelectionBackColor = Color.FromArgb(24, 115, 204);
            dataGridViewCellStyle5.SelectionForeColor = Color.White;
            dataGridViewCellStyle5.WrapMode = DataGridViewTriState.True;
            dgvdept.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            dgvdept.ColumnHeadersHeight = 40;
            dgvdept.CurrentTheme.AlternatingRowsStyle.BackColor = Color.FromArgb(248, 251, 255);
            dgvdept.CurrentTheme.AlternatingRowsStyle.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold);
            dgvdept.CurrentTheme.AlternatingRowsStyle.ForeColor = Color.Black;
            dgvdept.CurrentTheme.AlternatingRowsStyle.SelectionBackColor = Color.FromArgb(210, 232, 255);
            dgvdept.CurrentTheme.AlternatingRowsStyle.SelectionForeColor = Color.Black;
            dgvdept.CurrentTheme.BackColor = Color.White;
            dgvdept.CurrentTheme.GridColor = Color.FromArgb(221, 238, 255);
            dgvdept.CurrentTheme.HeaderStyle.BackColor = Color.DodgerBlue;
            dgvdept.CurrentTheme.HeaderStyle.Font = new Font("Segoe UI Semibold", 11.75F, FontStyle.Bold);
            dgvdept.CurrentTheme.HeaderStyle.ForeColor = Color.White;
            dgvdept.CurrentTheme.HeaderStyle.SelectionBackColor = Color.FromArgb(24, 115, 204);
            dgvdept.CurrentTheme.HeaderStyle.SelectionForeColor = Color.White;
            dgvdept.CurrentTheme.Name = null;
            dgvdept.CurrentTheme.RowsStyle.BackColor = Color.White;
            dgvdept.CurrentTheme.RowsStyle.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold);
            dgvdept.CurrentTheme.RowsStyle.ForeColor = Color.Black;
            dgvdept.CurrentTheme.RowsStyle.SelectionBackColor = Color.FromArgb(210, 232, 255);
            dgvdept.CurrentTheme.RowsStyle.SelectionForeColor = Color.Black;
            dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = Color.White;
            dataGridViewCellStyle6.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold);
            dataGridViewCellStyle6.ForeColor = Color.Black;
            dataGridViewCellStyle6.SelectionBackColor = Color.FromArgb(210, 232, 255);
            dataGridViewCellStyle6.SelectionForeColor = Color.Black;
            dataGridViewCellStyle6.WrapMode = DataGridViewTriState.False;
            dgvdept.DefaultCellStyle = dataGridViewCellStyle6;
            dgvdept.EnableHeadersVisualStyles = false;
            dgvdept.GridColor = Color.FromArgb(221, 238, 255);
            dgvdept.HeaderBackColor = Color.DodgerBlue;
            dgvdept.HeaderBgColor = Color.Empty;
            dgvdept.HeaderForeColor = Color.White;
            dgvdept.Location = new Point(0, 0);
            dgvdept.Name = "dgvdept";
            dgvdept.ReadOnly = true;
            dgvdept.RowHeadersVisible = false;
            dgvdept.RowHeadersWidth = 51;
            dgvdept.RowTemplate.Height = 40;
            dgvdept.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvdept.Size = new Size(984, 487);
            dgvdept.TabIndex = 1;
            dgvdept.Theme = Bunifu.UI.WinForms.BunifuDataGridView.PresetThemes.Light;
            dgvdept.CellMouseDoubleClick += dgvClass_CellMouseDoubleClick;
           
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
            txtSearch.Location = new Point(316, 26);
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
            label1.Size = new Size(280, 71);
            label1.TabIndex = 3;
            label1.Text = "Manage Departments";
            label1.TextAlign = ContentAlignment.MiddleRight;
            // 
            // AllDepartments
            // 
            AutoScaleDimensions = new SizeF(11F, 22F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(984, 561);
            Controls.Add(panel1);
            Controls.Add(dgvdept);
            Font = new Font("Century Gothic", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(4);
            Name = "AllDepartments";
            Text = "AllDepartments";
            ((System.ComponentModel.ISupportInitialize)dgvdept).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Bunifu.UI.WinForms.BunifuDataGridView dgvdept;
        private Panel panel1;
        private TextBox txtSearch;
        private Label label1;
        private Button btnAdd;
    }
}