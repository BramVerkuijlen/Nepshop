using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nepshop.Logic
{
    public class Customer : IUser
    {
        public string Username { get; private set; }
        public string Password { get; private set; }
        public string Firstname { get; private set; }
        public string Lastname { get; private set; }
        public string Address { get; private set; }
        public string Email { get; private set; }

        public Customer(string username, string password)
        {
            Username = username;
            Password = password;
            Favorite favorite = new Favorite();
            Cart cart = new Cart();
        }

        public void UpdateUser()
        {
            throw new NotImplementedException();
        }
    }
}
