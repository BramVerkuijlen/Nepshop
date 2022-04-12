using Nepshop.Logic.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nepshop.Logic
{
    public class ProductMaintainer
    {
        private IProductMaintainerDal ProductMaintainerDal;

        public ProductMaintainer(IProductMaintainerDal productMaintainerDal)
        {
            ProductMaintainerDal = productMaintainerDal;
        }

        void AddProduct(Product product)
        {
            ProductMaintainerDal.AddProduct(product);
        }

        void RemoveProduct(Product product)
        {
            ProductMaintainerDal.RemoveProduct(product);
        }

        void GetAllProducts()
        {
            ProductMaintainerDal.GetAllProducts();
        }
    }
}
