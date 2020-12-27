using System;

namespace _07._World_Swimming_Record
{
    class Program
    {
        static void Main(string[] args)
        {
            double record = double.Parse(Console.ReadLine());
            double meters = double.Parse(Console.ReadLine());
            double time = double.Parse(Console.ReadLine());

            double timeMeters = meters * time;
            double slow = Math.Floor(meters / 15) * 12.5;
            double totalTime = timeMeters + slow;

            if (totalTime < record)
            {
                Console.WriteLine($" Yes, he succeeded! The new world record is {totalTime:f2} seconds.");
            }
            else
            {
                double rzhod = totalTime - record;
                Console.WriteLine($"No, he failed! He was {rzhod:f2} seconds slower.");
            }


        }
    }
}
