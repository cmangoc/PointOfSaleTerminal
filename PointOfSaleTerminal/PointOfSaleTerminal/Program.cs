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

            Ascii.AsciiProductsList.Add(new Ascii(" ______                    _ \r\n| ___ \\                  | |\r\n| |_/ /_ __ ___  __ _  __| |\r\n| ___ \\ '__/ _ \\/ _` |/ _` |\r\n| |_/ / | |  __/ (_| | (_| |\r\n\\____/|_|  \\___|\\__,_|\\__,_| ", 4.99m));
            Ascii.AsciiProductsList.Add(new Ascii(" _____ _     _           \r\n/  __ \\ |   (_)          \r\n| /  \\/ |__  _ _ __  ___ \r\n| |   | '_ \\| | '_ \\/ __|\r\n| \\__/\\ | | | | |_) \\__ \\\r\n \\____/_| |_|_| .__/|___/\r\n              | |        \r\n              |_|         ", 4.99m));
            Ascii.AsciiProductsList.Add(new Ascii(" _____                   _    ______     _        _        \r\n/  ___|                 | |   | ___ \\   | |      | |       \r\n\\ `--.__      _____  ___| |_  | |_/ /__ | |_ __ _| |_ ___  \r\n `--. \\ \\ /\\ / / _ \\/ _ \\ __| |  __/ _ \\| __/ _` | __/ _ \\ \r\n/\\__/ /\\ V  V /  __/  __/ |_  | | | (_) | || (_| | || (_) |\r\n\\____/  \\_/\\_/ \\___|\\___|\\__| \\_|  \\___/ \\__\\__,_|\\__\\___/ ", 0.99m));
            Ascii.AsciiProductsList.Add(new Ascii("______            __ \r\n| ___ \\          / _|\r\n| |_/ / ___  ___| |_ \r\n| ___ \\/ _ \\/ _ \\  _|\r\n| |_/ /  __/  __/ |  \r\n\\____/ \\___|\\___|_|  ", 35.00m));
            Ascii.AsciiProductsList.Add(new Ascii(" _   _       _       _                 _    \r\n| \\ | |     | |     | |               | |   \r\n|  \\| | ___ | |_ ___| |__   ___   ___ | | __\r\n| . ` |/ _ \\| __/ _ \\ '_ \\ / _ \\ / _ \\| |/ /\r\n| |\\  | (_) | ||  __/ |_) | (_) | (_) |   < \r\n\\_| \\_/\\___/ \\__\\___|_.__/ \\___/ \\___/|_|\\_\\", 0.99m));
            Ascii.AsciiProductsList.Add(new Ascii("______ _           _           \r\n| ___ (_)         | |          \r\n| |_/ /_ _ __   __| | ___ _ __ \r\n| ___ \\ | '_ \\ / _` |/ _ \\ '__|\r\n| |_/ / | | | | (_| |  __/ |   \r\n\\____/|_|_| |_|\\__,_|\\___|_|   ", 4.69m));
            Ascii.AsciiProductsList.Add(new Ascii("______               _ _     \r\n| ___ \\             (_) |    \r\n| |_/ /__ _ __   ___ _| |___ \r\n|  __/ _ \\ '_ \\ / __| | / __|\r\n| | |  __/ | | | (__| | \\__ \\\r\n\\_|  \\___|_| |_|\\___|_|_|___/ ", 8.99m));
            Ascii.AsciiProductsList.Add(new Ascii(" ______ _            _     ______          \r\n| ___ \\ |          | |    | ___ \\         \r\n| |_/ / | __ _  ___| | __ | |_/ /__ _ __  \r\n| ___ \\ |/ _` |/ __| |/ / |  __/ _ \\ '_ \\ \r\n| |_/ / | (_| | (__|   <  | | |  __/ | | |\r\n\\____/|_|\\__,_|\\___|_|\\_\\ \\_|  \\___|_| |_|", 449.99m));
            Ascii.AsciiProductsList.Add(new Ascii("_                                         _____ _   _      _    \r\n| |                                       /  ___| | (_)    | |   \r\n| |     __ _  ___ _ __ ___  ___ ___  ___  \\ `--.| |_ _  ___| | __\r\n| |    / _` |/ __| '__/ _ \\/ __/ __|/ _ \\  `--. \\ __| |/ __| |/ /\r\n| |___| (_| | (__| | | (_) \\__ \\__ \\  __/ /\\__/ / |_| | (__|   < \r\n\\_____/\\__,_|\\___|_|  \\___/|___/___/\\___| \\____/ \\__|_|\\___|_|\\_\\", 99.88m));
            Ascii.AsciiProductsList.Add(new Ascii("______           _        _   _           _ _ \r\n| ___ \\         | |      | | | |         | | |\r\n| |_/ / __ _ ___| | _____| |_| |__   __ _| | |\r\n| ___ \\/ _` / __| |/ / _ \\ __| '_ \\ / _` | | |\r\n| |_/ / (_| \\__ \\   <  __/ |_| |_) | (_| | | |\r\n\\____/ \\__,_|___/_|\\_\\___|\\__|_.__/ \\__,_|_|_| ", 15.65m));
            Ascii.AsciiProductsList.Add(new Ascii(" _   _                       _____ _                     \r\n| | | |                     /  ___| |                    \r\n| |_| | ___  _ __ ___  ___  \\ `--.| |__   ___   ___  ___ \r\n|  _  |/ _ \\| '__/ __|/ _ \\  `--. \\ '_ \\ / _ \\ / _ \\/ __|\r\n| | | | (_) | |  \\__ \\  __/ /\\__/ / | | | (_) |  __/\\__ \\\r\n\\_| |_/\\___/|_|  |___/\\___| \\____/|_| |_|\\___/ \\___||___/", 44.95m));
            Ascii.AsciiProductsList.Add(new Ascii("______           _        _   _           _ _ \r\n| ___ \\         | |      | | | |         | | |\r\n| |_/ / __ _ ___| | _____| |_| |__   __ _| | |\r\n| ___ \\/ _` / __| |/ / _ \\ __| '_ \\ / _` | | |\r\n| |_/ / (_| \\__ \\   <  __/ |_| |_) | (_| | | |\r\n\\____/ \\__,_|___/_|\\_\\___|\\__|_.__/ \\__,_|_|_| ", 19.98m));

            Product.PrintProducts();

            bool goOn = true;
            while (goOn)
            {
                ProductsPurchased.OrderProduct();
                goOn = Validator.Continue();
            }
            decimal grandTotal = ProductsPurchased.DisplayReceipt();
            ProductsPurchased.PayReceipt(grandTotal);





        }
    }
}