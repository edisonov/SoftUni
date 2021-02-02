using System;
using System.Collections.Generic;
using System.Linq;

namespace _06._Reverse_And_Exclude
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> number = Console.ReadLine().Split().Select(int.Parse).ToList();
            int n = int.Parse(Console.ReadLine());

            number.Reverse();

            Func<int, bool> predicate = num => num % n != 0;

            number = number.Where(predicate).ToList();

            Action<List<int>> print = num => Console.WriteLine(string.Join(" ", num));

            print(number);
        }
    }
}
