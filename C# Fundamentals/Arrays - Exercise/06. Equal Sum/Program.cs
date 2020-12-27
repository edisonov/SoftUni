using System;
using System.Linq;

namespace _06._Equal_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            Напишете програма, която определя дали в масива съществува елемент, 
            така че сумата от елементите вляво да е равна на сумата от елементите вдясно
            (никога няма да има повече от 1 елемент от този).
            Ако няма елементи отляво / отдясно, тяхната сума се счита за 0.
            Отпечатайте индекса, който отговаря на необходимото условие, или "не", ако няма такъв индекс.
            */
            int[] arr = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            for (int i = 0; i < arr.Length; i++)
            {
                int rightSum = 0;
                int leftSum = 0;

                for (int j = 0; j < i; j++)
                {
                    leftSum += arr[j];
                }

                for (int k = i + 1; k < arr.Length; k++)
                {
                    rightSum += arr[k];
                }

                if (rightSum == leftSum)
                {
                    Console.WriteLine(i);
                    return;
                }
            }
            Console.WriteLine("no");
            
        }
    }
}
