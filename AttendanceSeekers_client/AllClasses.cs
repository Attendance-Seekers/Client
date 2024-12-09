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
using System.Threading.Tasks;
using System.Windows.Forms;
using Attendance_Student.DTOs.ClassDTO;

namespace AttendanceSeekers_client
{
    public partial class AllClasses : Form
    {
        HttpClient _httpClient;
        public AllClasses()
        {
            InitializeComponent();
            _httpClient = new HttpClient();
        }
        private async void LoadClassesAsync()
        {
            var Classes = await FetchDataFromAPI();
            //var Classes = students.Take(20).ToList();
            //TopAbsentStudentView.AutoGenerateColumns = false;
            dgvClass.DataSource = Classes;



        }
        private async Task<List<SelectClassDTO>> FetchDataFromAPI()
        {
            using (_httpClient)
            {
                string url = "https://localhost:7241/api/classes";
                HttpResponseMessage response = await _httpClient.GetAsync(url);
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
        }


    }
}
