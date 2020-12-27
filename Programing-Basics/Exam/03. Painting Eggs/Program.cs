using System;

namespace _03._Painting_Eggs
{
    class Program
    {
        static void Main(string[] args)
        {
            string razmerQica = Console.ReadLine();
            string colorQica = Console.ReadLine();
            double brPartidi = double.Parse(Console.ReadLine());

            double prace = 0;


            if (razmerQica == "Large")
            {
                if (colorQica == "Red")
                {
                    prace = 16;
                }
                else if (colorQica == "Green")
                {
                    prace = 12;
                }
                else if (colorQica == "Yellow")
                {
                    prace = 9;
                }
            }
            else if (razmerQica == "Medium")
            {
                if (colorQica == "Red")
                {
                    prace = 13;
                }
                else if (colorQica == "Green")
                {
                    prace = 9;
                }
                else if (colorQica == "Yellow")
                {
                    prace = 7;
                }
            }
            else if (razmerQica == "Small")
            {
                if (colorQica == "Red")
                {
                    prace = 9;
                }
                else if (colorQica == "Green")
                {
                    prace = 8;
                }
                else if (colorQica == "Yellow")
                {
                    prace = 5;
                }
            }

            double razhod = brPartidi * prace;
            double total = Math.Abs((razhod * 0.35) - razhod);
            Console.WriteLine($"{total:f2} leva.");

        }
    }
}
