using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingCartApplication
{
    public class GroceryStore
    {
        private List<Product> products;

        public GroceryStore()
        {
            products = new List<Product>
            {
                ProductGenerator.GenerateFoodProduct(),
                ProductGenerator.GenerateFoodProduct(),
                ProductGenerator.GenerateFoodProduct()
            };
        }

        public List<Product> GetAvailableProducts()
        {
            return products;
        }
    }
}
