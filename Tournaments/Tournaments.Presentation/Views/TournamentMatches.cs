using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tournaments.Data.Models;
using Tournaments.Domain.Repositories;
using Tournaments.Data;

namespace Tournaments.Presentation.Views
{
    public partial class TournamentMatches : Form
    {
        public TournamentMatches(Tournament tournament, string team1, string team2, string team3, string team4)
        {
            InitializeComponent();
            teamRepository = new TeamRepository();
            matchRepository = new MatchRepository();
            tournamentRepository = new TournamentRepository();
            Team1 = team1;
            Team2 = team2;
            Team3 = team3;
            Team4 = team4;
            Tournament = tournament;
        }

        private TeamRepository teamRepository;
        private MatchRepository matchRepository;
        private string Team1, Team2, Team3, Team4;
        private TournamentRepository tournamentRepository;

        private Tournament Tournament;

        private void btn_secondSemifinalPlay_Click(object sender, EventArgs e)
        {
            Match match2 = matchRepository.CreateMatch(lbl_secondSemifinalFirstTeam.Text + "-" + lbl_secondSemifinalSecondTeam.Text, Round.semiFinals, true, Tournament, teamRepository.GetTeamByName(lbl_secondSemifinalFirstTeam.Text), teamRepository.GetTeamByName(lbl_secondSemifinalSecondTeam.Text));
            /*match2.Tournament = Tournament;
            Tournament.Matches.Add(match2);*/

            /*teamRepository.GetTeamByName(lbl_secondSemifinalFirstTeam.Text).MatchesPlayed.Add(match2);
            teamRepository.GetTeamByName(lbl_secondSemifinalSecondTeam.Text).MatchesPlayed.Add(match2);
            match2.Teams.Add(teamRepository.GetTeamByName(lbl_secondSemifinalFirstTeam.Text));
            match2.Teams.Add(teamRepository.GetTeamByName(lbl_secondSemifinalSecondTeam.Text));*/

            Random rnd = new Random();

            if (rnd.Next(0, 1) < 0.5)
            {
                MessageBox.Show(lbl_secondSemifinalFirstTeam.Text + " won");
                lbl_secondFinalsTeam.Text = lbl_secondSemifinalFirstTeam.Text;
            }
            else
            {
                MessageBox.Show(lbl_secondSemifinalSecondTeam.Text + " won");
                lbl_secondFinalsTeam.Text = lbl_secondSemifinalSecondTeam.Text;
            }
        }

        private void btn_finalPlay_Click(object sender, EventArgs e)
        {
            if (lbl_firstFinalsTeam.Text == "First semifinal winner" || lbl_secondFinalsTeam.Text == "Second semifinal winner")
            {
                MessageBox.Show("Yout need to play both semi final games first");
                return;
            }
            else
            {
                Match match = matchRepository.CreateMatch(lbl_firstFinalsTeam.Text + "-" + lbl_secondFinalsTeam.Text, Round.finals, true, Tournament, teamRepository.GetTeamByName(lbl_firstFinalsTeam.Text), teamRepository.GetTeamByName(lbl_secondFinalsTeam.Text));
                /*match.Tournament = Tournament;
                Tournament.Matches.Add(match);*/

                /*teamRepository.GetTeamByName(lbl_firstFinalsTeam.Text).MatchesPlayed.Add(match);
                teamRepository.GetTeamByName(lbl_secondFinalsTeam.Text).MatchesPlayed.Add(match);
                match.Teams.Add(teamRepository.GetTeamByName(lbl_firstFinalsTeam.Text));
                match.Teams.Add(teamRepository.GetTeamByName(lbl_secondFinalsTeam.Text));*/

                Random rnd = new Random();

                if (rnd.Next(0, 1) < 0.5)
                {
                    MessageBox.Show(lbl_firstFinalsTeam.Text + " won the tournament");
                    teamRepository.GetTeamByName(lbl_firstFinalsTeam.Text).TournamentsWon.Add(Tournament);
                    teamRepository.GetTeamByName(lbl_firstFinalsTeam.Text).LastTournamentWonDate = DateTime.Now;
                }
                else
                {
                    MessageBox.Show(lbl_secondFinalsTeam.Text + " won the tournament");
                    teamRepository.GetTeamByName(lbl_secondFinalsTeam.Text).TournamentsWon.Add(Tournament);
                    teamRepository.GetTeamByName(lbl_secondFinalsTeam.Text).LastTournamentWonDate = DateTime.Now;
                }
                this.Close();
            }
        }

