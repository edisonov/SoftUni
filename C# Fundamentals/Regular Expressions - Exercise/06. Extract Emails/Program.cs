using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace _06._Extract_Emails
{
    class Program
    {
        static void Main(string[] args)
        {
            string pattern = @"\s([0-9A-Za-z]+(-*|_*|\.*)[0-9a-zA-Z]*@[a-z]+-*[a-z]*(\.[a-z]+)+\b)";

            Regex regex = new Regex(pattern);

            //List<string> email = new List<string>();

            string input = Console.ReadLine();

            MatchCollection validEmail = regex.Matches(input);

            foreach (var item in validEmail)
            {
                Console.WriteLine(item);
            }
        }
    }
}
