using Microsoft.AspNetCore.Mvc;

namespace MVC_project3.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
