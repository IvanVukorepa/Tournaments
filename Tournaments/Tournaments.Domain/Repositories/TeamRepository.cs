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
    public class TeamRepository
    {
        public List<Team> GetAllTeams()
        {
            using (var context = new TournamentsContext())
            {
                return context.Teams.ToList();
            }
        }

        public Team GetTeamByName(string name)
        {
            using (var context = new TournamentsContext())
            {
                return context.Teams.Include("Players").FirstOrDefault(x=>x.Name==name);
            }
        }

        public void CreateTeam(string name, string logoAnimalName)
        {
            using (var context = new TournamentsContext())
            {
                if (context.Teams.Where(x => x.Name == name || x.LogoAnimalName == logoAnimalName).Count() == 0)
                {
                    context.Teams.Add(new Team(name, logoAnimalName));
                    context.SaveChanges();
                }   
            }
        }

        public void DeleteTeam(string name)
        {
            using (var context = new TournamentsContext())
            {
                var team = context.Teams.FirstOrDefault(x => x.Name == name);
                context.Entry(team).State = EntityState.Deleted;
                context.SaveChanges();
            }
        }

        public void AddPlayerToTeam(string teamName, string personName)
        {
            string[] array = personName.Split(' ');
            string firstName = array[0];
            string lastName = array[1];
            using (var context = new TournamentsContext())
            {
                //var team = context.Teams.FirstOrDefault(x => x.Name == teamName);
                var player = context.Players.FirstOrDefault(x => x.FirstName == firstName && x.LastName == lastName);
                context.Teams.FirstOrDefault(x => x.Name == teamName).Players.Add(player);
                //context.Entry(team).State = EntityState.Modified;
                context.SaveChanges();
            }
        }

        public void RemovePlayerFromTeam(string teamName, string personName)
        {
            string[] array = personName.Split(' ');
            string firstName = array[0];
            string lastName = array[1];
            using (var context = new TournamentsContext())
            {
                //var team = context.Teams.FirstOrDefault(x => x.Name == teamName);
                var player = context.Players.FirstOrDefault(x => x.FirstName == firstName && x.LastName == lastName);
                context.Teams.FirstOrDefault(x => x.Name == teamName).Players.Remove(player);
                //context.Entry(team).State = EntityState.Modified;
                context.SaveChanges();
            }
        }

        public void RemoveAllPlayersFromTeam(string teamName)
        {
            using (var context = new TournamentsContext())
            {
                context.Teams.Include("Players").FirstOrDefault(x => x.Name == teamName).Players.ToList().ForEach(x => x.Team = null);
                context.Teams.FirstOrDefault(x => x.Name == teamName).Players.Clear();
                context.SaveChanges();
            }
        }
    }
}
