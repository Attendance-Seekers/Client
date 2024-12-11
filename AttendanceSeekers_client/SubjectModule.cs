using Attendance_Student.DTOs.SubjectDTO;
using Newtonsoft.Json;
using System.Net;
using System.Text;

namespace AttendanceSeekers_client
{
    public partial class SubjectModule : Form
    {

        HttpClient _http = GlobalConfig.Instance.HttpClient;
        int EditId;
        //EditTeacherDTO _editTeacher;
        public SubjectModule()
        {
            InitializeComponent();
            btnUpdate.Enabled = false;
            btnSave.Enabled = true;

        }
        public SubjectModule(SelectSubjectDTO subjectDTO)
        {
            InitializeComponent();


            btnUpdate.Enabled = true;
            btnSave.Enabled = false;
            EditId = subjectDTO.subject_Id;
            textSubjectName.Text=subjectDTO.subject_Name;
            subjectDuration.Value= subjectDTO.subject_Duration;
            deptId.Value= subjectDTO.DeptId;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
        private void Clear()
        {
            textSubjectName.Clear();
            subjectDuration.Value = 1;
            deptId.Value = 1;

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

        private async Task<HttpStatusCode> PostDataFromAPI(AddSubjectDTO addSubjectDTO)
        {
            try
            {
                string apiUrl = "api/Subject";

                string jsonData = JsonConvert.SerializeObject(addSubjectDTO);

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

        private async Task<HttpStatusCode> UpdateDataFromAPI(EditSubjectDTO editSubjectDTO)
        {
            try
            {
                string apiUrl = $"api/Subject"; 

                string jsonData = JsonConvert.SerializeObject(editSubjectDTO);

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
                    MessageBox.Show($"Failed to update subjcet. Status: {response.StatusCode}");
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
            var editSubject = new EditSubjectDTO()
            {
                subject_Id = EditId,
                subject_Name=textSubjectName.Text,
                subject_Duration=(int)subjectDuration.Value,
                DeptId = (int)deptId.Value,

            };

            try
            {
                var status = await UpdateDataFromAPI(editSubject);

                if (status == HttpStatusCode.OK)
                {
                    MessageBox.Show($"Subject updated successfully: {editSubject.subject_Name}");
                    Clear();
                }
                else
                {
                    MessageBox.Show($"Failed to update subject. Status: {status}");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}");
            }

        }

      

        private async  void btnSave_Click(object sender, EventArgs e)
        {
            var subjectDTO = new AddSubjectDTO()
            {
                subject_Name = textSubjectName.Text,
                subject_Duration = (int)subjectDuration.Value,
                DeptId = (int)deptId.Value
            };

            try
            {
                var status = await PostDataFromAPI(subjectDTO);

                if (status == HttpStatusCode.Created)
                {
                    MessageBox.Show($"subject added successfully: {subjectDTO.subject_Name}");
                    Clear();
                }
                else
                {
                    MessageBox.Show($"Failed to add subject. Status: {status}");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}");
            }
        }
    }
}
