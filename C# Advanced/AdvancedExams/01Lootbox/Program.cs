using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace _01Lootbox
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue<int> firstLine = new Queue<int>(Console.ReadLine()
                .Split().Select(int.Parse));

            Stack<int> secondLine = new Stack<int>(Console.ReadLine()
                .Split().Select(int.Parse));

            int value = 0;

            while (true)
            {
                if (firstLine.Count <= 0)
                {
                    Console.WriteLine("First lootbox is empty");
                    break;
                }
                if (secondLine.Count <= 0)
                {
                    Console.WriteLine("Second lootbox is empty");
                    break;
                }
                int first = firstLine.Peek();
                int second = secondLine.Peek();

                int sum = first + second;

                if (sum % 2 == 0)
                {
                    value += sum;
                    firstLine.Dequeue();
                    secondLine.Pop();
                }
                else
                {
                    firstLine.Enqueue(second);
                    secondLine.Pop();
                }


            }

            if (value >= 100)
            {
                Console.WriteLine($"Your loot was epic! Value: {value}");
            }
            else
            {
                Console.WriteLine($"Your loot was poor... Value: {value}");
            }
        }
    }
}
