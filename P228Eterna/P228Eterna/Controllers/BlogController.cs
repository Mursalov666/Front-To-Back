using Microsoft.AspNetCore.Mvc;

namespace P228Eterna.Controllers
{
    public class BlogController : Controller
    {
        public IActionResult Index()
        {
            ViewBag.Active = 7;

            return View();
        }
    }
}
