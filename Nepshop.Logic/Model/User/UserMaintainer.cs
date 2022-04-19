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
        void AddUser()
        {
            UserMaintainerDal.AddUser();
        }

        void RemoveUser()
        {
            UserMaintainerDal.RemoveUser();
        }

        void GetAllUsers()
        {
            UserMaintainerDal.GetAllUsers();
        }
    }
}
