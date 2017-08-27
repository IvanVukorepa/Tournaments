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
    public partial class AddNewTeamForm : Form
    {
        public AddNewTeamForm()
        {
            InitializeComponent();
            teamRepository = new TeamRepository();
        }

        public AddNewTeamForm(string name, string logoAnimalName)
        {
            InitializeComponent();
            teamRepository = new TeamRepository();
            txtbox_name.Text = name;
            txtbox_logoAnimalName.Text = logoAnimalName;
        }

        private TeamRepository teamRepository;
        private void btn_CreateNewTeam_Click(object sender, EventArgs e)
        {
            teamRepository.CreateTeam(txtbox_name.Text, txtbox_logoAnimalName.Text);
            this.Close();
        }
    }
}
