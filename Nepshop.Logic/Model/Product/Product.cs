using Nepshop.Logic.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nepshop.Logic
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; private set; }
        public string Description { get; private set; }
        public string Category { get; private set; }
        public string Picture { get; private set; }
        public int Price { get; private set; }
        public int Amount { get; private set; }
        public bool Available { get; private set; }

        readonly IProductDal ProductDal;

        public Product(IProductDal productDal)
        {
            IProductDal ProductDal = productDal;
        }

        public void UpdateProduct(Product product)
        {
            ProductDal.UpdateProduct(product);
        }

    }
}
