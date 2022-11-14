using Microsoft.AspNetCore.Mvc;
using Nepshop.Logic;
using Nepshop.Logic.DTO;
using Nepshop.Logic.Interface;
using NepshopApp.Models;
using System.Threading.Tasks;

namespace NepshopApp.Controllers
{
    public class UserController : Controller
    {
        readonly IUserMaintainerDal UserMaintainerDal;
        readonly IUserDal UserDal;
        public UserController(IUserMaintainerDal userMaintainerDal, IUserDal userDal)
        {
            UserMaintainerDal = userMaintainerDal;
            UserDal = userDal;
        }

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

        public async Task<IActionResult> RemoveAsync(UserViewModel userViewModel)
        {
            UserMaintainer userMaintainer = new UserMaintainer(UserMaintainerDal);

            UserDTO userDTO = new UserDTO();

            userMaintainer.RemoveUser(userViewModel.Id);
            TempData["Message"] = "User Deleted";
            
            
            return RedirectToAction("Profile");
        }

        
        public async Task<IActionResult> UpdateAsync(UserViewModel userViewModel)
        {
            User user = new User(UserDal);
            UserMaintainer userMaintainer = new UserMaintainer(UserMaintainerDal);

            UserDTO userDTO = new UserDTO();
            userDTO = userMaintainer.GetUserOnUsernameAndPassword(userViewModel.Username, userViewModel.Password);

            if (userDTO.Username == null || userDTO.Username == userViewModel.Username)
            {
                user.UpdateUser(userViewModel.Id, userViewModel.Username, userViewModel.Password, userViewModel.Firstname, userViewModel.Lastname, userViewModel.Email, userViewModel.Points);
                TempData["Message"] = "User Updated";
            }

            else
            {
                TempData["Message"] = "Username is already taken";
            }
            return RedirectToAction("Profile");
        }
    }
}
