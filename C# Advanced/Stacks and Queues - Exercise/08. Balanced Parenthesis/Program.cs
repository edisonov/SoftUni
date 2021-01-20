using System;
using System.Collections.Generic;
using System.Linq;

namespace _08._Balanced_Parenthesis
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack<char> open = new Stack<char>();

            string input = Console.ReadLine();
            bool isValid = true;

            foreach (var ch in input)
            {
                if (ch == '(' || ch == '{' || ch == '[')
                {
                    open.Push(ch);
                }
                else
                {
                    if (!open.Any())
                    {
                        isValid = false;
                        break;
                    }

                    char current = open.Pop();
                    bool isFirstIsValid = current == '(' && ch == ')';
                    bool isFirstIsValid2 = current == '{' && ch == '}';
                    bool isFirstIsValid3 = current == '[' && ch == ']';

                    if (isFirstIsValid == false && isFirstIsValid2 == false && isFirstIsValid3 == false)
                    {
                        isValid = false;
                        break;
                    }
                }
            }

            if (isValid)
            {
                Console.WriteLine("YES");
            }
            else
            {
                Console.WriteLine("NO");
            }
        }
    }
}
