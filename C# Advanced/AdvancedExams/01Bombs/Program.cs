﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace _01Bombs
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue<int> effects = new Queue<int>(
                Console.ReadLine().Split(", ").Select(int.Parse));

            Stack<int> cases = new Stack<int>(
                Console.ReadLine().Split(", ").Select(int.Parse));

            int datura = 0;
            int cherry = 0;
            int smoke = 0;

            int decrese = 0;

            while (effects.Count > 0 && cases.Count > 0)
            {
                if (datura >= 3 && cherry >= 3 && smoke >= 3)
                {
                    break;
                }

                int currentEffect = effects.Peek();
                int currentCases = cases.Peek() - decrese;
                int combined = currentEffect + currentCases;

                bool bombCreated = false;
                if (combined == 40)
                {
                    datura++;
                    bombCreated = true;
                }
                else if (combined == 60)
                {
                    cherry++;
                    bombCreated = true;
                }
                else if (combined == 120)
                {
                    smoke++;
                    bombCreated = true;
                }

                if (bombCreated)
                {
                    effects.Dequeue();
                    cases.Pop();
                    decrese = 0;
                }
                else if (currentCases <= 0)
                {
                    cases.Pop();
                    decrese = 0;
                }
                else
                {
                    decrese += 5;
                }
            }

            if (datura >= 3 && cherry >= 3 && smoke >= 3)
            {
                Console.WriteLine("Bene! You have successfully filled the bomb pouch!");
            }
            else
            {
                Console.WriteLine("You don't have enough materials to fill the bomb pouch.");
            }

            if (effects.Count == 0)
            {
                Console.WriteLine("Bomb Effects: empty");
            }
            else
            {
                Console.WriteLine($"Bomb Effects: {string.Join(", ",effects)}");
            }
            if (cases.Count == 0)
            {
                Console.WriteLine("Bomb Casings: empty");
            }
            else
            {
                Console.WriteLine($"Bomb Casings: {string.Join(", ", cases)}");
            }

            Console.WriteLine($"Cherry Bombs: {cherry}");
            Console.WriteLine($"Datura Bombs: {datura}");
            Console.WriteLine($"Smoke Decoy Bombs: {smoke}");
        }
    }
}
