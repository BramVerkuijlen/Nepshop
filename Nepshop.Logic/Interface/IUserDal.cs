using Nepshop.Logic.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nepshop.Logic.Interface
{
    public interface IUserDal
    {
        void UpdateUser(UserDTO userDTO);

        void AddProductToCart();
        void RemoveProductFromCart();

        void AddProductToFavorites();
        void RemoveProductFromFavorites();


    }
}
