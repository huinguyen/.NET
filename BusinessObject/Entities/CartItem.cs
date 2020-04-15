﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessObject.Entities
{
    public class CartItem
    {
        public Product product;
        public int Quantity;

        public CartItem(Product product, int quantity)
        {
            this.product = product;
            Quantity = quantity;
        }
    }
}
