using System;

namespace _12._Refactor_Special_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int numbar = int.Parse(Console.ReadLine());
            
            for (int num = 1; num <= numbar; num++)
            {
                int sum = 0;
                int digits = num;
                
                while (digits > 0)
                {
                    sum += digits % 10;
                    digits = digits / 10;
                }
                bool isSpecial = (sum == 5) || (sum == 7) || (sum == 11);
                Console.WriteLine($"{num} -> {isSpecial}");
                
            }

        }
    }
}
