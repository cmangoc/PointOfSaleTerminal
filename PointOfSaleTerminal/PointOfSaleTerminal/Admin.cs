using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace PointOfSaleTerminal
{
    internal class Admin
    {
        public Admin() { }
        public static void ActivateAdmin()
        {
            Console.WriteLine("Do you want to use Store Owner View?: [y/n]");
            string input = Console.ReadLine().Trim().ToLower();
            if (input == "y")
            {
                UseAdminCommands();
            }
            else if (input == "n")
            {
                Console.WriteLine("Returning to Customer View.");
            }
            else
            {
                Console.WriteLine("Invalid input, let's try again.");
                ActivateAdmin();
            }
        }
        public static void UseAdminCommands()
        {
            Console.WriteLine("What would you like to do?: [modify/sales/exit]");
            string input = Console.ReadLine().Trim().ToLower();
            if (input == "modify")
            {
                ModifyProducts();
                UseAdminCommands();
            }
            else if (input == "sales")
            {

            }
            else if (input == "exit")
            {
                Console.WriteLine("Returning to Customer View.");
                return;
            }
            else
            {
                Console.WriteLine("Unknown Command, let's try again.");
                UseAdminCommands();
            }
        }
        public static void ModifyProducts()
        {
            Product.PrintProducts();
            Console.WriteLine($"What Product would you like to modify?: [1-{Product.ProductsList.Count}] or [0 to exit]");
            int input1 = Validator.ValidateInt();
            if (input1 >= 1 && input1 <= Product.ProductsList.Count)
            {
                input1--;
                Console.WriteLine($"What would you like to modify about {Product.ProductsList[input1].Name}? [Name/Category/Description/Price]");
                string input2 = Console.ReadLine().Trim().ToLower();
                if (input2 == "name")
                {
                    Console.WriteLine("Input a new Name: ");
                    Product.ProductsList[input1].Name = Console.ReadLine();
                    ModifyProducts();
                }
                else if (input2 == "category")
                {
                    Console.WriteLine("Input a new Category: ");
                    Product.ProductsList[input1].Category = Console.ReadLine();
                    ModifyProducts();
                }
                else if (input2 == "description")
                {
                    Console.WriteLine("Input a new Description: ");
                    Product.ProductsList[input1].Description = Console.ReadLine();
                    ModifyProducts();
                }
                else if (input2 == "price")
                {
                    Console.WriteLine("Input a new Price: (Won't effect goods already in Shopping Carts)");
                    decimal newPrice = Validator.ValidateDecimal();
                    if (newPrice <= 0)
                    {
                        Console.WriteLine($"Unable to make {Product.ProductsList[input1].Name} free.");
                        ModifyProducts();
                    }
                    else
                    {
                        Product.ProductsList[input1].Price = newPrice;
                        ModifyProducts();
                    }
                }
            }
            else if (input1 == 0)
            {
                return;
            }
            else
            {
                ModifyProducts();
            }
        }
    }
}
