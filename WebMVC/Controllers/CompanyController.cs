using BolsaTrabajo.Models.Db;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Diagnostics;
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
            if (HttpContext.Session.GetString("Type") == "Person") return Redirect("/Person");

            return Redirect("/Company/Proposals");
        }

        public IActionResult Proposals(string Position, DateTime? From, DateTime? Until, string Type)
        {

            if (HttpContext.Session.GetString("Id") != null && HttpContext.Session.GetString("Type") == "Company")
            {
                int companyId = int.Parse(HttpContext.Session.GetString("Id"));

                IQueryable<JobProfile> jobProfiles = _context.JobProfiles
                                                .Include(jp => jp.Company)
                                                .Where(jp =>
                                                 jp.CompanyId == companyId);
                
                jobProfiles = Position != null ? jobProfiles.Where(jp => jp.Position.Contains(Position)) : jobProfiles;
                jobProfiles = From != null ? jobProfiles.Where(jp => jp.StartingDate >= From) : jobProfiles;
                jobProfiles = Until != null ? jobProfiles.Where(jp => jp.EndingDate <= Until) : jobProfiles;
                jobProfiles = Type != null && (Type == "relationship" || Type == "internship") ? jobProfiles.Where(jp => jp.Type.ToLower() == Type) : jobProfiles;

                ViewData["Position"] = Position;
                ViewData["From"] = From;
                ViewData["Until"] = Until;
                ViewData["Type"] = Type;

                return View(jobProfiles.ToList());
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
