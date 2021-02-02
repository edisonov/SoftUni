using System;
using System.Collections.Generic;
using System.Linq;

namespace _04._Find_Evens_or_Odds
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] ranges = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int start = ranges[0];
            int end = ranges[1];
            string crtitry = Console.ReadLine();

            Func<int, int, List<int>> generateNamesOfNums = (start, end) =>
            {
                List<int> nums = new List<int>();

                for (int i = start; i <= end; i++)
                {
                    nums.Add(i);
                }

                return nums;
            };

            List<int> numbers = generateNamesOfNums(start, end);

            Predicate<int> predicate = n => true;

            if (crtitry == "odd")
            {
                predicate = n => n % 2 != 0;
            }
            else if (crtitry == "even")
            {
                predicate = n => n % 2 == 0;
            }

            Console.WriteLine(string.Join(" ", MyWhere(numbers, predicate)));
        }

        static List<int> MyWhere(List<int> numbers, Predicate<int> predicate)
        {
            List<int> newNumber = new List<int>();

            foreach (var number in numbers)
            {
                if (predicate(number))
                {
                    newNumber.Add(number);
                }
            }

            return newNumber;
        }
    }
}
