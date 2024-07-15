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

        public static Product GenerateProduct()
        {
            var category = (ProductCategory)random.Next(0, 3);
            string name = "";
            decimal price = 0;

            switch (category)
            {
                case ProductCategory.Food:
                    name = foodNames[random.Next(foodNames.Length)];
                    price = (decimal)(random.NextDouble() * 10 + 1);
                    break;
                case ProductCategory.Clothing:
                    name = clothingNames[random.Next(clothingNames.Length)];
                    price = (decimal)(random.NextDouble() * 50 + 10);
                    break;
                case ProductCategory.Electronics:
                    name = electronicNames[random.Next(electronicNames.Length)];
                    price = (decimal)(random.NextDouble() * 200 + 50);
                    break;
            }

            return new Product(name, price, category);
        }
    }
}
