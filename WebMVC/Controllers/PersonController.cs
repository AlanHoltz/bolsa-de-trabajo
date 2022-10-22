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
    public class PersonController : Controller
    {
        private readonly BolsaTrabajoContext _context;
        public PersonController(BolsaTrabajoContext context)
        {            
            _context = context;
        }
        public IActionResult Index()
        {
            if (HttpContext.Session.GetInt32("Id") == null)
            {
                return Redirect("/login");
            }

            return View();
        }

        public IActionResult Applications()
        {
            if (HttpContext.Session.GetInt32("Id") == null)
            {
                return Redirect("/login");
            }

            int personId = (int)HttpContext.Session.GetInt32("Id");

            List<JobProfilePerson> jpPerson = _context.JobProfilePerson.Include(jp => jp.JobProfiles).Include(jp => jp.JobProfiles.Company).Where(jp => jp.PersonsId == personId && jp.JobProfiles.StartingDate <= DateTime.Now && jp.JobProfiles.EndingDate >= DateTime.Now).ToList();
            
            return View(jpPerson);
        }
    }
}
