using System;
using System.Collections.Generic;

namespace _6._Supermarket
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue<string> name = new Queue<string>();
            var command = string.Empty;

            while ((command = Console.ReadLine()) != "End")
            {
                if (command == "Paid")
                {
                    Console.WriteLine(string.Join(Environment.NewLine, name));
                    name.Clear();
                    continue;
                }

                name.Enqueue(command);
               
            }

            Console.WriteLine($"{name.Count} people remaining.");
        }
    }
}
