﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nepshop.Logic
{
    public class Customer
    {
        public string Username { get; private set; }
        public string Password { get; private set; }
        public string Firstname { get; private set; }
        public string Lastname { get; private set; }
        public string Address { get; private set; }
        public string Email { get; private set; }
        Favorite Favorite { get;}
        Cart Cart { get; }

        public Customer()
        {
            Favorite = new Favorite();
            Cart = new Cart();
        }
    }
}
