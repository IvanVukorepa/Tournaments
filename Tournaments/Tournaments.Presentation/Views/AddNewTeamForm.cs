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
            edit = false;
        }

        public AddNewTeamForm(string name, string logoAnimalName)
        {
            InitializeComponent();
            teamRepository = new TeamRepository();
            txtbox_name.Text = name;
            txtbox_logoAnimalName.Text = logoAnimalName;
            edit = true;
            teamName = name;
            LogoAnimalName = logoAnimalName;
            btn_CreateNewTeam.Text = "Submit changes";
        }

        private TeamRepository teamRepository;
        private bool edit;
        private string teamName;
        private string LogoAnimalName;

        private void btn_CreateNewTeam_Click(object sender, EventArgs e)
        {
            if (!edit)
                teamRepository.CreateTeam(txtbox_name.Text, txtbox_logoAnimalName.Text);
            else
            {
                if (teamRepository.GetAllTeams().Where(x => x.Name == txtbox_name.Text || x.LogoAnimalName == txtbox_logoAnimalName.Text).Count() == 0 || teamRepository.GetAllTeams().Where(x => x.Name == txtbox_name.Text || x.LogoAnimalName == txtbox_logoAnimalName.Text).Count() == 1 && (teamName==txtbox_name.Text || LogoAnimalName==txtbox_logoAnimalName.Text))
                {
                    teamRepository.EditTeam(teamName, txtbox_name.Text, txtbox_logoAnimalName.Text);
                    //teamRepository.GetTeamByName(teamName).LogoAnimalName = txtbox_logoAnimalName.Text;
                    //teamRepository.GetTeamByName(teamName).Name = txtbox_name.Text;
                }
            }
            this.Close();
        }
    }
}
