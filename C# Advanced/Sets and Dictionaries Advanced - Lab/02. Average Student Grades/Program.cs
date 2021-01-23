using System;
using System.Collections.Generic;
using System.Linq;

namespace _02._Average_Student_Grades
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<decimal>> studentsGrades = new Dictionary<string, List<decimal>>();

            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                var students = Console.ReadLine().Split();
                var name = students[0];
                var grade = decimal.Parse(students[1]);

                if (!studentsGrades.ContainsKey(name))
                {
                    studentsGrades.Add(name, new List<decimal>());
                }

                studentsGrades[name].Add(grade);
            }

            foreach (var strudent in studentsGrades)
            {
                Console.Write($"{strudent.Key} -> ");

                foreach (var grade in strudent.Value)
                {
                    Console.Write($"{grade:f2} ");
                }

                Console.WriteLine($"(avg: {strudent.Value.Average():f2})");
            }

        }
    }
}
