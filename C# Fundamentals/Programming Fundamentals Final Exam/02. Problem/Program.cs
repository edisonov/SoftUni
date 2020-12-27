using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace _02._Problem
{
    class Program
    {
        static void Main(string[] args)
        {
            string pattern = @"U\$([A-Z][a-z]{2,})U[$]P@\$([A-Za-z]{5,}[A-Za-z0-9]*[0-9])P@\$";
            Regex regex = new Regex(pattern);

            int n = int.Parse(Console.ReadLine());
            int count = 0;

            for (int i = 0; i < n; i++)
            {
                string command = Console.ReadLine();

                Match match = regex.Match(command);

                if (match.Success)
                {
                    count++;
                    Console.WriteLine("Registration was successful");
                    Console.WriteLine($"Username: {match.Groups[1]}, Password: {match.Groups[2]}");
                }
                else
                {
                    Console.WriteLine("Invalid username or password");
                }

            }

            Console.WriteLine($"Successful registrations: {count}");

        }
    }
}
