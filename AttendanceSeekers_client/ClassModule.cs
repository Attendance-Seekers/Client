using Attendance_Student.DTOs.ClassDTO;
using Newtonsoft.Json;
using System.Net;
using System.Text;

namespace AttendanceSeekers_client
{
    public partial class ClassModule : Form
    {

        HttpClient _http = GlobalConfig.Instance.HttpClient;
        //private int _classId;
        //private string _className;
        //private int _classSize;
        //Requests _requests;
        public ClassModule()
        {
            InitializeComponent();
            btnUpdate.Enabled = false; 
             lblId.Visible = false;
            Class_id.Visible = false;
            btnSave.Enabled = true;


            //_http = new HttpClient();
            //_requests = new Requests();
        }
        public ClassModule(int classId, string className, int classSize)
        {
            InitializeComponent();
            lblId.Visible = false;
            Class_id.Visible = false;
            Class_id.Value = classId;
            Size.Value= classSize;
            textClassName.Text = className;
            btnSave.Enabled = false;
            btnUpdate.Enabled = true;


        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {


            this.Dispose();
        }
        private void Clear()
        {
            textClassName.Clear();
            Size.Value = 1;
            textClassName.Focus();
            
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


        private async Task<HttpStatusCode> PostDataFromAPI(AddClassDTO addClassDTO)
        {
            try
            {
                string apiUrl = "api/classes";

                string jsonData = JsonConvert.SerializeObject(addClassDTO);

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

        private async Task<HttpStatusCode> UpdateDataFromAPI(EditClassDTO editClassDTO)
        {
            try
            {
                string apiUrl = $"api/classes"; // Assuming Class_Id is the identifier for the class to update.

                string jsonData = JsonConvert.SerializeObject(editClassDTO);

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
                    MessageBox.Show($"Failed to update class. Status: {response.StatusCode}");
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
            var classDto = new AddClassDTO()
            {
                Class_Name = textClassName.Text,
                Class_Size = (int)Size.Value,
                studentsIDs = []
            };

            try
            {
                var status = await PostDataFromAPI(classDto);

                if (status == HttpStatusCode.Created)
                {
                    MessageBox.Show($"Class added successfully: {classDto.Class_Name}, Size: {classDto.Class_Size}");
                    Clear();
                }
                else
                {
                    MessageBox.Show($"Failed to add class. Status: {status}");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}");
            }
        }

        private async void btnUpdate_Click_1(object sender, EventArgs e)
        {
           
            var editClassDto = new EditClassDTO()
            {
                Class_Id = (int)Class_id.Value,
                Class_Name = textClassName.Text,
                Class_Size = (int)Size.Value,
                studentsIDs = new List<string>(),
                flagAddOrOverwrite = false // don't overwrite cause we didn't handle editing student in class yet
            };

            try
            {
                var status = await UpdateDataFromAPI(editClassDto); // Using the UpdateDataFromAPI function

                if (status == HttpStatusCode.OK)
                {
                    MessageBox.Show($"Class updated successfully: {editClassDto.Class_Name}, Size: {editClassDto.Class_Size}");
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
