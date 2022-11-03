using BolsaTrabajo.Models.Db;
using Microsoft.AspNetCore.Mvc;
using System.Linq;
using Microsoft.AspNetCore.Http;


namespace WebMVC.Controllers
{
    public class LoginController : Controller
    {

        private readonly BolsaTrabajoContext _context;

        public LoginController(BolsaTrabajoContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {

            if (HttpContext.Session.GetString("Id") != null) return Redirect("/");

            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Index(Models.User user)
        {
            Models.User requestedUser = _context.Users.Where(u => u.Mail == user.Mail).FirstOrDefault();

            if (requestedUser == null || requestedUser.Password != user.Password)
            {
                ModelState.AddModelError(nameof(user.Mail), "Mail y/o Contraseña incorrectas");
                return View();
            }

            HttpContext.Session.SetString("Id", requestedUser.Id.ToString());
            HttpContext.Session.SetString("Mail", requestedUser.Mail);
            HttpContext.Session.SetString("Type", requestedUser.Type);

            if (requestedUser.Type == "Person")
            {
                Models.Person person = _context.Persons.Where(p => p.Id == requestedUser.Id).FirstOrDefault();
                HttpContext.Session.SetString("Name", person.Name);
                HttpContext.Session.SetString("Surname", person.Surname);
                HttpContext.Session.SetString("IsAdmin", person.IsAdmin.ToString());
            }
            else
            {
                Models.Company company = _context.Companies.Where(c => c.Id == requestedUser.Id).FirstOrDefault();
                HttpContext.Session.SetString("Name", company.Name);
                HttpContext.Session.SetString("Cuit", company.Cuit);
                HttpContext.Session.SetString("Authorized", company.Status);
            }

            return Redirect("/");

        }

    }
}
