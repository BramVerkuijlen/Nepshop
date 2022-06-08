using Nepshop.Logic.Interface;
using Nepshop.Logic.Model.DTO;
using Nepshop.Logic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Nepshop.Logic.Model
{
    internal class Cart
    {
        readonly ICartDAL CartDAL;
        public Cart(ICartDAL cartDAL)
        {
            CartDAL = cartDAL;
        }

        public void AddProduct(string userId, string productId)
        {
            CartDAL.AddProductToCart(userId, productId);
        }

        public void RemoveProduct(string userId, string productId)
        {
            CartDAL.RemoveProductFromCart(userId, productId);
        }

        public List<ProductDTO> GetAllProductsInCart(string userId, string productId)
        {
           return CartDAL.GetProductsInCart(userId, productId);
        }
    }
}
