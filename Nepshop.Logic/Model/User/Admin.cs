using Nepshop.Logic.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nepshop.Logic
{
    public class Admin
    {
        public string Username { get; private set; }
        public string Password { get; private set; }

        IUserDal UserDal;
        public Admin(IUserDal userDal)
        {
            UserDal = userDal;
        }
    }
}
