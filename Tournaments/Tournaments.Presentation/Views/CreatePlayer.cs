using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tournaments.Domain.Repositories;

namespace Tournaments.Presentation.Views
{
    public partial class CreatePlayer : Form
    {
        public CreatePlayer()
        {
            InitializeComponent();
            playerRepository = new PlayerRepository();
        }

        private PlayerRepository playerRepository;

        private void btn_submitNewPlayer_Click(object sender, EventArgs e)
        {
            bool succeded = false;
            do
            {
                succeded = playerRepository.CreatePlayer(txtbox_firstName.Text, txtbox_lastName.Text, txtbox_phoneNumber.Text, txtbox_email.Text);
                if (!succeded)
                    MessageBox.Show("That player already exists!");
            } while (!succeded);
            this.Close();
        }
    }
}
