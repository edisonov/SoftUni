using System;
using System.Collections.Generic;
using System.Linq;

namespace _01._Count_Same_Values_in_Array
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] number = Console.ReadLine().Split().Select(double.Parse).ToArray();

            Dictionary<double, int> times = new Dictionary<double, int>();


            for (int i = 0; i < number.Length; i++)
            {
                if (!times.ContainsKey(number[i]))
                {
                    times.Add(number[i], 0);
                } 
                
                times[number[i]] ++;
                
            }

            foreach (var time in times)
            {
                Console.WriteLine($"{time.Key} - {time.Value} times");
            }
        }
    }
}
