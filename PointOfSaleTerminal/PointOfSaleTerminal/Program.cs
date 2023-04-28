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
            DailySales.FetchProductList();

            Ascii.AsciiProductsList.Add(new Ascii("    _______\r\n   /       )\r\n  /_____   |\r\n (  '   ) / \r\n  |.  '| / \r\n  |____|/  ", 4.99m));
            Ascii.AsciiProductsList.Add(new Ascii("      ____________________________\r\n     /                           /\\\r\n    /                          _/ /\\\r\n   /                          / \\/\r\n  /                           /\\\r\n /___________________________/ /\r\n \\___________________________\\/\r\n  \\ \\ \\ \\ \\ \\ \\ \\ \\ \\ \\ \\ \\ \\ \\", 5.99m));
            Ascii.AsciiProductsList.Add(new Ascii(" _____                   _    ______     _        _        \r\n/  ___|                 | |   | ___ \\   | |      | |       \r\n\\ `--.__      _____  ___| |_  | |_/ /__ | |_ __ _| |_ ___  \r\n `--. \\ \\ /\\ / / _ \\/ _ \\ __| |  __/ _ \\| __/ _` | __/ _ \\ \r\n/\\__/ /\\ V  V /  __/  __/ |_  | | | (_) | || (_| | || (_) |\r\n\\____/  \\_/\\_/ \\___|\\___|\\__| \\_|  \\___/ \\__\\__,_|\\__\\___/ ", 0.99m));
            Ascii.AsciiProductsList.Add(new Ascii("           (    )\r\n            (oo)\r\n   )\\.-----/(O O)\r\n  # ;       / u\r\n    (  .   |} )\r\n     |/ `.;|/;\r\n     \"     \" \"", 35.00m));
            Ascii.AsciiProductsList.Add(new Ascii("                .-~~~~~~~~~-._       _.-~~~~~~~~~-.\r\n            __.'              ~.   .~              `.__\r\n          .'//                  \\./                  \\\\`.\r\n        .'//                     |                     \\\\`.\r\n      .'// .-~\"\"\"\"\"\"\"~~~~-._     |     _,-~~~~\"\"\"\"\"\"\"~-. \\\\`.            \r\n    .'//.-\"                 `-.  |  .-'                 \"-.\\\\`.\r\n  .'//______.============-..   \\ | /   ..-============.______\\\\`.\r\n.'______________________________\\|/______________________________`.", 0.99m));
            Ascii.AsciiProductsList.Add(new Ascii("    /,-. \r\n    // /|\r\n   // / |\r\n  (O <__|__ \r\n  |\\\\ \\    |\r\n  | \\\\ \\   |\r\n  |  \\`-`  |\r\n  |   | |  |\r\n  |   | |__|\r\n   \\  | |\r\n    \\ | |\r\n     \\|-'", 4.69m));
            Ascii.AsciiProductsList.Add(new Ascii("  ________________________________________________\r\n /\\______________________________________________/`-.\r\n<()>____________________________________________<    ##\r\n \\/______________________________________________\\,-'", 8.98m));
            Ascii.AsciiProductsList.Add(new Ascii("         .=======================ooooooo\r\n ___   ,'    \\_________________________________________\r\n/   /-/       /                           ////////////  ''--..._\r\n\\___\\-\\       \\                           \\\\\\\\\\\\\\\\\\\\\\\\  __..--'\r\n       `---------------------------------''''''''''''''", 449.99m));
            Ascii.AsciiProductsList.Add(new Ascii("        O       \\ O\r\n      //\\____O   \\/\\\\\r\n      /\\           /\\\r\n     / /           \\ \\   ", 99.88m));
            Ascii.AsciiProductsList.Add(new Ascii("                 -|\r\n               -' |\r\n             -'   | __\r\n        ==wkm=====|'\\/           ()\r\n                                 /|\r\n                                 `O\r\n                                 /`\r\n                                :\r\n                               /\\\r\n                               \\ \\\r\n                               ` `\r\n        ____________________________________,", 15.65m));
            Ascii.AsciiProductsList.Add(new Ascii(" _   _                       _____ _                     \r\n| | | |                     /  ___| |                    \r\n| |_| | ___  _ __ ___  ___  \\ `--.| |__   ___   ___  ___ \r\n|  _  |/ _ \\| '__/ __|/ _ \\  `--. \\ '_ \\ / _ \\ / _ \\/ __|\r\n| | | | (_) | |  \\__ \\  __/ /\\__/ / | | | (_) |  __/\\__ \\\r\n\\_| |_/\\___/|_|  |___/\\___| \\____/|_| |_|\\___/ \\___||___/", 44.95m));
            Ascii.AsciiProductsList.Add(new Ascii("                           /  \\_. _|__,/  \\\r\n                          /  )\\        )\\_ \\\r\n                         / _/  (   '  ) /  /\r\n                        / |     (_____) | /\r\n                       /,'      /     \\/ /,\r\n                     _/(_      (   ._, )-'\r\n                    `--,/      |____|__|\r\n                               |    )  |\r\n                               |   /   |\r\n                               |  / \\  |", 19.98m));


            bool newCustomer = true;
            while (newCustomer)
            {
                Product.PrintProducts();

                bool goOn = true;
                while (goOn)
                {
                    ProductsPurchased.OrderProduct();
                    goOn = Validator.Continue("Do you want to order something else");
                }
                decimal grandTotal = ProductsPurchased.DisplayReceipt();
                ProductsPurchased.PayReceipt(grandTotal);

                DailySales.FetchShoppingCart();
                ProductsPurchased.ShoppingCart.Clear();

                newCustomer = Validator.Continue("Start a new order");
            }
        }
    }
}