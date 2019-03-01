using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Linq;

namespace HockeyTeams.Models
{
    public static class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new HockeyTeamContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<HockeyTeamContext>>()))
            {
                // Look for any movies.
                if (context.Teams.Any())
                {
                    return;   // DB has been seeded
                }

                context.Teams.AddRange(
                    new Team { Location = "New York", Name = "Rangers", Division = "Metropolitan", Conference = "Eastern" },
                    new Team { Location = "New York", Name = "Islanders", Division = "Metropolitan", Conference = "Eastern" },
                    new Team { Location = "Washington", Name = "Capitals", Division = "Metropolitan", Conference = "Eastern" },
                    new Team { Location = "Pittsburgh", Name = "Penguins", Division = "Metropolitan", Conference = "Eastern" },
                    new Team { Location = "Philadelphia", Name = "Flyers", Division = "Metropolitan", Conference = "Eastern" },
                    new Team { Location = "Carolina", Name = "Hurricanes", Division = "Metropolitan", Conference = "Eastern" },
                    new Team { Location = "Columbus", Name = "Blue Jackets", Division = "Metropolitan", Conference = "Eastern" },
                    new Team { Location = "New Jersey", Name = "Devils", Division = "Metropolitan", Conference = "Eastern" },
                    new Team { Location = "Tampa Bay", Name = "Lightning", Division = "Atlantic", Conference = "Eastern" },
                    new Team { Location = "Boston", Name = "Bruins", Division = "Atlantic", Conference = "Eastern" },
                    new Team { Location = "Toronto", Name = "Maple Leafs", Division = "Atlantic", Conference = "Eastern" },
                    new Team { Location = "Montréal", Name = "Canadiens", Division = "Atlantic", Conference = "Eastern" },
                    new Team { Location = "Buffalo", Name = "Sabres", Division = "Atlantic", Conference = "Eastern" },
                    new Team { Location = "Florida", Name = "Panthers", Division = "Atlantic", Conference = "Eastern" },
                    new Team { Location = "Detroit", Name = "Red Wings", Division = "Atlantic", Conference = "Eastern" },
                    new Team { Location = "Ottawa", Name = "Senators", Division = "Atlantic", Conference = "Eastern" },
                    new Team { Location = "Winnipeg", Name = "Jets", Division = "Central", Conference = "Western" },
                    new Team { Location = "Nashville", Name = "Predators", Division = "Central", Conference = "Western" },
                    new Team { Location = "St. Louis", Name = "Blues", Division = "Central", Conference = "Western" },
                    new Team { Location = "Dallas", Name = "Stars", Division = "Central", Conference = "Western" },
                    new Team { Location = "Minnesota", Name = "Wild", Division = "Central", Conference = "Western" },
                    new Team { Location = "Colorado", Name = "Avalanche", Division = "Central", Conference = "Western" },
                    new Team { Location = "Chicago", Name = "Blackhawks", Division = "Central", Conference = "Western" },
                    new Team { Location = "Calgary", Name = "Flames", Division = "Pacific", Conference = "Western" },
                    new Team { Location = "San Jose", Name = "Sharks", Division = "Pacific", Conference = "Western" },
                    new Team { Location = "Anaheim", Name = "Ducks", Division = "Pacific", Conference = "Western" },
                    new Team { Location = "Vegas", Name = "Golden Knights", Division = "Pacific", Conference = "Western" },
                    new Team { Location = "Arizona", Name = "Coyotes", Division = "Pacific", Conference = "Western" },
                    new Team { Location = "Vancouver", Name = "Canucks", Division = "Pacific", Conference = "Western" },
                    new Team { Location = "Edmonton", Name = "Oilers", Division = "Pacific", Conference = "Western" },
                    new Team { Location = "Los Angeles", Name = "Kings", Division = "Pacific", Conference = "Western" }
                );
                context.SaveChanges();
            }
        }
    }
}