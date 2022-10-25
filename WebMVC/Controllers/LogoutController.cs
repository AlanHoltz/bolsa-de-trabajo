using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;

namespace WebMVC.Controllers
{
    public class LogoutController : Controller
    {
        public IActionResult Index()
        {
            HttpContext.Session.Clear();
            return Redirect("/login");
        }
    }
}
