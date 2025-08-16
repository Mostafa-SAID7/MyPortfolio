using Microsoft.AspNetCore.Mvc;

namespace MyPortfolio.Controllers
{
    public class BlogController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
