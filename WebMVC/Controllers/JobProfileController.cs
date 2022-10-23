using BolsaTrabajo.Models.Db;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebMVC.Controllers
{
    public class JobProfileController : Controller
    {
        private readonly BolsaTrabajoContext _context;

        public JobProfileController(BolsaTrabajoContext context)
        {
            _context = context;

        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Add()
        {

            if(HttpContext.Session.GetString("Id") != null && HttpContext.Session.GetString("Type") == "Company")
            {
                return View();
            } else
            {
                return Redirect("/");
            }
        }

        [HttpPost]
        public IActionResult Add(Models.JobProfile jobProfile)
        {
            jobProfile.CompanyId = int.Parse(HttpContext.Session.GetString("Id"));

            _context.JobProfiles.Add(jobProfile);
            _context.SaveChanges();

            return Redirect("/Company");
        }
    }
}
