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
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void userTextBox_Click(object sender, EventArgs e)
        {
            userTextBox.Clear();
            userTextBox.ForeColor = Color.Black;
        }

        private void passTextBox_Click(object sender, EventArgs e)
        {
            passTextBox.Clear();
            passTextBox.ForeColor = Color.Black;

        }

        private void Login_button_Click(object sender, EventArgs e)
        {
            var username = userTextBox.Text;
            var password = passTextBox.Text;
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
    }
}
