using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;

namespace _02._Sets_of_Elements
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int n = input[0];
            int m = input[1];
            HashSet<string> numbersOne = new HashSet<string>();
            HashSet<string> numbersTwo = new HashSet<string>();

            for (int i = 0; i < n; i++)
            {
                string number = Console.ReadLine();
                numbersOne.Add(number);
            }

            for (int i = 0; i < m; i++)
            {
                string number = Console.ReadLine();
                numbersTwo.Add(number);
            }

            foreach (var num in numbersOne)
            {
                if (numbersTwo.Contains(num))
                {
                    Console.Write(num + " ");
                }
            }
        }
    }
}
