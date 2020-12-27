using System;

namespace _02._Concatenate_Data
{
    class Program
    {
        static void Main(string[] args)
        {
            string fiarstName = Console.ReadLine();
            string lastName = Console.ReadLine();
            int age = int.Parse(Console.ReadLine());
            string tawn = Console.ReadLine();

            Console.WriteLine($"You are {fiarstName} {lastName}, a {age}-years old person from {tawn}.");


        }
    }
}
