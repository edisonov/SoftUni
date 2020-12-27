using System;

namespace _10._Poke_Mon
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstLine = int.Parse(Console.ReadLine());
            int secondLine = int.Parse(Console.ReadLine());
            int thirdLine = int.Parse(Console.ReadLine());

            int count = 0;
            double powar = firstLine * 0.5;

            while (firstLine >= secondLine)
            {
                count++;
                firstLine -= secondLine;
                if (powar == firstLine && thirdLine != 0)
                {
                    firstLine /= thirdLine;
                }
            }
            Console.WriteLine(firstLine);
            Console.WriteLine(count);
        }
    }
}
