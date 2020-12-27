using System;
using System.Collections.Generic;
using System.Linq;

namespace _03._Moving_Target
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * Отново сте в стрелбището и имате нужда от програма, която ви помага да следите движещите се цели.
             * На първия ред ще получите поредица от цели с техните цели стойности, разделени с едно интервал.
             * След това ще започнете да получавате команди за манипулиране на целите, до командата "End".
             * Командите са следните:
             * 
             * Shoot {index} {power}
             * Изстреляйте целта по индекса, ако тя съществува, като намалите стойността си с дадената мощност
             * (integer value). Целта се счита за изстрел, когато стойността й достигне 0.
             * Премахнете целта, ако е изстреляна.
             * Add {index} {value}
             * Поставете цел с получената стойност в получения индекс, ако тя съществува.
             * Ако не, отпечатайте: "Invalid placement!"
             * Strike {index} {radius}
             * Премахнете целта при дадения индекс и тези преди и след него в зависимост от радиуса, ако има такъв.
             * Ако някой от индексите в диапазона е невалиден, отпечатайте:„Strike missed!“ и пропуснете тази команда.
             * End
             * Print the sequence with targets in the following format:
               {target1}|{target2}…|{targetn}

            Coments
            Първата команда е "Shoot", така че намаляваме целта на индекс 5, който е валиден, с дадената мощност - 10.
            След това получаваме същата команда, но трябва да намалим целта на 1-ви индекс, с мощност 80.
            Стойността на тази цел е 74, така че се счита за изстрел и я премахваме.
            След това получаваме командата "Strike"на 2-ри индекс и трябва да проверим дали диапазонът
            с радиус 1 е валиден:52 23 44 96 100
            И е така, затова премахваме целите.Накрая получаваме командата "Добавяне",
            но индексът е невалиден, така че отпечатваме съответното съобщение и накрая имаме следния резултат:
            52 | 100
            */

            List<int> targets = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();

            string input;

            while ((input = Console.ReadLine()) != "End")
            {
                string[] tokens = input.Split();

                string command = tokens[0];
                int index = int.Parse(tokens[1]);
                int value = int.Parse(tokens[2]);

                if (index < 0 || index >= targets.Count)
                {
                    if (command == "Add")
                    {
                        Console.WriteLine("Invalid placement!");
                    }
                    else if (command == "Strike")
                    {
                        Console.WriteLine("Strike missed!");
                    }

                    continue;
                }

                switch (command)
                {
                    case "Shoot":
                        targets[index] -= value;

                        if (targets[index] <= 0)
                        {
                            targets.RemoveAt(index);
                        }
                        break;
                    case "Add":
                        targets.Insert(index, value);
                        break;
                    case "Strike":
                        if (index - value < 0 || index + value >= targets.Count)
                        {
                            Console.WriteLine("Strike missed!");
                            continue;
                        }

                        for (int i = index - value; i <= index + value; i++)
                        {
                            targets.RemoveAt(index - value);
                        }
                        break;
                }
            }

            Console.WriteLine(string.Join("|", targets));
        }
    }
}
