using System;

namespace _03._Flowers
{
    class Program
    {
        static void Main(string[] args)
        {
            double hrizantemi = double.Parse(Console.ReadLine());
            double rozi = double.Parse(Console.ReadLine());
            double laleta = double.Parse(Console.ReadLine());
            string seaseon = Console.ReadLine();
            char holyday = char.Parse(Console.ReadLine());

            double parce = 0;
            double totalFlwoer = 0;

            if (seaseon == "Spring")
            {
                parce = hrizantemi * 2.00 + rozi * 4.10 + laleta * 2.50;
                totalFlwoer = hrizantemi + rozi + laleta;
                if (laleta > 7)
                {
                    parce -= parce * 0.05;
                }
                if (totalFlwoer > 20)
                {
                    parce -= parce * 0.20;
                }
                if (holyday == 'Y')
                {
                    parce += parce * 0.15;
                }
            }
            else if (seaseon == "Summer")
            {
                parce = hrizantemi * 2.00 + rozi * 4.10 + laleta * 2.50;
                totalFlwoer = hrizantemi + rozi + laleta;
                
                if (totalFlwoer > 20)
                {
                    parce -= parce * 0.20;
                }
                if (holyday == 'Y')
                {
                    parce += parce * 0.15;
                }
            }
            else if (seaseon == "Autumn")
            {
                parce = hrizantemi * 3.75 + rozi * 4.50 + laleta * 4.15;
                totalFlwoer = hrizantemi + rozi + laleta;

                if (totalFlwoer > 20)
                {
                    parce -= parce * 0.20;
                }
                if (holyday == 'Y')
                {
                    parce += parce * 0.15;
                }
            }
            else if (seaseon == "Winter")
            {
                parce = hrizantemi * 3.75 + rozi * 4.50 + laleta * 4.15;
                totalFlwoer = hrizantemi + rozi + laleta;
                if (rozi >= 10)
                {
                    parce -= parce * 0.1;
                }

                if (totalFlwoer > 20)
                {
                    parce -= parce * 0.20;
                }
                if (holyday == 'Y')
                {
                    parce += parce * 0.15;
                }
            }
            Console.WriteLine($"{(parce + 2):f2}");

        }
    }
}
