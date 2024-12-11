using Attendance_Student.DTOs.ClassDTO;
using AttendanceSeekers_client.Services;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Net.Http;
using System.Net;
using System.Text;
using System.Text.Json;
using static System.Net.WebRequestMethods;
using Attendance_Student.DTOs.TeacherDTO;
using Attendance_Student.DTOs.SubjectDTO;
using Attendance_Student.DTOs.ParentDTOs;

namespace AttendanceSeekers_client
{
    public partial class ParentModule : Form
    {

        HttpClient _http = GlobalConfig.Instance.HttpClient;
        string EditId;
        //EditTeacherDTO _editTeacher;
        public ParentModule()
        {
            InitializeComponent();
            btnUpdate.Enabled = false;
            btnSave.Enabled = true;
            passlbl.Visible = true;
            textPass.Visible = true;
            textUsername.Visible = true;
            usernamelbl.Visible = true;
        }
        public ParentModule(SelectParentDTO parentDTO)
        {
            InitializeComponent();

            passlbl.Visible = false;
            textPass.Visible = false;
            textUsername.Visible = false;
            usernamelbl.Visible = false;
            btnUpdate.Enabled = true;
            btnSave.Enabled = false;

            //_editTeacher = editparentDTO;
            textAddress.Text = parentDTO.address;
            textEmail.Text = parentDTO.
            textPhone.Text = parentDTO.phonenumber;
            textTeacherName.Text = parentDTO.Teacher_fullName;
            age.Value = parentDTO.age;
            subjId.Value = parentDTO.SubjectId;
            EditId = parentDTO.Id;

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
            textTeacherName.Clear();
            age.Value = 1;
            subjId.Value = 1;
            textUsername.Clear();
            textPass.Clear();
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


        private async Task<HttpStatusCode> PostDataFromAPI(AddparentDTO addparentDTO)
        {
            try
            {
                string apiUrl = "api/Teacher";

                string jsonData = JsonConvert.SerializeObject(addparentDTO);

                var content = new StringContent(jsonData, Encoding.UTF8, "application/json");

                // Add the Bearer token to the headers if available
                if (!string.IsNullOrWhiteSpace(GlobalConfig.Instance.Token))
                {
                    _http.DefaultRequestHeaders.Authorization =
                        new System.Net.Http.Headers.AuthenticationHeaderValue("Bearer", GlobalConfig.Instance.Token);
                }

                // Send the POST request asynchronously
                HttpResponseMessage response = await _http.PostAsync(apiUrl, content);

                // Check the response status
                if (response.IsSuccessStatusCode)
                {

                    string responseBody = await response.Content.ReadAsStringAsync();
                    MessageBox.Show($"Data posted successfully. {response.StatusCode}");

                    return response.StatusCode;
                }
                else
                {
                    // Handle failed responses
                    return response.StatusCode;
                }
            }
            catch (Exception ex)
            {
                // Log the exception (optional)
                MessageBox.Show($"An error occurred: {ex.Message}");

                // Return a status code indicating an error (e.g., 500 Internal Server Error)
                return HttpStatusCode.InternalServerError;
            }
        }

        private async Task<HttpStatusCode> UpdateDataFromAPI(EditparentDTO editparentDTO)
        {
            try
            {
                string apiUrl = $"api/Teacher"; // Assuming Class_Id is the identifier for the class to update.

                string jsonData = JsonConvert.SerializeObject(editparentDTO);

                var content = new StringContent(jsonData, Encoding.UTF8, "application/json");

                // Add the Bearer token to the headers if available
                if (!string.IsNullOrWhiteSpace(GlobalConfig.Instance.Token))
                {
                    _http.DefaultRequestHeaders.Authorization =
                        new System.Net.Http.Headers.AuthenticationHeaderValue("Bearer", GlobalConfig.Instance.Token);
                }

                // Send the PUT request asynchronously (using PUT to update existing resources)
                HttpResponseMessage response = await _http.PutAsync(apiUrl, content);

                // Check the response status
                if (response.IsSuccessStatusCode)
                {
                    string responseBody = await response.Content.ReadAsStringAsync();
                    MessageBox.Show($"Data updated successfully. {response.StatusCode}");

                    return response.StatusCode;
                }
                else
                {
                    // Handle failed responses
                    MessageBox.Show($"Failed to update Teacher. Status: {response.StatusCode}");
                    return response.StatusCode;
                }
            }
            catch (Exception ex)
            {
                // Log the exception (optional)
                MessageBox.Show($"An error occurred: {ex.Message}");

                // Return a status code indicating an error (e.g., 500 Internal Server Error)
                return HttpStatusCode.InternalServerError;
            }
        }


        private async void btnUpdate_Click_1(object sender, EventArgs e)
        {
            var _editTeacher = new EditparentDTO()
            {
                address = textAddress.Text,
                email = textEmail.Text,
                phonenumber = textPhone.Text,
                Teacher_fullName = textTeacherName.Text,
                age = (int)age.Value,
                SubjectId = (int)subjId.Value,
                Id = EditId
            };

            try
            {
                var status = await UpdateDataFromAPI(_editTeacher);

                if (status == HttpStatusCode.OK)
                {
                    MessageBox.Show($"Teacher updated successfully: {_editTeacher.Teacher_fullName}");
                    Clear();
                }
                else
                {
                    MessageBox.Show($"Failed to update teacher. Status: {status}");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}");
            }

        }

       
        private async void btnSave_Click(object sender, EventArgs e)
        {
            var _addTeacher = new AddparentDTO()
            {
                address = textAddress.Text,
                email = textEmail.Text,
                phonenumber = textPhone.Text,
                Teacher_fullName = textTeacherName.Text,
                age = (int)age.Value,
                SubjectId = (int)subjId.Value,
                username = textUsername.Text,
                password = textPass.Text
            };

            try
            {
                var status = await PostDataFromAPI(_addTeacher);

                if (status == HttpStatusCode.OK)
                {
                    MessageBox.Show($"Teacher updated successfully: {_addTeacher.Teacher_fullName}");
                    Clear();
                }
                else
                {
                    MessageBox.Show($"Failed to update teacher. Status: {status}");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}");
            }

        }
    }
}
