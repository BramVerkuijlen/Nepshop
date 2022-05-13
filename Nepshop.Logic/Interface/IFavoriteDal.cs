using Nepshop.Logic.Model.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nepshop.Logic.Interface
{
    public interface IFavoriteDal
    {
        public void AddProduct(ProductDTO productDTO);
        public void RemoveProduct(ProductDTO productDTO);
        public void AddProductToCart();
        public void GetAllProducts(ProductDTO productDTO);
    }
}
