using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nepshop.Logic
{
    public class Cart
    {
        private List<Product> Products = new List<Product>();

        public void AddProduct(Product product)
        {
            this.Products.Add(product);
        }

        public void RemoveProduct(Product product)
        {
            this.Products.Add(product);
        }
    }
}
