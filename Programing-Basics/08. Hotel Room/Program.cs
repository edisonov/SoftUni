using System;

namespace _08._Hotel_Room
{
    class Program
    {
        static void Main(string[] args)
        {
            string month = Console.ReadLine();
            int nights = int.Parse(Console.ReadLine());

            double studio = 0;
            double apartamen = 0;

            switch (month)
            {
                case "May":
                case "October":
                    studio = 50;
                    apartamen = 65;
                    if (nights > 7 && nights <= 14)
                    {
                        studio -= studio * 0.05;
                    }
                    else if (nights > 14)
                    {
                        studio -= studio * 0.3;
                        apartamen -= apartamen * 0.1;
                    }
                    break;
                case "June":
                case "September":
                    studio = 75.20;
                    apartamen = 68.70;
                   
                    if (nights > 14)
                    {
                        studio -= studio * 0.2;
                        apartamen -= apartamen * 0.1;
                    }
                    break;
                case "July":
                case "August":
                    studio = 76;
                    apartamen = 77;

                    if (nights > 14)
                    {
                        apartamen -= apartamen * 0.1;
                    }
                    break;


                default:
                    break;
            }
            Console.WriteLine($"Apartment: {(apartamen * nights):f2} lv.");
            Console.WriteLine($"Studio: {(studio * nights):f2} lv.");
        }
    }
}
