using System;
using System.Collections.Generic;

namespace _01._Count_Chars_in_a_String
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] input = Console.ReadLine().ToCharArray();

            Dictionary<char, int> occurence = new Dictionary<char, int>();

            foreach (var item in input)
            {
                if (item != ' ')
                {
                    if (!occurence.ContainsKey(item))
                    {
                        occurence.Add(item, 0);
                    }
                    occurence[item]++;
                }
            }

            foreach (var c in occurence)
            {
                char key = c.Key;
                int value = c.Value;
                Console.WriteLine($"{key} -> {value}");
            }
        }
    }
}
