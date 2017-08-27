using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using Tournaments.Data.Models;

namespace Tournaments.Data
{
    public class TournamentsContext : DbContext
    {
        public TournamentsContext() : base("Tournaments")
        {
            Database.SetInitializer(new TournamentsInitializer());
        }

        public virtual DbSet<Player> Players { get; set; }
        public virtual DbSet<Team> Teams { get; set; }
        public virtual DbSet<Match> Matches { get; set; }
        public virtual DbSet<Tournament> Tournaments { get; set; }
    }
}
