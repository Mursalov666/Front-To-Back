using Microsoft.AspNetCore.Mvc;

namespace P228Eterna.Controllers
{
    public class ContactController : Controller
    {
        public IActionResult Index()
        {
            ViewBag.Active = 8;

            return View();
        }
    }
}
