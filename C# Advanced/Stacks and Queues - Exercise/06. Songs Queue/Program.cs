using System;
using System.Collections.Generic;
using System.Linq;

namespace _06._Songs_Queue
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] songs = Console.ReadLine().Split(", ").ToArray();
            Queue<string> nameSongs = new Queue<string>(songs);

            while (nameSongs.Count > 0)
            {
                var input = Console.ReadLine();
                var cmdArgs = input.Split();
                string command = cmdArgs[0];

                if (command == "Play")
                {
                    nameSongs.Dequeue();
                }
                else if (command == "Add")
                {
                    string song = input.Substring(command.Length + 1);
                    if (!nameSongs.Contains(song))
                    {
                        nameSongs.Enqueue(song);
                    }
                    else
                    {
                        Console.WriteLine($"{song} is already contained!");
                    }
                }
                else if (command == "Show")
                {
                    Console.WriteLine(string.Join(", ", nameSongs));
                }
            }

            Console.WriteLine("No more songs!");
        }
    }
}
