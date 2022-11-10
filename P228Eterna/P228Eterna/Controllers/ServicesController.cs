using Microsoft.AspNetCore.Mvc;

namespace P228Eterna.Controllers
{
    public class ServicesController : Controller
    {
        public IActionResult Index()
        {
            ViewBag.Active = 3;

            return View();
        }
    }
}
