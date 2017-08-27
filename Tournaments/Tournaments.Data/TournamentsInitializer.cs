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
            

            var player1 = new Player("Ivo", "Jukić", "0984565321", "ivoJukic@gmail.com") { Team = team1 };
            var player2 = new Player("Marin", "Stojkić", "0997897898", "marin1234@gmail.com") { Team = team1 };
            var player3 = new Player("Franko", "Jelovčić", "0997897897", "frankoJelovcic@gmail.com") { Team = team1 };
            var player4 = new Player("Branko", "Laura", "0997897238", "laurabranko@gmail.com") { Team = team1 };
            var player5 = new Player("Renato", "Koturović", "0954651234", "renikotur@gmail.com") { Team = team1 };

            var player6 = new Player("Matija", "Capar", "098495321", "matijac@gmail.com") { Team = team2 };
            var player7 = new Player("Željko", "Petrović", "0997658298", "zeljkopetrovic@gmail.com") { Team = team2 };
            var player8 = new Player("Goran", "Dakić", "0991263897", "gorand@gmail.com") { Team = team2 };
            var player9 = new Player("Alen", "Protega", "0999873258", "protegaalen@gmail.com") { Team = team2 };
            var player10 = new Player("Tihomir", "Novak", "0954463134", "tihonovak@gmail.com") { Team = team2 };

            context.Players.Add(player1);
            context.Players.Add(player2);
            context.Players.Add(player3);
            context.Players.Add(player4);
            context.Players.Add(player5);
            context.Players.Add(player6);
            context.Players.Add(player7);
            context.Players.Add(player8);
            context.Players.Add(player9);
            context.Players.Add(player10);

            team1.Players.Add(player1);
            team1.Players.Add(player2);
            team1.Players.Add(player3);
            team1.Players.Add(player4);
            team1.Players.Add(player5);
            team2.Players.Add(player6);
            team2.Players.Add(player7);
            team2.Players.Add(player8);
            team2.Players.Add(player9);
            team2.Players.Add(player10);

            context.Teams.Add(team1);
            context.Teams.Add(team2);

            context.SaveChanges();

            base.Seed(context);
        }
    }
}
