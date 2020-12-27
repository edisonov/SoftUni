﻿using System;

namespace _04._Array_Rotation
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            Напишете програма, която получава масив и брой завъртания, които трябва да извършите
                (първият елемент отива в края) Отпечатайте получения масив.
            */
            string[] arr = Console.ReadLine()
                .Split();

            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string elementToRotate = arr[0];

                for (int j = 1; j < arr.Length; j++)
                {
                    string currentElement = arr[j];
                    arr[j - 1] = currentElement;
                }
                arr[arr.Length - 1] = elementToRotate;
            }
            Console.WriteLine(string.Join(" ",arr));
        }
    }
}
