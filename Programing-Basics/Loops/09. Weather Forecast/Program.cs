using System;

namespace _09._Weather_Forecast
{
    class Program
    {
        static void Main(string[] args)
        {
            string temp = Console.ReadLine();

            if(temp == "sunny")
            {
                Console.WriteLine("It's warm outside!");
            }
            else
            {
                Console.WriteLine("It's cold outside!");
            }
        }
    }
}
