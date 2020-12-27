using System;

namespace magazin_plodove
{
    class Program
    {
        static void Main(string[] args)
        {
            var fruit = Console.ReadLine().ToLower();
            var day = Console.ReadLine().ToLower();
            var quantity = double.Parse(Console.ReadLine());
            var prise = -1.0;

            if (day == "monday" || day == "tuesday" || day == "wednesday" || day == "thursday"
                 || day == "friday")
            {
                //work day
                if (fruit == "banana") prise = 2.50;
                else if (fruit == "appel") prise = 1.20;
                else if (fruit == "orange") prise = 0.85;
                else if (fruit == "grapefruit") prise = 1.45;
                else if (fruit == "kiwi") prise = 2.70;
                else if (fruit == "pineapple") prise = 5.50;
                else if (fruit == "grapes") prise = 3.85;
            }
            else if (day == "saturday" || day == "sanday")
            {
                // Not-working day
                if (fruit == "banana") prise = 2.70;
                else if (fruit == "appel") prise = 1.25;
                else if (fruit == "orange") prise = 0.90;
                else if (fruit == "grapefruit") prise = 1.60;
                else if (fruit == "kiwi") prise = 3.00;
                else if (fruit == "pineapple") prise = 5.60;
                else if (fruit == "grapes") prise = 4.20;
            }
            if (prise >= 0)
            {
                Console.WriteLine("{0:f2}",prise * quantity);
            }
            else
            {
                Console.WriteLine("error");
            }
            
        }
    }
}
