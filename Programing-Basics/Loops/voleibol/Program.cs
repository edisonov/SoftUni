using System;

namespace voleibol
{
    class Program
    {
        static void Main(string[] args)
        {
            string year = Console.ReadLine().ToLower();
            int holiday = int.Parse(Console.ReadLine());
            int weekAndsHome = int.Parse(Console.ReadLine());

            int sofiaweekends = 48 - weekAndsHome;
            double playsofia = (3.0 * sofiaweekends / 4) + (2.0 * holiday / 3);
            double playtotal = playsofia + weekAndsHome;
            if (year.Equals("leap"))
            {
                playtotal = Math.Floor((playtotal * 0.15) + playtotal);
            }
            else if (year.Equals("Normal"))
            {
                playtotal = Math.Floor(playtotal);
            }
            Console.WriteLine(playtotal);
        }
    }
}
