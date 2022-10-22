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

        public IActionResult Index()
        {
            if(HttpContext.Session.GetString("Id") == null)
            {
                return Redirect("/login");
            };

            List<JobProfile> jobProfiles = _context.JobProfiles
                .Include(jp => jp.Company)
                .Include(jp => jp.JobProfilePerson)
                .Where<JobProfile>(jp => jp.StartingDate <= DateTime.Now 
                && jp.EndingDate >= DateTime.Now)
                .ToList();

            return View(jobProfiles);
        }


        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
