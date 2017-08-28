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
using Tournaments.Presentation.Views;

namespace Tournaments.Presentation.Views
{
    public partial class TournamentForm : Form
    {
        public TournamentForm()
        {
            InitializeComponent();
            teamRepository = new TeamRepository();
            tournamentRepository = new TournamentRepository();
        }

        private TeamRepository teamRepository;
        private TournamentRepository tournamentRepository;

        private void TournamentForm_Load(object sender, EventArgs e)
        {
            FillUpListBoxes();
        }

        private void FillUpListBoxes()
        {
            lbox_team1Selection.Items.AddRange(teamRepository.GetAllTeams().Where(x => x.Players.Count() == 5).Select(x => x.Name).ToArray());
            lbox_team2Selection.Items.AddRange(teamRepository.GetAllTeams().Where(x => x.Players.Count() == 5).Select(x => x.Name).ToArray());
            lbox_team3Selection.Items.AddRange(teamRepository.GetAllTeams().Where(x => x.Players.Count() == 5).Select(x => x.Name).ToArray());
            lbox_team4Selection.Items.AddRange(teamRepository.GetAllTeams().Where(x => x.Players.Count() == 5).Select(x => x.Name).ToArray());
        }

        private void btn_createTournament_Click(object sender, EventArgs e)
        {
            if (lbox_team1Selection.SelectedItem != null && lbox_team2Selection.SelectedItem != null && lbox_team3Selection.SelectedItem != null && lbox_team4Selection.SelectedItem != null && lbox_team1Selection.SelectedItem.ToString() != lbox_team2Selection.SelectedItem.ToString() && lbox_team1Selection.SelectedItem.ToString() != lbox_team3Selection.SelectedItem.ToString() && lbox_team1Selection.SelectedItem.ToString() != lbox_team4Selection.SelectedItem.ToString() && lbox_team2Selection.SelectedItem.ToString() != lbox_team3Selection.SelectedItem.ToString() && lbox_team2Selection.SelectedItem.ToString() != lbox_team4Selection.SelectedItem.ToString() && lbox_team3Selection.SelectedItem.ToString() != lbox_team4Selection.SelectedItem.ToString())
            {
                Tournament tournament = tournamentRepository.CreateTournament(DateTime.Now, DateTime.Now.AddDays(1), lbox_team1Selection.SelectedItem.ToString() + " tournament");
                TournamentMatches tournamentMatchers = new TournamentMatches(tournament, lbox_team1Selection.SelectedItem.ToString(), lbox_team2Selection.SelectedItem.ToString(), lbox_team3Selection.SelectedItem.ToString(), lbox_team4Selection.SelectedItem.ToString());
                tournamentMatchers.ShowDialog();
            }
            else
                MessageBox.Show("Choose 4 different teams!");
        }
    }
}
