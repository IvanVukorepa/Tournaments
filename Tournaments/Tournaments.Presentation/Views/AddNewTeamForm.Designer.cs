namespace Tournaments.Presentation.Views
{
    partial class AddNewTeamForm
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
            this.lbl_name = new System.Windows.Forms.Label();
            this.lbl_logoAnimalName = new System.Windows.Forms.Label();
            this.txtbox_name = new System.Windows.Forms.TextBox();
            this.txtbox_logoAnimalName = new System.Windows.Forms.TextBox();
            this.btn_CreateNewTeam = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_name
            // 
            this.lbl_name.AutoSize = true;
            this.lbl_name.Location = new System.Drawing.Point(12, 24);
            this.lbl_name.Name = "lbl_name";
            this.lbl_name.Size = new System.Drawing.Size(49, 17);
            this.lbl_name.TabIndex = 0;
            this.lbl_name.Text = "Name:";
            // 
            // lbl_logoAnimalName
            // 
            this.lbl_logoAnimalName.AutoSize = true;
            this.lbl_logoAnimalName.Location = new System.Drawing.Point(12, 92);
            this.lbl_logoAnimalName.Name = "lbl_logoAnimalName";
            this.lbl_logoAnimalName.Size = new System.Drawing.Size(128, 17);
            this.lbl_logoAnimalName.TabIndex = 1;
            this.lbl_logoAnimalName.Text = "Logo animal name:";
            // 
            // txtbox_name
            // 
            this.txtbox_name.Location = new System.Drawing.Point(78, 24);
            this.txtbox_name.Name = "txtbox_name";
            this.txtbox_name.Size = new System.Drawing.Size(208, 22);
            this.txtbox_name.TabIndex = 2;
            // 
            // txtbox_logoAnimalName
            // 
            this.txtbox_logoAnimalName.Location = new System.Drawing.Point(146, 92);
            this.txtbox_logoAnimalName.Name = "txtbox_logoAnimalName";
            this.txtbox_logoAnimalName.Size = new System.Drawing.Size(140, 22);
            this.txtbox_logoAnimalName.TabIndex = 3;
            // 
            // btn_CreateNewTeam
            // 
            this.btn_CreateNewTeam.Location = new System.Drawing.Point(211, 138);
            this.btn_CreateNewTeam.Name = "btn_CreateNewTeam";
            this.btn_CreateNewTeam.Size = new System.Drawing.Size(75, 43);
            this.btn_CreateNewTeam.TabIndex = 4;
            this.btn_CreateNewTeam.Text = "Add";
            this.btn_CreateNewTeam.UseVisualStyleBackColor = true;
            this.btn_CreateNewTeam.Click += new System.EventHandler(this.btn_CreateNewTeam_Click);
            // 
            // AddNewTeamForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(324, 215);
            this.Controls.Add(this.btn_CreateNewTeam);
            this.Controls.Add(this.txtbox_logoAnimalName);
            this.Controls.Add(this.txtbox_name);
            this.Controls.Add(this.lbl_logoAnimalName);
            this.Controls.Add(this.lbl_name);
            this.Name = "AddNewTeamForm";
            this.Text = "AddNewTeamForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_name;
        private System.Windows.Forms.Label lbl_logoAnimalName;
        private System.Windows.Forms.TextBox txtbox_name;
        private System.Windows.Forms.TextBox txtbox_logoAnimalName;
        private System.Windows.Forms.Button btn_CreateNewTeam;
    }
}