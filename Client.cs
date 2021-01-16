using System;
using System.Collections.Generic;
using System.Text;

namespace CarWash
{
    class Client: Person,IComparable<Client> // интерфейс имеет обобщенную версию, поэтому передаем тип Client для удобства
    {
        private Sex sex;
        public DateTime TimeVisit;
        private string fio;
        public int SpentMoney = 0;
        public int BuyServiceCount = 0;


        //свойство класса Client - нужен для проверки
        public new string FIO // использовали сокрытие т.к быстрее, и нам не надо менять все свойство
        {
            //читает
            get
            {
                try // использовали проверку на исключение
                {
                    if (this.sex == Sex.Male) return "Уважаемый клиент, " + fio + " потратил сумму: ";
                    else if (this.sex == Sex.Female) return "Уважаемая клиентка, " + fio + " потратила сумму: ";
                    else throw new Exception("В Person->Sex есть лишний пол!"); //использовали исключение, чтобы если что прекратить работу
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


        //сортируем клиентов по принципу
        public int CompareTo(Client clients)
        {
            if (this.BuyServiceCount == clients.BuyServiceCount) return this.Age.CompareTo(clients.Age);
            else return this.BuyServiceCount.CompareTo(clients.BuyServiceCount);
        }
    }
}
