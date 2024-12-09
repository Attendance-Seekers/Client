using System.Data.SqlClient;
namespace AttendanceSeekers_client
{
    public partial class MainForm : Form
    {
        HttpClient _httpClient;
        public MainForm()
        {
            InitializeComponent();
            customizeDesing();
            _httpClient = new HttpClient();
        }
        #region panelSlide
        private void customizeDesing()
        {
            panelSubClass.Visible = false;
            panelSubSubject.Visible = false;
            panelSubTeacher.Visible = false;
            panelSubDepartment.Visible = false;
            SubParent.Visible = false;
            openChildrenForm(new AdminForm());
        }
        private void hideSubmenu()
        {
            if (panelSubClass.Visible == true)
            {
                panelSubClass.Visible = false;
            }
            if (panelSubSubject.Visible == true)
            {
                panelSubSubject.Visible = false;
            }
            if (panelSubTeacher.Visible == true)
            {
                panelSubTeacher.Visible = false;
            }
            if (panelSubDepartment.Visible == true)
            {
                panelSubDepartment.Visible = false;
            }
            if(SubParent.Visible = true)
            {
                SubParent.Visible = false;  
            }
        }
        private void showSubmenu(Panel submenu)
        {
            if (submenu.Visible == false)
            {
                hideSubmenu();
                submenu.Visible = true;
            }
            else
                submenu.Visible = false;
        }
        #endregion panelSlide

        private Form? activeForm = null;
        public void openChildrenForm(Form ChildForm)
        {
            if (activeForm != null)
                activeForm.Close();
            activeForm = ChildForm;
            ChildForm.TopLevel = false;
            ChildForm.FormBorderStyle = FormBorderStyle.None;
            ChildForm.Dock = DockStyle.Fill;
            lblTitle.Text = ChildForm.Text;
            panelMain.Controls.Add(ChildForm);
            panelMain.Tag = ChildForm;
            ChildForm.BringToFront();

            ChildForm.Show();
        }

        private void btnClass_Click(object sender, EventArgs e)
        {
            showSubmenu(panelSubClass);

        }

        //private void btnProductList_Click(object sender, EventArgs e)
        //{
        //    openChildrenForm(new Product());
        //    hideSubmenu();
        //}

        //private void btnCategory_Click(object sender, EventArgs e)
        //{
        //    openChildrenForm(new Category());
        //    hideSubmenu();
        //}

        //private void btnBrand_Click(object sender, EventArgs e)
        //{
        //    openChildrenForm(new Brand());
        //    hideSubmenu();
        //}

        private void btnTeacher_Click(object sender, EventArgs e)
        {
            showSubmenu(panelSubTeacher);
        }
        private void panelSubSubject_DoubleClick(object sender, EventArgs e)
        {
            showSubmenu(panelSubSubject);

        }
        private void panelSubDepartment_Click(object sender, EventArgs e)
        {
            showSubmenu(panelSubDepartment);

        }
        private void SubParent_Click(object sender, EventArgs e)
        {
            showSubmenu(SubParent);

        }

        //private void btnStockEntry_Click(object sender, EventArgs e)
        //{
        //    openChildrenForm(new StockIn());
        //    hideSubmenu();
        //}





    }
}
