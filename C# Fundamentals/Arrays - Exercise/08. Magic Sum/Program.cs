﻿using System;
using System.Linq;

namespace _08._Magic_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            Напишете програма, която отпечатва всички уникални двойки в масив от цели числа,
                чиято сума е равна на дадено число.
            */
            int[] arr = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();
            int number = int.Parse(Console.ReadLine());

            for (int i = 0; i < arr.Length; i++)
            {
                int firstNumber = arr[i];

                for (int j = i + 1; j < arr.Length; j++)
                {
                    int seconNumber = arr[j];

                    if (firstNumber + seconNumber == number)
                    {
                        Console.WriteLine($"{firstNumber} {seconNumber}");
                        break;
                    }
                }
            }
        }
    }
}
