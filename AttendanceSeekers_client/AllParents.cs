using Attendance_Student.DTOs.ParentDTOs;
using Newtonsoft.Json;
using System.Net;

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
                string errorMessage = await response.Content.ReadAsStringAsync();
                MessageBox.Show($"Failed to fetch data: {response.StatusCode}\nDetails: {errorMessage}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return new List<ParentResponseDto>();
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
                string errorMessage = await response.Content.ReadAsStringAsync();
                MessageBox.Show($"Failed to fetch data: {response.StatusCode}\nDetails: {errorMessage}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return new ParentResponseDto();
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
