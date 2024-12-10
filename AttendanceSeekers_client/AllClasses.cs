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

namespace AttendanceSeekers_client
{
    public partial class AllClasses : Form
    {
        HttpClient _httpClient = GlobalConfig.Instance.HttpClient;

        private bool isAddingNewClass = false;

        public AllClasses()
        {

            InitializeComponent();
            dgvClass.Visible = true;

            LoadClassesAsync();

            //_httpClient = new HttpClient();
        }
        private async void LoadClassesAsync()
        {
            var Classes = await FetchDataFromAPI();
            //var Classes = students.Take(20).ToList();
            //TopAbsentStudentView.AutoGenerateColumns = false;
            dgvClass.DataSource = Classes;
            dgvClass.Visible = true;



        }
        private async Task<List<SelectClassDTO>> FetchDataFromAPI()
        {

            string ApiURL = "api/classes";
            HttpResponseMessage response = await _httpClient.GetAsync(ApiURL);
            if (response.StatusCode == HttpStatusCode.OK)
            {
                string json = await response.Content.ReadAsStringAsync();
                return JsonConvert.DeserializeObject<List<SelectClassDTO>>(json);
            }
            else
            {
                throw new Exception($"Failed to fetch data: {response.StatusCode}");
            }

        }
        private async Task<SelectClassDTO> FetchDataFromAPIUsingId(int id)
        {

            string ApiURL = $"api/classes/{id}";
            HttpResponseMessage response = await _httpClient.GetAsync(ApiURL);
            if (response.StatusCode == HttpStatusCode.OK)
            {
                string json = await response.Content.ReadAsStringAsync();
                return JsonConvert.DeserializeObject<SelectClassDTO>(json);
            }
            else
            {
                throw new Exception($"Failed to fetch data: {response.StatusCode}");
            }

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
            ClassModule classModule = new ClassModule();
            classModule.ShowDialog();
            LoadClassesAsync();

        }

        private async void dgvClass_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex >= 0) // Ensure a valid row is selected
            {
                try
                {
                    // Get the ID from the corresponding cell
                    int id = Convert.ToInt32(dgvClass.Rows[e.RowIndex].Cells["Id"].Value);

                    // Fetch the class data using the ID
                    var classDTO = await FetchDataFromAPIUsingId(id);

                    // Pass the fetched data to the ClassModule form
                    ClassModule classModule = new ClassModule(classDTO.Class_Id, classDTO.Class_Name, classDTO.Class_Size);
                    classModule.ShowDialog(); // Open the form as a modal dialog
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
                    int id = Convert.ToInt32(dgvClass.Rows[e.RowIndex].Cells["Id"].Value);

                    // Fetch the class data using the ID
                    var classDTO = await FetchDataFromAPIUsingId(id);

                    // Pass the fetched data to the ClassModule form
                    ClassModule classModule = new ClassModule(classDTO.Class_Id, classDTO.Class_Name, classDTO.Class_Size);
                    classModule.ShowDialog(); // Open the form as a modal dialog
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
