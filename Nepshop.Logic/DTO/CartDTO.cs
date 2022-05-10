﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nepshop.Logic.Model.DTO
{
    public class CartDTO
    {
        private List<Product> Products = new List<Product>();
        public IEnumerable<Product> products
        {
            get { return Products; }
        }
    }
}