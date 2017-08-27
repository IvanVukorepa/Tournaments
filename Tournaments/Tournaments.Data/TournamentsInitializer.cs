using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using Tournaments.Data.Models;

namespace Tournaments.Data
{
    public class TournamentsInitializer : CreateDatabaseIfNotExists<TournamentsContext>
    {
        protected override void Seed(TournamentsContext context)
        {
            var team1 = new Team() { Name = "MNK Split Tommy", LogoAnimalName = "Tigers" };
            var team2 = new Team() { Name = "MNK Murter", LogoAnimalName = "Lions" };
            context.Teams.Add(team1);
            context.Teams.Add(team2);

            var players = new List<Player>()
            {
                new Player("Ivo", "Jukić", "0984565321", "ivoJukic@gmail.com") { Team = team1},
                new Player("Marin", "Stojkić", "0997897898", "marin1234@gmail.com") { Team = team1},
                new Player("Franko", "Jelovčić", "0997897897", "frankoJelovcic@gmail.com"){ Team = team1},
                new Player("Branko", "Laura", "0997897238", "laurabranko@gmail.com"){ Team = team1},
                new Player("Renato", "Koturović", "0954651234", "renikotur@gmail.com"){ Team = team1},

                new Player("Matija", "Capar", "098495321", "matijac@gmail.com"){ Team = team2},
                new Player("Željko", "Petrović", "0997658298", "zeljkopetrovic@gmail.com"){ Team = team2},
                new Player("Goran", "Dakić", "0991263897", "gorand@gmail.com"){ Team = team2},
                new Player("Alen", "Protega", "0999873258", "protegaalen@gmail.com"){ Team = team2},
                new Player("Tihomir", "Novak", "0954463134", "tihonovak@gmail.com"){ Team = team2}
            };
            context.Players.AddRange(players);

            context.SaveChanges();

            base.Seed(context);
        }
    }
}
