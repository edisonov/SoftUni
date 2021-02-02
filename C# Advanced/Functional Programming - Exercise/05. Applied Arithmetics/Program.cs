using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Channels;

namespace _05._Applied_Arithmetics
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();

            string command = Console.ReadLine();
            Func<int, int> arithmetingFunc = num => num;
            Action<List<int>> print = nums => Console.WriteLine(string.Join(" ", nums));

            while (command != "end")
            {
                if (command == "add")
                {
                    arithmetingFunc = num => num + 1;
                    // numbers = numbers.Select(n => arithmetingFunc(n)).ToList();
                    numbers = numbers.Select(arithmetingFunc).ToList();
                }
                else if (command == "multiply")
                {
                    arithmetingFunc = num => num * 2;
                    numbers = numbers.Select(arithmetingFunc).ToList();
                }
                else if (command == "subtract")
                {
                    arithmetingFunc = num => num - 1;
                    numbers = numbers.Select(arithmetingFunc).ToList();
                }
                else if (command == "print")
                {
                    print(numbers);
                }

                command = Console.ReadLine();
            }
        }
    }
}
