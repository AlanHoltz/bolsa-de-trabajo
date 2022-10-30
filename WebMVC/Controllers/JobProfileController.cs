using BolsaTrabajo.Models.Db;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

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

            return Redirect("/Company/Proposals");
        }

        public IActionResult Edit(int id)
        {

            if (HttpContext.Session.GetString("Id") != null && HttpContext.Session.GetString("Type") == "Company")
            {
                Models.JobProfile jp = _context.JobProfiles.Where(jp => jp.Id == id).FirstOrDefault();

                if (jp != null)
                {
                    return View(jp);
                }

                return Redirect("/Company/Proposals");
            }
            else
            {
                return Redirect("/");
            }
        }

        [HttpPost]
        public IActionResult Edit(Models.JobProfile jobProfile)
        {
            jobProfile.CompanyId = int.Parse(HttpContext.Session.GetString("Id"));

            jobProfile.Status = true;

            _context.JobProfiles.Update(jobProfile);
            _context.SaveChanges();

            return Redirect("/Company/Proposals");
        }

        public IActionResult Delete(int id)
        {
            if (HttpContext.Session.GetString("Id") != null && HttpContext.Session.GetString("Type") == "Company")
            {
                Models.JobProfile jp = _context.JobProfiles.Where(jp => jp.Id == id).FirstOrDefault();

                if (jp != null)
                {
                    jp.Status = false;

                    _context.JobProfiles.Update(jp);
                    _context.SaveChanges();
                }

                return Redirect("/Company/Proposals");
            } else
            {
                return Redirect("/");
            }
        }
    }
}
