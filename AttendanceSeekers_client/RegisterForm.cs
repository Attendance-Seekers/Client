using Attendance_Student.DTOs.StudentDTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AttendanceSeekers_client
{
    public partial class RegisterForm : Form
    {
        public RegisterForm()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void student_fullName_Enter(object sender, EventArgs e)
        {
            student_fullName.Clear();
            student_fullName.ForeColor = Color.Black;
        }

        private void age_textBox_Enter(object sender, EventArgs e)
        {
            age_textBox.Clear();
            age_textBox.ForeColor = Color.Black;
        }

        private void username_textbox_Enter(object sender, EventArgs e)
        {
            username_textbox.Clear();
            username_textbox.ForeColor = Color.Black;
        }

        private void password_textbox_Enter(object sender, EventArgs e)
        {
            password_textbox.Clear();
            password_textbox.ForeColor = Color.Black;
            password_textbox.PasswordChar = '*';
        }

        private void email_textbox_Enter(object sender, EventArgs e)
        {
            email_textbox.Clear();
            email_textbox.ForeColor = Color.Black;
        }

        private void phone_textbox_Enter(object sender, EventArgs e)
        {
            phone_textbox.Clear();
            phone_textbox.ForeColor = Color.Black;
        }

        private void classId_textbox_Enter(object sender, EventArgs e)
        {
            classId_textbox.Clear();
            classId_textbox.ForeColor = Color.Black;
        }

        private void reg_button_Click(object sender, EventArgs e)
        {
            try
            {
                AddStudentDTO newStudent = new AddStudentDTO()
                {
                    Student_fullname = student_fullName.Text,
                    age = int.Parse(age_textBox.Text),
                    username = username_textbox.Text,
                    password = password_textbox.Text,
                    email = email_textbox.Text,
                    phonenumber = phone_textbox.Text,
                    ClassId = int.Parse(classId_textbox.Text),
                    status = 0



                };
                GlobalConfig.Instance.HttpClient.DefaultRequestHeaders.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));
                var response = GlobalConfig.Instance.HttpClient.PostAsJsonAsync("api/Student", newStudent).Result;

                if (response.IsSuccessStatusCode)
                {
                    MessageBox.Show("Student registered successfully!");
                    GlobalConfig.Instance.role = "Student";
                    LoginForm loginForm = new LoginForm();
                    this.Hide();
                    loginForm.ShowDialog();
                    this.Close();
                }
                else
                {
                    string error = response.Content.ReadAsStringAsync().Result;
                    MessageBox.Show($"Registration failed: {response.ReasonPhrase}\n{error}");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}");
            }

        }

        private void studetnLogin_button_Click(object sender, EventArgs e)
        {
            GlobalConfig.Instance.role = "Student";
            LoginForm loginForm = new LoginForm();
            this.Hide();
            loginForm.ShowDialog();
            this.Close();
        }
    }
}
