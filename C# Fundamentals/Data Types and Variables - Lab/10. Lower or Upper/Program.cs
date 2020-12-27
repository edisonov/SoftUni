using System;

namespace _10._Lower_or_Upper
{
    class Program
    {
        static void Main(string[] args)
        {
            char name = char.Parse(Console.ReadLine());

            if (char.IsLower(name))
            {
                Console.WriteLine("lower-case");
            }
            if (char.IsUpper(name)) 
            {
                Console.WriteLine("upper-case");
            }
        }
    }
}
