// ShoppingCartApplication/Program.cs
using System;
using System.Collections.Generic;

namespace ShoppingCartApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            ShoppingCart cart = new ShoppingCart();
            GroceryStore groceryStore = new GroceryStore();
            ClothingStore clothingStore = new ClothingStore();

            bool shopping = true;

            while (shopping)
            {
                Console.WriteLine("Welcome to the Smart Cart Application!");
                Console.WriteLine("1. Shop at Grocery Store");
                Console.WriteLine("2. Shop at Clothing Store");
                Console.WriteLine("3. View Shopping Cart");
                Console.WriteLine("4. Checkout and Exit");

                Console.Write("Enter your choice: ");
                int choice;
                if (int.TryParse(Console.ReadLine(), out choice))
                {
                    switch (choice)
                    {
                        case 1:
                            ShopAtStore(groceryStore, cart);
                            break;
                        case 2:
                            ShopAtStore(clothingStore, cart);
                            break;
                        case 3:
                            ViewCart(cart);
                            break;
                        case 4:
                            shopping = false;
                            break;
                        default:
                            Console.WriteLine("Invalid choice. Please select a valid option.");
                            break;
                    }
                }
                else
                {
                    Console.WriteLine("Invalid input. Please enter a number.");
                }
            }

            Console.WriteLine($"Total cost: ${cart.CalculateTotalCost():F2}");
            Console.WriteLine("Thank you for shopping with us!");
        }

        static void ShopAtStore(dynamic store, ShoppingCart cart)
        {
            var products = store.GetAvailableProducts();
            Console.WriteLine("Available products:");
            for (int i = 0; i < products.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {products[i].Name} - ${products[i].Price:F2} ({products[i].Category})");
            }

            Console.Write("Enter the number of the product to add to cart: ");
            int productNumber;
            if (int.TryParse(Console.ReadLine(), out productNumber) && productNumber > 0 && productNumber <= products.Count)
            {
                cart.AddItem(products[productNumber - 1]);
                Console.WriteLine($"{products[productNumber - 1].Name} added to cart.");
            }
            else
            {
                Console.WriteLine("Invalid product number.");
            }
        }

        static void ViewCart(ShoppingCart cart)
        {
            var items = cart.ViewItems();
            if (items.Count == 0)
            {
                Console.WriteLine("Your cart is empty.");
            }
            else
            {
                Console.WriteLine("Items in your cart:");
                foreach (var item in items)
                {
                    Console.WriteLine($"{item.Name} - ${item.Price:F2} ({item.Category})");
                }

                Console.Write("Enter the name of the item to remove from cart or press Enter to continue: ");
                string itemName = Console.ReadLine();

                if (!string.IsNullOrEmpty(itemName))
                {
                    var itemToRemove = items.Find(item => item.Name.Equals(itemName, StringComparison.OrdinalIgnoreCase));
                    if (itemToRemove != null)
                    {
                        cart.RemoveItem(itemToRemove);
                        Console.WriteLine($"{itemName} removed from cart.");
                    }
                    else
                    {
                        Console.WriteLine("Item not found in cart.");
                    }
                }
            }
        }
    }
}

