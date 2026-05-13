using Newtonsoft.Json.Linq;
using System;
using System.Windows.Forms;
using VotingSystemAdmin.Services;
using VotingSystemWinForms;

namespace VotingSystemAdmin.Forms
{
    public partial class AdminDashboard : Form
    {
        private Guna.UI2.WinForms.Guna2HtmlLabel lblLogo;
        private Guna.UI2.WinForms.Guna2Button btnTables;
        private Guna.UI2.WinForms.Guna2Button btnCandidates;
        private Guna.UI2.WinForms.Guna2Button btnDashboard;
        private Guna.UI2.WinForms.Guna2Button btnLogout;
        private Guna.UI2.WinForms.Guna2Panel panelContent;
        private Guna.UI2.WinForms.Guna2Panel panelSidebar;

        public AdminDashboard()
        {
            InitializeComponent();

            LoadForm(new DashboardPage());
        }

        private void LoadForm(Form form)
        {
            panelContent.Controls.Clear();

            form.TopLevel = false;

            form.Dock = DockStyle.Fill;

            panelContent.Controls.Add(form);

            panelContent.Tag = form;

            form.Show();
        }

        private void InitializeComponent()
        {
            this.panelSidebar = new Guna.UI2.WinForms.Guna2Panel();
            this.btnLogout = new Guna.UI2.WinForms.Guna2Button();
            this.btnTables = new Guna.UI2.WinForms.Guna2Button();
            this.btnCandidates = new Guna.UI2.WinForms.Guna2Button();
            this.btnDashboard = new Guna.UI2.WinForms.Guna2Button();
            this.lblLogo = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.panelContent = new Guna.UI2.WinForms.Guna2Panel();
            this.panelSidebar.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelSidebar
            // 
            this.panelSidebar.BorderRadius = 10;
            this.panelSidebar.Controls.Add(this.btnLogout);
            this.panelSidebar.Controls.Add(this.btnTables);
            this.panelSidebar.Controls.Add(this.btnCandidates);
            this.panelSidebar.Controls.Add(this.btnDashboard);
            this.panelSidebar.Controls.Add(this.lblLogo);
            this.panelSidebar.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelSidebar.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(23)))), ((int)(((byte)(42)))));
            this.panelSidebar.Location = new System.Drawing.Point(0, 0);
            this.panelSidebar.Name = "panelSidebar";
            this.panelSidebar.Size = new System.Drawing.Size(250, 600);
            this.panelSidebar.TabIndex = 0;
            // 
            // btnLogout
            // 
            this.btnLogout.BackColor = System.Drawing.Color.Transparent;
            this.btnLogout.BorderRadius = 8;
            this.btnLogout.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnLogout.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnLogout.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnLogout.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnLogout.FillColor = System.Drawing.Color.Red;
            this.btnLogout.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnLogout.ForeColor = System.Drawing.Color.White;
            this.btnLogout.Location = new System.Drawing.Point(12, 543);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(220, 45);
            this.btnLogout.TabIndex = 4;
            this.btnLogout.Text = "➜] Logout";
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // btnTables
            // 
            this.btnTables.BackColor = System.Drawing.Color.Transparent;
            this.btnTables.BorderRadius = 8;
            this.btnTables.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnTables.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnTables.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnTables.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnTables.FillColor = System.Drawing.Color.LimeGreen;
            this.btnTables.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnTables.ForeColor = System.Drawing.Color.White;
            this.btnTables.Location = new System.Drawing.Point(12, 274);
            this.btnTables.Name = "btnTables";
            this.btnTables.Size = new System.Drawing.Size(220, 45);
            this.btnTables.TabIndex = 3;
            this.btnTables.Text = "👥 Tables";
            this.btnTables.Click +=
    new System.EventHandler(
        this.btnTables_Click
    );

            // 
            // btnCandidates
            // 
            this.btnCandidates.BackColor = System.Drawing.Color.Transparent;
            this.btnCandidates.BorderRadius = 8;
            this.btnCandidates.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnCandidates.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnCandidates.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnCandidates.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnCandidates.FillColor = System.Drawing.Color.LimeGreen;
            this.btnCandidates.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnCandidates.ForeColor = System.Drawing.Color.White;
            this.btnCandidates.Location = new System.Drawing.Point(12, 212);
            this.btnCandidates.Name = "btnCandidates";
            this.btnCandidates.Size = new System.Drawing.Size(220, 45);
            this.btnCandidates.TabIndex = 2;
            this.btnCandidates.Text = "🗳 Candidates";
            this.btnCandidates.Click += new System.EventHandler(this.btnCandidates_Click);
            // 
            // btnDashboard
            // 
            this.btnDashboard.BackColor = System.Drawing.Color.Transparent;
            this.btnDashboard.BorderRadius = 8;
            this.btnDashboard.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnDashboard.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnDashboard.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnDashboard.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnDashboard.FillColor = System.Drawing.Color.LimeGreen;
            this.btnDashboard.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnDashboard.ForeColor = System.Drawing.Color.White;
            this.btnDashboard.Location = new System.Drawing.Point(12, 149);
            this.btnDashboard.Name = "btnDashboard";
            this.btnDashboard.Size = new System.Drawing.Size(220, 45);
            this.btnDashboard.TabIndex = 1;
            this.btnDashboard.Text = "📊 Dashboard";
            this.btnDashboard.Click +=
    new System.EventHandler(
        this.btnDashboard_Click
    );

            // 
            // lblLogo
            // 
            this.lblLogo.AutoSize = false;
            this.lblLogo.BackColor = System.Drawing.Color.Transparent;
            this.lblLogo.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLogo.ForeColor = System.Drawing.Color.White;
            this.lblLogo.Location = new System.Drawing.Point(40, 12);
            this.lblLogo.Name = "lblLogo";
            this.lblLogo.Size = new System.Drawing.Size(144, 101);
            this.lblLogo.TabIndex = 0;
            this.lblLogo.Text = "VOTING \r\nSYSTEM\r\n(School Base\r\n)";
            // 
            // panelContent
            // 
            this.panelContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContent.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.panelContent.Location = new System.Drawing.Point(250, 0);
            this.panelContent.Name = "panelContent";
            this.panelContent.Size = new System.Drawing.Size(750, 600);
            this.panelContent.TabIndex = 1;
            // 
            // AdminDashboard
            // 
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1000, 600);
            this.Controls.Add(this.panelContent);
            this.Controls.Add(this.panelSidebar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AdminDashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.panelSidebar.ResumeLayout(false);
            this.ResumeLayout(false);

        }


        private void btnLogout_Click(
    object sender,
    EventArgs e)
        {
            LoginForm login =
                new LoginForm();

            login.Show();

            this.Hide();
        }


        private void btnDashboard_Click(
 object sender,
 EventArgs e)
        {
            LoadForm(new DashboardPage());
        }

        private void btnCandidates_Click(
    object sender,
    EventArgs e)
        {
            LoadForm(new CandidatesPage());
        }
        private void btnTables_Click(
    object sender,
    EventArgs e)
        {
            LoadForm(new TablesPage());
        }
    }
    }
    
