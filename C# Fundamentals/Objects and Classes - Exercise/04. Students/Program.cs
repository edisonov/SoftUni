using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;

namespace _04._Students
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             
            Напишете програма, която получава брой ученици - n и ги подрежда по степени в низходящ ред.
            Всеки ученик трябва да има собствено име (низ), фамилно име (низ) и оценка (число с плаваща запетая).
                             input
            • На първия ред ще получите n - броят на учениците
            • На следващите n реда ще получавате информацията за учениците в следния формат:
            „{first name} {second name} {grade}“
                             output
            Отпечатайте всеки ученик в следния формат: „{first name} {second name}: {grade}“

             */
            List<Student> students = new List<Student>();

            int studentsCount = int.Parse(Console.ReadLine());

            for (int i = 0; i < studentsCount; i++)
            {
                var studentInfo = Console.ReadLine().Split().ToArray();

                Student student = new Student(studentInfo[0], studentInfo[1],
                    double.Parse(studentInfo[2]));

                students.Add(student);
            }

            Console.WriteLine(string.Join(Environment.NewLine,
                students.OrderByDescending(x => x.Grade)));
        }

        public class Student
        {
            public string FirstName { get; set; }
            public string LastName { get; set; }
            public double Grade { get; set; }

            public Student(string firstName, string lastName, double grade)
            {
                this.FirstName = firstName;   
                this.LastName = lastName;
                this.Grade = grade;
            }

            public override string ToString()
            {
                return $"{FirstName} {LastName}: {Grade:f2}"; 
            }
        }
    }
}
