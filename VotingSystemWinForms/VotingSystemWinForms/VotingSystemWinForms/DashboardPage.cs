using Newtonsoft.Json.Linq;
using System;
using System.Windows.Forms;
using VotingSystemAdmin.Services;

namespace VotingSystemWinForms
{
    public partial class DashboardPage : Form
    {
        public DashboardPage()
        {
            InitializeComponent();

            LoadDashboard();
        }

        private async void LoadDashboard()
        {
            try
            {
                string candidateResponse =
                    await ApiService.Get("candidate");

                JArray candidates =
                    JArray.Parse(candidateResponse);

                lblTotalCandidates.Text =
                    candidates.Count.ToString();

                string teamResponse =
                    await ApiService.Get("team");

                JArray teams =
                    JArray.Parse(teamResponse);

                lblTotalTeams.Text =
                    teams.Count.ToString();

                string voterResponse =
    await ApiService.Get("auth/users");

                JArray users =
                    JArray.Parse(voterResponse);

                int voterCount = 0;

                foreach (var user in users)
                {
                    if (user["role"] != null &&
                        user["role"].ToString().ToLower() == "voter")
                    {
                        voterCount++;
                    }
                }

                lblTotalVoters.Text =
                    voterCount.ToString();

                string voteResponse =
    await ApiService.Get("vote/results");

                JArray results =
                    JArray.Parse(voteResponse);

                int totalVotes = 0;

                foreach (var position in results)
                {
                    JArray votecandidates =
                        (JArray)position["candidates"];

                    foreach (var candidate in votecandidates)
                    {
                        totalVotes +=
                            Convert.ToInt32(
                                candidate["votes"]
                            );
                    }
                }

                lblTotalVotes.Text =
                    totalVotes.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}