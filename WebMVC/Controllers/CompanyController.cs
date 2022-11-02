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
        private readonly IReportService _reportService;

        public CompanyController(BolsaTrabajoContext context, IReportService reportService)
        {
            _context = context;
            _reportService = reportService;
        }

        public IActionResult Index()
        {
            if (HttpContext.Session.GetString("Id") == null) return Redirect("/login");
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

        public IActionResult ProposalsReport()
        {

            if (HttpContext.Session.GetString("Id") != null && HttpContext.Session.GetString("Type") == "Company")
            {

                int companyId = int.Parse(HttpContext.Session.GetString("Id"));

                List<JobProfile> jobProfiles = _context.JobProfiles
                                                .Include(jp => jp.Company)
                                                .Where(jp =>
                                                 jp.CompanyId == companyId)
                                                .ToList();

                var pdfFile = _reportService.GeneratePdfReport(jobProfiles);
                
                return File(pdfFile,
                "application/octet-stream", "Trabajos.pdf");

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
