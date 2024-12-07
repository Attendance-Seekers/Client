using System.Net.Http.Formatting;
using System.Net.Http;
using Attendance_Student.DTOs.ClassDTO;

namespace AttendanceSeekers_client
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri("https://localhost:7241/");
            HttpResponseMessage response = client.GetAsync("api/classes").Result;
            var classes = response.Content.ReadAsAsync<IEnumerable<SelectClassDTO>>().Result;

            dataGridView1.DataSource = classes;

        }
    }
}
