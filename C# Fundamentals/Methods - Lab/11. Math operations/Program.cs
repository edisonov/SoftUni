using System;

namespace _11._Math_operations
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstNumber = int.Parse(Console.ReadLine());
            string operatorCalcolate = Console.ReadLine();
            int secondNumber = int.Parse(Console.ReadLine());
            double result = Calculate(firstNumber, operatorCalcolate, secondNumber);
            Console.WriteLine(result);

        }

        static double Calculate(int firstNumber, string operatorCalcolate, int secondNumber)
        {
            double result = 0;
            switch (operatorCalcolate)
            {
                case "+":
                    result = firstNumber + secondNumber;
                    break;
                case "-":
                    result = firstNumber - secondNumber;
                    break;
                case "*":
                    result = firstNumber * secondNumber;
                    break;
                case "/":
                    result = firstNumber / secondNumber;
                    break;
            }
            return result;
        }
    }
}
