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
    }
}
