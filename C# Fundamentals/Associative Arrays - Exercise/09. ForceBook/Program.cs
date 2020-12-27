using System;
using System.Collections.Generic;

namespace _09._ForceBook
{
    class Program
    {
        static void Main(string[] args)
        {
            var forceUser = new Dictionary<string, List<string>>();

            var input = Console.ReadLine();

            while (input != "Lumpawaroo")
            {
                var cmdArds = input.Split(" ", StringSplitOptions.RemoveEmptyEntries);

                var firstName = cmdArds[0];
                var secondName = cmdArds[2];
                var symbol = cmdArds[1];

                if (symbol == "|")
                {
                    if (!forceUser.ContainsKey(firstName))
                    {
                        forceUser.Add(firstName, new List<string>() { secondName });
                    }
                    else
                    {

                    }
                }
                else
                {

                }

                input = Console.ReadLine();
            }
        }
    }
}
