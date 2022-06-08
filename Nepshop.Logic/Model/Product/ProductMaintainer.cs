using Nepshop.Logic.Interface;
using Nepshop.Logic.Model.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nepshop.Logic
{
    public class ProductMaintainer
    {
        private readonly IProductMaintainerDal ProductMaintainerDal;

        public ProductMaintainer(IProductMaintainerDal productMaintainerDal)
        {
            ProductMaintainerDal = productMaintainerDal;
        }

        public void AddProduct(ProductDTO product)
        {
            ProductMaintainerDal.AddProduct(product);
        }

        public void RemoveProduct(ProductDTO product)
        {
            ProductMaintainerDal.RemoveProduct(product);
        }

        public List<ProductDTO> GetAllProducts()
        {
            return ProductMaintainerDal.GetAllProducts();
        }
        public ProductDTO GetProductOnId(int id)
        {
            return ProductMaintainerDal.GetProductOnId(id);
        }
    }
}
