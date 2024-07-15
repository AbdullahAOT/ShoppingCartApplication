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
            ProductGenerator.GenerateProduct(),
            ProductGenerator.GenerateProduct(),
            ProductGenerator.GenerateProduct()
        };
        }

        public List<Product> GetAvailableProducts()
        {
            return products;
        }
    }
}
