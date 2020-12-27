using System;
using System.Collections.Generic;
using System.Linq;

namespace _05._Bomb_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             
            Напишете програма, която чете последователност от числа и специален номер на бомба с определена мощност. 
            Вашата задача е да взривите всяко появяване на специалния номер на бомба и според неговата мощ
            - неговите съседи отляво и отдясно. 
            Детонациите се извършват отляво надясно и всички детонирани числа изчезват.
            Накрая отпечатайте сумата от останалите елементи в последователността.

             */
            List<int> list = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();

            int[] bombData = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            int specialBombNumber = bombData[0];
            int power = bombData[1];

            int bombIndex = list.IndexOf(specialBombNumber);
            while (bombIndex != -1)
            {

                int leftNumber = bombIndex - power;
                int rightNumber = bombIndex + power;

                if (leftNumber < 0)
                {
                    leftNumber = 0;
                }
                if (rightNumber > list.Count - 1)
                {
                    rightNumber = list.Count - 1;
                }

                list.RemoveRange(leftNumber, rightNumber - leftNumber + 1);

                bombIndex = list.IndexOf(specialBombNumber);
            }

            int sum = list.Sum();
            
            Console.WriteLine(sum);
        }
    }
}
