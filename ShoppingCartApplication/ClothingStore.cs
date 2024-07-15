using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingCartApplication
{
    public class ClothingStore
    {
        private List<Product> products;

        public ClothingStore()
        {
            products = new List<Product>
            {
                ProductGenerator.GenerateClothingProduct(),
                ProductGenerator.GenerateClothingProduct(),
                ProductGenerator.GenerateClothingProduct()
            };
        }

        public List<Product> GetAvailableProducts()
        {
            return products;
        }
    }
}
