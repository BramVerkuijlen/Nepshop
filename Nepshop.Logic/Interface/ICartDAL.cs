using Nepshop.Logic.Model.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nepshop.Logic.Interface
{
    public interface ICartDAL
    {
        void AddProductToCart(string userId, string productId);
        void RemoveProductFromCart(string userId, string productId);
        List<ProductDTO> GetProductsInCart(string userId, string productId);

    }
}
