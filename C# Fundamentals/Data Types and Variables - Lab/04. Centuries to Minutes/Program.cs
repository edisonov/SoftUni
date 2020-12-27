using System;

namespace _04._Centuries_to_Minutes
{
    class Program
    {
        static void Main(string[] args)
        {
            int centuries = int.Parse(Console.ReadLine());

            int years = centuries * 100;
            int day =(int)(years * 365.2422);
            int hours = day * 24;
            int minutes = hours * 60;

            Console.WriteLine($"{centuries} centuries = {years} years = {day} days = {hours} hours = {minutes} minutes");


        }
    }
}
