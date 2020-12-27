using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;

namespace _06._Cards_Game
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            Ще ви бъдат дадени две ръце от карти, които ще бъдат цели числа. 
            Да приемем, че имате двама играчи. Трябва да разберете печелившата колода и съответно победителя.
            Започвате от началото на двете ръце. Сравнете картите от първата колода с картите от втората колода.
            Играчът, който има по-голямата карта, взема и двете карти и ги поставя в задната част на ръката си
            - картата на втория играч е последна, 
            а картата на първия човек (печелившата) е преди нея (втората до последната)
            и играчът с по-малката карта трябва да извади картата от тестето му. 
            Ако картите на двамата играчи имат еднакви стойности
            - никой не печели и двете карти трябва да бъдат премахнати от тестетата.
            Играта приключва, когато една от тестетата остане без никакви карти. 
            Трябва да отпечатате победителя на конзолата и сумата от останалите карти:
            „{First / Second} player печели! Сума: {sum}“.
             */
            List<int> firstPlayer = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();
            List<int> secondPlayer = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();

            while (firstPlayer.Count != 0 && secondPlayer.Count != 0)
            {
                int firstPlayerCard = firstPlayer[0];
                int secondPlayerCard = secondPlayer[0];

                if (firstPlayerCard > secondPlayerCard)
                {
                    firstPlayer.Add(firstPlayerCard);
                    firstPlayer.Add(secondPlayerCard);
                }
                else if (firstPlayerCard < secondPlayerCard)
                {
                    secondPlayer.Add(secondPlayerCard);
                    secondPlayer.Add(firstPlayerCard);
                }

                firstPlayer.RemoveAt(0);
                secondPlayer.RemoveAt(0);
            }

            if (firstPlayer.Count == 0)
            {
                Console.WriteLine($"Second player wins! Sum: {secondPlayer.Sum()}");
            }
            else
            {
                Console.WriteLine($"First player wins! Sum: {firstPlayer.Sum()}"); 
            }
        }
    }
}
