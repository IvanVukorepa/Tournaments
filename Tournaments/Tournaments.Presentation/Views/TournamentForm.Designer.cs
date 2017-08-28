namespace Tournaments.Presentation.Views
{
    partial class TournamentForm
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
            this.lbox_team1Selection = new System.Windows.Forms.ListBox();
            this.lbox_team2Selection = new System.Windows.Forms.ListBox();
            this.lbox_team3Selection = new System.Windows.Forms.ListBox();
            this.lbox_team4Selection = new System.Windows.Forms.ListBox();
            this.btn_createTournament = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbox_team1Selection
            // 
            this.lbox_team1Selection.FormattingEnabled = true;
            this.lbox_team1Selection.ItemHeight = 16;
            this.lbox_team1Selection.Location = new System.Drawing.Point(12, 24);
            this.lbox_team1Selection.Name = "lbox_team1Selection";
            this.lbox_team1Selection.Size = new System.Drawing.Size(128, 164);
            this.lbox_team1Selection.TabIndex = 0;
            // 
            // lbox_team2Selection
            // 
            this.lbox_team2Selection.FormattingEnabled = true;
            this.lbox_team2Selection.ItemHeight = 16;
            this.lbox_team2Selection.Location = new System.Drawing.Point(171, 24);
            this.lbox_team2Selection.Name = "lbox_team2Selection";
            this.lbox_team2Selection.Size = new System.Drawing.Size(130, 164);
            this.lbox_team2Selection.TabIndex = 1;
            // 
            // lbox_team3Selection
            // 
            this.lbox_team3Selection.FormattingEnabled = true;
            this.lbox_team3Selection.ItemHeight = 16;
            this.lbox_team3Selection.Location = new System.Drawing.Point(12, 221);
            this.lbox_team3Selection.Name = "lbox_team3Selection";
            this.lbox_team3Selection.Size = new System.Drawing.Size(128, 180);
            this.lbox_team3Selection.TabIndex = 2;
            // 
            // lbox_team4Selection
            // 
            this.lbox_team4Selection.FormattingEnabled = true;
            this.lbox_team4Selection.ItemHeight = 16;
            this.lbox_team4Selection.Location = new System.Drawing.Point(171, 221);
            this.lbox_team4Selection.Name = "lbox_team4Selection";
            this.lbox_team4Selection.Size = new System.Drawing.Size(130, 180);
            this.lbox_team4Selection.TabIndex = 3;
            // 
            // btn_createTournament
            // 
            this.btn_createTournament.Location = new System.Drawing.Point(308, 328);
            this.btn_createTournament.Name = "btn_createTournament";
            this.btn_createTournament.Size = new System.Drawing.Size(103, 73);
            this.btn_createTournament.TabIndex = 4;
            this.btn_createTournament.Text = "Create tournamnent";
            this.btn_createTournament.UseVisualStyleBackColor = true;
            this.btn_createTournament.Click += new System.EventHandler(this.btn_createTournament_Click);
            // 
            // TournamentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(417, 423);
            this.Controls.Add(this.btn_createTournament);
            this.Controls.Add(this.lbox_team4Selection);
            this.Controls.Add(this.lbox_team3Selection);
            this.Controls.Add(this.lbox_team2Selection);
            this.Controls.Add(this.lbox_team1Selection);
            this.Name = "TournamentForm";
            this.Text = "TournamentForm";
            this.Load += new System.EventHandler(this.TournamentForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lbox_team1Selection;
        private System.Windows.Forms.ListBox lbox_team2Selection;
        private System.Windows.Forms.ListBox lbox_team3Selection;
        private System.Windows.Forms.ListBox lbox_team4Selection;
        private System.Windows.Forms.Button btn_createTournament;
    }
}