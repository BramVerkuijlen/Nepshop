using Nepshop.Logic.Interface;
using System;
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

        readonly IUserDal UserDal;

        public Customer(IUserDal userDal, ICartDal cartDal, IFavoriteDal favoriteDal)
        {
            UserDal = userDal;

            Favorite = new Favorite(favoriteDal);
            Cart = new Cart(cartDal);
        }
    }
}
