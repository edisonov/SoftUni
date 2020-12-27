using System;

namespace _07._Cinema_Tickets
{
    class Program
    {
        static void Main(string[] args)
        {
            string movie = Console.ReadLine();

            int totalTickets = 0;
            int kidTicket = 0;
            int studentTicket = 0;
            int standardTicket = 0;

            while (movie != "Finish")
            {
                int seat = int.Parse(Console.ReadLine());

                string ticket = Console.ReadLine();
                int ticketCounter = 0;

                while (ticket != "End")
                {
                    switch (ticket)
                    {
                        case "kid":
                            kidTicket++;
                            break;
                        case "standard":
                            standardTicket++;
                            break;
                        case "student":
                            studentTicket++;
                            break;      
                    }
                    ticketCounter++;
                    if (ticketCounter == seat)
                    {
                        break;
                    }
                    ticket = Console.ReadLine();
                }
                totalTickets += ticketCounter;
                double seatsTaken = ticketCounter * 1.0 / seat * 100;
                Console.WriteLine($"{movie} - {seatsTaken:f2}% full.");

                movie = Console.ReadLine();
            }
            double kidProcent = kidTicket * 1.0 / totalTickets * 100;
            double standardProcent = standardTicket * 1.0 / totalTickets * 100;
            double studentProcent = studentTicket * 1.0 / totalTickets * 100;

            Console.WriteLine($"Total tickets: {totalTickets}");
            Console.WriteLine($"{studentProcent:f2}% student tickets.");
            Console.WriteLine($"{standardProcent:f2}% standard tickets.");
            Console.WriteLine($"{kidProcent:f2}% kids tickets.");
        }
    }
}
