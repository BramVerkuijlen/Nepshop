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
        void AddUser(User user)
        {
            UserMaintainerDal.AddUser(user);
        }

        void RemoveUser(User user)
        {
            UserMaintainerDal.RemoveUser(user);
        }

        List<UserDTO> GetAllUsers()
        {
            return UserMaintainerDal.GetAllUsers();
        }
    }
}
