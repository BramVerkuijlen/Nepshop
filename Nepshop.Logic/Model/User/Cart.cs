using Nepshop.Logic.Interface;
using Nepshop.Logic.Model.DTO;
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

        public void AddProduct(ProductDTO product)
        {
            CartDal.AddProduct(product);
        }

        public void RemoveProduct(ProductDTO product)
        {
            CartDal.RemoveProduct(product);
        }

        public List<ProductDTO> GetAllProducts()
        {
            return CartDal.GetAllProducts();
        }

        public int CountProducts()
        {
            return CartDal.GetAllProducts().Count();
        }

        public int TotalPrice()
        {
            int total = 0;

            foreach (ProductDTO product in GetAllProducts())
            {
                total = total + product.Price;
            }
            return total;
        }

    }
}
