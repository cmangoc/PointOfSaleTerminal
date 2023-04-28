using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PointOfSaleTerminal
{
    public class Validator
    {
        public static int ValidateInt()
        {
            try
            {
                int input = int.Parse(Console.ReadLine());
                return input;
            }
            catch (FormatException)
            {
                Console.WriteLine("Invalid input, NaN.");
                return ValidateInt();
            }
        }
        public static decimal ValidateDecimal()
        {
            try
            {
                decimal input = decimal.Parse(Console.ReadLine());
                return Math.Round(input,2);
            }
            catch (FormatException)
            {
                Console.WriteLine("Invalid input, NaN.");
                return ValidateInt();
            }
        }
        public static bool Continue(string prompt)
        {
            Console.WriteLine($"{prompt}? (y/n)");
            string input = Console.ReadLine().Trim().ToLower();
            if (input == "y")
            {
                return true;
            }
            else if (input == "n")
            {
                return false;
            }
            else
            {
                Console.WriteLine("Invalid input, try agian.");
                return Continue(prompt);
            }
        }
        public static string ValidateCreditCard()
        {
            Console.WriteLine("Enter a 16 digit credit card number: ");
            string cardNumber = "";
            string input = Console.ReadLine().Trim();
            if (input.Length == 16)
            {
                char[] chars = input.ToCharArray();
                foreach(char c in chars)
                {
                    if (char.IsNumber(c))
                    {
                        cardNumber += c;
                    }
                }
            }
            else
            {
                return ValidateCreditCard();
            }
            if (cardNumber.Length == 16)
            {
                return cardNumber;
            }
            else
            {
                return ValidateCreditCard();
            }
        }
        public static int ValidateMonth()
        {
            Console.WriteLine("Enter the expiration month: ");
            int month = ValidateInt();
            if (month >= 1 && month <= 12)
            {
                return month;
            }
            else
            {
                return ValidateMonth();
            }
        }
        public static int ValidateYear()
        {
            Console.WriteLine("Enter the expiration year: ");
            int year = ValidateInt();
            if (year >= 23 && year <= 99)
            {
                return year;
            }
            else
            {
                return ValidateYear();
            }
        }
        public static string ValidateCVV()
        {
            Console.WriteLine("Enter a 3 digit CVV: ");
            string numCVV = "";
            string input = Console.ReadLine().Trim();
            if (input.Length == 3)
            {
                char[] chars = input.ToCharArray();
                foreach (char c in chars)
                {
                    if (char.IsNumber(c))
                    {
                        numCVV += c;
                    }
                }
            }
            else
            {
                return ValidateCreditCard();
            }
            if (numCVV.Length == 3)
            {
                return numCVV;
            }
            else
            {
                return ValidateCreditCard();
            }
        }
        public static string ValidateCheck()
        {
            Console.WriteLine("Enter a 9 digit Routing Number: ");
            string routingNum = "";
            string input = Console.ReadLine().Trim();
            if (input.Length == 9)
            {
                char[] chars = input.ToCharArray();
                foreach (char c in chars)
                {
                    if (char.IsNumber(c))
                    {
                        routingNum += c;
                    }
                }
            }
            else
            {
                return ValidateCreditCard();
            }
            if (routingNum.Length == 9)
            {
                return routingNum;
            }
            else
            {
                return ValidateCheck();
            }
        }
    }
}
