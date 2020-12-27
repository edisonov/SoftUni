using System;

namespace _07._Max_Sequence_of_Equal_Elements
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            Напишете програма, която намира най-дългата последователност от равни елементи в масив от цели числа.
            Ако съществуват няколко най-дълги последователности, отпечатайте най-лявата.
            */
            string[] arr = Console.ReadLine().Split();

            int maxLength = 0;
            int length = 1;

            int start = 0;
            int bestStart = 0;

            for (int i = 1; i < arr.Length; i++)
            {
                if (arr[i] == arr[i - 1])
                {
                    length++;
                }
                else
                {
                    length = 1;
                    start = i;
                }

                if (length > maxLength)
                {
                    maxLength = length;
                    bestStart = start;
                }
            }

            for (int i = bestStart; i < bestStart + maxLength; i++)
            {
                Console.Write(arr[i] + " ");
            }
        }
    }
}
