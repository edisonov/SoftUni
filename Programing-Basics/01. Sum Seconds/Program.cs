using System;

namespace _01._Sum_Seconds
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstTime = int.Parse(Console.ReadLine());
            int secondTime = int.Parse(Console.ReadLine());
            int thirdTime = int.Parse(Console.ReadLine());

            int totaltime = firstTime + secondTime + thirdTime;
            int minutes = totaltime / 60;
            int second = totaltime % 60;

            if (second < 10)
            {
                Console.WriteLine($"{minutes}:0{second}");
            }
            else
            {
                Console.WriteLine($"{minutes}:{second}");
            }
        }
    }
}
