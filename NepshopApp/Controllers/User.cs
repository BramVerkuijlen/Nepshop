using Microsoft.AspNetCore.Mvc;

namespace NepshopApp.Controllers
{
    public class User : Controller
    {
        public IActionResult Cart()
        {
            return View();
        }
        public IActionResult Favorite()
        {
            return View();
        }


    }
}
