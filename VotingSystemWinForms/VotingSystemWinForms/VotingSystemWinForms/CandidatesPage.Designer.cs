namespace VotingSystemWinForms
{
    partial class CandidatesPage
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panelTeam = new Guna.UI2.WinForms.Guna2Panel();
            this.btnAddTeam = new Guna.UI2.WinForms.Guna2Button();
            this.txtTeam = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.btnAddPosition = new Guna.UI2.WinForms.Guna2Button();
            this.txtPosition = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2HtmlLabel2 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.panelCandidate = new Guna.UI2.WinForms.Guna2Panel();
            this.btnSaveCandidate = new Guna.UI2.WinForms.Guna2Button();
            this.guna2HtmlLabel3 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.cmbPosition = new Guna.UI2.WinForms.Guna2ComboBox();
            this.cmbTeam = new Guna.UI2.WinForms.Guna2ComboBox();
            this.txtCandidateName = new Guna.UI2.WinForms.Guna2TextBox();
            this.panelTeam.SuspendLayout();
            this.guna2Panel1.SuspendLayout();
            this.panelCandidate.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelTeam
            // 
            this.panelTeam.BackColor = System.Drawing.Color.Transparent;
            this.panelTeam.BorderRadius = 10;
            this.panelTeam.Controls.Add(this.btnAddTeam);
            this.panelTeam.Controls.Add(this.txtTeam);
            this.panelTeam.Controls.Add(this.guna2HtmlLabel1);
            this.panelTeam.FillColor = System.Drawing.Color.LimeGreen;
            this.panelTeam.Location = new System.Drawing.Point(12, 12);
            this.panelTeam.Name = "panelTeam";
            this.panelTeam.Size = new System.Drawing.Size(304, 190);
            this.panelTeam.TabIndex = 0;
            // 
            // btnAddTeam
            // 
            this.btnAddTeam.BorderRadius = 20;
            this.btnAddTeam.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnAddTeam.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnAddTeam.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnAddTeam.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnAddTeam.FillColor = System.Drawing.Color.Navy;
            this.btnAddTeam.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddTeam.ForeColor = System.Drawing.Color.White;
            this.btnAddTeam.Location = new System.Drawing.Point(172, 130);
            this.btnAddTeam.Name = "btnAddTeam";
            this.btnAddTeam.Size = new System.Drawing.Size(109, 45);
            this.btnAddTeam.TabIndex = 2;
            this.btnAddTeam.Text = "ADD TEAM";
            this.btnAddTeam.Click += new System.EventHandler(this.btnAddTeam_Click);
            // 
            // txtTeam
            // 
            this.txtTeam.BorderRadius = 10;
            this.txtTeam.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTeam.DefaultText = "";
            this.txtTeam.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtTeam.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtTeam.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTeam.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTeam.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTeam.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtTeam.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTeam.Location = new System.Drawing.Point(19, 71);
            this.txtTeam.Name = "txtTeam";
            this.txtTeam.PlaceholderForeColor = System.Drawing.Color.DimGray;
            this.txtTeam.PlaceholderText = "Enter Team Name";
            this.txtTeam.SelectedText = "";
            this.txtTeam.Size = new System.Drawing.Size(262, 42);
            this.txtTeam.TabIndex = 1;
            // 
            // guna2HtmlLabel1
            // 
            this.guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel1.Location = new System.Drawing.Point(19, 33);
            this.guna2HtmlLabel1.Name = "guna2HtmlLabel1";
            this.guna2HtmlLabel1.Size = new System.Drawing.Size(97, 19);
            this.guna2HtmlLabel1.TabIndex = 0;
            this.guna2HtmlLabel1.Text = "TEAM SECTION";
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2Panel1.BorderRadius = 10;
            this.guna2Panel1.Controls.Add(this.btnAddPosition);
            this.guna2Panel1.Controls.Add(this.txtPosition);
            this.guna2Panel1.Controls.Add(this.guna2HtmlLabel2);
            this.guna2Panel1.FillColor = System.Drawing.Color.LimeGreen;
            this.guna2Panel1.Location = new System.Drawing.Point(12, 238);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(304, 192);
            this.guna2Panel1.TabIndex = 1;
            // 
            // btnAddPosition
            // 
            this.btnAddPosition.BorderRadius = 20;
            this.btnAddPosition.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnAddPosition.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnAddPosition.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnAddPosition.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnAddPosition.FillColor = System.Drawing.Color.Navy;
            this.btnAddPosition.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddPosition.ForeColor = System.Drawing.Color.White;
            this.btnAddPosition.Location = new System.Drawing.Point(172, 131);
            this.btnAddPosition.Name = "btnAddPosition";
            this.btnAddPosition.Size = new System.Drawing.Size(109, 45);
            this.btnAddPosition.TabIndex = 3;
            this.btnAddPosition.Text = "ADD POSITION";
            this.btnAddPosition.Click += new System.EventHandler(this.btnAddPosition_Click);
            // 
            // txtPosition
            // 
            this.txtPosition.BorderRadius = 10;
            this.txtPosition.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPosition.DefaultText = "";
            this.txtPosition.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtPosition.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtPosition.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPosition.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPosition.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtPosition.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtPosition.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtPosition.Location = new System.Drawing.Point(19, 71);
            this.txtPosition.Name = "txtPosition";
            this.txtPosition.PlaceholderForeColor = System.Drawing.Color.DimGray;
            this.txtPosition.PlaceholderText = "Enter Position";
            this.txtPosition.SelectedText = "";
            this.txtPosition.Size = new System.Drawing.Size(262, 42);
            this.txtPosition.TabIndex = 1;
            // 
            // guna2HtmlLabel2
            // 
            this.guna2HtmlLabel2.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel2.Location = new System.Drawing.Point(19, 33);
            this.guna2HtmlLabel2.Name = "guna2HtmlLabel2";
            this.guna2HtmlLabel2.Size = new System.Drawing.Size(122, 19);
            this.guna2HtmlLabel2.TabIndex = 0;
            this.guna2HtmlLabel2.Text = "POSITION SECTION";
            // 
            // panelCandidate
            // 
            this.panelCandidate.BorderRadius = 30;
            this.panelCandidate.Controls.Add(this.btnSaveCandidate);
            this.panelCandidate.Controls.Add(this.guna2HtmlLabel3);
            this.panelCandidate.Controls.Add(this.cmbPosition);
            this.panelCandidate.Controls.Add(this.cmbTeam);
            this.panelCandidate.Controls.Add(this.txtCandidateName);
            this.panelCandidate.FillColor = System.Drawing.Color.LimeGreen;
            this.panelCandidate.Location = new System.Drawing.Point(356, 12);
            this.panelCandidate.Name = "panelCandidate";
            this.panelCandidate.Size = new System.Drawing.Size(410, 418);
            this.panelCandidate.TabIndex = 2;
            // 
            // btnSaveCandidate
            // 
            this.btnSaveCandidate.BackColor = System.Drawing.Color.Transparent;
            this.btnSaveCandidate.BorderRadius = 20;
            this.btnSaveCandidate.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnSaveCandidate.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnSaveCandidate.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnSaveCandidate.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnSaveCandidate.FillColor = System.Drawing.Color.Navy;
            this.btnSaveCandidate.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaveCandidate.ForeColor = System.Drawing.Color.White;
            this.btnSaveCandidate.Location = new System.Drawing.Point(212, 348);
            this.btnSaveCandidate.Name = "btnSaveCandidate";
            this.btnSaveCandidate.Size = new System.Drawing.Size(180, 45);
            this.btnSaveCandidate.TabIndex = 4;
            this.btnSaveCandidate.Text = "SAVE CANDIDATE";
            this.btnSaveCandidate.Click += new System.EventHandler(this.btnSaveCandidate_Click);
            // 
            // guna2HtmlLabel3
            // 
            this.guna2HtmlLabel3.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel3.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel3.Location = new System.Drawing.Point(29, 44);
            this.guna2HtmlLabel3.Name = "guna2HtmlLabel3";
            this.guna2HtmlLabel3.Size = new System.Drawing.Size(195, 27);
            this.guna2HtmlLabel3.TabIndex = 3;
            this.guna2HtmlLabel3.Text = "CANDIDATE SECTION";
            // 
            // cmbPosition
            // 
            this.cmbPosition.BackColor = System.Drawing.Color.Transparent;
            this.cmbPosition.BorderRadius = 10;
            this.cmbPosition.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbPosition.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPosition.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmbPosition.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmbPosition.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmbPosition.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cmbPosition.ItemHeight = 30;
            this.cmbPosition.Location = new System.Drawing.Point(20, 280);
            this.cmbPosition.Name = "cmbPosition";
            this.cmbPosition.Size = new System.Drawing.Size(372, 36);
            this.cmbPosition.TabIndex = 2;
            // 
            // cmbTeam
            // 
            this.cmbTeam.BackColor = System.Drawing.Color.Transparent;
            this.cmbTeam.BorderRadius = 10;
            this.cmbTeam.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbTeam.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTeam.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmbTeam.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmbTeam.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmbTeam.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cmbTeam.ItemHeight = 30;
            this.cmbTeam.Location = new System.Drawing.Point(20, 197);
            this.cmbTeam.Name = "cmbTeam";
            this.cmbTeam.Size = new System.Drawing.Size(372, 36);
            this.cmbTeam.TabIndex = 1;
            // 
            // txtCandidateName
            // 
            this.txtCandidateName.BackColor = System.Drawing.Color.Transparent;
            this.txtCandidateName.BorderRadius = 10;
            this.txtCandidateName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtCandidateName.DefaultText = "Enter Candidate Name";
            this.txtCandidateName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtCandidateName.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtCandidateName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtCandidateName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtCandidateName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtCandidateName.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtCandidateName.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtCandidateName.Location = new System.Drawing.Point(20, 106);
            this.txtCandidateName.Name = "txtCandidateName";
            this.txtCandidateName.PlaceholderText = "";
            this.txtCandidateName.SelectedText = "";
            this.txtCandidateName.Size = new System.Drawing.Size(372, 42);
            this.txtCandidateName.TabIndex = 0;
            // 
            // CandidatesPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(23)))), ((int)(((byte)(42)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panelCandidate);
            this.Controls.Add(this.guna2Panel1);
            this.Controls.Add(this.panelTeam);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CandidatesPage";
            this.Text = "CandidatesPage";
            this.panelTeam.ResumeLayout(false);
            this.panelTeam.PerformLayout();
            this.guna2Panel1.ResumeLayout(false);
            this.guna2Panel1.PerformLayout();
            this.panelCandidate.ResumeLayout(false);
            this.panelCandidate.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel panelTeam;
        private Guna.UI2.WinForms.Guna2TextBox txtTeam;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
        private Guna.UI2.WinForms.Guna2Button btnAddTeam;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2Button btnAddPosition;
        private Guna.UI2.WinForms.Guna2TextBox txtPosition;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel2;
        private Guna.UI2.WinForms.Guna2Panel panelCandidate;
        private Guna.UI2.WinForms.Guna2TextBox txtCandidateName;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel3;
        private Guna.UI2.WinForms.Guna2ComboBox cmbPosition;
        private Guna.UI2.WinForms.Guna2ComboBox cmbTeam;
        private Guna.UI2.WinForms.Guna2Button btnSaveCandidate;
    }
}