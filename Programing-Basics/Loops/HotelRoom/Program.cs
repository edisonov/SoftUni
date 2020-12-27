using System;

namespace HotelRoom
{
    class Program
    {
        static void Main(string[] args)
        {
            string month = Console.ReadLine();
            int nights = int.Parse(Console.ReadLine());

            decimal studioPrise = 50.00M;
            decimal apartamentPrise = 65.00M;
            decimal studioRent = 0.00M;
            decimal apartamentRent = 0.00M;

            switch (month)
            {
                case "May":
                case "October":
                    studioPrise = 50.00M;
                    apartamentPrise = 65.00M;

                    studioRent = studioPrise * nights;
                    apartamentRent = apartamentPrise * nights;
                    if (nights > 14)
                    {
                        studioRent *= 0.70M;
                        apartamentRent *= 0.90M;
                    }
                    else if (nights > 7)
                    {
                        studioRent *= 0.95M;
                    }
                    break;
                case "June":
                case "September":
                    studioPrise = 75.20M;
                    apartamentPrise = 68.70M;

                    studioRent = studioPrise * nights;
                    apartamentRent = apartamentPrise * nights;
                    if (nights > 14)
                    {
                        studioRent *= 0.80M;
                        apartamentRent *= 0.90M;
                    }
                    break;
                case "July":
                case "August":
                    studioPrise = 76.00M;
                    apartamentPrise = 77.00M;

                    studioRent = studioPrise * nights;
                    apartamentRent = apartamentPrise * nights;
                    if (nights > 14)
                    {
                        apartamentRent *= 0.90M;
                    }
                    break;
            }
                    string studioInfo = 
                     string.Format("Studio: {0:F2} lv.", decimal.Round(studioRent, 2));
                    string apartamentInfo =
                        string.Format("Apartment: {0:F2} lv.", decimal.Round(apartamentRent, 2));
            Console.WriteLine(apartamentInfo);
            Console.WriteLine(studioInfo);
                    
            
        }
    }
}
