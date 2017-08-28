using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tournaments.Data;
using Tournaments.Data.Models;

namespace Tournaments.Domain.Repositories
{
    public class MatchRepository
    {
        public Match CreateMatch(string name, Round round, bool isTournamentMatch, Team team1, Team team2)
        {
            Match match = new Match() { Name = name, Round = round, IsTournamentMatch = isTournamentMatch, Tournament=null };

            using (var context = new TournamentsContext())
            {
                context.Teams.Attach(team1);
                context.Teams.Attach(team2);
                context.Matches.Add(match);
                match.Teams.Add(team1);
                match.Teams.Add(team2);
                context.SaveChanges();
            }
            return match;
        }
    }
}
