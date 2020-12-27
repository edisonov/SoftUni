﻿using System;

namespace _01._Day_of_Week
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] days = new string[] 
            {
                "Monday", 
                "Tuesday",
                "Wednesday", 
                "Thursday",
                "Friday", 
                "Saturday",
                "Sunday"
            };
            int number = int.Parse(Console.ReadLine());
            if (number < 1 || number > days.Length)
            {
                Console.WriteLine("Invalid day!");
            }
            else
            {
                Console.WriteLine(days[number - 1]);
            }
        }
    }
}
