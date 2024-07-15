using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingCartApplication
{
    public class ProductGenerator
    {
        private static Random random = new Random();
        private static string[] foodNames = { "Apple", "Bread", "Milk" };
        private static string[] clothingNames = { "Shirt", "Pants", "Jacket" };
        private static string[] electronicNames = { "Phone", "Laptop", "Tablet" };

        public static Product GenerateFoodProduct()
        {
            string name = foodNames[random.Next(foodNames.Length)];
            decimal price = (decimal)(random.NextDouble() * 10 + 1);
            return new Product(name, price, ProductCategory.Food);
        }

        public static Product GenerateClothingProduct()
        {
            string name = clothingNames[random.Next(clothingNames.Length)];
            decimal price = (decimal)(random.NextDouble() * 50 + 10);
            return new Product(name, price, ProductCategory.Clothing);
        }

        public static Product GenerateElectronicProduct()
        {
            string name = electronicNames[random.Next(electronicNames.Length)];
            decimal price = (decimal)(random.NextDouble() * 200 + 50);
            return new Product(name, price, ProductCategory.Electronics);
        }
    }
}
