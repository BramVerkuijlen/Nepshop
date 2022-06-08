using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

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

        public IActionResult Profile()
        {
            return View();
        }

        public async Task<IActionResult> UpdateAsync()
        {
            return RedirectToAction("Index");
        }
    }
}
