using System.ComponentModel.DataAnnotations;

namespace PointOfSaleTerminal
{
    public class Program
    {
        static void Main()
        {
            Product.ProductsList.Add(new Product("Bread", "Food", "wholegrain", 4.99m));
            Product.ProductsList.Add(new Product("Chips", "Food", "Potato chips", 5.99m));
            Product.ProductsList.Add(new Product("SweetPotato", "Food", "Fresh sweet potato", 0.99m));
            Product.ProductsList.Add(new Product("Beef", "Food", "Chunk roasted beef, 4pound", 35.00m));
            Product.ProductsList.Add(new Product("Notebook", "Office Supplies", "1 Subject Notebook", 0.99m));
            Product.ProductsList.Add(new Product("Binder", "Office Supplies", "3-ringed binder", 4.69m));
            Product.ProductsList.Add(new Product("Pencils", "Office Supplies", "30 Pre-Sharpened, #2 Pencils", 8.98m));
            Product.ProductsList.Add(new Product("Black Pen", "Office Supplies", "It's a really good pen", 449.99m));
            Product.ProductsList.Add(new Product("Lacrosse Stick", "Sporting Goods", "Netted stick for playing game", 99.88m));
            Product.ProductsList.Add(new Product("Basketball", "Sporting Goods", "Always round guaranteed", 15.65m));
            Product.ProductsList.Add(new Product("Horseshoes", "Sporting Goods", "Not for Horses", 44.95m));
            Product.ProductsList.Add(new Product("Shorts", "Sporting Goods", "For the true sportsperson", 19.98m));

            Product.PrintProducts();

            bool goOn = true;
            while (goOn)
            {
                Product.OrderProduct();
                goOn = Validator.Continue();
            }
            decimal grandTotal = ProductsPurchased.DisplayReceipt();
            ProductsPurchased.PayReceipt(grandTotal);
        }
    }
}