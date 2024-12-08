using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AttendanceSeekers_client
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        //private void userTextBox_Click(object sender, EventArgs e)
        //{
        //    userTextBox.Clear();
        //    userTextBox.ForeColor = Color.Black;
        //}

        //private void passTextBox_Click(object sender, EventArgs e)
        //{
        //    passTextBox.Clear();
        //    passTextBox.ForeColor = Color.Black;

        //}

        private void Login_button_Click(object sender, EventArgs e)
        {
            var username = userTextBox.Text;
            var password = passTextBox.Text;


            var loginData = new
            {
                Username = username,
                Password = password
            };

            // Convert the login data to JSON
            string jsonData = JsonSerializer.Serialize(loginData);
            var content = new StringContent(jsonData, Encoding.UTF8, "application/json");
            try
            {
                // Post login data to the API
                HttpResponseMessage response = GlobalConfig.Instance.HttpClient.PostAsync("api/Account/login", content).Result;

                if (response.IsSuccessStatusCode)
                {
                    // Get the token from the response
                    string responseBody = response.Content.ReadAsStringAsync().Result;
                    var responseData = JsonSerializer.Deserialize<JwtResponse>(responseBody);

                    string getRole = GlobalConfig.Instance.role;
                    if (responseData.roles.Contains(getRole))
                    {
                        GlobalConfig.Instance.Token = responseData.Token;
                    }
                    else
                    {
                        MessageBox.Show($"Make sure to login with your '{getRole}' account.", "Role Check", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                // Display the token in a textbox or use it as needed
                //MessageBox.Show($"Token is {token}","TOKEN" ,MessageBoxButtons.OK);

                else
                {
                    // Display error message
                    MessageBox.Show("Login failed. Please check your credentials.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                // Handle any exceptions
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            welcomeForm welcomeForm = new welcomeForm();
            this.Hide();
            welcomeForm.ShowDialog();
            this.Close();



        }

        private void LoginForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            //this.Close();
            //Application.Exit();
        }


        // Class to deserialize the JWT response
        public class JwtResponse
        {
            public string Token { get; set; }
            public string Username { get; set; }
            public List<string> roles { get; set; }
        }

        
        private void passTextBox_Enter_1(object sender, EventArgs e)
        {
            passTextBox.Clear();
            passTextBox.ForeColor = Color.Black;
        }

        private void userTextBox_Enter_1(object sender, EventArgs e)
        {
            userTextBox.Clear();
            userTextBox.ForeColor = Color.Black;
        }
    }
}
