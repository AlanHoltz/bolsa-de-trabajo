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

        /*public IActionResult Add(int id)
        {
           
            int idPerson = int.Parse(HttpContext.Session.GetString("Id"));

            JobProfilePerson jpPerson = new JobProfilePerson();

            jpPerson.PersonsId = idPerson;
            jpPerson.JobProfilesId = id;
            jpPerson.Status = "Pending";

            JobProfile jp = _context.JobProfiles.Find(id);
            jp.Capacity--;

            _context.Update(jp);
            _context.SaveChanges();

            _context.JobProfilePerson.Add(jpPerson);
            _context.SaveChanges();

            return Redirect("/");
            

        }*/

        public IActionResult Cancel(int id)
        {
            JobProfilePerson jpp = _context.JobProfilePerson.Where(jpp => jpp.Id == id).FirstOrDefault();
            _context.Remove(jpp);
            _context.SaveChanges();

            return Redirect("/Person/Applications");
        }
    }
}
