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

        public List<Player> GetAllPlayersWithoutTeams()
        {
            using (var context = new TournamentsContext())
            {
                return context.Players.Where(x => x.Team==null).ToList();
            }
        }

        public Player GetPlayerByName(string fullName)
        {
            string[] name = fullName.Split(' ');
            using (var context = new TournamentsContext())
            {
                return context.Players.FirstOrDefault(x => x.FirstName == name[0] && x.LastName==name[1]);
            }
        }

        public bool CreatePlayer(string firstName ,string lastName, string phoneNumber, string email)
        {
            bool returnValue=false;
            using (var context = new TournamentsContext())
            {
                if (context.Players.Where(x => x.FirstName == firstName && x.LastName == lastName).Count() == 0)
                {
                    context.Players.Add(new Player(firstName, lastName, phoneNumber, email));
                    context.SaveChanges();
                    returnValue= true;
                }              
            }
            return returnValue;
        } 
    }
}
