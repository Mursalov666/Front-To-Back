using Microsoft.AspNetCore.Mvc;

namespace P228Eterna.Controllers
{
    public class TeamController : Controller
    {
        public IActionResult Index()
        {
            ViewBag.Active = 5;

            return View();
        }
    }
}
