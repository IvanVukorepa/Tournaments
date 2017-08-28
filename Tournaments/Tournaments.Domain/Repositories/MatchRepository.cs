using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tournaments.Data;
using Tournaments.Data.Models;
using System.Data.Entity;

namespace Tournaments.Domain.Repositories
{
    public class MatchRepository
    {
        public Match CreateMatch(string name, Round round, bool isTournamentMatch, Tournament tournament, Team team1, Team team2)
        {
            Match match = new Match() { Name = name, Round = round, IsTournamentMatch = isTournamentMatch, Tournament=tournament };

            using (var context = new TournamentsContext())
            {
                if (round == Round.semiFinals || round==Round.friendly)
                {
                    context.Teams.Attach(team1);
                    context.Teams.Attach(team2);
                    if (tournament != null)
                        context.Tournaments.Attach(tournament);
                }

                context.Matches.Add(match);
                if(tournament!=null)
                    tournament.Matches.Add(match);
                match.Teams.Add(team1);
                match.Teams.Add(team2);

                context.SaveChanges();
            }
            return match;
        }
    }
}
