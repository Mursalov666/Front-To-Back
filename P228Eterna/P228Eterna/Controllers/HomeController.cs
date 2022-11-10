using Microsoft.AspNetCore.Mvc;

namespace P228Eterna.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            ViewBag.Active = 1;

            return View();
        }
    }
}
