using System;

namespace _12._Even_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            int numbar = int.Parse(Console.ReadLine());

            while (true)
            {

                if (numbar % 2 == 0)
                {
                    Console.WriteLine($"The number is: {Math.Abs(numbar)}");
                    return;
                }
                else
                {
                    Console.WriteLine("Please write an even number.");
                    numbar = int.Parse(Console.ReadLine());
                }
            }
        }
    }
}
