using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _03._House_Party
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             Напишете програма, която следи гостите, които отиват на домашно парти.
             На първия ред на въвеждане ще получите броя на командите, които ще получите. 
             На следващите редове ще получите едно от следните съобщения:
                • "{name} is going!"
                • "{name} is not going!"
            
             Ако получите първото съобщение, трябва да добавите човека,
             ако той / тя не е в списъка и ако той / тя е в списъка, отпечатайте на конзолата: "{name} вече е в списъка!".
             Ако получите второто съобщение, трябва да премахнете човека,
             ако той / тя е в списъка и ако не е отпечатан: "{name} не е в списъка!". В края отпечатайте всички гости.

             */

            List<string> guests = new List<string>();

            var n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string[] command = Console.ReadLine().Split();
                string name = command[0];

                if (command.Length == 3)
                {

                    if (guests.Contains(name))
                    {
                        Console.WriteLine($"{name} is already in the list!");
                    }
                    else
                    {
                        guests.Add(name);
                    }

                }
                else
                {
                    if (guests.Contains(name))
                    {
                        guests.Remove(name);
                    }
                    else
                    {
                        Console.WriteLine($"{name} is not in the list!");
                    }
                }
                

            }

            Console.WriteLine(string.Join(Environment.NewLine, guests));

        }
    }
}
