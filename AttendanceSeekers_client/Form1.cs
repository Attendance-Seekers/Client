using System.Net.Http.Json;
using System.Net.Http;
using System.Text;
using System.Text.Json;
using Attendance_Student.DTOs.ClassDTO;


namespace AttendanceSeekers_client
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            try 
            {
                
                var classes = await GlobalConfig.Instance.HttpClient.GetFromJsonAsync<IEnumerable<SelectClassDTO>>("api/classes");
             
                if (classes != null)
                        {
                            // Display formatted JSON in the RichTextBox
                            string formattedJson = JsonSerializer.Serialize(classes, new JsonSerializerOptions { WriteIndented = true });
                            richTextBox1.Text = formattedJson;

                            // Bind data to DataGridView
                            dataGridView1.DataSource = classes.Select(c => new
                            {
                                c.Class_Id,
                                c.Class_Name,
                                c.Class_Size,
                                StudentsCount = c.students?.Count ?? 0 // Show number of students
                            }).ToList();
                        }
                else
                {
                    richTextBox1.Text = "No data received.";
                }
            }

            catch (Exception ex)
            {
                // Handle exceptions
                MessageBox.Show($"Error: {ex.Message}");
            }

}
    }
}
