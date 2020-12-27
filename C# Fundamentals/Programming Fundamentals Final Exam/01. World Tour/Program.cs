using System;

namespace _01._World_Tour
{
    class Program
    {
        static void Main(string[] args)
        {
            string travel = Console.ReadLine();
            string command = Console.ReadLine();

            while (command != "Travel")
            {
                string[] split = command.Split(':');

                switch (split[0])
                {
                    case "Add Stop":
                        int index = int.Parse(split[1]);
                        string insertWord = split[2];

                        if (index >= 0 && index < travel.Length)
                        {
                            travel = travel.Insert(index, insertWord);
                        }
                            Console.WriteLine(travel);
                        break;
                    case "Remove Stop":
                        int startIndex = int.Parse(split[1]);
                        int endIndex = int.Parse(split[2]);

                        if (startIndex >= 0 && startIndex < travel.Length && endIndex >= 0 && endIndex < travel.Length)
                        {
                            travel = travel.Remove(startIndex, endIndex - startIndex + 1);
                        }
                            Console.WriteLine(travel);
                        break;
                    case "Switch":
                        string oldString = split[1];
                        string newString = split[2];
                        if (travel.Contains(oldString))
                        {
                            travel = travel.Replace(oldString, newString);
                        }
                            Console.WriteLine(travel);
                        break;
                }

                command = Console.ReadLine();
            }

            Console.WriteLine($"Ready for world tour! Planned stops: {travel}");
        }
    }
}
