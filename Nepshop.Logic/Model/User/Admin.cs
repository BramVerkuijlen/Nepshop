using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nepshop.Logic
{
    public class Admin : IUser
    {
        public string Username { get; private set; }
        public string Password { get; private set; }

        public Admin(string username, string password)
        {
            Username = username;
            Password = password;
        }

        void IUser.UpdateUser()
        {
            throw new NotImplementedException();
        }
    }
}
