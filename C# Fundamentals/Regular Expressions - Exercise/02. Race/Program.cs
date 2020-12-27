using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace _02._Race
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] listOfPeoples = Console.ReadLine().Split(", ");

            Dictionary<string, int> dictionaryName = new Dictionary<string, int>();

            foreach (var name in listOfPeoples)
            {
                dictionaryName.Add(name, 0);
            }

            string namePattern = @"[\W\d]";
            string numberPattern = @"[\WA-Za-z]";

            string input = Console.ReadLine();

            while (input != "end of race")
            {
                string name = Regex.Replace(input, namePattern, "");
                string distance = Regex.Replace(input, numberPattern, "");
                int sum = 0;

                foreach (var item in distance)
                {
                    int currentDigit = int.Parse(item.ToString());
                    sum += currentDigit;
                }

                if (dictionaryName.ContainsKey(name))
                {
                    dictionaryName[name] += sum;
                }

                input = Console.ReadLine();
            }

            int count = 1;

            foreach (var item in dictionaryName.OrderByDescending(x=>x.Value))
            {
                string text = count == 1 ? "st" : count == 2 ? "nd" : "rd";

                Console.WriteLine($"{count++}{text} place: {item.Key}");

                if (count == 4)
                {
                    break;
                }
            }
        }
    }
}
