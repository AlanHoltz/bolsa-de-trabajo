using BolsaTrabajo.Models.Db;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using WebMVC.Models;

namespace WebMVC.Controllers
{
    public class PersonController : Controller
    {
        private readonly BolsaTrabajoContext _context;
        private readonly IReportService _reportService;
        private readonly IHostEnvironment _hostingEnvironment;

        public PersonController(BolsaTrabajoContext context, IHostEnvironment environment, IReportService reportService)
        {            
            _context = context;
            _reportService = reportService;
            _hostingEnvironment = environment;
        }
        public IActionResult Index()
        {
            if (HttpContext.Session.GetString("Type") != "Person") return Redirect("/");
            if (HttpContext.Session.GetString("IsAdmin") != "True") return Redirect("/Person/Jobs");

            List<Person> persons = _context.Persons.Include(person => person.User).Where(person => person.User.Status == true
                                                                                        && person.IsAdmin == false).ToList();
            
            return View(persons);
        }
        public IActionResult Jobs(int id)
        {

            if (HttpContext.Session.GetString("Type") != "Person") return Redirect("/");

            if (id != 0)
            {
                JobProfile jobProfile = _context.JobProfiles
                .Include(jp => jp.Company)
                .Where(
                    jp => jp.Id == id 
                ).FirstOrDefault();

                int personId = int.Parse(HttpContext.Session.GetString("Id"));

                JobProfilePerson jobProfilePerson = _context.JobProfilePerson
                .Where(jpp =>
                jpp.PersonsId == personId
                && jpp.JobProfilesId == id
                ).FirstOrDefault();


                ViewData["PersonApplied"] = jobProfilePerson != null;
                ViewData["ApplicationStatus"] = jobProfilePerson != null ? jobProfilePerson.Status : "";

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
                && !jobsIds.Contains(jp.Id)
                )
                .OrderByDescending(jp => jp.CreatedAt)
                .ToList();



            return View(jobProfiles); 
        }

        public IActionResult Applications()
        {
            if (HttpContext.Session.GetString("Type") != "Person") return Redirect("/");

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

        public IActionResult ApplicationsReport()
        {
            if (HttpContext.Session.GetString("Type") != "Person") return Redirect("/");

            int personId = int.Parse(HttpContext.Session.GetString("Id"));

            List<JobProfilePerson> jpPerson = _context.JobProfilePerson
                .Include(jp => jp.JobProfiles)
                .Include(jp => jp.JobProfiles.Company)
                .Where(
                jp => jp.PersonsId == personId
                && jp.JobProfiles.StartingDate <= DateTime.Now
                && jp.JobProfiles.EndingDate >= DateTime.Now).ToList();


            var pdfFile = _reportService.GeneratePdfReport(jpPerson);

            return File(pdfFile,
            "application/octet-stream", "Aplicaciones.pdf");
        }

        public IActionResult AddApplication(int id)
        {

            if (HttpContext.Session.GetString("Type") != "Person") return Redirect("/");

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
            if (HttpContext.Session.GetString("Type") != "Person") return Redirect("/");

            JobProfilePerson jpp = _context.JobProfilePerson.Where(jpp => 
            jpp.JobProfilesId == id
            && jpp.PersonsId == int.Parse(HttpContext.Session.GetString("Id"))
            ).FirstOrDefault();
            
            if (jpp != null)
            {
                _context.Remove(jpp);
                _context.SaveChanges();
            }


            return Redirect("/Person/Applications");
        }

        public IActionResult Signup()
        {


            if (HttpContext.Session.GetString("IsAdmin") == "True") return View();
            

            return Redirect("/");
        }

        [HttpPost]
        public IActionResult Signup(Models.Person person)
        {

            if (HttpContext.Session.GetString("IsAdmin") == "True")
            {
                person.IsAdmin = false;

                Models.User user = new User();
                user.Mail = person.Mail;
                user.Password = person.Password;
                user.SignupDate = DateTime.Now;
                user.Type = "Person";
                user.Status = true;

                _context.Users.Add(user);
                _context.SaveChanges();

                person.Id = user.Id;
                _context.Persons.Add(person);
                _context.SaveChanges();

                return Redirect("/Person");
            }

            return Redirect("/");
        }

        public IActionResult Edit(int id)
        {

            if (HttpContext.Session.GetString("Type") == "Person")
            {
                Models.Person person = _context.Persons.Include(person => person.User).Where(person => person.Id == id).FirstOrDefault();

                if (person != null)
                {
                    person.Mail = person.User.Mail;
                    person.Password = person.User.Password;

                    return View(person);
                }

                return Redirect("/Person");
            }
            else
            {
                return Redirect("/");
            }
        }

        [HttpPost]
        public IActionResult Edit(Models.Person person)
        {

            if (HttpContext.Session.GetString("Type") == "Person")
            {

                Models.User user = _context.Users.Where(user => user.Id == person.Id).FirstOrDefault();
                user.Password = person.Password;

                _context.Users.Update(user);
                _context.SaveChanges();

                _context.Persons.Update(person);
                _context.SaveChanges();

                return Redirect("/Person/Profile");
            }

            return Redirect("/");
        }

        public IActionResult Delete(int id)
        {

            if (HttpContext.Session.GetString("IsAdmin") == "True")
            {
                Models.User person = _context.Users.Where(user => user.Id == id).FirstOrDefault();

                if (person != null)
                {
                    person.Status = false;

                    _context.Update(person);

                    _context.SaveChanges();
                }

                return Redirect("/Person");
            }

            return Redirect("/");
        }

        public IActionResult Profile()
        {

            if (HttpContext.Session.GetString("Type") == "Person")
            {
                int id = int.Parse(HttpContext.Session.GetString("Id"));
                Models.Person person = _context.Persons.Include(p => p.User).Where(user => user.Id == id).FirstOrDefault();

                return View(person);
            }

            return Redirect("/");
        }

        public IActionResult MyCV()
        {

            int id = int.Parse(HttpContext.Session.GetString("Id"));
            Models.Person person = _context.Persons.Include(p => p.User).Where(user => user.Id == id).FirstOrDefault();

            return View(person);
        }

        [HttpPost]
        public IActionResult MyCVAsync(IFormFile cv)
        {

            if (HttpContext.Session.GetString("Type") != "Person") return Redirect("/");

            if (cv != null && cv.Length <= 8000000)
            {


                

                var uniqueFileName = GetUniqueFileName(cv.FileName);
                var uploads = Path.Combine(_hostingEnvironment.ContentRootPath + "\\wwwroot\\", "CVs");
                var filePath = Path.Combine(uploads, uniqueFileName);
                cv.CopyTo(new FileStream(filePath, FileMode.Create));

                int userId = int.Parse(HttpContext.Session.GetString("Id"));

                Person myself = _context.Persons.Where(p => p.Id == userId).FirstOrDefault();

                myself.Cv = uniqueFileName;

                _context.Persons.Update(myself);
                _context.SaveChanges();


            }


            return Redirect("/Person/MyCV");
        }

        private string GetUniqueFileName(string fileName)
        {
            fileName = Path.GetFileName(fileName);
            return Path.GetFileNameWithoutExtension(fileName)
                      + "_"
                      + Guid.NewGuid().ToString().Substring(0, 4)
                      + Path.GetExtension(fileName);
        }
    }
}
