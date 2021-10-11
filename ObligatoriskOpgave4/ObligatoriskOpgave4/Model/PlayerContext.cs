using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Opgave_1;

namespace ObligatoriskOpgave4.Model
{
    public class PlayerContext: DbContext
    {
        public PlayerContext(DbContextOptions<PlayerContext> options): base(options)
        {
        }

        public DbSet<FootballPlayer> Players { get; set; }
    }
}
