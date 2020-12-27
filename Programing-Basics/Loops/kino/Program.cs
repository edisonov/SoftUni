using System;

namespace kino
{
    class Program
    {
        static void Main(string[] args)
        {
            string type = Console.ReadLine().ToLower();
            var rows = double.Parse(Console.ReadLine());
            var cols = double.Parse(Console.ReadLine());

            double full = rows * cols;
            double total = 0;

            switch (type)
            {
                case "premiere":
                    total = full * 12.00;
                    break;
                case "normal":
                    total = full * 7.50;
                    break;
                case "discount":
                    total = full * 5.00;
                    break;
            }
            Console.WriteLine("{0:F2} leva", total);

        }
    }
}
    