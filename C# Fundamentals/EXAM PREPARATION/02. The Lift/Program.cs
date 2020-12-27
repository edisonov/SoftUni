using System;
using System.Linq;

namespace _02._The_Lift
{
    class Program
    {
        static void Main(string[] args)
        {
            int people = int.Parse(Console.ReadLine());

            int[] wagons = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            int peopleCount = 0;

            for (int i = 0; i < wagons.Length; i++)
            {
                peopleCount = 4 - wagons[i];

                if (people < 4)
                {
                    wagons[i] += people;
                    people -= people;
                }
                else
                {
                    wagons[i] += peopleCount;
                    people -= peopleCount;
                }
               
            }

            if (people > 0)
            {
                Console.WriteLine($"There isn't enough space! {people} people in a queue!");
                Console.WriteLine(string.Join(" ", wagons));
            }
            
            else
            {
                Console.WriteLine("The lift has empty spots!");
                Console.WriteLine(string.Join(' ', wagons));
            }

           
        }
    }
}
