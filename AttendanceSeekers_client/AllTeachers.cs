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
using Attendance_Student.DTOs.TeacherDTO;

namespace AttendanceSeekers_client
{
    public partial class AllTeachers : Form
    {
        HttpClient _httpClient = GlobalConfig.Instance.HttpClient;


        public AllTeachers()
        {

            InitializeComponent();
            LoadTeachersAsync();

        }
        private async void LoadTeachersAsync()
        {
            var teachers = await FetchDataFromAPI();
        
            dgvClass.DataSource = teachers;

            // Now reorder the columns
            dgvClass.Columns["Id"].DisplayIndex = 0; 
            dgvClass.Columns["Teacher_fullName"].DisplayIndex = 1; 
            dgvClass.Columns["address"].DisplayIndex = 2;          
            dgvClass.Columns["age"].DisplayIndex = 3;              
            
            dgvClass.Columns["DeptId"].DisplayIndex = 4;           
            dgvClass.Columns["username"].DisplayIndex = 5;         


        }
        private async Task<List<SelectTeacherDTO>> FetchDataFromAPI()
        {

            string ApiURL = "api/Teacher";
            HttpResponseMessage response = await _httpClient.GetAsync(ApiURL);
            if (response.StatusCode == HttpStatusCode.OK)
            {
                string json = await response.Content.ReadAsStringAsync();
                return JsonConvert.DeserializeObject<List<SelectTeacherDTO>>(json);
            }
            else
            {
                throw new Exception($"Failed to fetch data: {response.StatusCode}");
            }

        }
        private async Task<SelectTeacherDTO> FetchDataFromAPIUsingId(string id)
        {

            string ApiURL = $"api/Teacher/{id}";
            HttpResponseMessage response = await _httpClient.GetAsync(ApiURL);
            if (response.StatusCode == HttpStatusCode.OK)
            {
                string json = await response.Content.ReadAsStringAsync();
                return JsonConvert.DeserializeObject<SelectTeacherDTO>(json);
            }
            else
            {
                throw new Exception($"Failed to fetch data: {response.StatusCode}");
            }

        }
        
        private async void btnAdd_Click(object sender, EventArgs e)
        {
          
            TeacherModule teacherModule = new TeacherModule();
            teacherModule.ShowDialog();
            LoadTeachersAsync();

        }

      

        private async void dgvClass_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            
            if (e.RowIndex >= 0) // Ensure a valid row is selected
            {
                try
                {
                    // Get the ID from the corresponding cell
                    string id = Convert.ToString(dgvClass.Rows[e.RowIndex].Cells["Id"].Value);

                    // Fetch the class data using the ID
                    var teacherDTO = await FetchDataFromAPIUsingId(id);

                    // Pass the fetched data to the ClassModule form
                    TeacherModule teacherModule = new TeacherModule(teacherDTO);
                    teacherModule.ShowDialog(); // Open the form as a modal dialog
                    LoadTeachersAsync();

                }
                catch (Exception ex)
                {
                    MessageBox.Show($"An error occurred: {ex.Message}");
                }
            }
        }
    }
}
