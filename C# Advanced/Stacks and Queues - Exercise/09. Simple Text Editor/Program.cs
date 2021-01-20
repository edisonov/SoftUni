using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _09._Simple_Text_Editor
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            var text = new Stack<string>();
            var bilder = new StringBuilder();
            text.Push(bilder.ToString());

            for (int i = 0; i < n; i++)
            {
                var input = Console.ReadLine().Split();
                int command = int.Parse(input[0]);

                switch (command)
                {
                    case 1:
                        bilder.Append(input[1]);
                        text.Push(bilder.ToString());
                        break;
                    case 2:
                        int number = int.Parse(input[1]);
                        bilder.Remove(bilder.Length - number, number);
                        text.Push(bilder.ToString());
                        break;
                    case 3:
                        int index = int.Parse(input[1]);
                        Console.WriteLine(bilder[index - 1]);
                        break;
                    case 4:
                        text.Pop();
                        bilder = new StringBuilder();
                        bilder.Append(text.Peek());
                        break;
                }

                
            }
        }
    }
}
