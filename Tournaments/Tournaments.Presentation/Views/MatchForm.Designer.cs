namespace Tournaments.Presentation.Views
{
    partial class MatchForm
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
            this.lbox_homeTeamSelection = new System.Windows.Forms.ListBox();
            this.lbox_awayTeamSelection = new System.Windows.Forms.ListBox();
            this.lbl_chooseTeams = new System.Windows.Forms.Label();
            this.btn_playMatch = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbox_homeTeamSelection
            // 
            this.lbox_homeTeamSelection.FormattingEnabled = true;
            this.lbox_homeTeamSelection.ItemHeight = 16;
            this.lbox_homeTeamSelection.Location = new System.Drawing.Point(24, 13);
            this.lbox_homeTeamSelection.Name = "lbox_homeTeamSelection";
            this.lbox_homeTeamSelection.Size = new System.Drawing.Size(120, 180);
            this.lbox_homeTeamSelection.TabIndex = 0;
            // 
            // lbox_awayTeamSelection
            // 
            this.lbox_awayTeamSelection.FormattingEnabled = true;
            this.lbox_awayTeamSelection.ItemHeight = 16;
            this.lbox_awayTeamSelection.Location = new System.Drawing.Point(276, 13);
            this.lbox_awayTeamSelection.Name = "lbox_awayTeamSelection";
            this.lbox_awayTeamSelection.Size = new System.Drawing.Size(120, 180);
            this.lbox_awayTeamSelection.TabIndex = 1;
            // 
            // lbl_chooseTeams
            // 
            this.lbl_chooseTeams.AutoSize = true;
            this.lbl_chooseTeams.Location = new System.Drawing.Point(162, 43);
            this.lbl_chooseTeams.Name = "lbl_chooseTeams";
            this.lbl_chooseTeams.Size = new System.Drawing.Size(98, 17);
            this.lbl_chooseTeams.TabIndex = 2;
            this.lbl_chooseTeams.Text = "Choose teams";
            // 
            // btn_playMatch
            // 
            this.btn_playMatch.Location = new System.Drawing.Point(165, 217);
            this.btn_playMatch.Name = "btn_playMatch";
            this.btn_playMatch.Size = new System.Drawing.Size(95, 74);
            this.btn_playMatch.TabIndex = 3;
            this.btn_playMatch.Text = "Play match";
            this.btn_playMatch.UseVisualStyleBackColor = true;
            this.btn_playMatch.Click += new System.EventHandler(this.btn_playMatch_Click);
            // 
            // MatchForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(456, 365);
            this.Controls.Add(this.btn_playMatch);
            this.Controls.Add(this.lbl_chooseTeams);
            this.Controls.Add(this.lbox_awayTeamSelection);
            this.Controls.Add(this.lbox_homeTeamSelection);
            this.Name = "MatchForm";
            this.Text = "MatchForm";
            this.Load += new System.EventHandler(this.MatchForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lbox_homeTeamSelection;
        private System.Windows.Forms.ListBox lbox_awayTeamSelection;
        private System.Windows.Forms.Label lbl_chooseTeams;
        private System.Windows.Forms.Button btn_playMatch;
    }
}