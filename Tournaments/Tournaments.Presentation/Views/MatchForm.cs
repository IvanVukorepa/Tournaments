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
using Tournaments.Data.Models;

namespace Tournaments.Presentation.Views
{
    public partial class MatchForm : Form
    {
        public MatchForm()
        {
            InitializeComponent();
            teamRepository = new TeamRepository();
            matchRepository = new MatchRepository();
        }

        private TeamRepository teamRepository;
        private MatchRepository matchRepository;

        private void MatchForm_Load(object sender, EventArgs e)
        {
            FillUpListBoxes();
        }

        private void FillUpListBoxes()
        {
            lbox_homeTeamSelection.Items.AddRange(teamRepository.GetAllTeams().Where(x => x.Players.Count() == 5).Select(x => x.Name).ToArray());
            lbox_awayTeamSelection.Items.AddRange(teamRepository.GetAllTeams().Where(x => x.Players.Count() == 5).Select(x => x.Name).ToArray());
        }

        private void btn_playMatch_Click(object sender, EventArgs e)
        {
            if (lbox_homeTeamSelection.SelectedItem != null && lbox_awayTeamSelection.SelectedItem != null && lbox_awayTeamSelection.SelectedItem.ToString() != lbox_homeTeamSelection.SelectedItem.ToString())
            {
                Match match = matchRepository.CreateMatch(lbox_homeTeamSelection.SelectedItem.ToString() + "-" + lbox_awayTeamSelection.SelectedItem.ToString(), Round.friendly, false/*, teamRepository.GetTeamByName(lbox_homeTeamSelection.SelectedItem.ToString()), teamRepository.GetTeamByName(lbox_awayTeamSelection.SelectedItem.ToString())*/);

                teamRepository.GetTeamByName(lbox_homeTeamSelection.SelectedItem.ToString()).MatchesPlayed.Add(match);
                teamRepository.GetTeamByName(lbox_awayTeamSelection.SelectedItem.ToString()).MatchesPlayed.Add(match);
                match.Teams.Add(teamRepository.GetTeamByName(lbox_homeTeamSelection.SelectedItem.ToString()));
                match.Teams.Add(teamRepository.GetTeamByName(lbox_awayTeamSelection.SelectedItem.ToString()));

                Random rnd = new Random();

                if (rnd.Next(0, 1) < 0.6)
                    MessageBox.Show(lbox_homeTeamSelection.SelectedItem.ToString() + " won");
                else
                    MessageBox.Show(lbox_awayTeamSelection.SelectedItem.ToString() + " won");

                this.Close();
            }
            else if (lbox_awayTeamSelection.SelectedItem.ToString() == lbox_homeTeamSelection.SelectedItem.ToString())
                MessageBox.Show("You have to choose two different teams");
            else
                MessageBox.Show("You nee to choose two teams to play");
        }
    }
}
