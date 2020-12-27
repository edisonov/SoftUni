using System;
using System.Linq;

namespace _04._Fold_and_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int k = arr.Length / 4;
            int[] midArr = new int[2 * k];
            int[] upperArr1 = new int[k];
            int[] upperArr2 = new int[k];
            int[] sumArr = new int[2 * k];

            // defining the lower row
            for (int i = 0; i < 2 * k; i++)
            {
                midArr[i] = arr[i + k];
            }
            //defining the upper row
            //first half
            for (int i = 0; i < k; i++)
            {
                upperArr1[i] = arr[i];
            }
            upperArr1 = upperArr1.Reverse().ToArray();

            // second half
            for (int i = 0; i < k; i++)
            {
                upperArr2[i] = arr[3 * k + i];
            }
            upperArr2 = upperArr2.Reverse().ToArray();

            // combining the first and the second half
            int[] combined = upperArr1.Concat(upperArr2).ToArray();

            // getting the sum of the arrays
            for (int i = 0; i < 2 * k; i++)
            {
                sumArr[i] = combined[i] + midArr[i];
            }

            Console.WriteLine(string.Join(" ", sumArr));
        }
    }
}
