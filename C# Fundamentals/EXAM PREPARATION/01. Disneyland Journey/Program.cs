using System;

namespace _01._Disneyland_Journey
{
    class Program
    {
        static void Main(string[] args)
        {
            double money = double.Parse(Console.ReadLine());
            int mount = int.Parse(Console.ReadLine());

            double saveMoney = 0;

            for (int i = 1; i <= mount; i++)
            {

                if (i % 2 == 0)
                {
                    if (i % 4 == 0)
                    {
                        saveMoney += saveMoney * 0.25;
                    }

                    saveMoney += money * 0.25;

                }
                else
                {
                    if (i != 1)
                    {
                        saveMoney -= saveMoney * 0.16; 
                        saveMoney += money * 0.25;
                        continue;
                    }
                    saveMoney += money * 0.25;
                }

            }

            if (saveMoney > money)
            {
                saveMoney -= money;
                Console.WriteLine($"Bravo! You can go to Disneyland and you will have {saveMoney:f2}lv. for souvenirs.");
            }
            else
            {
                Console.WriteLine($"Sorry. You need {Math.Abs(saveMoney - money):f2}lv. more.");
            }
        }
    }
}
