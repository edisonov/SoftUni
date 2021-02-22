using System;

namespace _02._Recursive_Factorial
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int n = 5;

            long fact = Factorial(n);

            Console.WriteLine($"{n}! = {fact}");
        }

        public static long Factorial(int n)
        {
            if (n == 1)
            {
                return 1;
            }

            return n * Factorial(n - 1);
        }
    }
}
