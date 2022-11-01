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
            if (HttpContext.Session.GetString("Id") == null) return Redirect("/login");
            if (HttpContext.Session.GetString("IsAdmin") == "True") return View();
            if (HttpContext.Session.GetString("Type") == "Person") return Redirect("/Person");

            return Redirect("/Company/Proposals");
        }

        public IActionResult Proposals()
        {
            if(HttpContext.Session.GetString("Id") != null && HttpContext.Session.GetString("Type") == "Company")
            {
                int companyId = int.Parse(HttpContext.Session.GetString("Id"));

                List<JobProfile> jobProfiles = _context.JobProfiles
                                                .Include(jp => jp.Company)
                                                .Where(jp => 
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

        public IActionResult Signup()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Signup(Models.Company company)
        {
            if (HttpContext.Session.GetString("IsAdmin") == "true")
            {
                company.Status = "Pending";

                _context.Companies.Add(company);
                _context.SaveChanges();

                return Redirect("/");
            }

            return Redirect("/");
        }
    }
}
