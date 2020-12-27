using System;

namespace _02._Grades
{
    class Program
    {
        static void Main(string[] args)
        {
            double grade = double.Parse(Console.ReadLine());
            Grade(grade);
        }

        static void Grade (double grade)
        {
            string greatResult = string.Empty;
            if (grade >=2 && grade <= 2.99)
            {
                greatResult = "Fail";
            }
            else if (grade >= 3 && grade <= 3.49)
            {
                greatResult = "Poor";
            }
            else if (grade >= 3.50 && grade <= 4.49)
            {
                greatResult = "Good";
            }
            else if (grade >= 4.50 && grade <= 5.49)
            {
                greatResult = "Very good";
            }
            else if (grade >= 5.5 && grade <= 6.00)
            {
                greatResult =  "Excellent";
            }
            Console.WriteLine(greatResult);
        }
    }
}
