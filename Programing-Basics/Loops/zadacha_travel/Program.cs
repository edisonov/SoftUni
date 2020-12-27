using System;

namespace zadacha_travel
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal budget = decimal.Parse(Console.ReadLine());
            string season = Console.ReadLine();

            string destinationResult = string.Empty;
            string holidayInformation = string.Empty;
            decimal moneySpent = 0.00M;

            if (budget <= 100.00M)
            {
                destinationResult = "Bulgaria";
                if (season.Equals("summer"))
                {
                    moneySpent = 0.30M * budget;
                    holidayInformation =
                    string.Format("Camp - {0:f2}", moneySpent);
                }
                else
                {
                    moneySpent = 0.70M * budget;
                    holidayInformation =
                    string.Format("Hotel - {0:f2}", moneySpent);
                }
            }
            else if (budget <= 1000.00M)
              {
                    destinationResult = "Balkans";
                    if (season.Equals("summer"))
                    {
                        moneySpent = 0.40M * budget;
                        holidayInformation =
                        string.Format("Camp - {0:f2}", moneySpent);
                    }
                    else
                    {
                        moneySpent = 0.80M * budget;
                        holidayInformation =
                            string.Format("Hotel - {0:f2}", moneySpent);
                    }

               }
                else
                {
                    destinationResult = "Europe";
                    moneySpent = 0.90M * budget;
                    holidayInformation =
                        string.Format("Hotel - {0:f2}", moneySpent);
                }

                Console.WriteLine("Somewhere in {0}",destinationResult);
                Console.WriteLine(holidayInformation);
            
        }
    }
}
