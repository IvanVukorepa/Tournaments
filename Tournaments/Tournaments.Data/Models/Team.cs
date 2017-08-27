using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tournaments.Data.Models
{
    public class Team
    {
        public int Id { get; set; }

        public string Name { get; set; }
        public ICollection<Tournament> TournamentsWon { get; set; }
        public DateTime? LastTournamentWonDate { get; set; }
        public string LogoAnimalName { get; set; }

        public ICollection<Match> MatchesPlayed { get; set; }
        public ICollection<Player> Players { get; set; }

        public Team()
        {
            TournamentsWon = new HashSet<Tournament>();
            LastTournamentWonDate = null;
            MatchesPlayed = new HashSet<Match>();
            Players = new List<Player>();
        }
    }
}
