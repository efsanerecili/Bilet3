using Microsoft.AspNetCore.Mvc;

namespace MVC_project3.Areas.Admin.Controllers
{
    
    public class DashboardController : Controller
    {
        [Area("Admin")]
       
        public IActionResult Index()
        {
            return View();
        }
    }
}
