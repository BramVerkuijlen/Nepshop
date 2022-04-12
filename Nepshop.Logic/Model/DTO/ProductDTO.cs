using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nepshop.Logic.Model.DTO
{
    public class ProductDTO
    {
        public string Name { get; private set; }
        public string Description { get; private set; }
        public Helper.Category Category { get; private set; }
        public string Picture { get; private set; }
        public int Price { get; private set; }
        public int Amount { get; private set; }
        public bool Available { get; private set; }
    }
}
