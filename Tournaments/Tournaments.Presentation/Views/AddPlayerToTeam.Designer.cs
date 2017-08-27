namespace Tournaments.Presentation.Views
{
    partial class AddPlayerToTeam
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
            this.lbox_availablePlayers = new System.Windows.Forms.ListBox();
            this.lbl_availableplayers = new System.Windows.Forms.Label();
            this.btn_addPlayerToTeam = new System.Windows.Forms.Button();
            this.btn_CreateNewPlayer = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbox_availablePlayers
            // 
            this.lbox_availablePlayers.FormattingEnabled = true;
            this.lbox_availablePlayers.ItemHeight = 16;
            this.lbox_availablePlayers.Location = new System.Drawing.Point(12, 49);
            this.lbox_availablePlayers.Name = "lbox_availablePlayers";
            this.lbox_availablePlayers.Size = new System.Drawing.Size(138, 276);
            this.lbox_availablePlayers.TabIndex = 0;
            // 
            // lbl_availableplayers
            // 
            this.lbl_availableplayers.AutoSize = true;
            this.lbl_availableplayers.Location = new System.Drawing.Point(12, 13);
            this.lbl_availableplayers.Name = "lbl_availableplayers";
            this.lbl_availableplayers.Size = new System.Drawing.Size(120, 17);
            this.lbl_availableplayers.TabIndex = 1;
            this.lbl_availableplayers.Text = "Available Players:";
            // 
            // btn_addPlayerToTeam
            // 
            this.btn_addPlayerToTeam.Location = new System.Drawing.Point(171, 278);
            this.btn_addPlayerToTeam.Name = "btn_addPlayerToTeam";
            this.btn_addPlayerToTeam.Size = new System.Drawing.Size(98, 47);
            this.btn_addPlayerToTeam.TabIndex = 2;
            this.btn_addPlayerToTeam.Text = "Add selected";
            this.btn_addPlayerToTeam.UseVisualStyleBackColor = true;
            this.btn_addPlayerToTeam.Click += new System.EventHandler(this.btn_addPlayerToTeam_Click);
            // 
            // btn_CreateNewPlayer
            // 
            this.btn_CreateNewPlayer.Location = new System.Drawing.Point(171, 188);
            this.btn_CreateNewPlayer.Name = "btn_CreateNewPlayer";
            this.btn_CreateNewPlayer.Size = new System.Drawing.Size(98, 55);
            this.btn_CreateNewPlayer.TabIndex = 3;
            this.btn_CreateNewPlayer.Text = "Create player";
            this.btn_CreateNewPlayer.UseVisualStyleBackColor = true;
            this.btn_CreateNewPlayer.Click += new System.EventHandler(this.btn_CreateNewPlayer_Click);
            // 
            // AddPlayerToTeam
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(305, 382);
            this.Controls.Add(this.btn_CreateNewPlayer);
            this.Controls.Add(this.btn_addPlayerToTeam);
            this.Controls.Add(this.lbl_availableplayers);
            this.Controls.Add(this.lbox_availablePlayers);
            this.Name = "AddPlayerToTeam";
            this.Text = "AddPlayerToTeam";
            this.Load += new System.EventHandler(this.AddPlayerToTeam_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lbox_availablePlayers;
        private System.Windows.Forms.Label lbl_availableplayers;
        private System.Windows.Forms.Button btn_addPlayerToTeam;
        private System.Windows.Forms.Button btn_CreateNewPlayer;
    }
}