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
                return View(await Task.FromResult(_dbContext.Teams.ToList()));
            } else {
                ViewData["BaseMessage"] = $"Filtering Teams By The {division} Division";
                return View(await Task.FromResult(_dbContext.Teams.Where(t => t.Division.ToUpper().Equals(division.ToUpper()))));
            }
        }

        // 
        // GET: /HockeyTeam/IndividualTeam/{id}
        public async Task<IActionResult> IndividualTeam(int? id)
        {
            if (id == null) { return NotFound(); }
            var team = await Task.FromResult(_dbContext.Teams.FirstOrDefault(m => m.Id == id));
            if (team == null) { return NotFound(); }
            return View("~/Views/HockeyTeam/IndividualTeam.cshtml", team);
        }

        // GET: /HockeyTeam/GetAll
        [HttpGet]
        public async Task<ActionResult> GetAll()
        {
            var teams = await Task.FromResult(_dbContext.Teams.ToList());
            return Ok(teams);
        }
    }
}