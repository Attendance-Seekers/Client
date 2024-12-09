using Attendance_Student.DTOs.StudentDTO;
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
        HttpClient _httpClient;

        public AdminForm()
        {
            InitializeComponent();
            _httpClient = new HttpClient();
            LoadDataAsync();

        }
        private async void LoadDataAsync()
        {
            var students = await FetchDataFromAPI();
            var Top5StudentsAbsent = students.Take(5).ToList();
            //TopAbsentStudentView.AutoGenerateColumns = false;
            TopAbsentStudentView.DataSource = Top5StudentsAbsent;

        }
        private async Task<List<SelectStudentDTO>> FetchDataFromAPI()
        {
            using (_httpClient)
            {
                string url = "https://localhost:7241/api/Student";
                HttpResponseMessage response = await _httpClient.GetAsync(url);
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
        }

        private void lblStudentAbsent_Click(object sender, EventArgs e)
        {

        }

        private void bunifuLabel3_Click(object sender, EventArgs e)
        {

        }
    }
}
