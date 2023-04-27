using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading.Tasks;

namespace PointOfSaleTerminal
{
    public class Product
    {
        public string Name { get; set; }
        public string Category { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public static List<Product> ProductsList { get; set; } = new List<Product>();
        public Product(string Name, string Category, string Description, decimal Price)
        {
            this.Name = Name;
            this.Category = Category;
            this.Description = Description;
            this.Price = Price;
        }

        public override string ToString()
        {
            return String.Format("{0,-15} {1,-18} {2,-30} {3,10}", $"{Name}", $"{Category}", $"{Description}", $"${Price}");
        }
        public static void PrintProducts()
        {
            for (int i = 0; i < 84; i++)
            {
                Console.Write("=");
            }
            Console.WriteLine();
            for (int i = 0; i < ProductsList.Count; i++)
            {
                Console.WriteLine(i + 1 + ".\t" + ProductsList[i].ToString());
            }
            for (int i = 0; i < 84; i++)
            {
                Console.Write("=");
            }
            Console.WriteLine();
        }
        public static void OrderProduct()
        {
            Console.WriteLine($"What would you like to order? [1-{ProductsList.Count}] or [0 to display list again]");
            int input1 = Validator.ValidateInt(); //needs to accept string/int
            if (input1 >= 1 && input1 <= ProductsList.Count)
            {
                input1--;
                Console.WriteLine($"How many {ProductsList[input1].Name} do you want to order?");
                int input2 = Validator.ValidateInt();
                int total = input2;
                if (input2 >= 1)
                {
                    for (int i = 0; i < ProductsPurchased.ShoppingCart.Count; i++)
                    {
                        if (ProductsPurchased.ShoppingCart[i].Name == ProductsList[input1].Name)
                        {
                            total += ProductsPurchased.ShoppingCart[i].Quantity;
                            ProductsPurchased.ShoppingCart.Remove(ProductsPurchased.ShoppingCart[i]);
                        }
                    }
                    ProductsPurchased.ShoppingCart.Add(new ProductsPurchased(ProductsList[input1].Name, ProductsList[input1].Category, ProductsList[input1].Description, ProductsList[input1].Price * total, total));
                    Console.WriteLine($"Added {input2} {ProductsList[input1].Name} for ${ProductsList[input1].Price * input2}");
                }
                else
                {
                    Console.WriteLine($"Unable to add {input2} of products");
                }

            }
            else if (input1 == 0)
            {
                PrintProducts();
                OrderProduct();
            }
            else
            {
                OrderProduct();
            }
        }
    }
}

