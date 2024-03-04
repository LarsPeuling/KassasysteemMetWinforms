using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KassasysteemMetWinforms.Models
{
    public class Customer : User
    {
        public int Id { get; set; }
        public Basket Basket { get; set; }
    }
}
