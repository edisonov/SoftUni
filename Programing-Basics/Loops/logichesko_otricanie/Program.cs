using System;

namespace logichesko_otricanie
{
    class Program
    {
        static void Main(string[] args)
        {
            var num = double.Parse(Console.ReadLine());
            var inRange = (num >= 100 && num <= 200);
            var zero = (num == 0);
            var valid = inRange || zero;
            
            if (!valid)
            {
                Console.WriteLine("Invalid");
            }

          

        }
    }
}
