using Attendance_Student.DTOs.AdminDTOs;
using Attendance_Student.DTOs.ParentDTOs;
using Attendance_Student.DTOs.TeacherDTO;
using Newtonsoft.Json;
using System.Net;
using System.Text;

namespace AttendanceSeekers_client
{
    public partial class ProfileModule : Form
    {

        HttpClient _http = GlobalConfig.Instance.HttpClient;
        string EditId;
        //EditTeacherDTO _editTeacher;
        //public ProfileModule()
        //{
        //    InitializeComponent();
        //    btnUpdate.Enabled = false;
        //    btnChangePass.Enabled = true;

        //    textUsername.Visible = true;
        //    usernamelbl.Visible = true;
        //}
        //public ProfileModule(SelectTeacherDTO TeacherDTO)
        //{
        //    InitializeComponent();

        //    textUsername.Visible = false;
        //    usernamelbl.Visible = false;
        //    btnUpdate.Enabled = true;
        //    btnChangePass.Enabled = true;
        //    subjIdlbl.Visible = true;
        //    subjIDval.Visible = true;
        //    //_editTeacher = editTeacherDTO;
        //    textAddress.Text = TeacherDTO.address;
        //    textEmail.Text = TeacherDTO.email;
        //    textPhone.Text = TeacherDTO.phonenumber;
        //    textName.Text = TeacherDTO.Teacher_fullName;
        //    age.Value = TeacherDTO.age;
        //    subjIDval.Value = TeacherDTO.SubjectId;
        //    EditId = TeacherDTO.Id;

        //}
        //public ProfileModule(AdminDTO admin)
        //{
        //    InitializeComponent();

        //    textUsername.Visible = false;
        //    usernamelbl.Visible = false;
        //    btnUpdate.Enabled = true;
        //    btnChangePass.Enabled = true;
        //    subjIdlbl.Visible = false;
        //    subjIDval.Visible = false;

        //    textAddress.Text = admin.address;
        //    textEmail.Text = admin.email;
        //    textPhone.Text = admin.phonenumber;
        //    textName.Text = admin.fullName;
        //    age.Value = admin.age;

        //    EditId = admin.Id;

        //}
        //public ProfileModule(ParentResponseDto parentDTO)
        //{
        //    InitializeComponent();

        //    textUsername.Visible = false;
        //    usernamelbl.Visible = false;
        //    btnUpdate.Enabled = true;
        //    btnChangePass.Enabled = true;
        //    subjIdlbl.Visible = true;
        //    subjIDval.Visible = true;

        //    textAddress.Text = parentDTO.Address;
        //    textEmail.Text = parentDTO.Email;

        //    textName.Text = parentDTO.Fullname;
        //    age.Value = parentDTO.Age;

        //    EditId = parentDTO.Id;

        //}

        public ProfileModule(object profileData)
        {
            InitializeComponent();

            textUsername.Visible = false;
            usernamelbl.Visible = false;
            btnUpdate.Enabled = true;
            btnChangePass.Enabled = true;

            if (profileData is SelectTeacherDTO teacherDTO)
            {
                subjIdlbl.Visible = true;
                subjIDval.Visible = true;
                textAddress.Text = teacherDTO.address;
                textEmail.Text = teacherDTO.email;
                textPhone.Text = teacherDTO.phonenumber;
                textName.Text = teacherDTO.Teacher_fullName;
                age.Value = teacherDTO.age;
                subjIDval.Value = teacherDTO.SubjectId;
                EditId = teacherDTO.Id;
            }
            else if (profileData is AdminDTO adminDTO)
            {
                subjIdlbl.Visible = false;
                subjIDval.Visible = false;
                textAddress.Enabled = false;
                textEmail.Text = adminDTO.email;
                textPhone.Text =adminDTO.phonenumber;

                textName.Enabled = false;
                age.Enabled = false;
                EditId = adminDTO.Id;
            }
            else if (profileData is ParentResponseDto parentDTO)
            {
                subjIdlbl.Visible = false;
                subjIDval.Visible = false;
                textAddress.Text = parentDTO.Address;
                textPhone.Enabled= false;

                textEmail.Text = parentDTO.Email;
                textName.Text = parentDTO.Fullname;
                age.Value = parentDTO.Age;
                EditId = parentDTO.Id;
            }
        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
        private void Clear()
        {
            textAddress.Clear();
            textEmail.Clear();
            textPhone.Clear();
            textName.Clear();
            age.Value = 1;
            subjIDval.Value = 1;
            textUsername.Clear();
            
            this.Dispose();

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Clear();

        }

        private void pictureBox_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }


       
        private async Task<HttpStatusCode> UpdateDataAPI<T>(T updateDto, string apiUrl)
        {
            try
            {
                string jsonData = JsonConvert.SerializeObject(updateDto);
                var content = new StringContent(jsonData, Encoding.UTF8, "application/json");

                // Add Bearer token if available
                if (!string.IsNullOrWhiteSpace(GlobalConfig.Instance.Token))
                {
                    _http.DefaultRequestHeaders.Authorization =
                        new System.Net.Http.Headers.AuthenticationHeaderValue("Bearer", GlobalConfig.Instance.Token);
                }

                // Send the PUT request asynchronously
                HttpResponseMessage response = await _http.PutAsync(apiUrl, content);

                if (response.IsSuccessStatusCode)
                {
                    MessageBox.Show($"Data updated successfully: {response.StatusCode}");
                    return response.StatusCode;
                }
                else
                {
                    MessageBox.Show($"Failed to update. Status: {response.StatusCode}");
                    return response.StatusCode;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}");
                return HttpStatusCode.InternalServerError;
            }
        }
        private async void btnUpdate_Click_1(object sender, EventArgs e)
        {
            if (GlobalConfig.Instance.role == "Teacher")
            {
                var _editTeacher = new EditTeacherDTO()
                {
                    address = textAddress.Text,
                    email = textEmail.Text,
                    phonenumber = textPhone.Text,
                    Teacher_fullName = textName.Text,
                    age = (int)age.Value,
                    SubjectId = (int)subjIDval.Value,
                    
                    Id = EditId
                };

                var status = await UpdateDataAPI(_editTeacher, $"api/Teacher");
                if (status == HttpStatusCode.OK)
                {
                    Clear();
                }
            }
            else if (GlobalConfig.Instance.role == "Parent")
            {
                var _editParent = new ParentUpdateDto()
                {
                    Address = textAddress.Text,
                    Email = textEmail.Text,
                    Fullname = textName.Text,
                    Age = (int)age.Value,
                };

                var status = await UpdateDataAPI(_editParent, $"api/Parent/{EditId}");
                if (status == HttpStatusCode.OK)
                {
                    Clear();
                }
            }
            else if (GlobalConfig.Instance.role == "Admin")
            {
                var _editAdmin = new EditAdminDTO()
                {
                    address = textAddress.Text,
                    email = textEmail.Text,
                    phonenumber = textPhone.Text,
                    fullName = textName.Text,
                    age = (int)age.Value,
                    Id = EditId
                };

                var status = await UpdateDataAPI(_editAdmin, $"api/Admin/{EditId}");
                if (status == HttpStatusCode.OK)
                {
                    Clear();
                }
            }
        }



        }
}
