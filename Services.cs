using System;
using System.Collections.Generic;
using System.Text;

namespace CarWash
{
    class Services
    {
        public Employee Employee;
        public Client Client;
        public Service Service;
        public Services(Employee employee, Client client, Service service)
        {
            Employee = employee;
            Client = client;
            Service = service;

            Employee.WorkCount++;
            Client.SpentMoney += Service.Price;
            Client.BuyServiceCount++;
        }
    }
}
