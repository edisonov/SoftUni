using System;
using System.Linq;

namespace _02._Array_Modifier
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbars = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            string command = Console.ReadLine();

            while (command != "end")
            {
                string[] cmdArgs = command.Split();

                if (cmdArgs[0] == "swap")
                {
                    int firstIndex = int.Parse(cmdArgs[1]);
                    int seconIndex = int.Parse(cmdArgs[2]);

                    int moveIndex = numbars[firstIndex];
                    numbars[firstIndex] = numbars[seconIndex];
                    numbars[seconIndex] = moveIndex;
                }
                else if (cmdArgs[0] == "multiply")
                {
                    int firstIndex = int.Parse(cmdArgs[1]);
                    int seconIndex = int.Parse(cmdArgs[2]);

                    numbars[firstIndex] *= numbars[seconIndex];
                }
                else if (cmdArgs[0] == "decrease")
                {
                    for (int i = 0; i < numbars.Length; i++)
                    {
                        numbars[i] -= 1;
                    }
                }

                command = Console.ReadLine();
            }

            Console.WriteLine(string.Join(", ", numbars));
        }
    }
}
