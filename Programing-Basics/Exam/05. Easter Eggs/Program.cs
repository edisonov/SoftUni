using System;

namespace _05._Easter_Eggs
{
    class Program
    {
        static void Main(string[] args)
        {
            double numberEggs = double.Parse(Console.ReadLine());

            double red = 0;
            double orange = 0;
            double blue = 0;
            double green = 0;

            for (int i = 1; i <= numberEggs; i++)
            {
                string color = Console.ReadLine();
                if (color == "red")
                {
                    red++;
                }
                else if (color == "orange")
                {
                    orange++;
                }
                else if (color == "blue")
                {
                    blue++;
                }
                else if (color == "green")
                {
                    green++;
                }
            }

            Console.WriteLine($"Red eggs: {red}");
            Console.WriteLine($"Orange eggs: {orange}");
            Console.WriteLine($"Blue eggs: {blue}");
            Console.WriteLine($"Green eggs: {green}");
            if (red > orange && red > blue && red > green)
            {
                Console.WriteLine($"Max eggs: {red} -> red");
            }
            else if (orange > red && orange > blue && orange > green)
            {
                Console.WriteLine($"Max eggs: {orange} -> orange");
            }
            else if (blue > red && blue > orange && blue > green)
            {
                Console.WriteLine($"Max eggs: {blue} -> blue");
            }
            else if (green > red && green > blue && green > orange)
            {
                Console.WriteLine($"Max eggs: {green} -> green");
            }
        }
    }
}
