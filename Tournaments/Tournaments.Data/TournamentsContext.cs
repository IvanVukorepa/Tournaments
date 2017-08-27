using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace Tournaments.Data
{
    public class TournamentsContext : DbContext
    {
        public TournamentsContext() : base("Tournaments")
        {

        }
    }
}
