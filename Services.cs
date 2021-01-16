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
        //записали в коструктор т.к оно выполняется при вызове экземпляра Services
        //и плюс к этому тут по сути инкременты и писать в метод тупо
            Employee.WorkCount++;
            Client.SpentMoney += Service.Price;
            Client.BuyServiceCount++;
        }
    }
}
