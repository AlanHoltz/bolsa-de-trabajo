using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebMVC.Controllers
{
    public class AdminController : Controller
    {
        public IActionResult Index()
        {
            if(HttpContext.Session.GetString("Id") != null && HttpContext.Session.GetString("IsAdmin") == "True")
            {
                return Redirect("/Person/Jobs");
            }

            return Redirect("/");
        }
    }
}
