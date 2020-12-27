using System;
using System.Collections.Generic;
using System.Linq;

namespace demo
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> number = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();

            List<int> newNumber = new List<int>();

            double averige = number.Average();

            foreach (var num in number)
            {
                if (num > averige && newNumber.Count <= 5)
                {
                    int max = number.Max();
                    newNumber.Add(max);
                    number[num] = 1;
                }
            }


            Console.WriteLine(string.Join(" ", newNumber.OrderByDescending(x => x)));

        }
    }
}
