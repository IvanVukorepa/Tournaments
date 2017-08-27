using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tournaments.Data.Models
{
    public enum Round { friendly, semiFinals, finals}
    public class Match
    {
        public int Id { get; set; }

        public string Name { get; set; }
        public Round Round { get; set; }
        public bool IsTournamentMatch { get; set; }

        public Tournament Tournament { get; set; }
        public ICollection<Team> Teams { get; set; }

        public Match()
        {
            Teams = new List<Team>();
        }
    }
}
