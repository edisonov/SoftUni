using System;

namespace _07._Area_of_Figures
{
    class Program
    {
        static void Main(string[] args)
        {
            string figures = Console.ReadLine();
            double area = 0;

            if (figures == "square")
            {
                double strana = double.Parse(Console.ReadLine());
                area = strana * strana;
            }
            else if (figures == "rectangle")
            {
                double strana = double.Parse(Console.ReadLine());
                double strana2 = double.Parse(Console.ReadLine());
                area = strana * strana2;
            }
            else if (figures == "circle")
            {
                double radisus = double.Parse(Console.ReadLine());
                area = Math.PI * radisus * radisus;
            }
            else if (figures == "triangle")
            {
                double strana = double.Parse(Console.ReadLine());
                double heatdh = double.Parse(Console.ReadLine());
                area = (strana * heatdh) / 2;
            }
            Console.WriteLine($"{area:f3}");
        }
    }
}
