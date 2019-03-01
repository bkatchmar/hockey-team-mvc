
using System;
using System.ComponentModel.DataAnnotations;

namespace HockeyTeams.Models
{
    public class Team
    {
        public int Id { get; set; }
        public string Location { get; set; }
        public string Name { get; set; }
        public string Division { get; set; }
        public string Conference { get; set; }
    }
}