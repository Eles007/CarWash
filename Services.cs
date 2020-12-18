using System;
using System.Collections.Generic;
using System.Text;

namespace CarWash
{
    class Services
    {
        public int Price;
        public DateTime Time;
        public Employee Employee;
        public Client Client;
        public Services(Employee employee, Client client, DateTime time)
        {
            Time = time;
            Employee = employee;
            Client = client;
        }
        public void DoService()
        {
            Employee.WorkCount++;
            Client.SpentMoney += Price;
            Client.BuyServiceCount++;
        }
        public void ComplexWashing()
        {
            Price = 600;
            
        }
        public void InteriorCleaning()
        {
            Price = 250;
        }
        public void DryCleaningFull()
        {
            Price = 4000;
        }
        public void Drying()
        {
            Price = 100;
        }
    }
}
