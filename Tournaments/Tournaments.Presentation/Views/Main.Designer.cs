namespace Tournaments.Presentation
{
    partial class Form1
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
            this.lbox_teams = new System.Windows.Forms.ListBox();
            this.lbl_teams = new System.Windows.Forms.Label();
            this.lbl_players = new System.Windows.Forms.Label();
            this.lbox_players = new System.Windows.Forms.ListBox();
            this.btn_AddTeam = new System.Windows.Forms.Button();
            this.btn_EditTeam = new System.Windows.Forms.Button();
            this.btn_DeleteTeam = new System.Windows.Forms.Button();
            this.btn_AddNewPlayer = new System.Windows.Forms.Button();
            this.btn_RemovePlayerFromTeam = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbox_teams
            // 
            this.lbox_teams.FormattingEnabled = true;
            this.lbox_teams.ItemHeight = 16;
            this.lbox_teams.Location = new System.Drawing.Point(24, 45);
            this.lbox_teams.Name = "lbox_teams";
            this.lbox_teams.Size = new System.Drawing.Size(228, 324);
            this.lbox_teams.TabIndex = 0;
            this.lbox_teams.SelectedIndexChanged += new System.EventHandler(this.lbox_teams_SelectedIndexChanged);
            // 
            // lbl_teams
            // 
            this.lbl_teams.AutoSize = true;
            this.lbl_teams.Location = new System.Drawing.Point(21, 25);
            this.lbl_teams.Name = "lbl_teams";
            this.lbl_teams.Size = new System.Drawing.Size(55, 17);
            this.lbl_teams.TabIndex = 1;
            this.lbl_teams.Text = "Teams:";
            // 
            // lbl_players
            // 
            this.lbl_players.AutoSize = true;
            this.lbl_players.Location = new System.Drawing.Point(336, 25);
            this.lbl_players.Name = "lbl_players";
            this.lbl_players.Size = new System.Drawing.Size(190, 17);
            this.lbl_players.TabIndex = 2;
            this.lbl_players.Text = "Players in the selected team:";
            // 
            // lbox_players
            // 
            this.lbox_players.FormattingEnabled = true;
            this.lbox_players.ItemHeight = 16;
            this.lbox_players.Location = new System.Drawing.Point(339, 55);
            this.lbox_players.Name = "lbox_players";
            this.lbox_players.Size = new System.Drawing.Size(267, 100);
            this.lbox_players.TabIndex = 3;
            // 
            // btn_AddTeam
            // 
            this.btn_AddTeam.Location = new System.Drawing.Point(24, 389);
            this.btn_AddTeam.Name = "btn_AddTeam";
            this.btn_AddTeam.Size = new System.Drawing.Size(75, 51);
            this.btn_AddTeam.TabIndex = 4;
            this.btn_AddTeam.Text = "Add new team";
            this.btn_AddTeam.UseVisualStyleBackColor = true;
            this.btn_AddTeam.Click += new System.EventHandler(this.btn_AddTeam_Click);
            // 
            // btn_EditTeam
            // 
            this.btn_EditTeam.Location = new System.Drawing.Point(105, 389);
            this.btn_EditTeam.Name = "btn_EditTeam";
            this.btn_EditTeam.Size = new System.Drawing.Size(67, 51);
            this.btn_EditTeam.TabIndex = 5;
            this.btn_EditTeam.Text = "Edit";
            this.btn_EditTeam.UseVisualStyleBackColor = true;
            this.btn_EditTeam.Click += new System.EventHandler(this.btn_EditTeam_Click);
            // 
            // btn_DeleteTeam
            // 
            this.btn_DeleteTeam.Location = new System.Drawing.Point(179, 389);
            this.btn_DeleteTeam.Name = "btn_DeleteTeam";
            this.btn_DeleteTeam.Size = new System.Drawing.Size(73, 51);
            this.btn_DeleteTeam.TabIndex = 6;
            this.btn_DeleteTeam.Text = "Delete team";
            this.btn_DeleteTeam.UseVisualStyleBackColor = true;
            this.btn_DeleteTeam.Click += new System.EventHandler(this.btn_DeleteTeam_Click);
            // 
            // btn_AddNewPlayer
            // 
            this.btn_AddNewPlayer.Location = new System.Drawing.Point(339, 172);
            this.btn_AddNewPlayer.Name = "btn_AddNewPlayer";
            this.btn_AddNewPlayer.Size = new System.Drawing.Size(92, 48);
            this.btn_AddNewPlayer.TabIndex = 7;
            this.btn_AddNewPlayer.Text = "Add new player";
            this.btn_AddNewPlayer.UseVisualStyleBackColor = true;
            // 
            // btn_RemovePlayerFromTeam
            // 
            this.btn_RemovePlayerFromTeam.Location = new System.Drawing.Point(437, 172);
            this.btn_RemovePlayerFromTeam.Name = "btn_RemovePlayerFromTeam";
            this.btn_RemovePlayerFromTeam.Size = new System.Drawing.Size(75, 48);
            this.btn_RemovePlayerFromTeam.TabIndex = 8;
            this.btn_RemovePlayerFromTeam.Text = "Remove";
            this.btn_RemovePlayerFromTeam.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(761, 465);
            this.Controls.Add(this.btn_RemovePlayerFromTeam);
            this.Controls.Add(this.btn_AddNewPlayer);
            this.Controls.Add(this.btn_DeleteTeam);
            this.Controls.Add(this.btn_EditTeam);
            this.Controls.Add(this.btn_AddTeam);
            this.Controls.Add(this.lbox_players);
            this.Controls.Add(this.lbl_players);
            this.Controls.Add(this.lbl_teams);
            this.Controls.Add(this.lbox_teams);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lbox_teams;
        private System.Windows.Forms.Label lbl_teams;
        private System.Windows.Forms.Label lbl_players;
        private System.Windows.Forms.ListBox lbox_players;
        private System.Windows.Forms.Button btn_AddTeam;
        private System.Windows.Forms.Button btn_EditTeam;
        private System.Windows.Forms.Button btn_DeleteTeam;
        private System.Windows.Forms.Button btn_AddNewPlayer;
        private System.Windows.Forms.Button btn_RemovePlayerFromTeam;
    }
}

