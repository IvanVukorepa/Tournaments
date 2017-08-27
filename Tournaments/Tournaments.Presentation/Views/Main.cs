using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tournaments.Domain;
using Tournaments.Domain.Repositories;
using Tournaments.Data.Models;
using Tournaments.Presentation.Views;

namespace Tournaments.Presentation
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            playerRepository = new PlayerRepository();
            teamRepository = new TeamRepository();
        }

        private PlayerRepository playerRepository;
        private TeamRepository teamRepository;

        private void Form1_Load(object sender, EventArgs e)
        {
            UpdateTeamsListBox();
        }

        private void lbox_teams_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lbox_teams.SelectedItem != null)
            {
                //lbox_players.Items.Clear();
                //lbox_players.Items.AddRange(teamRepository.GetTeamByName(lbox_teams.SelectedItem.ToString()).Players.Select(x => x.FirstName + " " + x.LastName).ToArray());
                UpdatePlayersListBox();
            }
        }

        private void btn_AddTeam_Click(object sender, EventArgs e)
        {
            AddNewTeamForm addNewTeamForm = new AddNewTeamForm();
            addNewTeamForm.ShowDialog();

            UpdateTeamsListBox();
        }

        private void UpdateTeamsListBox()
        {
            lbox_teams.Items.Clear();
            lbox_teams.Items.AddRange(teamRepository.GetAllTeams().Select(x => x.Name).ToArray());
        }

        private void UpdatePlayersListBox()
        {
            lbox_players.Items.Clear();
            lbox_players.Items.AddRange(teamRepository.GetTeamByName(lbox_teams.SelectedItem.ToString()).Players.Select(x => x.FirstName + " " + x.LastName).ToArray());
        }

        private void btn_DeleteTeam_Click(object sender, EventArgs e)
        {
            if (lbox_teams.SelectedItem != null)
            {
                teamRepository.DeleteTeam(lbox_teams.SelectedItem.ToString());
                UpdateTeamsListBox();
            }
        }

        private void btn_EditTeam_Click(object sender, EventArgs e)
        {
            string teamName = lbox_teams.SelectedItem.ToString();
            AddNewTeamForm addNewTeamForm = new AddNewTeamForm(teamRepository.GetTeamByName(teamName).Name, teamRepository.GetTeamByName(teamName).LogoAnimalName);
            teamRepository.DeleteTeam(teamName);
            addNewTeamForm.ShowDialog();

            UpdateTeamsListBox();
        }
    }
}
