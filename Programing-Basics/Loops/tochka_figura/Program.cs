using System;

namespace tochka_figura
{
    class Program
    {
        static void Main(string[] args)
        {
            int h = int.Parse(Console.ReadLine());
            int x = int.Parse(Console.ReadLine());
            int y = int.Parse(Console.ReadLine());
            bool outRectangle1 = (x < 0 || x > 3 * h) || (y < 0 || y > h);
            bool outRactangle2 = (x < h || x > 3 * h) || (y < h || y > 4 * h);
            bool inRactangle1 = (x > 0 && x < 3 * h) && (y > 0 && y < h);
            bool inRactangle2 = (x > h && x < 3 * h) && (y > h && y < h);
            bool commonBorder = (x > h && x < 3 * h) && y == h;

            if (outRectangle1 && outRactangle2)
            {
                Console.WriteLine("outside");
            }
            else if (inRactangle1 || inRactangle2 || commonBorder)
            {
                Console.WriteLine("inside");
            }
            else
            {
                Console.WriteLine("Border");
            }

        }
    }
}
