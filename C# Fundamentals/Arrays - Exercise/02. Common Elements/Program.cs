using System;
using System.Linq;

namespace _02._Common_Elements
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * 
            Напишете програма, която отпечатва общи елементи в два масива.
            Трябва да сравните елементите на втория масив с елементите на първия.
             */
            string[] arr1 = Console.ReadLine().Split();
            string[] arr2 = Console.ReadLine().Split();

            foreach (var element in arr2)
            {
                for (int i = 0; i < arr1.Length; i++)
                {
                    if (element == arr1[i])
                    {
                        Console.Write(element + " ");
                        break;
                    }
                }
            }
        }
    }
}
