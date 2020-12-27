using System;

namespace _03._Summer_Outfit
{
    class Program
    {
        static void Main(string[] args)
        {
            double degrees = double.Parse(Console.ReadLine());
            string timeOfDay = Console.ReadLine();
            string outFit = "";
            string shoes = "";

            if (degrees >= 10 && degrees <= 18)
            {
                if (timeOfDay == "Morning")
                {
                    outFit = "Sweatshirt";
                    shoes = "Sneakers";
                }
                else if (timeOfDay == "Afternoon" || timeOfDay == "Evening")
                {
                    outFit = "Shirt";
                    shoes = "Moccasins";
                }

            }
            else if (degrees > 18 && degrees <= 24)
            {
                if (timeOfDay == "Morning")
                {
                    outFit = "Shirt";
                    shoes = "Moccasins";
                }
                else if (timeOfDay == "Afternoon")
                {
                    outFit = "T-Shirt";
                    shoes = "Sandals";
                }
                else if (timeOfDay == "Evening")
                {
                    outFit = "Shirt";
                    shoes = "Moccasins";
                }
            }
            else if (degrees >= 25)
            {
                if (timeOfDay == "Morning")
                {
                    outFit = "T-Shirt";
                    shoes = "Sandals";
                }
                else if (timeOfDay == "Afternoon")
                {
                    outFit = "Swim Suit";
                    shoes = "Barefoot";
                }
                else if (timeOfDay == "Evening")
                {
                    outFit = "Shirt";
                    shoes = "Moccasins";
                }
            }
            Console.WriteLine($"It's {degrees} degrees, get your {outFit} and {shoes}.");
        }
    }
}
