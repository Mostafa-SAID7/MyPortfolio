using Microsoft.AspNetCore.Mvc;

namespace PortfolioMVC.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
