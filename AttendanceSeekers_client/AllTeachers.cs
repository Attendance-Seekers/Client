using Attendance_Student.DTOs.TeacherDTO;
using Newtonsoft.Json;
using System.Net;

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
                return new List<SelectTeacherDTO>(); // Return an empty list to avoid exceptions
            }
        }

        private async Task<SelectTeacherDTO> FetchDataFromAPIUsingId(string id)
        {
            string ApiURL = $"api/Teacher/{id}";

            if (!string.IsNullOrWhiteSpace(GlobalConfig.Instance.Token))
            {
                _httpClient.DefaultRequestHeaders.Authorization =
                    new System.Net.Http.Headers.AuthenticationHeaderValue("Bearer", GlobalConfig.Instance.Token);
            }

            HttpResponseMessage response = await _httpClient.GetAsync(ApiURL);

            if (response.StatusCode == HttpStatusCode.OK)
            {
                string json = await response.Content.ReadAsStringAsync();
                return JsonConvert.DeserializeObject<SelectTeacherDTO>(json);
            }
            else
            {
                string errorMessage = await response.Content.ReadAsStringAsync();
                MessageBox.Show($"Failed to fetch data: {response.StatusCode}\nDetails: {errorMessage}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return new SelectTeacherDTO();
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
