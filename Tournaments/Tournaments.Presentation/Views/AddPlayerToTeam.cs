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
    public partial class AddPlayerToTeam : Form
    {
        public AddPlayerToTeam(string name)
        {
            InitializeComponent();
            playerRepository = new PlayerRepository();
            teamRepository = new TeamRepository();
            teamName = name;
        }
        private PlayerRepository playerRepository;
        private TeamRepository teamRepository;
        private string teamName;

        private void AddPlayerToTeam_Load(object sender, EventArgs e)
        {
            UpdateAvailablePlayersListBox();
        }

        private void UpdateAvailablePlayersListBox()
        {
            lbox_availablePlayers.Items.Clear();
            lbox_availablePlayers.Items.AddRange(playerRepository.GetAllPlayersWithoutTeams().Select(x => x.FirstName + " " + x.LastName).ToArray());
        }

        private void btn_addPlayerToTeam_Click(object sender, EventArgs e)
        {
            if (lbox_availablePlayers.SelectedItem != null)
            {
                //teamRepository.GetTeamByName(teamName).Players.Add(playerRepository.GetPlayerByName(lbox_availablePlayers.SelectedItem.ToString()));
                //playerRepository.GetPlayerByName(lbox_availablePlayers.SelectedItem.ToString()).Team=teamRepository.GetTeamByName(teamName);

                teamRepository.AddPlayerToTeam(teamName, lbox_availablePlayers.SelectedItem.ToString());
                playerRepository.AddPlayerToTeam(teamName, lbox_availablePlayers.SelectedItem.ToString());

                this.Close();
            }
        }

        private void btn_CreateNewPlayer_Click(object sender, EventArgs e)
        {
            CreatePlayer createPlayerForm = new CreatePlayer();
            createPlayerForm.ShowDialog();
            UpdateAvailablePlayersListBox();
        }
    }
}
