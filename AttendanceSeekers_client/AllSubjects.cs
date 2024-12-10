using Attendance_Student.DTOs.StudentDTO;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Net;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;
using Attendance_Student.DTOs.ClassDTO;
using Attendance_Student.DTOs.Account_DTOs;
using static AttendanceSeekers_client.LoginForm;
using Microsoft.AspNetCore.Mvc;
using Attendance_Student.DTOs.SubjectDTO;

namespace AttendanceSeekers_client
{
    public partial class AllSubjcets : Form
    {
        HttpClient _httpClient = GlobalConfig.Instance.HttpClient;

        public AllSubjcets()
        {

            InitializeComponent();
            dgvSubject.Visible = true;

            LoadClassesAsync();

        }
        private async void LoadClassesAsync()
        {
            var subjects = await FetchDataFromAPI();
           
            dgvSubject.DataSource = subjects;
            dgvSubject.Visible = true;
            dgvSubject.Columns[0].HeaderText = "Id";
            dgvSubject.Columns[0].Name = "Id";



        }
        private async Task<List<SelectSubjectDTO>> FetchDataFromAPI()
        {

            string ApiURL = "api/Subject";
            if (!string.IsNullOrWhiteSpace(GlobalConfig.Instance.Token))
            {
                _httpClient.DefaultRequestHeaders.Authorization =
                    new System.Net.Http.Headers.AuthenticationHeaderValue("Bearer", GlobalConfig.Instance.Token);
            }
            HttpResponseMessage response = await _httpClient.GetAsync(ApiURL);
            if (response.StatusCode == HttpStatusCode.OK)
            {
                string json = await response.Content.ReadAsStringAsync();
                return JsonConvert.DeserializeObject<List<SelectSubjectDTO>>(json);
            }
            else
            {
                throw new Exception($"Failed to fetch data: {response.StatusCode}");
            }

        }
        private async Task<SelectSubjectDTO> FetchDataFromAPIUsingId(int id)
        {

            string ApiURL = $"api/Subject/{id}";
            if (!string.IsNullOrWhiteSpace(GlobalConfig.Instance.Token))
            {
                _httpClient.DefaultRequestHeaders.Authorization =
                    new System.Net.Http.Headers.AuthenticationHeaderValue("Bearer", GlobalConfig.Instance.Token);
            }
            HttpResponseMessage response = await _httpClient.GetAsync(ApiURL);
            if (response.StatusCode == HttpStatusCode.OK)
            {
                string json = await response.Content.ReadAsStringAsync();
                return JsonConvert.DeserializeObject<SelectSubjectDTO>(json);
            }
            else
            {
                throw new Exception($"Failed to fetch data: {response.StatusCode}");
            }

        }
        private async Task<HttpStatusCode> PostDataFromAPI(AddSubjectDTO addSubjectDTO)
        {
            try
            {
                string apiUrl = "api/Subjcet";

                string jsonData = JsonConvert.SerializeObject(addSubjectDTO);

                var content = new StringContent(jsonData, Encoding.UTF8, "application/json");

                // Add the Bearer token to the headers if available
                if (!string.IsNullOrWhiteSpace(GlobalConfig.Instance.Token))
                {
                    _httpClient.DefaultRequestHeaders.Authorization =
                        new System.Net.Http.Headers.AuthenticationHeaderValue("Bearer", GlobalConfig.Instance.Token);
                }

                // Send the POST request asynchronously
                HttpResponseMessage response = await _httpClient.PostAsync(apiUrl, content);

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




        private async void btnAdd_Click(object sender, EventArgs e)
        {
            SubjectModule subjectModule = new SubjectModule();
            subjectModule.ShowDialog();
            LoadClassesAsync();

        }

        private async void dgvClass_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex >= 0) // Ensure a valid row is selected
            {
                try
                {
                    // Get the ID from the corresponding cell
                    int id = Convert.ToInt32(dgvSubject.Rows[e.RowIndex].Cells["Id"].Value);

                    // Fetch the class data using the ID
                    var subjectDTO = await FetchDataFromAPIUsingId(id);

                    SubjectModule subjectModule = new SubjectModule(subjectDTO);
                    subjectModule.ShowDialog();
                    LoadClassesAsync();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"An error occurred: {ex.Message}");
                }
            }

        }

        private async void dgvClass_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex >= 0) // Ensure a valid row is selected
            {
                try
                {
                    // Get the ID from the corresponding cell
                    int id = Convert.ToInt32(dgvSubject.Rows[e.RowIndex].Cells["Id"].Value);

                    // Fetch the class data using the ID
                    var subjectDTO = await FetchDataFromAPIUsingId(id);

                    SubjectModule subjectModule = new SubjectModule(subjectDTO);
                    subjectModule.ShowDialog();
                    LoadClassesAsync();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"An error occurred: {ex.Message}");
                }
            }
        }
    }
}
