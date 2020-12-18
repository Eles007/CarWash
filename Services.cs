using System;
using System.Collections.Generic;
using System.Text;

namespace CarWash
{
    class Services:Service
    {
        public ComplexWashing (Employee employee, Client client, DateTime time) : base(employee, client, time)
        {
            Price = 600;
        }
        public InteriorCleaning(Employee employee, Client client, DateTime time) : base(employee, client, time)
        {
            Price = 250;
        }
        public DryCleaningFull(Employee employee, Client client, DateTime time) : base(employee, client, time)
        {
            Price = 4000;
        }
        public Drying(Employee employee, Client client, DateTime time) : base(employee, client, time)
        {
            Price = 100;
        }
    }
}
