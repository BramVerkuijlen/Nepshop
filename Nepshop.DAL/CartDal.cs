using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Nepshop.Logic.Interface;
using Nepshop.Logic.Model.DTO;

namespace Nepshop.DAL
{
    public class CartDal : ICartDal
    {
        public void AddProduct(ProductDTO product)
        {
            throw new NotImplementedException();
        }

        public void EmptyCart()
        {
            throw new NotImplementedException();
        }

        public void RemoveProduct(ProductDTO product)
        {
            throw new NotImplementedException();
        }

        public List<ProductDTO> GetAllProducts()
        {
            throw new NotImplementedException();
        }
    }
}
