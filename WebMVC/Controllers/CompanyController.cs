using Microsoft.AspNetCore.Mvc;

namespace WebMVC.Controllers
{
    public class CompanyController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult AddJobProfile()
        {
            return View();
        }
    }
}
