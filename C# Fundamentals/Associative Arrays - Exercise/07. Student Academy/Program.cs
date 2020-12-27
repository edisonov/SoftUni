using System;
using System.Collections.Generic;
using System.Linq;
namespace _07._Student_Academy
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            Dictionary<string, List<double>> student = new Dictionary<string, List<double>>();

            for (int i = 0; i < n; i++)
            {
                string name = Console.ReadLine();
                double great = double.Parse(Console.ReadLine());

                if (!student.ContainsKey(name))
                {
                    
                    student.Add(name, new List<double>());
                }
                
                student[name].Add(great); 
              
            }

            foreach (var item in student.OrderByDescending(x => x.Value.Average()))
            {

                if (item.Value.Average() >= 4.5)
                {
                     Console.WriteLine($"{item.Key} -> {item.Value.Average():f2}");

                }
            }
        }
    }
}
