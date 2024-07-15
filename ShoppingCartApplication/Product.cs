using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingCartApplication
{
    // ShoppingCartApplication/Product.cs
    using System;

    public enum ProductCategory
    {
        Food,
        Clothing,
        Electronics
    }

    public class Product
    {
        public string Name { get; set; }
        public decimal Price { get; set; }
        public ProductCategory Category { get; set; }

        public Product(string name, decimal price, ProductCategory category)
        {
            Name = name;
            Price = price;
            Category = category;
        }
    }

}
