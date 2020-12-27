using System;

namespace _07._Concat_Names
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            string secandName = Console.ReadLine();
            string n = Console.ReadLine();

            Console.WriteLine($"{name}{n}{secandName}");
        }
    }
}
