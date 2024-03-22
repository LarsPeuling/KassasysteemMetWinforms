using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KassasysteemMetWinforms.Models
{
    public class Employee : User
    {
        public int Id { get; set; }
        private string _name;
        public override string Name
        {
            get => _name;
            set => _name = value;
        }
       
        public Employee(string name)
        {
            Name = name;
        }
    }
}
