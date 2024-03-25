using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KassasysteemMetWinforms.Models
{
    public class Basket
    {
        public int Id { get; set; }
        public int CustomerId { get; set; }
        public List<Product> Products { get; set; }

        public Basket(int customerid, List<Product> products)
        {
            CustomerId = customerid;
            Products = products;
        }
    }
}
