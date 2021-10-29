using System;
using System.Linq;

namespace demo1
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split(", ")
                .Select(int.Parse)
                .ToList();
            var index = int.Parse(Console.ReadLine());
            var command = Console.ReadLine();

           
                if (command == "cheap")
                {
                    if (input[index - 1] == input[index + 1])
                    {
                        Console.WriteLine($"Left - {input[index - 1]}");
                    }

                    if (input[index - 1] > input[index + 1])
                    {
                        Console.WriteLine($"Right - {input[index + 1]}");
                    }
                    else
                    {
                        Console.WriteLine($"Left - {input[index - 1]}");
                    }
                }
                else
                {
                    if (input[index - 1] == input[index + 1])
                    {
                        Console.WriteLine($"Left - {input[index - 1]}");
                    }

                    if (input[index - 1] > input[index + 1])
                    {
                        int sum = 0;
                        for (int i = 0; i < input.Count; i++)
                        {
                            
                            if (i == index)
                            {
                                break;
                            }

                            sum += input[i];
                        }

                        Console.WriteLine($"Left - {sum}");
                    }
                    else
                    {
                        int sum = 0;

                        for (int i = index + 1; i < input.Count; i++)
                        {
                            sum += input[i];
                        }
                        Console.WriteLine($"Right - {sum}");
                    }
                }
                
            
        }
    }
}
