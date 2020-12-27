using System;
using System.Collections.Generic;
using System.Linq;

namespace _02._Archery_Tournament
{
    class Program
    {
        static void Main(string[] args)
        {

            int[] target = Console.ReadLine().Split("|").Select(int.Parse).ToArray();

            int point = 0;
            string command = Console.ReadLine();

            // 10 | 10 | 10 | 10 | 10
            // Shoot Left@0@2
            // Shoot Right@4@5
            // Shoot Right@6@5
            // Reverse
            // Game over


            while (command != "Game over")
            {
                string[] arr = command.Split('@');

                string commandArr = arr[0];

                switch (commandArr)
                {
                    case "Shoot Left":
                        int startIndex = int.Parse(arr[1]);
                        int length = int.Parse(arr[2]);

                        if (startIndex >= 0 && startIndex < target.Length)
                        {
                            int move = startIndex + length + 1;

                            if (move > target.Length)
                            {
                                if (target[target.Length - 1] < 5)
                                {
                                    point += target[target.Length - 1];
                                    target[target.Length - 1] = 0;
                                }
                                else
                                {
                                    target[target.Length - 1] -= 5;
                                    point += 5;
                                }
                            }
                            else
                            {
                                if (target[move] < 5)
                                {
                                    point += target[move];
                                    target[move] = 0;
                                }
                                else
                                {
                                    target[move] -= 5;
                                    point += 5;
                                }
                            }
                        }

                        break;
                    case "Shoot Right":

                        int startIndexRight = int.Parse(arr[1]);
                        int lengthRight = int.Parse(arr[2]);

                        if (startIndexRight >= 0 && startIndexRight < target.Length)
                        {
                            int move = startIndexRight - lengthRight - 1;

                            if (move < 0)
                            {
                                
                                if (target[target.Length - 1] < 5)
                                {
                                    point += target[target.Length - 1];
                                    target[target.Length - 1] = 0;
                                }
                                else
                                {
                                    target[target.Length - 1] -= 5;
                                    point += 5;
                                }
                            }
                            else
                            {
                                if (target[move] < 5)
                                {
                                    point += target[move];
                                    target[move] = 0;
                                }
                                else
                                {
                                    target[move] -= 5;
                                    point += 5;
                                }
                            }

                            
                        }
                        break;



                    case "Reverse":

                        for (int i = 0; i < target.Length / 2; i++)
                        {
                            int tmp = target[i];
                            target[i] = target[target.Length - i - 1];
                            target[target.Length - i - 1] = tmp;
                        }
                        break;
                }

                command = Console.ReadLine();
            }

            Console.WriteLine(string.Join(" - ", target));
            Console.WriteLine($"Iskren finished the archery tournament with {point} points!");
        }
    }
}
