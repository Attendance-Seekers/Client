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

using static System.Net.WebRequestMethods;
using Attendance_Student.DTOs.ParentDTOs;

namespace AttendanceSeekers_client
{
    public partial class AllParents : Form
    {
        HttpClient _httpClient = GlobalConfig.Instance.HttpClient;


        public AllParents()
        {

            InitializeComponent();
            LoadParentsAsync();

        }
        private async void LoadParentsAsync()
        {
            var Parents = await FetchDataFromAPI();
        
            dgvParent.DataSource = Parents;

            // Now reorder the columns
            dgvParent.Columns["Id"].DisplayIndex = 0; 
            dgvParent.Columns["FullName"].DisplayIndex = 1; 
            dgvParent.Columns["Address"].DisplayIndex = 2;          
            dgvParent.Columns["Age"].DisplayIndex = 3;              
            dgvParent.Columns["UserName"].DisplayIndex = 4;         


        }
        private async Task<List<ParentResponseDto>> FetchDataFromAPI()
        {

            string ApiURL = "api/Parent";
            if (!string.IsNullOrWhiteSpace(GlobalConfig.Instance.Token))
            {
                _httpClient.DefaultRequestHeaders.Authorization =
                    new System.Net.Http.Headers.AuthenticationHeaderValue("Bearer", GlobalConfig.Instance.Token);
            }

            HttpResponseMessage response = await _httpClient.GetAsync(ApiURL);
            if (response.StatusCode == HttpStatusCode.OK)
            {
                string json = await response.Content.ReadAsStringAsync();
                return JsonConvert.DeserializeObject<List<ParentResponseDto>>(json);
            }
            else
            {
                throw new Exception($"Failed to fetch data: {response.StatusCode}");
            }

        }
        private async Task<ParentResponseDto> FetchDataFromAPIUsingId(string id)
        {

            string ApiURL = $"api/Parent/{id}";
            if (!string.IsNullOrWhiteSpace(GlobalConfig.Instance.Token))
            {
                _httpClient.DefaultRequestHeaders.Authorization =
                    new System.Net.Http.Headers.AuthenticationHeaderValue("Bearer", GlobalConfig.Instance.Token);
            }
            HttpResponseMessage response = await _httpClient.GetAsync(ApiURL);
            if (response.StatusCode == HttpStatusCode.OK)
            {
                string json = await response.Content.ReadAsStringAsync();
                return JsonConvert.DeserializeObject<ParentResponseDto>(json);
            }
            else
            {
                throw new Exception($"Failed to fetch data: {response.StatusCode}");
            }

        }
        
        private async void btnAdd_Click(object sender, EventArgs e)
        {
          
            ParentModule ParentModule = new ParentModule();
            ParentModule.ShowDialog();
            LoadParentsAsync();

        }

      

        private async void dgvClass_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            
            if (e.RowIndex >= 0) // Ensure a valid row is selected
            {
                try
                {
                    // Get the ID from the corresponding cell
                    string id = Convert.ToString(dgvParent.Rows[e.RowIndex].Cells["Id"].Value);

                    // Fetch the class data using the ID
                    var ParentDTO = await FetchDataFromAPIUsingId(id);

                    // Pass the fetched data to the ClassModule form
                    ParentModule ParentModule = new ParentModule(ParentDTO);
                    ParentModule.ShowDialog(); // Open the form as a modal dialog
                    LoadParentsAsync();

                }
                catch (Exception ex)
                {
                    MessageBox.Show($"An error occurred: {ex.Message}");
                }
            }
        }
    }
}
