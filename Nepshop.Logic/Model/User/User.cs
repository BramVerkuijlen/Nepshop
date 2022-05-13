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
        Favorite Favorite { get;}
        Cart Cart { get; }

        readonly IUserDal UserDal;

        public User(IUserDal userDal, ICartDal cartDal, IFavoriteDal favoriteDal)
        {
            UserDal = userDal;

            Favorite = new Favorite(favoriteDal);
            Cart = new Cart(cartDal);
        }

        public void UpdateUser(User user)
        {
            UserDTO userDTO = new UserDTO();

            userDTO.Username = user.Username;   
            userDTO.Password = user.Password;           
            userDTO.Firstname = user.Firstname;
            userDTO.Lastname = user.Lastname;
            userDTO.Email = user.Email;
            userDTO.Points = user.Points;

            UserDal.UpdateUser(userDTO);
        }

        public void AddProductToCart()
        {
            Cart.AddProduct(ProductDTO );
        }
    }
}
