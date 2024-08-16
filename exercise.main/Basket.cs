﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercise.main
{
    public class Basket
    {
        private List<Product> _products = new List<Product>();
        private static int _capacity;

        public bool add(string v)
        {
            Product value = BagelShop.Category[v];
            _products.Add(value);
            return true;
        }

        public bool remove(string v)
        {
            Product value = BagelShop.Category[v];
            if (!_products.Contains(value)) return false;

            _products.Remove(value);
            return true;
        }

        public List<Product> Products { get { return _products; } }
    }
}
