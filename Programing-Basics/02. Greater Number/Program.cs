using System;

namespace _02._Greater_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            double numbar1 = double.Parse(Console.ReadLine());
            double numbar2 = double.Parse(Console.ReadLine());
            if (numbar1 > numbar2)
            {
                Console.WriteLine(numbar1);
            }
            else
            {
                Console.WriteLine(numbar2);
            }
        }
    }
}
