using System;
using System.Collections.Generic;
using System.Linq;

namespace _02._Change_List
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
              Напишете програма, която чете списък с цели числа от конзолата и получава команди, които манипулират списъка.
              Вашата програма може да получи следните команди:

              • Delete {element} - изтрива всички елементи в масива, които са равни на дадения елемент.
              • Вмъкване {елемент} {позиция} - вмъкване на елемент и дадената позиция.
              Трябва да спрете програмата, когато получите командата "край".
              Отпечатайте числата в масива, разделени с един интервал.
             */
            List<int> number = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();

            string[] command = Console.ReadLine()
                .Split();

            while (command[0] != "end")
            {
                switch (command[0])
                {
                    case "Delete":
                       // number.Where(n => n != int.Parse(command[1]));
                        for (int i = 0; i < number.Count; i++)
                        {
                            number.Remove(int.Parse(command[1]));
                        }
                        break;
                    case "Insert":

                        number.Insert(int.Parse(command[2]), (int.Parse(command[1])));
                        break;
                    default:
                        break;
                }

                command = Console.ReadLine().Split();
            }

            Console.WriteLine(string.Join(' ',number));
        }
    }
}
