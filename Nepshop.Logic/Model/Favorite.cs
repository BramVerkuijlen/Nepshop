using Nepshop.Logic.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nepshop.Logic.Model
{
    internal class Favorite
    {
        readonly IFavoriteDAL FavoriteDAL;

        public Favorite(IFavoriteDAL favoriteDAL)
        {
            FavoriteDAL = favoriteDAL;
        }

        public void AddProduct()
        {
            FavoriteDAL.AddProductToFavorites();
        }

        public void RemoveProduct()
        {
            FavoriteDAL.RemoveProductFromFavorites();
        }
    }
}
