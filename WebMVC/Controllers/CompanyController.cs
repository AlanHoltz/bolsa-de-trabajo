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
            if (HttpContext.Session.GetString("Authorized") == "Pending") return Redirect("/Company/Profile");
            if (HttpContext.Session.GetString("IsAdmin") == "True")
            {
                List<Company> company = _context.Companies
                                        .Include(company => company.City)
                                        .Include(company => company.User)
                                        .Where(company => company.User.Status == true)
                                        .ToList();
                
                return View(company);
            }
            if (HttpContext.Session.GetString("Type") == "Person") return Redirect("/Person");

            return Redirect("/Company/Proposals");
        }

        public IActionResult Proposals(string Position, DateTime? From, DateTime? Until, string Type)
        {
            if (HttpContext.Session.GetString("Authorized") == "Pending") return Redirect("/Company/Profile");
            
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
            if (HttpContext.Session.GetString("Authorized") == "Pending") return Redirect("/Company/Profile");
            if (HttpContext.Session.GetString("Id") != null && HttpContext.Session.GetString("Type") == "Company")
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
            if (HttpContext.Session.GetString("IsAdmin") == "True")
            {
                ViewBag.cities = _context.Cities.ToList();
                return View();
            }

            return Redirect("/");
        }

        [HttpPost]
        public IActionResult Signup(Models.Company company)
        {
            if (HttpContext.Session.GetString("IsAdmin") == "True")
            {
                company.Status = "Pending";

                Models.User user = new User();
                user.Mail = company.Mail;
                user.Password = company.Password;
                user.SignupDate = DateTime.Now;
                user.Type = "Company";
                user.Status = true;

                _context.Users.Add(user);
                _context.SaveChanges();

                company.Id = user.Id;
                _context.Companies.Add(company);
                _context.SaveChanges();

                return Redirect("/Company");
            }

            return Redirect("/");
        }

        public IActionResult Edit(int id)
        {
            if (HttpContext.Session.GetString("Authorized") == "Pending") return Redirect("/Company/Profile");
            if (HttpContext.Session.GetString("Type") == "Company" || HttpContext.Session.GetString("IsAdmin") == "True")
            {
                Models.Company company = _context.Companies.Include(company => company.User).Where(company => company.Id == id).FirstOrDefault();

                if (company != null)
                {
                    company.Mail = company.User.Mail;
                    company.Password = company.User.Password;
                    ViewBag.cities = _context.Cities.ToList();

                    return View(company);
                }

                return Redirect("/Company");
            }
            else
            {
                return Redirect("/");
            }
        }

        [HttpPost]
        public IActionResult Edit(Models.Company company)
        {
            if (HttpContext.Session.GetString("Type") == "Company")
            {
                Models.User user = _context.Users.Where(user => user.Id == company.Id).FirstOrDefault();
                user.Password = company.Password;

                _context.Users.Update(user);
                _context.SaveChanges();

                _context.Companies.Update(company);
                _context.SaveChanges();

                return Redirect("/Company/Profile");
            }

            return Redirect("/");
        }

        public IActionResult Delete(int id)
        {
            if (HttpContext.Session.GetString("Authorized") == "Pending") return Redirect("/Company/Profile");
            if (HttpContext.Session.GetString("IsAdmin") == "True")
            {
                Models.User company = _context.Users.Where(user => user.Id == id).FirstOrDefault();

                if (company != null)
                {
                    company.Status = false;

                    _context.Update(company);

                    _context.SaveChanges();
                }

                return Redirect("/Company");
            }

            return Redirect("/");
        }

        public IActionResult Authorize(int id)
        {
            if (HttpContext.Session.GetString("IsAdmin") == "True")
            {
                Models.Company company = _context.Companies.Where(company => company.Id == id).FirstOrDefault();

                if (company != null)
                {
                    company.Status = "Authorized";

                    _context.Update(company);

                    _context.SaveChanges();
                }

                return Redirect("/Company");
            }

            return Redirect("/");
        }

        public IActionResult Profile()
        {
            if (HttpContext.Session.GetString("Type") == "Company")
            {
                int id = int.Parse(HttpContext.Session.GetString("Id"));
                Models.Company company = _context.Companies.Include(c => c.User).Include(c => c.City).Where(company => company.Id == id).FirstOrDefault();

                return View(company);
            }

            return Redirect("/");
        }
    }
}
