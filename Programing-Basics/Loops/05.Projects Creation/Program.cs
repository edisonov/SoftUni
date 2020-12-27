using System;

namespace _05.Projects_Creation
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            int people = int.Parse(Console.ReadLine());

            int hours = people * 3;

            Console.WriteLine($"The architect {name} will need {hours} hours to complete {people} project/s.");
        }
    }
}
