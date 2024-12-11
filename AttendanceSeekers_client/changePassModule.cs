using Attendance_Student.DTOs.TeacherDTO;
using Newtonsoft.Json;
using System.Net;
using System.Text;

namespace AttendanceSeekers_client
{
    public partial class changePassModule : Form
    {

        HttpClient _http = GlobalConfig.Instance.HttpClient;
        string EditId;
        //EditTeacherDTO _editTeacher;
        public changePassModule()
        {
            InitializeComponent();
         
        }
        

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
        private void Clear()
        {
            oldPass.Clear();
            newPass.Clear();
           
            confirmPass.Clear();
            
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


       
      


        private async void btnSave_Click(object sender, EventArgs e)
        {
            string oldPassword = oldPass.Text;
            string newPassword = newPass.Text;
            string confirmPassword = confirmPass.Text;

            // Validate inputs
            if (string.IsNullOrEmpty(oldPassword) || string.IsNullOrEmpty(newPassword) || string.IsNullOrEmpty(confirmPassword))
            {
                MessageBox.Show("All fields are required.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (newPassword != confirmPassword)
            {
                MessageBox.Show("New password and confirmation do not match.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Prepare data for API request
            var changePasswordRequest = new
            {
                OldPassword = oldPassword,
                NewPassword = newPassword
            };

            string jsonData = JsonConvert.SerializeObject(changePasswordRequest);

           
                try
                {
                    var content = new StringContent(jsonData, Encoding.UTF8, "application/json");
                     string apiUrl = "api/Account/change-password";


                // Add the Bearer token to the headers if available
                if (!string.IsNullOrWhiteSpace(GlobalConfig.Instance.Token))
                    {
                        _http.DefaultRequestHeaders.Authorization =
                            new System.Net.Http.Headers.AuthenticationHeaderValue("Bearer", GlobalConfig.Instance.Token);
                    }

                  HttpResponseMessage response = await _http.PostAsync(apiUrl, content);

                    if (response.IsSuccessStatusCode)
                    {
                        MessageBox.Show("Password changed successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Clear();
                    }
                    else
                    {
                        string errorMessage = await response.Content.ReadAsStringAsync();
                        MessageBox.Show($"Failed to change password: {errorMessage}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            

        }

    }
}
