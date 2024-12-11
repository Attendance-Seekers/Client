using Attendance_Student.DTOs.ClassDTO;
using Attendance_Student.DTOs.DepartmentDTO;
using Attendance_Student.DTOs.StudentDTO;
using Attendance_Student.DTOs.TeacherDTO;
using Newtonsoft.Json;
using System.Net;

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
            // Add the Bearer token to the headers if available
            if (!string.IsNullOrWhiteSpace(GlobalConfig.Instance.Token))
            {
                _httpClient.DefaultRequestHeaders.Authorization =
                    new System.Net.Http.Headers.AuthenticationHeaderValue("Bearer", GlobalConfig.Instance.Token);
            }
            HttpResponseMessage response = await _httpClient.GetAsync(ApiURL);
                if (response.StatusCode == HttpStatusCode.OK)
                {
                    string json = await response.Content.ReadAsStringAsync();
                    return JsonConvert.DeserializeObject<List<SelectStudentDTO>>(json);
                }
                else
                {
                string errorMessage = await response.Content.ReadAsStringAsync();
                MessageBox.Show($"Failed to fetch data: {response.StatusCode}\nDetails: {errorMessage}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return new List<SelectStudentDTO>();
                }

        }
        private async Task<List<SelectDepartmentDTO>> FetchDeptDataFromAPI()
        {
            
                string ApiURL = "api/Department";
            // Add the Bearer token to the headers if available
            if (!string.IsNullOrWhiteSpace(GlobalConfig.Instance.Token))
            {
                _httpClient.DefaultRequestHeaders.Authorization =
                    new System.Net.Http.Headers.AuthenticationHeaderValue("Bearer", GlobalConfig.Instance.Token);
            }
            HttpResponseMessage response = await _httpClient.GetAsync(ApiURL);
                if (response.StatusCode == HttpStatusCode.OK)
                {
                    string json = await response.Content.ReadAsStringAsync();
                    return JsonConvert.DeserializeObject<List<SelectDepartmentDTO>>(json);
                }
                else
                {
                string errorMessage = await response.Content.ReadAsStringAsync();
                MessageBox.Show($"Failed to fetch data: {response.StatusCode}\nDetails: {errorMessage}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return new List<SelectDepartmentDTO>();
                }
            
        }
        private async Task<List<SelectClassDTO>> FetchClassDataFromAPI()
        {
            
                string ApiURL = "api/classes";
            // Add the Bearer token to the headers if available
            if (!string.IsNullOrWhiteSpace(GlobalConfig.Instance.Token))
            {
                _httpClient.DefaultRequestHeaders.Authorization =
                    new System.Net.Http.Headers.AuthenticationHeaderValue("Bearer", GlobalConfig.Instance.Token);
            }
            HttpResponseMessage response = await _httpClient.GetAsync(ApiURL);
            if (response.StatusCode == HttpStatusCode.OK)
            {
                string json = await response.Content.ReadAsStringAsync();
                return JsonConvert.DeserializeObject<List<SelectClassDTO>>(json);
            }
            else
            {
                string errorMessage = await response.Content.ReadAsStringAsync();
                MessageBox.Show($"Failed to fetch data: {response.StatusCode}\nDetails: {errorMessage}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return new List<SelectClassDTO>();
            }
            
        }
        private async Task<List<SelectTeacherDTO>> FetchTeacherDataFromAPI()
        {
            
                string ApiURL = "api/Student";
            // Add the Bearer token to the headers if available
            if (!string.IsNullOrWhiteSpace(GlobalConfig.Instance.Token))
            {
                _httpClient.DefaultRequestHeaders.Authorization =
                    new System.Net.Http.Headers.AuthenticationHeaderValue("Bearer", GlobalConfig.Instance.Token);
            }
            HttpResponseMessage response = await _httpClient.GetAsync(ApiURL);
            if (response.StatusCode == HttpStatusCode.OK)
            {
                string json = await response.Content.ReadAsStringAsync();
                return JsonConvert.DeserializeObject<List<SelectTeacherDTO>>(json);
            }
            else
            {
                string errorMessage = await response.Content.ReadAsStringAsync();
                MessageBox.Show($"Failed to fetch data: {response.StatusCode}\nDetails: {errorMessage}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return new List<SelectTeacherDTO>();
            }
            
        }
       
    }
}
