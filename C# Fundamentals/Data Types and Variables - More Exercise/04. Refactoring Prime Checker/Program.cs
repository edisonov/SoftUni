using System;

namespace _04._Refactoring_Prime_Checker
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());

            for (int num = 2; num <= number; num++)
            {
                bool isSpecial = true;
                for (int num1 = 2; num1 < num; num1++)
                {
                    if (num % num1 == 0)
                    {
                        isSpecial = false;
                        break;
                    }
                }
                Console.WriteLine("{0} -> {1}",num , isSpecial.ToString().ToLower());
            }

        }
    }
}
