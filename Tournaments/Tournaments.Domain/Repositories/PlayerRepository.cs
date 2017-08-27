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

        public void CreatePlayer(string firstName ,string lastName, string phoneNumber, string email)
        {
            using (var context = new TournamentsContext())
            {
                if(context.Players.Where(x => x.FirstName==firstName && x.LastName==lastName).Count()==0)
                    context.Players.Add(new Player(firstName, lastName, phoneNumber, email));
                context.SaveChanges();
            }
        } 
    }
}
