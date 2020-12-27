using System;

namespace _09._Spice_Must_Flow
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            int counter = 0;
            int sum = 0;
            if (number < 100)
            {
                Console.WriteLine(counter);
                Console.WriteLine(sum);
               
            }
            else
            {
                while (number >= 100)
                {
                    sum += number - 26;
                    number -= 10;
                    counter++;
                }
                sum -= 26;
                Console.WriteLine(counter);
                Console.WriteLine(sum);
            }
            
        }
    }
}
