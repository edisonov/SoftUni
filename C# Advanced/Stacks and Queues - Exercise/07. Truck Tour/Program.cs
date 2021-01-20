using System;
using System.Collections.Generic;
using System.Linq;

namespace _07._Truck_Tour
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Queue<string> pumpNumber = new Queue<string>();

            for (int i = 0; i < n; i++)
            {
               pumpNumber.Enqueue(Console.ReadLine());
            }

            int index = 0;
            int length = pumpNumber.Count;

            for (int i = 0; i < length; i++)
            {
                int totalAmount = 0;
                bool isComleted = true;

                for (int j = 0; j < length; j++)
                {
                    string currentPump = pumpNumber.Dequeue();
                    int[] currentPumpValues = currentPump.Split().Select(int.Parse).ToArray();
                    int currentAmount = currentPumpValues[0];
                    int distance = currentPumpValues[1];

                    totalAmount += currentAmount;

                    if (totalAmount >= distance)
                    {
                        totalAmount -= distance;
                    }
                    else
                    {
                        isComleted = false;
                    }

                    pumpNumber.Enqueue(currentPump);
                }

                if (isComleted)
                {
                    index = i;
                    break;
                }

                pumpNumber.Enqueue(pumpNumber.Dequeue());
            }

            Console.WriteLine(index);
        }
    }
}
