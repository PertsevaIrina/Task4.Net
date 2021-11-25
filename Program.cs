using System;

namespace Task4
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            string[] names1 = {"Иванов", "Петров", "Семёнов", "Васильев", "Мишин"};
            string[] names2 = {"Иван", "Пётр", "Семён", "Василий", "Михаил"};
            Random r = new Random();
            for (int i = 0; i < 5; i++)
            {
                Soldier s = new Soldier(names1[r.Next(5)] + " " + names2[r.Next(5)],
                    1f + r.Next(100) / 100f, 50f + r.Next(1000) / 10f);
                Console.WriteLine(s.getInfo());
            }

            for (int i = 0; i < 5; i++)
            {
                Soldier s = new Officer(names1[r.Next(5)] + " " + names2[r.Next(5)],
                    1f + r.Next(100) / 100f, 50f + r.Next(1000) / 10f, (Education)
                    Enum.GetValues(typeof(Education)).GetValue(r.Next(Enum.GetValues(typeof(Education)).Length)));
                Console.WriteLine(s.getInfo());
               
            }
            Console.ReadKey();
        }
        
    }
}