using Nepshop.Logic.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nepshop.Logic
{
    public class Cart
    {
        readonly ICartDal CartDal;

        private List<Product> Products = new List<Product>();
        public IEnumerable<Product> products
        {
            get { return Products; }
        }
        public Cart(ICartDal cartDal)
        {
            CartDal = cartDal;
        }

        public void AddProduct(Product product)
        {
            CartDal.AddProduct();
        }

        public void RemoveProduct(Product product)
        {
            CartDal.RemoveProduct();
        }
    }
}
