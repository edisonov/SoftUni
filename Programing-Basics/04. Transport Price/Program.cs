using System;

namespace _04._Transport_Price
{
    class Program
    {
        static void Main(string[] args)
        {
            int cilometars = int.Parse(Console.ReadLine());
            string days = Console.ReadLine();
            double student = 0;

            if (days == "day")
            {
                if (cilometars < 20)
                {
                    student = 0.70 + cilometars * 0.79;
                }
                else if (cilometars < 100)
                {
                    student = cilometars * 0.09;
                }
                else if (cilometars >= 100)
                {
                    student = cilometars * 0.06;
                }
            }
            else if (days == "night")
            {
                if (cilometars < 20)
                {
                    student = 0.70 + cilometars * 0.90;
                }
                else if (cilometars < 100)
                {
                    student = cilometars * 0.09;
                }
                else if (cilometars >= 100)
                {
                    student = cilometars * 0.06;
                }
            }
            Console.WriteLine($"{student:f2}");
        }
    }
}
