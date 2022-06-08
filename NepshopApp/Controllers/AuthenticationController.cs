using Microsoft.AspNetCore.Mvc;
using Nepshop.Logic.DTO;
using NepshopApp.Models;
using Nepshop.Logic;
using Nepshop.Logic.Interface;
using System.Security.Claims;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authentication;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace NepshopApp.Controllers
{
    public class AuthenticationController : Controller
    {
        readonly IUserMaintainerDal UserMaintainerDal;
        public AuthenticationController(IUserMaintainerDal userMaintainerDal)
        {
            UserMaintainerDal = userMaintainerDal;
        }

        public IActionResult Login()
        {
            return View();
        }

        public IActionResult Registration()
        {
            return View();
        }

        
        public async Task<IActionResult> AuthAsync(UserViewModel userViewModel)
        {
            UserMaintainer userMaintainer = new UserMaintainer(UserMaintainerDal);

            UserDTO user = userMaintainer.GetUserOnUsernameAndPassword(userViewModel.Username, userViewModel.Password);

            if (user.Username == null)
            {
                TempData["message"] = "Wrong username or Password";
                return Redirect("Login");
            }

            else
            {
                List<Claim> claims = new()
                {
                    new Claim(ClaimTypes.NameIdentifier, user.Id.ToString()),
                    new Claim(ClaimTypes.Name, user.Username),

                };

                var identity = new ClaimsIdentity(claims, CookieAuthenticationDefaults.AuthenticationScheme);
                var claimsPrincipal = new ClaimsPrincipal(identity);
                await HttpContext.SignInAsync(claimsPrincipal);
            }

            return RedirectToAction("Index");
        }

        public async Task<IActionResult> RegisterAsync (UserViewModel userViewModel)
        {
            UserMaintainer userMaintainer = new UserMaintainer(UserMaintainerDal);

            if (userMaintainer.AddUser(userViewModel.Username, userViewModel.Password, userViewModel.Firstname, userViewModel.Lastname, userViewModel.Email, userViewModel.Points))
            {
                return RedirectToAction("Login");
            }

            else
            {
                TempData["message"] = "User Already exists";
                return Redirect("Registration");
            }
        }

    }
       
}

