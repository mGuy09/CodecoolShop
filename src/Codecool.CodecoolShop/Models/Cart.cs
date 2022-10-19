using System;
using System.Collections.Generic;

namespace Codecool.CodecoolShop.Models
{
    public class Cart
    {
        public Dictionary<Product, int> Products;
        private Cart()
        {
            Products = new Dictionary<Product, int>();
        }
        private static Cart instance = null;
        public static Cart Instance {
            get {
                if (instance is null) instance = new Cart();

                return instance;
            } }
        
        
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

        public int SumCart()
        {
            int sum = 0;
            foreach (var product in Products)
            {
                

            }
            return sum;
        }
       


    }
}
