using System;

namespace _03._Sum_Prime_Non_Prime
{
    class Program
    {
        static void Main(string[] args)
        {
            string command = Console.ReadLine();

            int sumPrime = 0;
            int sumNoPrime = 0;

            while (command != "stop")
            {
                int numbar = int.Parse(command);
                if (numbar < 0)
                {
                    Console.WriteLine("Number is negative.");
                    command = Console.ReadLine();
                    continue;
                }
                int count = 0;
                for (int i = 1; i <= numbar; i++)
                {
                    if (numbar % i == 0)
                    {
                        count++;
                    }
                }
                if (count == 2)
                {
                    sumPrime += numbar;
                }
                else if (count > 2)
                {
                    sumNoPrime += numbar;
                }


                command = Console.ReadLine();
            }
            Console.WriteLine($"Sum of all prime numbers is: {sumPrime}");
            Console.WriteLine($"Sum of all non prime numbers is: {sumNoPrime}");
        }
    }
}
