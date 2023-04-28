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
    }
}

