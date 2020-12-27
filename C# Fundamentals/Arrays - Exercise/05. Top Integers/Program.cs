using System;
using System.Linq;

namespace _05._Top_Integers
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            Напишете програма, за да намерите всички най-големи цели числа в масив. 
            Горе цяло число е цяло число, което е по-голямо от всички елементи вдясно.
            */
            int[] arr = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            bool isBigger = true;

            for (int i = 0; i < arr.Length; i++)
            {
                int currentInt = arr[i];
                for (int j = i + 1; j < arr.Length; j++)
                {
                    if (arr[j] >= currentInt)
                    {
                        isBigger = false;
                        break;
                    }
                }

                if (isBigger)
                {
                    Console.Write(currentInt + " ");
                }

                isBigger = true;
            }
        }
    }
}
