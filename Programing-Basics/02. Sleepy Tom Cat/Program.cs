using System;

namespace _02._Sleepy_Tom_Cat
{
    class Program
    {
        static void Main(string[] args)
        {
            int freeDay = int.Parse(Console.ReadLine());

            double totalfreeDay = freeDay * 127;
            double workDay = (365 - freeDay) * 63;
            double total = totalfreeDay + workDay;
            double horse = 0;
            double minute = 0;

            if (30000 > total)
            {
                total = 30000 - total;
                horse = Math.Floor(total / 60);
                minute = total % 60;
                Console.WriteLine("Tom sleeps well");
                Console.WriteLine($"{horse} hours and {minute} minutes less for play");
            }
            else
            {
                total = total - 30000;
                horse = Math.Floor(total / 60);
                minute = total % 60;
                Console.WriteLine("Tom will run away");
                Console.WriteLine($"{horse} hours and {minute} minutes more for play");
            }
        }
    }
}
