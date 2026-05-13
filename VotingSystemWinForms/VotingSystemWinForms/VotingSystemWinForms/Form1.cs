using Newtonsoft.Json.Linq;
using System;
using System.Windows.Forms;
using VotingSystemAdmin.Forms;
using VotingSystemAdmin.Models;
using VotingSystemAdmin.Services;

namespace VotingSystemWinForms
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private async void btnLogin_Click(
            object sender,
            EventArgs e)
        {
            try
            {
                if (txtUsername.Text == "" ||
                   txtPassword.Text == "")
                {
                    MessageBox.Show(
                        "Please fill all fields"
                    );

                    return;
                }

                LoginModel login =
                    new LoginModel()
                    {
                        username = txtUsername.Text,
                        password = txtPassword.Text
                    };

                string response =
                    await ApiService.Post(
                        "auth/login",
                        login
                    );

                JObject data =
                    JObject.Parse(response);

                if (data["role"].ToString() == "admin")
                {
                    MessageBox.Show(
                        "Login Successful"
                    );

                    AdminDashboard dashboard =
                        new AdminDashboard();

                    dashboard.Show();

                    this.Hide();
                }
                else
                {
                    MessageBox.Show(
                        "Access Denied"
                    );
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

    }
}