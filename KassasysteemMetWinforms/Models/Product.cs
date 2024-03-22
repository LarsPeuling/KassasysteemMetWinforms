using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KassasysteemMetWinforms.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
        public int Stock { get; set; }
        public string Description { get; set; }

        public Product(string name, double price, int stock, string? description)
        {
            Name = name;
            Price = price;
            Stock = stock;
            Description = description;
        }
    }
}
