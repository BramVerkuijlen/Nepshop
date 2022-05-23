using Microsoft.AspNetCore.Mvc;

namespace Nepshop.View.Controllers
{
    public class Authentication : Controller
    {
        public IActionResult Login()
        {
            return View();
        }

        public IActionResult Registration()
        {
            return View();
        }
    }
}
