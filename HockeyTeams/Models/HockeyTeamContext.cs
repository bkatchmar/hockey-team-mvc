using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace HockeyTeams.Models
{
    public class HockeyTeamContext : DbContext
    {
        public HockeyTeamContext (DbContextOptions<HockeyTeamContext> options)
            : base(options)
        {
        }

        public DbSet<HockeyTeams.Models.Team> Teams { get; set; }
    }
}