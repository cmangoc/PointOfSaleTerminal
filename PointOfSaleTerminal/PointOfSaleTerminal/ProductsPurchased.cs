using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PointOfSaleTerminal
{
    public class ProductsPurchased
    {
        public string Name { get; set; }
        public decimal Price { get; set; }
        public int Quantity { get; set; }
        public static List<ProductsPurchased> ShoppingCart { get; set; } = new List<ProductsPurchased>();
        public ProductsPurchased(string Name, decimal Price, int quantity)
        {
            this.Name = Name;
            this.Price = Price;
            Quantity = quantity;
        }
        public static void OrderProduct()
        {
            Console.WriteLine($"What would you like to order? [1-{Product.ProductsList.Count}] or [0 to display list again]");
            int input1 = Validator.ValidateInt(); //needs to accept string/int
            if (input1 >= 1 && input1 <= Product.ProductsList.Count)
            {
                input1--;
                Console.WriteLine($"How many {Product.ProductsList[input1].Name} do you want to order?");
                int input2 = Validator.ValidateInt();
                int newItem = 1;
                if (input2 >= 1)
                {
                    decimal priceInitial = Product.ProductsList[input1].Price * input2;
                    for (int i = 0; i < ShoppingCart.Count; i++)
                    {
                        if (ShoppingCart[i].Name == Product.ProductsList[input1].Name)
                        {
                            ShoppingCart[i].Price /= ShoppingCart[i].Quantity;
                            ShoppingCart[i].Quantity += input2;
                            priceInitial = ShoppingCart[i].Price * input2;
                            ShoppingCart[i].Price *= ShoppingCart[i].Quantity;
                            newItem--;
                        }
                    }
                    if (newItem == 1)
                    {
                        ShoppingCart.Add(new ProductsPurchased(Product.ProductsList[input1].Name, Product.ProductsList[input1].Price * input2, input2));
                    }
                    Console.WriteLine($"Added {input2} {Product.ProductsList[input1].Name} for ${priceInitial}");
                }
                else
                {
                    Console.WriteLine($"Unable to add {input2} of products");
                }

            }
            else if (input1 == 0)
            {
                Product.PrintProducts();
                OrderProduct();
            }
            else if (input1 == 2048)
            {
                Admin.ActivateAdmin();
            }
            else
            {
                OrderProduct();
            }
        }
        public static decimal DisplayReceipt()
        {
            for (int i = 0; i < 84; i++)
            {
                Console.Write("=");
            }
            Console.WriteLine();
            Console.WriteLine(String.Format("{0,-7} {1,-15} {2,-18} {3,10} {4,29}", "Amount", "Name", "Category", "Description", "Price"));
            decimal subtotal = 0;
            for (int i = 0; i < ShoppingCart.Count; i++)
            {
                Console.WriteLine(ShoppingCart[i].Quantity + ":\t" + ShoppingCart[i].ToString());
                subtotal += ShoppingCart[i].Price;
            }
            Console.WriteLine(String.Format("{0,84}", "Subtotal"));
            Console.WriteLine(String.Format("{0,84}", $"${subtotal}"));
            Console.WriteLine(String.Format("{0,84}", "6% Tax"));
            Console.WriteLine(String.Format("{0,84}", $"${Math.Round(subtotal * .06m, 2)}"));
            Console.WriteLine(String.Format("{0,84}", "Grandtotal"));
            decimal grandTotal = Math.Round(subtotal + subtotal * .06m, 2);
            Console.WriteLine(String.Format("{0,84}", $"${grandTotal}"));
            return grandTotal;
        }
        public static void PayReceipt(decimal total)
        {
            Console.WriteLine("How would you like to pay?: [Cash, Credit, Check]");
            string input = Console.ReadLine().Trim().ToLower();
            decimal change = 00.00m;
            string creditCard = "";
            string check = "";
            if (input == "cash")
            {
                change = PayInCash(total);
                DisplayReceipt();
                Console.WriteLine(String.Format("{0,84}", $"Amount Paid: ${total + change}"));
                Console.WriteLine(String.Format("{0,84}", $"Amount Change: ${change}"));
            }
            else if (input == "credit")
            {
                creditCard = PayInCredit();
                string censoredCard = "****-****-****-" + creditCard.Substring(12);
                DisplayReceipt();
                Console.WriteLine(String.Format("{0,84}", $"Card Used: {censoredCard}"));
                Console.WriteLine(String.Format("{0,84}", $"Amount Change: ${change}"));
            }
            else if (input == "check")
            {
                check = PayInCheck();
                DisplayReceipt();
                Console.WriteLine(String.Format("{0,84}", $"Routing Number: {check}"));
                Console.WriteLine(String.Format("{0,84}", $"Amount Change: ${change}"));
            }
            else
            {
                PayReceipt(total);
            }
            for (int i = 0; i < 84; i++)
            {
                Console.Write("=");
            }
            Console.WriteLine();
        }
        public static decimal PayInCash(decimal total)
        {
            Console.WriteLine("How much cash: $");
            decimal input2 = Validator.ValidateDecimal();
            decimal change = 0;
            if (total < input2)
            {
                change = input2 - total;
                Console.WriteLine("Your change is: $" + change);
            }
            else if (total == input2)
            {
                Console.WriteLine("No change to return");
            }
            else
            {
                decimal due = total - input2;
                Console.WriteLine("Not enough, balance still due: $" + due);
                while (true)
                {
                    decimal inputDue = Validator.ValidateDecimal();
                    if (inputDue > due)
                    {
                        Console.WriteLine("Your change is: $" + (inputDue - due));
                        change = inputDue - due;
                        break;
                    }
                    else if (due == inputDue)
                    {
                        Console.WriteLine("No change to return");
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Input the remaining balance: $" + due);
                    }
                }
            }
            return change;
        }
        public static string PayInCredit()
        {
            string creditCard = Validator.ValidateCreditCard();
            int expireMonth = Validator.ValidateMonth();
            int expireYear = Validator.ValidateYear();
            string numCVV = Validator.ValidateCVV();
            return $"{creditCard}  {expireMonth}/{expireYear}  {numCVV}";
        }
        public static string PayInCheck()
        {
            string check = Validator.ValidateCheck();
            return check;
        }
        public override string ToString()
        {

            return String.Format("{0,-15} {1,60}", $"{Name}",  $"${Price}");
        }
    }
}

