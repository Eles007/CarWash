using System;

namespace CarWash
{
    class Program
    {
        static void Main(string[] args)
        {
            Client[] clientBase = { new Client("Федор 67 лет", "male", 67, new DateTime(2020, 7, 24)),
            new Client("Алексей 54 года", "male", 54, new DateTime(2020, 7, 25)),
            new Client("Анфиса 20 лет", "female", 20, new DateTime(2020, 7, 25)),
            new Client("Денис 20 лет", "male", 20, new DateTime(2020, 7,26)),
            new Client("Елена 34 года", "female", 34, new DateTime(2020, 7, 26)),
            new Client("Мария 46 года", "female", 46, new DateTime(2020, 7, 27)),
            };
            Employee[] emp = { new Employee("Алексей Варунов Сергеевич"),
                               new Employee("Фемур Глазастый Вандалович") };
            var rand1 = new Random();
            var rand2 = new Random();
            var rand3 = new Random();
            //рандомно выполняем услуги 
            for (int i = 0; i < 40; i++)
            {
                //рандом работников, клиентов и чисел
                int Num = rand1.Next(0, 100);
                int j = rand2.Next(0, 6);
                int e = rand3.Next(0, 2);

                Services clt = new Services(emp[e], clientBase[j], new DateTime()); // каждый раз объевляем другого клиента
               
                if (Num <= 25)
                {
                    clt.ComplexWashing();
                }
                if (25 <= Num && Num <= 50)
                {
                    clt.InteriorCleaning();
                }
                if (50 <= Num && Num <= 75)
                {
                    clt.DryCleaningFull();
                }
                if (75 <= Num && Num <= 100)
                {
                    clt.Drying();
                }
                clt.DoService();
            }
            Array.Sort(clientBase);// сортируем по CompareTo -> после этого список уже отсортируем
            int count = 0;
            DateTime start = new DateTime(2020, 7, 25);
            DateTime finish = new DateTime(2020, 7, 26);
            for (int i = 0; i < clientBase.Length; i++)
            {
                DateTime time = clientBase[i].TimeVisit;
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
             for(int i = 0; i< clientBase.Length; i++)
             {
                    Console.WriteLine($"{clientBase[i].FIO} потратил(а) сумму: {clientBase[i].SpentMoney}");
             }
        }
    }
}
