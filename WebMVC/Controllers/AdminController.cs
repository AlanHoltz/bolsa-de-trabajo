using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebMVC.Controllers
{
    public class AdminController : Controller
    {
        public IActionResult Index()
        {
            if(HttpContext.Session.GetString("Id") != null)
            {
                return View();
            }

            return Redirect("/");
        }
    }
}
