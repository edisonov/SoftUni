using System;

namespace _07._Invalid_Number12
{
    class Program
    {
        static void Main(string[] args)
        {
           int num = int.Parse(Console.ReadLine());

            if (num < 100 || num > 200)
            {
                if (num != 0)
                {
                    Console.WriteLine("invalid");
                }
            }
        }
    }
}
