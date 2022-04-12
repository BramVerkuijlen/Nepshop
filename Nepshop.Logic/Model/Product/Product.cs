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
        public string Name { get; private set; }
        public string Description { get; private set; }
        public Helper.Category Category { get; private set; }
        public string Picture { get; private set; }
        public int Price { get; private set; }
        public int Amount { get; private set; }
        public bool Available { get; private set; }

        readonly IProductDal ProductDal;

        public Product(string name, string description, Helper.Category category, string picture, int price, int amount, bool available, IProductDal productDal)
        {
            Name = name;
            Description = description;
            Category = category;
            Picture = picture;
            Price = price;
            Amount = amount;
            Available = available;

            IProductDal ProductDal = productDal;
            
        }

        void UpdateProduct()
        {
            ProductDal.UpdateProduct();
        }
    }
}
