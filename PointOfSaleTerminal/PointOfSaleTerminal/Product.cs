using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PointOfSaleTerminal
{
    class Product
    {
        public string Name { get; set; }    
        public string Category { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public static List<Product> ProductsList=new List<Product>();

        public Product(string Name, string Category, string Description, decimal Price) 
        {
            this.Name = Name;
            this.Category = Category;
            this.Description = Description;
            this.Price = Price;
        }

        public override string ToString()
        {
            return String.Format("{0}{}{}{}")
        }

    }
}
