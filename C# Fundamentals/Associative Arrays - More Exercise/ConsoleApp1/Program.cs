using System;
using System.Linq;
using System.Collections.Generic;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, Dictionary<string, int>> softUni = new Dictionary<string, Dictionary<string, int>>();

            string input = Console.ReadLine();

            while (input != "end of submissions")
            {
                var cmdArgs = input.Split(":");
                var contest = cmdArgs[0];
                var password = cmdArgs[1];

                softUni.Add(contest, password);

                input = Console.ReadLine();
            }

            string command = Console.ReadLine();

            while (command != "end of contests")
            {
                var cmdArgs = command.Split("=>");
                var contest = cmdArgs[0];
                var password = cmdArgs[1];
                var username = cmdArgs[2];
                var points = cmdArgs[3];



                command = Console.ReadLine();
            }
        }
    }
}
