using Attendance_Student.DTOs.DepartmentDTO;
using Newtonsoft.Json;
using System.Net;
using System.Text;

namespace AttendanceSeekers_client
{
    public partial class DepartmentModule : Form
    {

        HttpClient _http = GlobalConfig.Instance.HttpClient;
        int editId;
        public DepartmentModule()
        {
            InitializeComponent();
            btnUpdate.Enabled = false;
            btnSave.Enabled = true;

        }
        public DepartmentModule(SelectDepartmentDTO selectDepartment)
        {
            InitializeComponent();
           
            textName.Text = selectDepartment.Name;
            editId= selectDepartment.Id;

            btnSave.Enabled = false;
            btnUpdate.Enabled = true;


        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {


            this.Dispose();
        }
        private void Clear()
        {
            textName.Clear();
           
            textName.Focus();

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


        private async Task<HttpStatusCode> PostDataFromAPI(AddDepartmentDTO departmentDTO)
        {
            try
            {
                string apiUrl = "api/Department";

                string jsonData = JsonConvert.SerializeObject(departmentDTO);

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

        private async Task<HttpStatusCode> UpdateDataFromAPI(EditDepartmentDTO departmentDTO)
        {
            try
            {
                string apiUrl = $"api/Department"; // Assuming Class_Id is the identifier for the class to update.

                string jsonData = JsonConvert.SerializeObject(departmentDTO);

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
                    MessageBox.Show($"Failed to update department. Status: {response.StatusCode}");
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

        private async void btnSave_Click(object sender, EventArgs e)
        {
            var deptDto = new AddDepartmentDTO()
            {
                Name = textName.Text,
                TeachersIDs = [],
                SubjectsIDs = []
            };

            try
            {
                var status = await PostDataFromAPI(deptDto);

                if (status == HttpStatusCode.Created)
                {
                    MessageBox.Show($"Department added successfully: {deptDto.Name}");
                    Clear();
                }
                else
                {
                    MessageBox.Show($"Failed to add department. Status: {status}");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}");
            }
        }

        private async void btnUpdate_Click_1(object sender, EventArgs e)
        {

            var editdeptDto = new EditDepartmentDTO()
            {
                Id=editId,
                Name = textName.Text,
                TeachersIDs= [],
                SubjectsIDs = [],
                flagAddOrOverwrite = false // don't overwrite cause we didn't handle editing student in class yet
            };

            try
            {
                var status = await UpdateDataFromAPI(editdeptDto); // Using the UpdateDataFromAPI function

                if (status == HttpStatusCode.OK)
                {
                    MessageBox.Show($"Department updated successfully: {editdeptDto.Name}");
                    Clear(); // Optionally clear input fields or reset the UI
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

    }
}
