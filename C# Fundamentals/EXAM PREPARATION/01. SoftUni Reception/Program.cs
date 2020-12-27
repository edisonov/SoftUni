using System;

namespace _01._SoftUni_Reception
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstEnergy = int.Parse(Console.ReadLine());
            int secondEnergy = int.Parse(Console.ReadLine());
            int threEnergy = int.Parse(Console.ReadLine());
            int students = int.Parse(Console.ReadLine());

            int totalEnergy = firstEnergy + secondEnergy + threEnergy;
            int count = 0;
            while (students > 0)
            {
                count++;

                if (count % 4 != 0)
                {
                    students -= totalEnergy;
                }
            }

            Console.WriteLine($"Time needed: {count}h.");
        }
    }
}
