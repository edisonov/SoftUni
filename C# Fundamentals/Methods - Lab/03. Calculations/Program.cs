using System;

namespace _03._Calculations
{
    class Program
    {
        static void Main(string[] args)
        {
            string metod = Console.ReadLine();
            double numberOne = double.Parse(Console.ReadLine());
            double numberTwo = double.Parse(Console.ReadLine());
            if (metod == "add")
            {
                Addition(numberOne, numberTwo);
            }
            else if (metod == "multiply")
            {
                Multiply(numberOne, numberTwo);
            }
            else if (metod == "subtract")
            {
                Subtract(numberOne, numberTwo);
            }
            else if (metod == "divide")
            {
                Divide(numberOne, numberTwo);
            }

        }

        static void Addition(double num1,double num2)
        {
            num1 += num2;
            Console.WriteLine(num1);
        }

        static void Multiply(double num1, double num2)
        {
            num1 *= num2;
            Console.WriteLine(num1);
        }

        static void Subtract(double num1, double num2)
        {
            num1 -= num2;
            Console.WriteLine(num1);
        }

        static void Divide(double num1, double num2)
        {
            num1 /= num2;
            Console.WriteLine(num1);
        }


    }
}
