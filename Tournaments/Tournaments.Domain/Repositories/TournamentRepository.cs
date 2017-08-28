using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tournaments.Data.Models;
using Tournaments.Data;

namespace Tournaments.Domain.Repositories
{
    public class TournamentRepository
    {
        public Tournament CreateTournament(DateTime startDate, DateTime endDate, string name)
        {
            Tournament tournament = new Tournament(startDate, endDate, name);

            using (var context = new TournamentsContext())
            {
                context.Tournaments.Add(tournament);
                context.SaveChanges();
            }
            return tournament;
        }
    }
}
