using System;
using System.Collections.Generic;

namespace _05._Count_Symbols
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            SortedDictionary<char, int> charText = new SortedDictionary<char, int>();

            foreach (var item in text)
            {
                if (!charText.ContainsKey(item))
                {
                    charText.Add(item, 0);
                }

                charText[item]++;
            }

            foreach (var ch in charText)
            {
                Console.WriteLine($"{ch.Key}: {ch.Value} time/s");
            }
        }
    }
}
