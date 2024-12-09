using Attendance_Student.DTOs.ClassDTO;
using AttendanceSeekers_client.Services;
using Newtonsoft.Json.Linq;
using System.Text;
using System.Text.Json;
using static System.Net.WebRequestMethods;

namespace AttendanceSeekers_client
{
    public partial class ClassModule : Form
    {

        HttpClient _http;
        Requests _requests;
        public ClassModule()
        {
            InitializeComponent();
            _http = new HttpClient();
            _requests = new Requests(_http);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
        private void Clear()
        {
            textClassName.Clear();
            Size = null;
            textClassName.Focus();
            btnUpdate.Enabled = false;
            btnSave.Enabled = true;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Clear();
        }

        private void pictureBox_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private async Task btnSave_ClickAsync(object sender, EventArgs e)
        {
            using (_http)
            {
                // Define the API endpoint
                string apiUrl = "https://localhost:7241/api/classes";

                // Set the Authorization header with the Bearer token
                //_http.DefaultRequestHeaders.Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue("Bearer", token);


                var classDto = new AddClassDTO()
                {
                    Class_Name = textClassName.Text,
                    Class_Size = (int)Size.Value,
                };


                string jsonPayload = JsonSerializer.Serialize(classDto);

                StringContent content = new StringContent(jsonPayload, Encoding.UTF8, "application/json");


                HttpResponseMessage response = await _http.PostAsync(apiUrl, content);


                if (response.IsSuccessStatusCode)
                {
                    MessageBox.Show("Class added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    string errorMessage = await response.Content.ReadAsStringAsync();
                    MessageBox.Show($"Failed to add class. Error: {errorMessage}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private async void btnUpdate_ClickAsync(object sender, EventArgs e)
        {
            var editClassDto = new EditClassDTO()
            {
                Class_Id = (int)Class_id.Value,
                Class_Name = textClassName.Text,
                Class_Size = (int)Size.Value
            };

            string apiUrl = "https://localhost:7241/api/classes";

            // Call the generic method for PUT
            HttpResponseMessage response = await _requests.SendRequestAsync(apiUrl, HttpMethod.Put, editClassDto);

            await _requests.HandleResponse(response, "Class added successfully!", "Failed to add class");
        }
    }
}
