using System;

namespace Demo
{
    class Program
    {
        static void Main(string[] args)
        {
            double yard = double.Parse(Console.ReadLine());

            double total = yard * 7.61;
            double comission = 0.18 * total;
            double final = total - comission;
            Console.WriteLine($"The final price is: {final:f2} lv.");
            Console.WriteLine($"The discount is: {comission:f2} lv.");
        }
    }
}
