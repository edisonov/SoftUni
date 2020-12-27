using System;

namespace _01._Integer_Operations
{
    class Program
    {
        static void Main(string[] args)
        {
            int fiarstNumber = int.Parse(Console.ReadLine());
            int secondNumber = int.Parse(Console.ReadLine());
            int thirdNumber = int.Parse(Console.ReadLine());
            int fourthNumber = int.Parse(Console.ReadLine());

            int sum = fiarstNumber + secondNumber;
            int divide = sum / thirdNumber;
            int multiply = divide * fourthNumber;

            Console.WriteLine(multiply);
        }
    }
}
