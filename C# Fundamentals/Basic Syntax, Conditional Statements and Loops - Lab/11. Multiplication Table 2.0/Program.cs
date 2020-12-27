using System;

namespace _11._Multiplication_Table_2._0
{
    class Program
    {
        static void Main(string[] args)
        {

            int n = int.Parse(Console.ReadLine());
            int theInteger = int.Parse(Console.ReadLine());

            for (int i = theInteger; i <= 10; i++)
            {
                Console.WriteLine($"{n} X {i} = {n * i}");
            }
            if (theInteger > 10)
            {
                Console.WriteLine($"{n} X {theInteger} = {n * theInteger}");
            }

        }
    }
}
