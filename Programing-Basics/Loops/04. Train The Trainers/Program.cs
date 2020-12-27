using System;

namespace _04._Train_The_Trainers
{
    class Program
    {
        static void Main(string[] args)
        {
            int cauntJudges = int.Parse(Console.ReadLine());

            string text = Console.ReadLine();

            double totalSum = 0;
            int cauntGrades = 0;

            while (text != "Finish")
            {
                double sum = 0;

                for (int judge = 1; judge <= cauntJudges; judge++)
                {
                    double grade = double.Parse(Console.ReadLine());
                    sum += grade;
                    totalSum += grade;
                    cauntGrades++;
                }
                double average = sum / cauntJudges;
                Console.WriteLine($"{text} - {average:f2}.");

                text = Console.ReadLine();
            }
            double total = totalSum / cauntGrades;
            Console.WriteLine($"Student's final assessment is {total:f2}.");
           
        }
    }
}
