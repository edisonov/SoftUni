using System;
using System.Linq;

namespace demo
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split().ToList();

            int n = int.Parse(Console.ReadLine());

            for (
                int i = 0; i < n; i++)
            {
                var arr = Console.ReadLine().Split().ToArray();
                var command = arr[0];

                if (command == "Include")
                {
                    var coffee = arr[1];
                    input.Add(coffee);
                }
                else if (command == "Remove")
                {
                    var commandRemove = arr[1];
                    var index = int.Parse(arr[2]);

                    if (commandRemove == "first")
                    {
                        input.RemoveRange(0, index);
                    }
                    else
                    {
                        input.Reverse();
                        input.RemoveRange(0, index);
                        input.Reverse();
                    }
                }
                else if (command == "Prefer")
                {
                    var index1 = int.Parse(arr[1]);
                    var index2 = int.Parse(arr[2]);

                    input.Insert(index1, input[index2]);
                    input.RemoveAt(index1);
                }
                else if (command == "Reverse")
                {
                    input.Reverse();
                }
            }
            Console.WriteLine("Coffees:");
            Console.WriteLine(string.Join(" ", input));
        }
    }
}
