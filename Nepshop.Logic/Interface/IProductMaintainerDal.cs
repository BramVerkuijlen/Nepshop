using Nepshop.Logic.Model.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nepshop.Logic.Interface
{
    public interface IProductMaintainerDal
    {
        void AddProduct(ProductDTO productDTO);
        
        void RemoveProduct(ProductDTO productDTO);

        List<ProductDTO> GetAllProducts();

        public ProductDTO GetProductOnId(int id);

    }
}
