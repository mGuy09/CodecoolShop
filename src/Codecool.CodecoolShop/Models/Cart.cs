using System;
using System.Collections.Generic;

namespace Codecool.CodecoolShop.Models
{
    public class Cart
    {
        public Dictionary<Product, int> Products { get; set; } = new Dictionary<Product, int>();
        public int cartId { get; set; }

        public void Add(Product product)
        {
            if (Products.Count >= 1)
            {
                bool productExists = false;
                foreach (Product key in Products.Keys)
                {
                    if (key.Id == product.Id)
                    {
                        Products[key] += 1;
                        productExists = true;
                    }
                }

                if (!productExists) Products[product] = 1;
            }
            else Products[product] = 1;
        }

       


    }
}
