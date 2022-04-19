using Nepshop.Logic.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nepshop.Logic
{
    public class Favorite
    {
        readonly IFavoriteDal FavoriteDal;

        private List<Product> Products = new List<Product>();
        public IEnumerable<Product> products
        {
            get { return Products; }
        }
        public Favorite(IFavoriteDal favoriteDal)
        {
            FavoriteDal = favoriteDal;
        }

        public void AddProduct(Product product)
        {
            this.Products.Add(product);
        }

        public void RemoveProduct(Product product)
        {
            this.Products.Add(product);
        }
    }
}
