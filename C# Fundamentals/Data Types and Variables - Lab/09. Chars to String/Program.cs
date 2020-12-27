using System;

namespace _09._Chars_to_String
{
    class Program
    {
        static void Main(string[] args)
        {
            char linesOne = char.Parse(Console.ReadLine());
            char linesTwo = char.Parse(Console.ReadLine());
            char linesThree = char.Parse(Console.ReadLine());

            Console.WriteLine($"{linesOne}{linesTwo}{linesThree}");
        }
    }
}
