using System;
using System.Linq;

namespace _01._Valid_Usernames
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split(", ");

            for (int i = 0; i < input.Length; i++)
            {
                var cur = input[i];
                if (Isvalide(cur))
                {
                    Console.WriteLine(cur);
                }
            }
        }

        public static bool Isvalide(string curent)
        {
            return curent.Length >= 3 && curent.Length <= 16 &&
                curent.All(c => char.IsLetterOrDigit(c)) || curent.Contains("-") ||
                curent.Contains("_");
        }
    }
}
