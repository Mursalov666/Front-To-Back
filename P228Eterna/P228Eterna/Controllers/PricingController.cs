using Microsoft.AspNetCore.Mvc;

namespace P228Eterna.Controllers
{
    public class PricingController : Controller
    {
        public IActionResult Index()
        {
            ViewBag.Active = 6;

            return View();
        }
    }
}
