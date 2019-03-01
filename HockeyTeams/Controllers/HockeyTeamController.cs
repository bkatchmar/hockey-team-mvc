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
        private readonly HockeyTeamContext _dbContext;
        
        public HockeyTeamController(HockeyTeamContext context)
        {
            _dbContext = context;
        }

        // 
        // GET: /HockeyTeam/ 
        public async Task<IActionResult> Index(string division = "")
        {
            if (string.IsNullOrEmpty(division)) {
                ViewData["BaseMessage"] = "List all Hockey Teams Here";
            } else {
                ViewData["BaseMessage"] = $"Filtering Teams By The {division} Division";
            }

            return View(await Task.FromResult(_dbContext.Teams.ToList()));
        }

        // 
        // GET: /HelloWorld/IndividualTeam/ 

        public string IndividualTeam()
        {
            return "Individual Team From Params Here";
        }
    }
}