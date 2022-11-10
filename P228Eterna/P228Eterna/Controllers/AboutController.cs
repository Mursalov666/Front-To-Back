using Microsoft.AspNetCore.Mvc;

namespace P228Eterna.Controllers
{
    public class AboutController : Controller
    {
        public IActionResult Index()
        {
            ViewBag.Active = 2;

            return View();
        }
    }
}
