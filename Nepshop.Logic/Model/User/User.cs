using Nepshop.Logic.DTO;
using Nepshop.Logic.Interface;
using Nepshop.Logic.Model.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nepshop.Logic
{
    public class User
    {
        public int Id { get; set; }
        public string Username { get; private set; }
        public string Password { get; private set; }
        public string Firstname { get; private set; }
        public string Lastname { get; private set; }
        public string Email { get; private set; }
        public int Points { get; private set; }

        readonly IUserDal UserDal;

        public User(IUserDal userDal)
        {
            UserDal = userDal;
        }

        public void UpdateUser(int id, string username, string password, string firstname, string lastname, string email, int points)
        {

            UserDTO userDTO = new UserDTO();

            userDTO.Id = id;
            userDTO.Username = username;
            userDTO.Password = password; 
            userDTO.Firstname = firstname;
            userDTO.Lastname = lastname;
            userDTO.Email = email;
            userDTO.Points = points;

            UserDal.UpdateUser(userDTO);
        }
    }
}
