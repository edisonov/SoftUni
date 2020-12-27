using System;

namespace _06._Pet_Shop
{
    class Program
    {
        static void Main(string[] args)
        {
            double dog = double.Parse(Console.ReadLine());
            double ovar = double.Parse(Console.ReadLine());

            double dogPrise = dog * 2.5;
            double ovarPrise = ovar * 4;
            double total = dogPrise + ovarPrise;

            Console.WriteLine("{0:f2} lv.",total);

            
        }
    }
}
