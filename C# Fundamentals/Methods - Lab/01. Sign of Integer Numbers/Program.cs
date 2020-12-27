using System;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;

namespace _01._Sign_of_Integer_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            Numbar(int.Parse(Console.ReadLine()));
            
        }

        static void Numbar (int sing)
        {
            if (sing > 0)
            {
                Console.WriteLine($"The number {sing} is positive.");
            }
            else if (sing < 0)
            {
                Console.WriteLine($"The number {sing} is negative.");
            }
            else if (sing == 0)
            {
                Console.WriteLine($"The number {sing} is zero.");
            }
            Consol);
        }
    }
}
