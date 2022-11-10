using Microsoft.AspNetCore.Mvc;

namespace P228Eterna.Controllers
{
    public class PortfolioController : Controller
    {
        public IActionResult Index()
        {
            ViewBag.Active = 4;

            return View();
        }

        public IActionResult Detail()
        {
            return View();
        }
    }
}
