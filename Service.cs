using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarWash
{
    class Service
    {
        public string Name;
        public int Price;
        public Service(int price, string name)
        {
            Name = name;
            Price = price;
        }
    }
}
