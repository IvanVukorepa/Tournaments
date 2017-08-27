namespace Tournaments.Presentation.Views
{
    partial class CreatePlayer
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
            this.lbl_firstName = new System.Windows.Forms.Label();
            this.lbl_lastName = new System.Windows.Forms.Label();
            this.lbl_phoneNumber = new System.Windows.Forms.Label();
            this.lbl_email = new System.Windows.Forms.Label();
            this.txtbox_firstName = new System.Windows.Forms.TextBox();
            this.txtbox_lastName = new System.Windows.Forms.TextBox();
            this.txtbox_phoneNumber = new System.Windows.Forms.TextBox();
            this.txtbox_email = new System.Windows.Forms.TextBox();
            this.btn_submitNewPlayer = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_firstName
            // 
            this.lbl_firstName.AutoSize = true;
            this.lbl_firstName.Location = new System.Drawing.Point(12, 30);
            this.lbl_firstName.Name = "lbl_firstName";
            this.lbl_firstName.Size = new System.Drawing.Size(78, 17);
            this.lbl_firstName.TabIndex = 0;
            this.lbl_firstName.Text = "First name:";
            // 
            // lbl_lastName
            // 
            this.lbl_lastName.AutoSize = true;
            this.lbl_lastName.Location = new System.Drawing.Point(12, 74);
            this.lbl_lastName.Name = "lbl_lastName";
            this.lbl_lastName.Size = new System.Drawing.Size(80, 17);
            this.lbl_lastName.TabIndex = 1;
            this.lbl_lastName.Text = "Last Name:";
            // 
            // lbl_phoneNumber
            // 
            this.lbl_phoneNumber.AutoSize = true;
            this.lbl_phoneNumber.Location = new System.Drawing.Point(12, 113);
            this.lbl_phoneNumber.Name = "lbl_phoneNumber";
            this.lbl_phoneNumber.Size = new System.Drawing.Size(109, 17);
            this.lbl_phoneNumber.TabIndex = 2;
            this.lbl_phoneNumber.Text = " Phone number:";
            // 
            // lbl_email
            // 
            this.lbl_email.AutoSize = true;
            this.lbl_email.Location = new System.Drawing.Point(12, 147);
            this.lbl_email.Name = "lbl_email";
            this.lbl_email.Size = new System.Drawing.Size(46, 17);
            this.lbl_email.TabIndex = 3;
            this.lbl_email.Text = "Email:";
            // 
            // txtbox_firstName
            // 
            this.txtbox_firstName.Location = new System.Drawing.Point(98, 30);
            this.txtbox_firstName.Name = "txtbox_firstName";
            this.txtbox_firstName.Size = new System.Drawing.Size(158, 22);
            this.txtbox_firstName.TabIndex = 4;
            // 
            // txtbox_lastName
            // 
            this.txtbox_lastName.Location = new System.Drawing.Point(98, 74);
            this.txtbox_lastName.Name = "txtbox_lastName";
            this.txtbox_lastName.Size = new System.Drawing.Size(158, 22);
            this.txtbox_lastName.TabIndex = 5;
            // 
            // txtbox_phoneNumber
            // 
            this.txtbox_phoneNumber.Location = new System.Drawing.Point(118, 113);
            this.txtbox_phoneNumber.Name = "txtbox_phoneNumber";
            this.txtbox_phoneNumber.Size = new System.Drawing.Size(138, 22);
            this.txtbox_phoneNumber.TabIndex = 6;
            // 
            // txtbox_email
            // 
            this.txtbox_email.Location = new System.Drawing.Point(78, 144);
            this.txtbox_email.Name = "txtbox_email";
            this.txtbox_email.Size = new System.Drawing.Size(178, 22);
            this.txtbox_email.TabIndex = 7;
            // 
            // btn_submitNewPlayer
            // 
            this.btn_submitNewPlayer.Location = new System.Drawing.Point(170, 193);
            this.btn_submitNewPlayer.Name = "btn_submitNewPlayer";
            this.btn_submitNewPlayer.Size = new System.Drawing.Size(86, 42);
            this.btn_submitNewPlayer.TabIndex = 8;
            this.btn_submitNewPlayer.Text = "Create";
            this.btn_submitNewPlayer.UseVisualStyleBackColor = true;
            this.btn_submitNewPlayer.Click += new System.EventHandler(this.btn_submitNewPlayer_Click);
            // 
            // CreatePlayer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(281, 276);
            this.Controls.Add(this.btn_submitNewPlayer);
            this.Controls.Add(this.txtbox_email);
            this.Controls.Add(this.txtbox_phoneNumber);
            this.Controls.Add(this.txtbox_lastName);
            this.Controls.Add(this.txtbox_firstName);
            this.Controls.Add(this.lbl_email);
            this.Controls.Add(this.lbl_phoneNumber);
            this.Controls.Add(this.lbl_lastName);
            this.Controls.Add(this.lbl_firstName);
            this.Name = "CreatePlayer";
            this.Text = "CreatePlayer";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_firstName;
        private System.Windows.Forms.Label lbl_lastName;
        private System.Windows.Forms.Label lbl_phoneNumber;
        private System.Windows.Forms.Label lbl_email;
        private System.Windows.Forms.TextBox txtbox_firstName;
        private System.Windows.Forms.TextBox txtbox_lastName;
        private System.Windows.Forms.TextBox txtbox_phoneNumber;
        private System.Windows.Forms.TextBox txtbox_email;
        private System.Windows.Forms.Button btn_submitNewPlayer;
    }
}