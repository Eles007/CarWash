using System;

namespace CarWash
{
    class Program
    {
        static int CountClientOnInterval(Client[] Base, DateTime Start, DateTime Finish)
        {
            var start = Start.ToBinary();
            var finish = Finish.ToBinary();
            int count = 0;
            for (int i = 0; i < Base.Length; i++)
            {
                var time = Base[i].TimeVisit.ToBinary();
                if (time >= start && time <= finish)
                {
                    count++;
                }
            }

            return count;
        }
        static void Main(string[] args)
        {
            Client[] clientBase = { new Client("Самый старый человек", "male", 99, new DateTime(2020, 7, 24)),
            new Client("Старый человек", "male", 70, new DateTime(2020, 7, 25)),
            new Client("Молодая девушка", "female", 20, new DateTime(2020, 7, 25)),
            new Client("Молодой парень", "male", 20, new DateTime(2020, 7,26)),
            new Client("Женщина, с купленной одной услугой", "female", 30, new DateTime(2020, 7, 26)),
            new Client("Женщина с двумя купленными услугами", "female", 40, new DateTime(2020, 7, 27)),
            };
            for (int i = 0; i < clientBase.Length; i++)
            {
                Console.WriteLine(clientBase[i].FIO);
            }
        }
    }
}
