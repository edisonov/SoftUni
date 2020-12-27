using System;
using System.Collections.Generic;
using System.Linq;

namespace _03._Memory_Game
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> element = Console.ReadLine()
                .Split(" ",StringSplitOptions.RemoveEmptyEntries)
                .ToList();

            int count = 0;

            string command = Console.ReadLine();

            while (true)
            {
                if (command == "end")
                {
                    break;
                }

                count++;

                string[] elementCommand = command
                    .Split();
                    
                int firstIndex = int.Parse(elementCommand[0]);
                int secondIndex = int.Parse(elementCommand[1]);

                if (firstIndex >= 0 && secondIndex >= 0 && firstIndex < element.Count && secondIndex < element.Count && firstIndex != secondIndex)
                {
                    if (element[firstIndex] == element[secondIndex])
                    {
                        Console.WriteLine($"Congrats! You have found matching elements - {element[firstIndex]}!");

                        if (firstIndex > secondIndex)
                        {
                            element.RemoveAt(firstIndex);
                            element.RemoveAt(secondIndex);
                        }
                        else
                        {
                            element.RemoveAt(secondIndex);
                            element.RemoveAt(firstIndex);
                        }

                        if (element.Count == 0)
                        {
                            Console.WriteLine($"You have won in {count} turns!");
                            return;
                        }
                    }
                    else if (element[firstIndex] != element[secondIndex])
                    {
                        Console.WriteLine("Try again!");
                    }

                }
                else 
                {
                    element.Insert(element.Count / 2, $"-{count}a");
                    element.Insert(element.Count / 2, $"-{count}a");

                    Console.WriteLine("Invalid input! Adding additional elements to the board");
   
                }

                command = Console.ReadLine();

            }

            Console.WriteLine("Sorry you lose :(");
            Console.WriteLine(string.Join(" ", element));




        }
    }   
}

