﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nepshop.Logic.Interface
{
    public interface IFavoriteDal
    {
        public void AddProduct();
        public void RemoveProduct();
        public void AddProductToCart();
    }
}
