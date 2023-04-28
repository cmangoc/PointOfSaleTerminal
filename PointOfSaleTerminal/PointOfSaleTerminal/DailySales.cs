using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PointOfSaleTerminal
{
    public class DailySales
    {
        public string Name { get; set; }
        public decimal Revenue { get; set; }
        public int Quantity { get; set; }
        public static List<DailySales> ItemsSold { get; set; } = new List<DailySales>();
        public DailySales()
        {
            this.Name = string.Empty;
            this.Revenue = 0;
            this.Quantity = 0;
        }
        public DailySales(string name, decimal revenue, int quantity)
        {
            Name = name;
            Revenue = revenue;
            Quantity = quantity;
        }
        public static void FetchProductList()
        {
            foreach(var item in Product.ProductsList)
            {
                ItemsSold.Add(new DailySales(item.Name, 00.00m, 0));
            }
        }
        public static void FetchShoppingCart()
        {
            for (int i = 0; i < ProductsPurchased.ShoppingCart.Count; i++)
            {
                string name = ProductsPurchased.ShoppingCart[i].Name;
                decimal currentPrice = ProductsPurchased.ShoppingCart[i].Price / ProductsPurchased.ShoppingCart[i].Quantity;
                int quantity = ProductsPurchased.ShoppingCart[i].Quantity;
                DailySales.AddToDailySales(name, currentPrice, quantity);
            }
        }
        public static void AddToDailySales(string name, decimal currentPrice, int quantity)
        {
            bool inList = false;
            for (int i = 0; i < ItemsSold.Count(); i++)
            {
                if (ItemsSold[i].Name == name)
                {
                    inList = true;
                    ItemsSold[i].Quantity += quantity;
                    ItemsSold[i].Revenue += quantity*currentPrice;
                }
            }
            if (inList == false)
            {
                ItemsSold.Add(new DailySales(name, currentPrice*quantity, quantity));
            }
        }
        public override string ToString()
        {
            return String.Format("{0,-15} {1,-18} {2,41}", $"{Name}", $"{Quantity}", $"${Revenue}");
        }
        public static void PrintProducts()
        {
            decimal dailyTotal = 00.00m;
            for (int i = 0; i < 84; i++)
            {
                Console.Write("=");
            }
            Console.WriteLine();
            for (int i = 0; i < ItemsSold.Count; i++)
            {
                Console.WriteLine(i + 1 + ".\t" + ItemsSold[i].ToString());
                if (ItemsSold[i].Quantity > 0)
                {
                    dailyTotal += ItemsSold[i].Revenue;
                }
            }
            Console.WriteLine(String.Format("{0,-20} {1,63}", $"Total for the day: " , $"${dailyTotal}"));
            for (int i = 0; i < 84; i++)
            {
                Console.Write("=");
            }
            Console.WriteLine();
        }
    }
}
