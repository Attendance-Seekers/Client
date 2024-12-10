using Attendance_Student.DTOs.ClassDTO;
using Attendance_Student.DTOs.DepartmentDTO;
using Attendance_Student.DTOs.StudentDTO;
using Attendance_Student.DTOs.TeacherDTO;
using Bunifu.Licensing.Models;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AttendanceSeekers_client
{
    public partial class AdminForm : Form
    {
        HttpClient _httpClient = GlobalConfig.Instance.HttpClient;

        public AdminForm()
        {
            InitializeComponent();
            //_httpClient = new HttpClient();
            LoadDataAsync();

        }
        private async void LoadDataAsync()
        {
            var students = await FetchStudentDataFromAPI();
            var teachers = await FetchTeacherDataFromAPI();
            var classes = await FetchClassDataFromAPI();
            var depts = await FetchDeptDataFromAPI();
           
            var Top5StudentsAbsent = students.Take(5).ToList();
            //TopAbsentStudentView.AutoGenerateColumns = false;
            TopAbsentStudentView.DataSource = Top5StudentsAbsent;
            totalStudentLabel.Text = students.Count().ToString();
            totalClassLabel.Text = classes.Count().ToString();
            totalTeacherLabel.Text= teachers.Count().ToString();
            totalDeptLabel.Text= depts.Count().ToString();
            

        }
        private async Task<List<SelectStudentDTO>> FetchStudentDataFromAPI()
        {
            
                string ApiURL = "api/Student";
                HttpResponseMessage response = await _httpClient.GetAsync(ApiURL);
                if (response.StatusCode == HttpStatusCode.OK)
                {
                    string json = await response.Content.ReadAsStringAsync();
                    return JsonConvert.DeserializeObject<List<SelectStudentDTO>>(json);
                }
                else
                {
                    throw new Exception($"Failed to fetch data: {response.StatusCode}");
                }
            
        }
        private async Task<List<SelectDepartmentDTO>> FetchDeptDataFromAPI()
        {
            
                string ApiURL = "api/Department";
                HttpResponseMessage response = await _httpClient.GetAsync(ApiURL);
                if (response.StatusCode == HttpStatusCode.OK)
                {
                    string json = await response.Content.ReadAsStringAsync();
                    return JsonConvert.DeserializeObject<List<SelectDepartmentDTO>>(json);
                }
                else
                {
                    throw new Exception($"Failed to fetch data: {response.StatusCode}");
                }
            
        }
        private async Task<List<SelectClassDTO>> FetchClassDataFromAPI()
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
        private async Task<List<SelectTeacherDTO>> FetchTeacherDataFromAPI()
        {
            
                string ApiURL = "api/Student";
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
        private void lblStudentAbsent_Click(object sender, EventArgs e)
        {

        }

        private void bunifuLabel3_Click(object sender, EventArgs e)
        {

        }
    }
}
