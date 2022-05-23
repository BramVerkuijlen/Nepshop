using Microsoft.AspNetCore.Mvc;
using Nepshop.Logic.DTO;
using NepshopApp.Models;
using Nepshop.Logic;

namespace NepshopApp.Controllers
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

        /*public async Task<IActionResult> LoginAsync(UserViewModel userViewModel)
        {
            UserDTO user = GetUserOnUsernameAndPassword(userViewModel.Username, userViewModel.Password);

        }
        */
    }
}
