using System;
using System.Collections.Generic;
using System.Linq;

namespace CustomTuple
{
    public class Program
    {
        static void Main(string[] args)
        {
            string[] splittedFirst = Console.ReadLine().Split();
            string fullName = $"{splittedFirst[0]} {splittedFirst[1]}";
            List<string> townData = splittedFirst.Skip(3).ToList();
            string town = string.Join(" ", townData);

            Threeuple<string, string, string> firstThreeuple =
                new Threeuple<string, string, string>(fullName, splittedFirst[2], town);

            string[] splittedSecond = Console.ReadLine().Split();
            bool drunk = splittedSecond[2] == "drunk";

            Threeuple<string, int, bool> secondThreeuple =
                new Threeuple<string, int, bool>
                (splittedSecond[0], int.Parse(splittedSecond[1]), drunk);

            string[] splittedThird = Console.ReadLine().Split();

            Threeuple<string, double, string> thirdThreeuple =
                new Threeuple<string, double, string>
                (splittedThird[0], double.Parse(splittedThird[1]), splittedThird[2]);

            Console.WriteLine(firstThreeuple);
            Console.WriteLine(secondThreeuple);
            Console.WriteLine(thirdThreeuple);
        }
    }
}
