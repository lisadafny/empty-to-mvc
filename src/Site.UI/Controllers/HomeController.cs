using Microsoft.AspNetCore.Mvc;

namespace Site.UI.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
