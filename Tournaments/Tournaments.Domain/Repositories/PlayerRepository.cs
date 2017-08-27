using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tournaments.Data;
using Tournaments.Data.Models;

namespace Tournaments.Domain.Repositories
{
    public class PlayerRepository
    {
        public List<Player> GetAllPlayers()
        {
            using (var context = new TournamentsContext())
            {
                return context.Players.ToList();
            }
        }
    }
}
