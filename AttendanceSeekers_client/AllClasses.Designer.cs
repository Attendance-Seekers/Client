namespace AttendanceSeekers_client
{
    partial class AllClasses
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AllClasses));
            dgvClass = new Bunifu.UI.WinForms.BunifuDataGridView();
            Id = new DataGridViewTextBoxColumn();
            ClassName = new DataGridViewTextBoxColumn();
            ClassSize = new DataGridViewTextBoxColumn();
            Show = new DataGridViewImageColumn();
            Edit = new DataGridViewImageColumn();
            Delete = new DataGridViewImageColumn();
            panel1 = new Panel();
            btnAdd = new Button();
            txtSearch = new TextBox();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvClass).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // dgvClass
            // 
            dgvClass.AllowCustomTheming = false;
            dgvClass.AllowUserToAddRows = false;
            dgvClass.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(248, 251, 255);
            dataGridViewCellStyle1.ForeColor = Color.Black;
            dgvClass.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dgvClass.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvClass.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvClass.BackgroundColor = SystemColors.Control;
            dgvClass.BorderStyle = BorderStyle.None;
            dgvClass.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvClass.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.DodgerBlue;
            dataGridViewCellStyle2.Font = new Font("Segoe UI Semibold", 11.75F, FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(24, 115, 204);
            dataGridViewCellStyle2.SelectionForeColor = Color.White;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dgvClass.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dgvClass.ColumnHeadersHeight = 40;
            dgvClass.Columns.AddRange(new DataGridViewColumn[] { Id, ClassName, ClassSize, Show, Edit, Delete });
            dgvClass.CurrentTheme.AlternatingRowsStyle.BackColor = Color.FromArgb(248, 251, 255);
            dgvClass.CurrentTheme.AlternatingRowsStyle.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold);
            dgvClass.CurrentTheme.AlternatingRowsStyle.ForeColor = Color.Black;
            dgvClass.CurrentTheme.AlternatingRowsStyle.SelectionBackColor = Color.FromArgb(210, 232, 255);
            dgvClass.CurrentTheme.AlternatingRowsStyle.SelectionForeColor = Color.Black;
            dgvClass.CurrentTheme.BackColor = Color.White;
            dgvClass.CurrentTheme.GridColor = Color.FromArgb(221, 238, 255);
            dgvClass.CurrentTheme.HeaderStyle.BackColor = Color.DodgerBlue;
            dgvClass.CurrentTheme.HeaderStyle.Font = new Font("Segoe UI Semibold", 11.75F, FontStyle.Bold);
            dgvClass.CurrentTheme.HeaderStyle.ForeColor = Color.White;
            dgvClass.CurrentTheme.HeaderStyle.SelectionBackColor = Color.FromArgb(24, 115, 204);
            dgvClass.CurrentTheme.HeaderStyle.SelectionForeColor = Color.White;
            dgvClass.CurrentTheme.Name = null;
            dgvClass.CurrentTheme.RowsStyle.BackColor = Color.White;
            dgvClass.CurrentTheme.RowsStyle.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold);
            dgvClass.CurrentTheme.RowsStyle.ForeColor = Color.Black;
            dgvClass.CurrentTheme.RowsStyle.SelectionBackColor = Color.FromArgb(210, 232, 255);
            dgvClass.CurrentTheme.RowsStyle.SelectionForeColor = Color.Black;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.White;
            dataGridViewCellStyle3.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold);
            dataGridViewCellStyle3.ForeColor = Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(210, 232, 255);
            dataGridViewCellStyle3.SelectionForeColor = Color.Black;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            dgvClass.DefaultCellStyle = dataGridViewCellStyle3;
            dgvClass.EnableHeadersVisualStyles = false;
            dgvClass.GridColor = Color.FromArgb(221, 238, 255);
            dgvClass.HeaderBackColor = Color.DodgerBlue;
            dgvClass.HeaderBgColor = Color.Empty;
            dgvClass.HeaderForeColor = Color.White;
            dgvClass.Location = new Point(0, 0);
            dgvClass.Name = "dgvClass";
            dgvClass.ReadOnly = true;
            dgvClass.RowHeadersVisible = false;
            dgvClass.RowHeadersWidth = 51;
            dgvClass.RowTemplate.Height = 40;
            dgvClass.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvClass.Size = new Size(984, 487);
            dgvClass.TabIndex = 1;
            dgvClass.Theme = Bunifu.UI.WinForms.BunifuDataGridView.PresetThemes.Light;
            dgvClass.CellMouseDoubleClick += dgvClass_CellMouseDoubleClick;
            dgvClass.RowHeaderMouseDoubleClick += dgvClass_RowHeaderMouseDoubleClick;
            // 
            // Id
            // 
            Id.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            Id.DataPropertyName = "Class_Id";
            Id.HeaderText = "ID";
            Id.MinimumWidth = 6;
            Id.Name = "Id";
            Id.ReadOnly = true;
            Id.Width = 59;
            // 
            // ClassName
            // 
            ClassName.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            ClassName.DataPropertyName = "Class_Name";
            ClassName.HeaderText = "Name";
            ClassName.MinimumWidth = 6;
            ClassName.Name = "ClassName";
            ClassName.ReadOnly = true;
            ClassName.Width = 93;
            // 
            // ClassSize
            // 
            ClassSize.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            ClassSize.DataPropertyName = "Class_Size";
            ClassSize.HeaderText = "Size";
            ClassSize.MinimumWidth = 6;
            ClassSize.Name = "ClassSize";
            ClassSize.ReadOnly = true;
            // 
            // Show
            // 
            Show.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            Show.HeaderText = "";
            Show.Image = Properties.Resources.Eye;
            Show.MinimumWidth = 6;
            Show.Name = "Show";
            Show.ReadOnly = true;
            Show.Width = 6;
            // 
            // Edit
            // 
            Edit.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            Edit.HeaderText = "";
            Edit.Image = Properties.Resources.Edit;
            Edit.MinimumWidth = 6;
            Edit.Name = "Edit";
            Edit.ReadOnly = true;
            Edit.Width = 6;
            // 
            // Delete
            // 
            Delete.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            Delete.HeaderText = "";
            Delete.Image = Properties.Resources.Delete;
            Delete.MinimumWidth = 6;
            Delete.Name = "Delete";
            Delete.ReadOnly = true;
            Delete.Width = 6;
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
            label1.Size = new Size(178, 71);
            label1.TabIndex = 3;
            label1.Text = "Manage Class";
            label1.TextAlign = ContentAlignment.MiddleRight;
            // 
            // AllClasses
            // 
            AutoScaleDimensions = new SizeF(11F, 22F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(984, 561);
            Controls.Add(panel1);
            Controls.Add(dgvClass);
            Font = new Font("Century Gothic", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(4);
            Name = "AllClasses";
            Text = "AllClasses";
            ((System.ComponentModel.ISupportInitialize)dgvClass).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Bunifu.UI.WinForms.BunifuDataGridView dgvClass;
        private Panel panel1;
        private TextBox txtSearch;
        private Label label1;
        private DataGridViewTextBoxColumn Id;
        private DataGridViewTextBoxColumn ClassName;
        private DataGridViewTextBoxColumn ClassSize;
        private DataGridViewImageColumn Show;
        private DataGridViewImageColumn Edit;
        private DataGridViewImageColumn Delete;
        private Button btnAdd;
    }
}