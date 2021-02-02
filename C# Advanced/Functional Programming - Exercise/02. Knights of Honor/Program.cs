using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Channels;

namespace _02._Knights_of_Honor
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> names = Console.ReadLine().Split().ToList();

            List<string> newNames = names.Select(name => $"Sir {name}").ToList();

            Action<List<string>> printNames = names => Console.WriteLine(string.Join(Environment.NewLine, newNames));

            printNames(newNames);
        }
    }
}
