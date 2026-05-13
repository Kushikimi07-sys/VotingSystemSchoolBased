using Newtonsoft.Json.Linq;
using System;
using System.Windows.Forms;
using VotingSystemAdmin.Services;

namespace VotingSystemWinForms
{
    public partial class CandidatesPage : Form
    {
        public CandidatesPage()
        {
            InitializeComponent();

            LoadTeams();

            LoadPositions();
        }

        private async void LoadTeams()
        {
            try
            {
                string response =
                    await ApiService.Get("team");

                JArray data =
                    JArray.Parse(response);

                cmbTeam.DataSource = data;

                cmbTeam.DisplayMember = "name";

                cmbTeam.ValueMember = "id";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private async void LoadPositions()
        {
            try
            {
                string response =
                    await ApiService.Get("position");

                JArray data =
                    JArray.Parse(response);

                cmbPosition.DataSource = data;

                cmbPosition.DisplayMember = "position";

                cmbPosition.ValueMember = "id";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private async void btnAddTeam_Click(
            object sender,
            EventArgs e)
        {
            try
            {
                var data = new
                {
                    name = txtTeam.Text
                };

                await ApiService.Post(
                    "team",
                    data
                );

                MessageBox.Show(
                    "Team Added"
                );

                txtTeam.Clear();

                LoadTeams();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private async void btnAddPosition_Click(
            object sender,
            EventArgs e)
        {
            try
            {
                var data = new
                {
                    position = txtPosition.Text
                };

                await ApiService.Post(
                    "position",
                    data
                );

                MessageBox.Show(
                    "Position Added"
                );

                txtPosition.Clear();

                LoadPositions();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private async void btnSaveCandidate_Click(
            object sender,
            EventArgs e)
        {
            try
            {
                var data = new
                {
                    name = txtCandidateName.Text,

                    teamId = cmbTeam.SelectedValue,

                    positionId = cmbPosition.SelectedValue
                };

                await ApiService.Post(
                    "candidate",
                    data
                );

                MessageBox.Show(
                    "Candidate Added"
                );

                txtCandidateName.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
