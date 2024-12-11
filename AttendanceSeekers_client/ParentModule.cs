using Attendance_Student.DTOs.ParentDTOs;
using Newtonsoft.Json;
using System.Net;
using System.Text;

namespace AttendanceSeekers_client
{
    public partial class ParentModule : Form
    {

        HttpClient _http = GlobalConfig.Instance.HttpClient;
        string EditId;
        
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
        public ParentModule(ParentResponseDto parentDTO)
        {
            InitializeComponent();

            passlbl.Visible = false;
            textPass.Visible = false;
            textUsername.Visible = false;
            usernamelbl.Visible = false;
            btnUpdate.Enabled = true;
            btnSave.Enabled = false;

            textAddress.Text = parentDTO.Address;
            textEmail.Text = parentDTO.Email;

            textParentName.Text = parentDTO.Fullname;
            age.Value = parentDTO.Age;
            
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
            textParentName.Clear();
            age.Value = 1;
            
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


        private async Task<HttpStatusCode> PostDataFromAPI(ParentCreateDto addparentDTO)
        {
            try
            {
                string apiUrl = "api/Parent";

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

        private async Task<HttpStatusCode> UpdateDataFromAPI(ParentUpdateDto editparentDTO)
        {
            try
            {
                string apiUrl = $"api/Parent/{EditId}"; // Assuming Class_Id is the identifier for the class to update.

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
                    MessageBox.Show($"Failed to update Data. Status: {response.StatusCode}");
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
            var _editparent = new ParentUpdateDto()
            {
                Address = textAddress.Text,
                Email = textEmail.Text,
                Fullname = textParentName.Text,
                Age = (int)age.Value,
                
            };

            try
            {
                var status = await UpdateDataFromAPI(_editparent);

                if (status == HttpStatusCode.OK)
                {
                    //MessageBox.Show($"Parent updated successfully: {_editparent.Fullname}");
                    Clear();
                }
                else
                {
                    //MessageBox.Show($"Failed to update Parent. Status: {status}");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}");
            }

        }

       
        private async void btnSave_Click(object sender, EventArgs e)
        {
            var _addparent = new ParentCreateDto()
            {
                Address = textAddress.Text,
                Email = textEmail.Text,
                Fullname = textParentName.Text,
                Age = (int)age.Value,
                Username = textUsername.Text,
                Password = textPass.Text
            };

            try
            {
                var status = await PostDataFromAPI(_addparent);

                if (status == HttpStatusCode.Created)
                {
                    MessageBox.Show($"Parent updated successfully: {_addparent.Fullname}");
                    Clear();
                }
                else
                {
                    MessageBox.Show($"Failed to update Parent. Status: {status}");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}");
            }

        }
    }
}
