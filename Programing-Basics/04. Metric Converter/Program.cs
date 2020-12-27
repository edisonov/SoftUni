using System;

namespace _04._Metric_Converter
{
    class Program
    {
        static void Main(string[] args)
        {
            double num = double.Parse(Console.ReadLine());
            string convector = Console.ReadLine();
            string outConvector = Console.ReadLine();

            if (convector == "m")
            {
                if (outConvector == "cm")
                {
                    num = num * 100;
                }
                else if (outConvector == "mm")
                {
                    num = num * 1000;
                }
            }
            else if (convector == "cm")
            {
                if (outConvector == "m")
                {
                    num = num / 100;
                }
                else if (outConvector == "mm")
                {
                    num = num * 10;
                }
            }
            else if (convector == "mm")
            {
                if (outConvector == "m")
                {
                    num = num / 1000;
                }
                else if (outConvector == "cm")
                {
                    num = num / 10;
                }
            }
            Console.WriteLine($"{num:f3}");
        }
    }
}
