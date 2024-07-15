using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingCartApplication
{

    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class ShoppingCart
    {
        private List<Product> items;

        public ShoppingCart()
        {
            items = new List<Product>();
        }

        public void AddItem(Product product)
        {
            items.Add(product);
        }

        public void RemoveItem(Product product)
        {
            items.Remove(product);
        }

        public List<Product> ViewItems()
        {
            return new List<Product>(items);
        }

        public decimal CalculateTotalCost()
        {
            return items.Sum(item => item.Price);
        }
    }

}
