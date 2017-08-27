using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tournaments.Data.Models
{   
    public class Tournament
    {
        public int Id { get; set; }

        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public string Name { get; set; }

        public ICollection<Match> Matches { get; set; }

        public Tournament(DateTime startDate, DateTime endDate)
        {
            Matches = new List<Match>();
            StartDate = startDate;
            EndDate = endDate;
        }
    }
}
