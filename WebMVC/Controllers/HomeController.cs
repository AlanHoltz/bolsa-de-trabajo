using BolsaTrabajo.Models;
using BolsaTrabajo.Models.Db;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using WebMVC.Models;
using Microsoft.AspNetCore.Http;

namespace BolsaTrabajo.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly BolsaTrabajoContext _context;

        public HomeController(ILogger<HomeController> logger, BolsaTrabajoContext context)
        {
            _logger = logger;
            _context = context;
            
        }

        public IActionResult Index(int id)
        {

            if(id != 0)
            {
                return Redirect("/"); //Redireccionar a vista con trabajo único y mostrar toda la info
            }

            if(HttpContext.Session.GetString("Id") == null)
            {
                return Redirect("/login");
            };

            List<JobProfilePerson> jobsPersonApplied = _context.JobProfilePerson
                .Where(jpp => jpp.PersonsId == int.Parse(HttpContext.Session.GetString("Id")))
                .ToList();

            List<int> jobsIds = new List<int>();

            foreach (JobProfilePerson jpp in jobsPersonApplied) jobsIds.Add(jpp.JobProfilesId);

            List<JobProfile> jobProfiles = _context.JobProfiles
                .Include(jp => jp.Company)
                //.Include(jp => jp.JobProfilePerson)
                .Where(
                jp => jp.StartingDate <= DateTime.Now 
                && jp.EndingDate >= DateTime.Now 
                && !jobsIds.Contains(jp.Id)
                )
                .OrderByDescending(jp => jp.CreatedAt)
                .ToList();

            

            return View(jobProfiles);
        }

        public int Jobs(int JobId)
        {
            return JobId;
        }

            [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
