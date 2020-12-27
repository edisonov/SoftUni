using System;
using System.Collections.Generic;
using System.Linq;

namespace _03._Numbers
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
               if (num > averige)
               {
                    newNumber.Add(num);
               }
            }

            newNumber.Sort();
            newNumber.Reverse();

            List<int> total = new List<int>();

            for (int i = 0; i < newNumber.Count; i++)
            {
                 
                    total.Add(newNumber[i]);

                    if (total.Count >= 5)
                    {
                        break;
                    }

            }

            Console.WriteLine(string.Join(" ", total));
            
        }
    }
}
