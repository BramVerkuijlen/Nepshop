﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nepshop.Logic.Interface
{
    public interface IFavoriteDAL
    {
        void AddProductToFavorites();
        void RemoveProductFromFavorites();
    }
}
