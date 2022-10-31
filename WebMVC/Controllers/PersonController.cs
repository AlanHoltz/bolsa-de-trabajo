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
    public class PersonController : Controller
    {
        private readonly BolsaTrabajoContext _context;
        public PersonController(BolsaTrabajoContext context)
        {            
            _context = context;
        }
        public IActionResult Index()
        {
            if (HttpContext.Session.GetString("Id") == null) return Redirect("/login");
            if (HttpContext.Session.GetString("Type") == "Company") return Redirect("/Company");

            return Redirect("/Person/Jobs");

        }
        public IActionResult Jobs(int id)
        {

            if (HttpContext.Session.GetString("Id") == null)
            {
                return Redirect("/login");
            }

            if (id != 0)
            {
                JobProfile jobProfile = _context.JobProfiles
                .Include(jp => jp.Company)
                .Where(jp => jp.Id == id).FirstOrDefault();

                int personId = int.Parse(HttpContext.Session.GetString("Id"));

                JobProfilePerson jobProfilePerson = _context.JobProfilePerson
                .Where(jpp =>
                jpp.PersonsId == personId
                && jpp.JobProfilesId == id
                ).FirstOrDefault();


                ViewData["PersonApplied"] = jobProfilePerson != null;

                return View("/Views/Person/Job.cshtml", jobProfile);
            }

            List<JobProfilePerson> jobsPersonApplied = _context.JobProfilePerson
            .Where(jpp => jpp.PersonsId == int.Parse(HttpContext.Session.GetString("Id")))
            .ToList();

            List<int> jobsIds = new List<int>();

            foreach (JobProfilePerson jpp in jobsPersonApplied) jobsIds.Add(jpp.JobProfilesId);

            List<JobProfile> jobProfiles = _context.JobProfiles
                .Include(jp => jp.Company)
                .Where(
                jp => jp.StartingDate <= DateTime.Now
                && jp.EndingDate >= DateTime.Now
                && jp.Status == true
                && !jobsIds.Contains(jp.Id)
                )
                .OrderByDescending(jp => jp.CreatedAt)
                .ToList();



            return View(jobProfiles); 
        }

        public IActionResult Applications()
        {
            if (HttpContext.Session.GetString("Id") == null)
            {
                return Redirect("/login");
            }

            int personId = int.Parse(HttpContext.Session.GetString("Id"));

            List<JobProfilePerson> jpPerson = _context.JobProfilePerson
                .Include(jp => jp.JobProfiles)
                .Include(jp => jp.JobProfiles.Company)
                .Where(
                jp => jp.PersonsId == personId 
                && jp.JobProfiles.StartingDate <= DateTime.Now
                && jp.JobProfiles.EndingDate >= DateTime.Now).ToList();
            
            return View(jpPerson);
        }

        public IActionResult AddApplication(int id)
        {

            int idPerson = int.Parse(HttpContext.Session.GetString("Id"));

            JobProfilePerson jpPerson = new JobProfilePerson();

            jpPerson.PersonsId = idPerson;
            jpPerson.JobProfilesId = id;
            jpPerson.Status = "Pending";

            JobProfile jp = _context.JobProfiles.Find(id);
            
            //jp.Capacity--;
            //Por el momento se supone que la capacidad aumenta o disminuye
            //acorde a si la empresa acepta o rechaza la postulación

            _context.Update(jp);
            _context.SaveChanges();

            _context.JobProfilePerson.Add(jpPerson);
            _context.SaveChanges();

            return Redirect("/");

        }

        public IActionResult RemoveApplication(int id)
        {
            JobProfilePerson jpp = _context.JobProfilePerson.Where(jpp => 
            jpp.JobProfilesId == id
            && jpp.PersonsId == int.Parse(HttpContext.Session.GetString("Id"))
            ).FirstOrDefault();
            _context.Remove(jpp);
            _context.SaveChanges();

            return Redirect("/Person/Applications");
        }

    }
}
