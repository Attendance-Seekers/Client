namespace AttendanceSeekers_client
{
    partial class ShowStudent
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
            dgvClass = new Bunifu.UI.WinForms.BunifuDataGridView();
            No = new DataGridViewTextBoxColumn();
            Id = new DataGridViewTextBoxColumn();
            studentName = new DataGridViewTextBoxColumn();
            St_Satus = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dgvClass).BeginInit();
            SuspendLayout();
            // 
            // dgvClass
            // 
            dgvClass.AllowCustomTheming = false;
            dgvClass.AllowUserToAddRows = false;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(248, 251, 255);
            dataGridViewCellStyle1.ForeColor = Color.Black;
            dgvClass.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
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
            dgvClass.Columns.AddRange(new DataGridViewColumn[] { No, Id, studentName, St_Satus });
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
            dgvClass.Margin = new Padding(3, 4, 3, 4);
            dgvClass.Name = "dgvClass";
            dgvClass.RowHeadersVisible = false;
            dgvClass.RowHeadersWidth = 51;
            dgvClass.RowTemplate.Height = 40;
            dgvClass.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvClass.Size = new Size(914, 600);
            dgvClass.TabIndex = 4;
            dgvClass.Theme = Bunifu.UI.WinForms.BunifuDataGridView.PresetThemes.Light;
            // 
            // No
            // 
            No.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            No.FillWeight = 52.63158F;
            No.HeaderText = "NoStudent";
            No.MinimumWidth = 6;
            No.Name = "No";
            No.Width = 137;
            // 
            // Id
            // 
            Id.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            Id.DataPropertyName = "Class_Id";
            Id.HeaderText = "ID";
            Id.MinimumWidth = 6;
            Id.Name = "Id";
            Id.Visible = false;
            Id.Width = 125;
            // 
            // studentName
            // 
            studentName.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            studentName.DataPropertyName = "username";
            studentName.HeaderText = "Student_Name";
            studentName.MinimumWidth = 6;
            studentName.Name = "studentName";
            studentName.Width = 172;
            // 
            // St_Satus
            // 
            St_Satus.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            St_Satus.DataPropertyName = "status";
            St_Satus.FillWeight = 147.368423F;
            St_Satus.HeaderText = "Status";
            St_Satus.MinimumWidth = 6;
            St_Satus.Name = "St_Satus";
            // 
            // ShowStudent
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(914, 600);
            Controls.Add(dgvClass);
            Margin = new Padding(3, 4, 3, 4);
            Name = "ShowStudent";
            Text = "ShowStudent";
            ((System.ComponentModel.ISupportInitialize)dgvClass).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Bunifu.UI.WinForms.BunifuDataGridView dgvClass;
        private DataGridViewTextBoxColumn No;
        private DataGridViewTextBoxColumn Id;
        private DataGridViewTextBoxColumn studentName;
        private DataGridViewTextBoxColumn St_Satus;
    }
}