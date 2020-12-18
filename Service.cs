using System;
using System.Collections.Generic;
using System.Text;

namespace CarWash
{
    class Service
    {
        public int Price;
        public DateTime Time;
        public Employee Employee;
        public Client Client;
        public Service(Employee employee, Client client, DateTime time)
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
    }
}
