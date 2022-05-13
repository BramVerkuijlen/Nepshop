using Nepshop.Logic.Model.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nepshop.Logic.Interface
{
    public interface IProductDal
    {
        public void UpdateProduct(ProductDTO productDTO);
    }
}
