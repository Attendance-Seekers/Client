using System.Data.SqlClient;
using System.Net;
namespace AttendanceSeekers_client
{
    public partial class MainForm : Form
    {
        HttpClient _httpClient = GlobalConfig.Instance.HttpClient;
        public MainForm()
        {
            InitializeComponent();
            customizeDesing();
            lblRole.Text = GlobalConfig.Instance.role;
            lblUsername.Text = GlobalConfig.Instance.username;
            //_httpClient = new HttpClient();
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
            if (SubParent.Visible = true)
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

        private void btnClassList_Click(object sender, EventArgs e)
        {
            AllClasses allClasses = new AllClasses();
            allClasses.ShowDialog();
        }

        private void btnTeacherList_Click(object sender, EventArgs e)
        {
            AllTeachers allteacher = new AllTeachers();
            allteacher.ShowDialog();
        }

        private void btnSubjectsList_Click(object sender, EventArgs e)
        {
            AllSubjcets allSubjcets = new AllSubjcets();    
            allSubjcets.ShowDialog();
        }

        private void btnDepartmentList_Click(object sender, EventArgs e)
        {
            AllDepartments allDepartments = new AllDepartments();
            allDepartments.ShowDialog();
        }

        private void btnParentList_Click(object sender, EventArgs e)
        {
             AllParents allParents = new AllParents();
            allParents.ShowDialog();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            LogoutClientAsync();
            welcomeForm welcome = new welcomeForm();
            this.Hide();
            welcome.ShowDialog();
            this.Close();    
        }

        private async Task LogoutClientAsync()
        {
            string apiURL = "api/Account/logout";

            // Set the Authorization header if a token exists
            if (!string.IsNullOrWhiteSpace(GlobalConfig.Instance.Token))
            {
                _httpClient.DefaultRequestHeaders.Authorization =
                    new System.Net.Http.Headers.AuthenticationHeaderValue("Bearer", GlobalConfig.Instance.Token);
            }

            try
            {
                // Call the API's logout endpoint
                HttpResponseMessage response = await _httpClient.PostAsync(apiURL, null); // POST with no content

                if (response.StatusCode == HttpStatusCode.OK)
                {
                    MessageBox.Show("You have successfully logged out.", "Logout", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    GlobalConfig.Instance.Token = null; // Clear the token after logout
                }
                else
                {
                    MessageBox.Show($"Failed to log out. Status code: {response.StatusCode}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while logging out: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //private void btnStockEntry_Click(object sender, EventArgs e)
        //{
        //    openChildrenForm(new StockIn());
        //    hideSubmenu();
        //}





    }
}
