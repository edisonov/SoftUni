using System;

namespace operacii_chisla
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal n1 = decimal.Parse(Console.ReadLine());
            decimal n2 = decimal.Parse(Console.ReadLine());
            string nOperator = Console.ReadLine();

            decimal result = 0.00M;
            string output = string.Empty;
            

            if (n2 == 0 && (nOperator.Equals("/") || nOperator.Equals("%")))
            {
                output = string.Format("Cannot divide {0} by zero", n1);
            }
            else if (nOperator.Equals("/"))
            {
                result = n1 / n2;
                output = string.Format("{0} {1} {2} = {3:F2}", 
                    n1, nOperator, n2, result); ;
            }
            else if (nOperator.Equals("%"))
            {
                result = n1 % n2;
                output = string.Format("{0} {1} {2} = {3}",
                    n1, nOperator, n2, result);
            }
            else
            {
                if (nOperator.Equals("+"))
                {
                    result = n1 + n2;
                }
                else if (nOperator.Equals("-"))
                {
                    result = n1 - n2;
                }
                else if (nOperator.Equals("*"))
                {
                    result = n1 * n2;
                }
                output = string.Format("{0} {1} {2} = {3} - {4}", 
                    n1, nOperator, n2, result, result % 2 == 0 ? "even" : "odd");
            }
            Console.WriteLine(output);
        }
    }
}
