using System;

namespace _02._Bonus_Score
{
    class Program
    {
        static void Main(string[] args)
        {
            int nambar = int.Parse(Console.ReadLine());

            double bonus = 0.0;

            if (nambar <= 100)
            {
                bonus = 5;
            }
            else if (nambar > 1000)
            {
                bonus = nambar * 0.1;
            }
            else
            {
                bonus = nambar * 0.2;
            }
            if (nambar % 2 == 0)
            {
                bonus++;
            }
            else if (nambar % 10 == 5)
            {
                bonus += 2;
            }
            Console.WriteLine(bonus);
            Console.WriteLine(nambar + bonus);
        }
    }
}
