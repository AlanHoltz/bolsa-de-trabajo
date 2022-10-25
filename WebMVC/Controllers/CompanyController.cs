using BolsaTrabajo.Models.Db;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using WebMVC.Models;

namespace WebMVC.Controllers
{
    public class CompanyController : Controller
    {
        private readonly BolsaTrabajoContext _context;

        public CompanyController(BolsaTrabajoContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            if (HttpContext.Session.GetString("Id") != null && HttpContext.Session.GetString("Type") == "Company")
            {
                return View();
            }

            return Redirect("/");
        }

        public IActionResult Proposals()
        {
            if(HttpContext.Session.GetString("Id") != null && HttpContext.Session.GetString("Type") == "Company")
            {
                int companyId = int.Parse(HttpContext.Session.GetString("Id"));

                List<JobProfile> jobProfiles = _context.JobProfiles
                                                .Include(jp => jp.Company)
                                                .Where(jp => 
                                                //jp.StartingDate <= DateTime.Now 
                                                ///&& jp.EndingDate >= DateTime.Now 
                                                //&&
                                                jp.CompanyId == companyId)
                                                .ToList();
            
                return View(jobProfiles);
            }

            return Redirect("/");
        }
        
        public IActionResult Proposal(int id)
        {
            if(HttpContext.Session.GetString("Id") != null && HttpContext.Session.GetString("Type") == "Company")
            {
                int companyId = int.Parse(HttpContext.Session.GetString("Id"));

                List<JobProfilePerson> jobProfile = _context.JobProfilePerson
                                            .Include(jpp => jpp.JobProfiles)
                                            .Include(jpp => jpp.Persons)
                                            .Include(jpp => jpp.Persons.User)
                                            .Where(jp => jp.JobProfilesId == id 
                                            && jp.JobProfiles.CompanyId == companyId)
                                            .ToList();

                ViewBag.quantity = jobProfile.Count();
            
                return View(jobProfile);
            }

            return Redirect("/");
        }
    }
}
