using System;
using Sex = CarWash.Client.Sex; // использовали псевдоним для удобства

namespace CarWash
{
    class Program
    {
        static void Main(string[] args)
        {
            Client[] client = { 
                new ("Федор 67 лет", Sex.Male, 67, new (2020, 7, 24)),
                new ("Алексей 54 года", Sex.Male, 54, new (2020, 7, 25)),
                new ("Анфиса 20 лет", Sex.Female, 20, new(2020, 7, 25)),
                new ("Денис 20 лет", Sex.Male, 20, new (2020, 7,26)),
                new ("Елена 34 года", Sex.Female, 34, new (2020, 7, 26)),
                new ("Мария 46 года", Sex.Female, 46, new (2020, 7, 27)),
            };
            Employee[] emp = { 
                new ("Алексей Варунов Сергеевич"),
                new ("Фемур Глазастый Вандалович") 
            };
            Service[] ser = { 
                new (200, "сушка"),
                new (600, "комплексная мойка"),
                new (1600, "химчистка"),
                new (500, "уборка пола")
            }; 
            var rand1 = new Random();
            var rand2 = new Random();
            var rand3 = new Random();
            //рандомно выполняем услуги 
            for (int i = 0; i < 10; i++)
            {
                //рандом работников, клиентов и услуг
                int s = rand1.Next(0, 4);
                int j = rand2.Next(0, 6);
                int e = rand3.Next(0, 2);

                new Services(emp[e], client[j], ser[s]);
            }
            Array.Sort(client);
            Array.Reverse(client);// сортируем по CompareTo -> после этого список уже отсортируем
            int count = 0;
            DateTime start = new (2020, 7, 25);
            DateTime finish = new (2020, 7, 26);
            for (int i = 0; i < client.Length; i++)
            {
                DateTime time = client[i].TimeVisit;
                if (time >= start && time <= finish) //выводит количество посетителей за период
                {
                    count++;
                }
            }
            //вывод
            Console.WriteLine($"Количество посетителей с {start} по {finish}: " + count);
            for(int i = 0; i< emp.Length; i++)
            {
                Console.WriteLine($"Рабочий {emp[i].FIO} выполнил услуг: {emp[i].WorkCount}");
            }
             for(int i = 0; i< client.Length; i++)
             {
                    Console.WriteLine($"{client[i].FIO}{client[i].SpentMoney}, количество услуг: {client[i].BuyServiceCount}");
             }
        }
    }
}
