using System;
using System.Collections.Generic;
using System.Text;

namespace CarWash
{
    class Client: Person,IComparable<Client> // интерфейс имеет обобщенную версию, поэтому передаем тип Client
    {
        private Sex sex;
        public DateTime TimeVisit;
        private string fio;
        public int SpentMoney = 0;
        public int BuyServiceCount = 0;


        //свойство класса Client - нужен для проверки
        public new string FIO
        {
            //читает
            get
            {
                try
                {
                    if (Sex.Male == this.sex) return "Уважаемый клиент, " + fio + " потратил сумму: ";
                    else if (Sex.Female == this.sex) return "Уважаемая клиентка, " + fio + " потратила сумму: ";
                    else throw new Exception("В Person->Sex есть лишний пол!");
                }
                catch
                {
                    return "Ошибка:Такого пола нет!";
                }
            }
            //записывает
            set
            {
                fio = value;
            }
        }
        public Client(string fullname, Sex sex, int age, DateTime timeVisit)
        {
            TimeVisit = timeVisit;
            this.sex = sex;
            FIO = fullname;
            Age = age;
        }


        //сортируем клиентов по принципу, кто больше купил - выше, кому больше лет - выше
        public int CompareTo(Client clients)
        {
            if (this.BuyServiceCount == clients.BuyServiceCount) return this.Age.CompareTo(clients.Age);
            else return this.BuyServiceCount.CompareTo(clients.BuyServiceCount);
        }
    }
}
