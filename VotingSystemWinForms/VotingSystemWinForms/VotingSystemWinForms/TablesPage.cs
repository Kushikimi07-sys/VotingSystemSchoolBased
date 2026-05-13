using Newtonsoft.Json.Linq;
using System;
using System.Data;
using System.Windows.Forms;
using VotingSystemAdmin.Services;

namespace VotingSystemWinForms
{
    public partial class TablesPage : Form
    {
        public TablesPage()
        {
            InitializeComponent();

            LoadTeams();

            LoadCandidates();

            LoadVoters();
        }

        private async void LoadTeams()
        {
            try
            {
                string response =
                    await ApiService.Get("team");

                JArray data =
                    JArray.Parse(response);

                dgvTeams.DataSource =
                    data.ToObject<DataTable>();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private async void LoadCandidates()
        {
            try
            {
                string response =
                    await ApiService.Get("candidate");

                JArray data =
                    JArray.Parse(response);

                dgvCandidates.DataSource =
                    data.ToObject<DataTable>();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private async void LoadVoters()
        {
            try
            {
                string response =
                    await ApiService.Get("auth/users");

                JArray data =
                    JArray.Parse(response);

                dgvVoters.DataSource =
                    data.ToObject<DataTable>();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}