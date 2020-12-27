using System;
using System.Linq;

namespace _03._Zig_Zag_Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             
            Напишете програма, която създава 2 масива. Ще ви бъде дадено цяло число n. 
            На следващите n реда получавате 2 цели числа. Формирайте масиви 2, както е показано по-долу.
             */
            int n = int.Parse(Console.ReadLine());

            string[] firstArray = new string[n];
            string[] secondArray = new string[n];

            for (int i = 0; i < n; i++)
            {
                string[] currentArray = Console.ReadLine()
                    .Split()
                    .ToArray();
                string firstElement = currentArray[0];
                string secondElement = currentArray[1];

                if (i % 2 == 0)
                {
                    firstArray[i] = firstElement;
                    secondArray[i] = secondElement;
                }
                else if(i % 2 == 1)
                {
                    firstArray[i] = secondElement;
                    secondArray[i] = firstElement;
                }
            }
            Console.WriteLine(string.Join(" " , firstArray));
            Console.WriteLine(string.Join(" " , secondArray));
        }
    }
}