        private void btn_firstSemifinalPlay_Click(object sender, EventArgs e)
        {
            Match match1 = matchRepository.CreateMatch(lbl_firstSemifinalFirstTeam.Text + "-" + lbl_firstSemifinalSecondTeam.Text, Round.semiFinals, true, Tournament, teamRepository.GetTeamByName(lbl_firstSemifinalFirstTeam.Text), teamRepository.GetTeamByName(lbl_firstSemifinalSecondTeam.Text));
            /*match1.Tournament = Tournament;
            Tournament.Matches.Add(match1);*/

            /*teamRepository.GetTeamByName(lbl_firstSemifinalFirstTeam.Text).MatchesPlayed.Add(match1);
            teamRepository.GetTeamByName(lbl_firstSemifinalSecondTeam.Text).MatchesPlayed.Add(match1);
            match1.Teams.Add(teamRepository.GetTeamByName(lbl_firstSemifinalFirstTeam.Text));
            match1.Teams.Add(teamRepository.GetTeamByName(lbl_firstSemifinalSecondTeam.Text));*/

            Random rnd = new Random();

            if (rnd.Next(0, 1) < 0.5)
            {
                MessageBox.Show(lbl_firstSemifinalFirstTeam.Text + " won");
                lbl_firstFinalsTeam.Text = lbl_firstSemifinalFirstTeam.Text;
            }
            else
            {
                MessageBox.Show(lbl_firstSemifinalSecondTeam.Text + " won");
                lbl_firstFinalsTeam.Text = lbl_firstSemifinalSecondTeam.Text;
            }

        }

        private void TournamentMatches_Load(object sender, EventArgs e)
        {
            List<int> positions = new List<int>();
            Random rand = new Random();
            int number;
            for (int i = 0; i < 4; i++)
            {
                number = rand.Next(1, 5);
                if (positions.Contains(number))
                {
                    i--;
                    continue;
                }
                positions.Add(number);
                switch (i)
                {
                    case 0:
                        switch (number)
                        {
                            case 1:
                                lbl_firstSemifinalFirstTeam.Text = Team1;
                                break;
                            case 2:
                                lbl_firstSemifinalSecondTeam.Text = Team1;
                                break;
                            case 3:
                                lbl_secondSemifinalFirstTeam.Text = Team1;
                                break;
                            case 4:
                                lbl_secondSemifinalSecondTeam.Text = Team1;
                                break;
                        }
                        break;
                    case 1:
                        switch (number)
                        {
                            case 1:
                                lbl_firstSemifinalFirstTeam.Text = Team2;
                                break;
                            case 2:
                                lbl_firstSemifinalSecondTeam.Text = Team2;
                                break;
                            case 3:
                                lbl_secondSemifinalFirstTeam.Text = Team2;
                                break;
                            case 4:
                                lbl_secondSemifinalSecondTeam.Text = Team2;
                                break;
                        }
                        break;
                    case 2:
                        switch (number)
                        {
                            case 1:
                                lbl_firstSemifinalFirstTeam.Text = Team3;
                                break;
                            case 2:
                                lbl_firstSemifinalSecondTeam.Text = Team3;
                                break;
                            case 3:
                                lbl_secondSemifinalFirstTeam.Text = Team3;
                                break;
                            case 4:
                                lbl_secondSemifinalSecondTeam.Text = Team3;
                                break;
                        }
                        break;
                    case 3:
                        switch (number)
                        {
                            case 1:
                                lbl_firstSemifinalFirstTeam.Text = Team4;
                                break;
                            case 2:
                                lbl_firstSemifinalSecondTeam.Text = Team4;
                                break;
                            case 3:
                                lbl_secondSemifinalFirstTeam.Text = Team4;
                                break;
                            case 4:
                                lbl_secondSemifinalSecondTeam.Text = Team4;
                                break;
                        }
                        break;
                }
            }
        }
    }
}
