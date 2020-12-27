using System;
using System.Collections.Generic;
using System.Linq;

namespace _09._Pokemon_Don_t_Go
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            Ели много обича да играе Pokemon Go. Но Pokemon Go фалира ...
            Така че разработчиците направиха Pokemon Don’t Go out от депресия.
            И така, Ели сега играе Pokemon Don’t Go. В Pokemon Don’t Go, когато ходите до определен покемон,
            тези, които са по-близо до вас, естествено се приближават, а тези, които са по-далеч от вас, се приближават.
Ще получи   те последователност от цели числа, разделени с интервали - разстоянията до покемоните.
            След това ще започнете да получавате цели числа, които ще съответстват на индексите в тази последователност.
Когато по   лучите индекс, трябва да премахнете елемента от този индекс от последователността (сякаш сте заловили покемона).
    • Тря   бва да увеличите стойността на всички елементи в последователността, които са по-малки или равни на премахнатия елемент, със стойността на премахнатия елемент.
    • Тря   бва да намалите стойността на всички елементи в последователността, които са по-големи от премахнатия елемент,
            със стойността на премахнатия елемент.
Ако даден   ият индекс е по-малък от 0, премахнете първия елемент от последователността и копирайте последния елемент на мястото му.
Ако даден   ият индекс е по-голям от последния индекс на последователността,
            премахнете последния елемент от последователността и копирайте първия елемент на мястото му.

            The increasing and decreasing of elements should be done in these cases, also.
            The element, whose value you should use is the removed element.
The progr   am ends when the sequence has no elements (there are no pokemons left for Ely to catch).
Input
    • On     the first line of input you will receive a sequence of integers, separated by spaces.
    • On     the next several lines you will receive integers – the indexes.
Output
    • Whe    n the program ends, you must print the summed value of all removed elements.
             */
            List<int> numbers = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();

            int result = 0;
            int index = int.Parse(Console.ReadLine());

            while (true)
            {

                if (index < 0)
                {
                    int delnum = numbers[0];
                    numbers.RemoveAt(0);
                    numbers.Insert(0, numbers[numbers.Count - 1]);
                    for (int i = 0; i < numbers.Count; i++)
                    {
                        numbers[i] += delnum;
                    }
                    result += delnum;
                }
                else if (index > numbers.Count - 1)
                { 
                    int delNum = numbers[numbers.Count - 1];
                    numbers.RemoveAt(numbers.Count - 1);
                    numbers.Add(numbers[0]);
                    for (int i = 0; i < numbers.Count; i++)
                    {
                        numbers[i] += delNum;
                    }
                    result += delNum;
                }
                else
                {
                    int delNum = numbers[index];
                    numbers.RemoveAt(index);

                    for (int i = 0; i < numbers.Count; i++)
                    {
                        if (delNum >= numbers[i])
                        {
                            numbers[i] += delNum;
                        }
                        else
                        {
                            numbers[i] -= delNum;
                        }
                    }

                    result += delNum;
                }
                if (numbers.Count - 1 < 0)
                {
                    break;
                }

                index = int.Parse(Console.ReadLine());
            }

            Console.WriteLine(result);
        }
    }
}
