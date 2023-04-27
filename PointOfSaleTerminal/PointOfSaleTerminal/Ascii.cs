using System;
using System.Collections.Generic;
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

        public static void PrintAscii()
        {
            for (int i = 0; i < 84; i++)
            {
                Console.Write("=");
            }
            Console.WriteLine();
            for (int i = 0; i < AsciiProductsList.Count; i++)
            {
                Console.WriteLine(i + 1 + ".\t" + AsciiProductsList[i].ToString());
            }
            for (int i = 0; i < 84; i++)
            {
                Console.Write("=");
            }
            Console.WriteLine();
        }

        public override string ToString()
        {
            return String.Format("{0,-70} {1, 10}", $"{AsciiName}", $"${Price}");
            //return (AsciiName + Price);
        }
    }
}


        //public string AsciiName { get; set; }

        //public Ascii(string Ascii, decimal Price) : base("", "", "", Price)
        //{
        //    this.AsciiName = Ascii;
        //}
        

        //public override string ToString()
        //{
        //    return String.Format("{0,-60} {3,10}", $"{AsciiName}", $"${Price}");
        //}



        //List<Ascii> AsciiList { get; set; } = new List<Ascii>();
        //public int AsciiChoice { get; set; }
        //public Ascii(int asciiChoice)
        //{
        //    this.AsciiChoice = asciiChoice;
        //}

        //public void AsciiTime (int asciiTime)
        //{
        //    Console.WriteLine(AsciiList.IndexOf(AsciiList[asciiTime]));
        //}