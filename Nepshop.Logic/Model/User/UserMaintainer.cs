using Nepshop.Logic.DTO;
using Nepshop.Logic.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nepshop.Logic
{
    public class UserMaintainer
    {
        readonly IUserMaintainerDal UserMaintainerDal;
        public UserMaintainer(IUserMaintainerDal userMaintainerDal)
        {
          UserMaintainerDal = userMaintainerDal;
        }
        public bool AddUser(string username, string password, string firstname, string lastname, string email, int points)
        {
            UserDTO userDTO = new UserDTO();
            userDTO.Username = username;
            userDTO.Password = password;
            userDTO.Firstname = firstname;
            userDTO.Lastname = lastname;
            userDTO.Email = email;
            userDTO.Points = points;

            if (GetUserOnUsernameAndPassword(userDTO.Username, userDTO.Password).Username == null)
            {
                UserMaintainerDal.AddUser(userDTO);
                return true;
            }

            else return false;
        }

        public void RemoveUser(UserDTO user)
        {
            UserMaintainerDal.RemoveUser(user);
        }

        public List<UserDTO> GetAllUsers()
        {
            return UserMaintainerDal.GetAllUsers();
        }

        public UserDTO GetUserOnUsernameAndPassword(string username, string password)
        {
            return UserMaintainerDal.GetUserOnUsernameAndPassword(username, password);
        }
    }
}
