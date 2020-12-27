using System;
using System.Collections.Generic;
using System.Linq;

namespace _07._Append_Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             
            Напишете програма за добавяне на няколко масива от числа.
            • Масивите са разделени с '|'.
            • Стойностите са разделени с интервали ('', едно или няколко).
            • Подредете масивите от последния към първия и техните стойности отляво надясно.
             */
            List<string> items = Console.ReadLine()
               .Split("|")
               .ToList();

            items.Reverse();

            List<string> result = new List<string>();

            foreach (var itemList in items)
            {
                string[] numbers = itemList
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();

                foreach (var numbersToAdd in numbers)
                {
                    result.Add(numbersToAdd);
                }
            }

            Console.WriteLine(string.Join(" ", result));
        }
    }
}
