using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nepshop.Logic.Model.DTO
{
    public class ProductDTO
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        string Category { get; set; }
        public string Picture { get; set; }
        public int Price { get; set; }
        public int Amount { get; set; }
        public bool Available { get; set; }

    }
}
