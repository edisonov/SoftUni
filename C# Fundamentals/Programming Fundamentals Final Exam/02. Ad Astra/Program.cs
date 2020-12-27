using System;
using System.Linq;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace _02._Ad_Astra
{
    class Program
    {
        static void Main(string[] args)
        {

            string pattern = @"(#|[|])([A-Za-z"" ""]+)\1([0-9]*\/[0-9]*\/[0-9]*)\1([0-9]+)\1";
            string message = Console.ReadLine();
            MatchCollection matches = Regex.Matches(message, pattern);

            int sum = 0;
            int caloryDay = 2000;

            foreach (Match item in matches)
            {
                sum += int.Parse(item.Groups[4].ToString());
            }

            int day = sum / caloryDay;
            Console.WriteLine($"You have food to last you for: {day} days!");

            foreach (Match item in matches)
            {
                Console.WriteLine($"Item: {item.Groups[2]}, Best before: {item.Groups[3]}, Nutrition: {item.Groups[4]}");
            }



        }
    }
}
