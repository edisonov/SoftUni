using System;
using System.Collections.Generic;
using System.Linq;

namespace _01._Bonus_Scoring_System
{
    class Program
    {
        static void Main(string[] args)
        {
            int student = int.Parse(Console.ReadLine());
            double lecturesCount = double.Parse(Console.ReadLine());
            double bonus = double.Parse(Console.ReadLine());

            List<double> totalBonus = new List<double>();
            List<double> totalAttendan = new List<double>();

            for (int i = 0; i < student; i++)
            {
                double attendancesStudent = double.Parse(Console.ReadLine());
                double total = (attendancesStudent / lecturesCount) * (5 + bonus);
                totalBonus.Add(total);
                totalAttendan.Add(attendancesStudent);

            }

            double max = totalBonus.Max();
            double maxAttendances = totalAttendan.Max();
            Console.WriteLine($"Max Bonus: {Math.Ceiling(max)}.");
            Console.WriteLine($"The student has attended {maxAttendances} lectures.");
        }
    }
}
