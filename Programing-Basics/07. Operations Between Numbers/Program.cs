using System;

namespace _07._Operations_Between_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int n1 = int.Parse(Console.ReadLine());
            int n2 = int.Parse(Console.ReadLine());
            char sum = char.Parse(Console.ReadLine());

            switch (sum)
            {
                case '+':
                    int sum1 = n1 + n2;
                    if (sum1 % 2 == 0)
                    {
                        Console.WriteLine($"{n1} {sum} {n2} = {sum1} - even");
                    }
                    else
                    {
                        Console.WriteLine($"{n1} {sum} {n2} = {sum1} - odd");
                    }
                    break;
                case '-':
                    int sum2 = n1 - n2;
                    if (sum2 % 2 == 0)
                    {
                        Console.WriteLine($"{n1} {sum} {n2} = {sum2} - even");
                    }
                    else
                    {
                        Console.WriteLine($"{n1} {sum} {n2} = {sum2} - odd");
                    }
                    break;
                case '*':
                    int sum3 = n1 * n2;
                    if (sum3 % 2 == 0)
                    {
                        Console.WriteLine($"{n1} {sum} {n2} = {sum3} - even");
                    }
                    else
                    {
                        Console.WriteLine($"{n1} {sum} {n2} = {sum3} - odd");
                    }
                    break;
                case '/':
                    if (n2 == 0)
                    {
                        Console.WriteLine($"Cannot divide {n1} by zero");
                    }
                    else
                    {
                        double sum4 = n1 * 1.0 / n2;
                        Console.WriteLine($"{n1} / {n2} = {sum4:f2}");
                    }
                    break;
                case '%':
                    if (n2 == 0)
                    {
                        Console.WriteLine($"Cannot divide {n1} by zero");
                    }
                    else
                    {
                        double sum5 = n1 % n2;
                        Console.WriteLine($"{n1} % {n2} = {sum5}");
                    }
                    break;
            }


        }
    }
}
