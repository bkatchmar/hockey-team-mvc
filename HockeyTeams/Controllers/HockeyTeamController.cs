using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using Microsoft.AspNetCore.Mvc;
using HockeyTeams.Models;

namespace HockeyTeams.Controllers
{
    public class HockeyTeamController : Controller
    {
        // 
        // GET: /HockeyTeam/

        public string Index(string division = "")
        {
            if (string.IsNullOrEmpty(division)) {
                return "List all Hockey Teams Here";
            } else {
                return HttpUtility.HtmlEncode($"Filtering Teams By The {division} Division");
            }
        }

        // 
        // GET: /HelloWorld/IndividualTeam/ 

        public string IndividualTeam()
        {
            return "Individual Team From Params Here";
        }
    }
}