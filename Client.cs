using System;
using System.Collections.Generic;
using System.Text;

namespace CarWash
{
    class Client: IComparable
    {
        public DateTime TimeVisit;
        public string Sex;
        private string fio;
        public int Age;
        public int SpentMoney = 0;
        public int BuyServiceCount = 0;
        public string FIO
        {
            get
            {
                if (Sex == "male")
                {
                    return "Уважаемый клиент, " + fio;
                }
                return "Уважаемая клиентка, " + fio;
            }
            set
            {
                fio = value;
            }
        }
        public Client(string fullname, string sex, int age, DateTime timeVisit)
        {
            TimeVisit = timeVisit;
            Sex = sex;
            FIO = fullname;
            Age = age;
        }
        //сортируем клиентов по принципу, кто больше купил - выше, кому больше лет - выше
        public int CompareTo(object client2)
        {
            Client client3 = (Client)client2;
            if (this.BuyServiceCount > client3.BuyServiceCount)
            {
                return -1;
            }
            else if (this.BuyServiceCount == client3.BuyServiceCount)
            {
                if (this.Age > client3.Age)
                {
                    return -1;
                }
                else if (this.Age == client3.Age)
                {
                    return 0;
                }
                else
                {
                    return 1;
                }
            }
            else
            {
                return 1;
            }
        }
    }
}
