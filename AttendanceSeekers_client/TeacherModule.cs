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

namespace AttendanceSeekers_client
{
    public partial class TeacherModule : Form
    {

        HttpClient _http = GlobalConfig.Instance.HttpClient;
        string EditId;
        //EditTeacherDTO _editTeacher;
        public TeacherModule()
        {
            InitializeComponent();
            btnUpdate.Enabled = false;

        }
        public TeacherModule(SelectTeacherDTO TeacherDTO)
        {
            InitializeComponent();


            btnUpdate.Enabled = true;
            //_editTeacher = editTeacherDTO;
            textAddress.Text = TeacherDTO.address;
            textEmail.Text = TeacherDTO.email;
            textPhone.Text = TeacherDTO.phonenumber;
            textTeacherName.Text = TeacherDTO.Teacher_fullName;
            age.Value = TeacherDTO.age;
            subjId.Value = TeacherDTO.SubjectId;
            EditId = TeacherDTO.Id;

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



        private async Task<HttpStatusCode> UpdateDataFromAPI(EditTeacherDTO editTeacherDTO)
        {
            try
            {
                string apiUrl = $"api/Teacher"; // Assuming Class_Id is the identifier for the class to update.

                string jsonData = JsonConvert.SerializeObject(editTeacherDTO);

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
            var _editTeacher = new EditTeacherDTO()
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
                    MessageBox.Show($"Class updated successfully: {_editTeacher.Teacher_fullName}");
                    Clear();
                }
                else
                {
                    MessageBox.Show($"Failed to update class. Status: {status}");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}");
            }

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
