using Nepshop.Logic.Interface;
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

        public void AddProduct()
        {
            CartDAL.AddProductToCart();
        }

        public void RemoveProduct()
        {
            CartDAL?.RemoveProductFromCart();
        }
    }
}
