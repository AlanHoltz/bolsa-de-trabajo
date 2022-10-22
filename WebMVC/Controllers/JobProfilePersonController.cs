using BolsaTrabajo.Models.Db;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Linq;
using WebMVC.Models;

namespace WebMVC.Controllers
{
    public class JobProfilePersonController : Controller
    {
        private readonly BolsaTrabajoContext _context;
        public JobProfilePersonController(BolsaTrabajoContext context)
        {
            _context = context;

        }

        public IActionResult Index(int idJobProfile)
        {
            return View();
        }

        public IActionResult MyJobProfile()
        {
            return View();
        }

        public IActionResult Add(int id)
        {
            try
            {
                int idPerson = (int)HttpContext.Session.GetInt32("Id");

                JobProfilePerson jpPerson = new JobProfilePerson();

                jpPerson.PersonsId = idPerson;
                jpPerson.JobProfilesId = id;
                jpPerson.Status = "Waiting";

                JobProfile jp = _context.JobProfiles.Find(id);
                jp.Capacity--;

                _context.Update(jp);
                _context.SaveChanges();

                _context.JobProfilePerson.Add(jpPerson);
                _context.SaveChanges();

                return Redirect("/");
            }
            catch (System.Exception ex)
            {
                throw;
            }
        }

        public IActionResult Cancel(int id)
        {
            JobProfilePerson jpp = _context.JobProfilePerson.Where(jpp => jpp.Id == id).FirstOrDefault();
            jpp.Status = "Canceled";
            _context.SaveChanges();

            return Redirect("/Person/Applications");
        }
    }
}
