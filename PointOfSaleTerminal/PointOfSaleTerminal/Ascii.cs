using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace PointOfSaleTerminal
{
    public class Ascii
    {
        public decimal Price { get; set; }
        public string AsciiName { get; set; }
        public static List<Ascii> AsciiProductsList { get; set; } = new List<Ascii>();
        public Ascii(string Ascii, decimal Price)
        {
            this.Price = Price;
            this.AsciiName = Ascii;
        }

        public static void PrintAscii(int input)
        {

            Console.ForegroundColor = ConsoleColor.Green;

            for (int i = 0; i < AsciiProductsList.Count; i++)
            {
                if (i == input)
                    Console.WriteLine(AsciiProductsList[i].ToString());
                
            }
           
            Console.ResetColor();
            
        }

        public override string ToString()
        {
            return String.Format("{0,-70} {1, 40}", $"{AsciiName}", $"${Price}");

        }
    }
}