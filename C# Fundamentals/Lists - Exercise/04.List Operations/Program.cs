using System;
using System.Collections.Generic;
using System.Linq;

namespace _04.List_Operations
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             Ще ви бъде даден списък с цели числа на първия ред на въвеждане. 
             Ще получавате операции, които трябва да приложите в списъка, докато не получите командата "Край". 
             Възможните команди са:
                • Add {number} – add number at the end.
                • Insert {number} {index} – insert number at given index.
                • Shift left {count} – first number becomes last ‘count’ times.
                • Shift right {count} – last number becomes first ‘count’ times.
                • Remove {index} – remove at index.
             Забележка: има възможност даден индекс да е извън границите на масива. 
             В този случай отпечатайте "Невалиден индекс"
             */
            List<int> list = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();

            string input = Console.ReadLine();

            while (input != "End")
            {
                string[] command = input.Split();
                string operation = command[0];

                switch (operation)
                {
                    case "Add":
                        int number = int.Parse(command[1]);
                        list.Add(number);
                        break;
                    case "Insert":
                        int numberToInsert = int.Parse(command[1]);
                        int index = int.Parse(command[2]);

                        if (index >= 0 && index < list.Count)
                        {
                            list.Insert(index, numberToInsert);
                        }
                        else
                        {
                            Console.WriteLine("Invalid index");
                        }

                        break;
                    case "Remove":
                        int indexToRemove = int.Parse(command[1]);

                        if (indexToRemove >= 0 && indexToRemove < list.Count)
                        {
                            list.RemoveAt(indexToRemove);
                        }
                        else
                        {
                            Console.WriteLine("Invalid index");
                        }
                    
                        break;
                    case "Shift":
                        int count = int.Parse(command[2]);

                        if (command[1] == "left")
                        {
                            for (int i = 0; i < count; i++)
                            {
                                int firstElement = list[0];
                                list.Add(firstElement);
                                list.RemoveAt(0);
                            }
                        }
                        else
                        {
                            for (int i = 0; i < count; i++)
                            {
                                int lastElement = list[list.Count - 1];
                                list.Insert(0, lastElement);
                                list.RemoveAt(list.Count - 1);
                            }
                        }
                        break;
                }

                input = Console.ReadLine();
            }

            Console.WriteLine(string.Join(' ',list));
        }
    }
}
