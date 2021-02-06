using System;

namespace DateModifierProblem
{
    class Program
    {
        static void Main(string[] args)
        {
            string firstData = Console.ReadLine();
            string secondDate = Console.ReadLine();

            int days = DateModifier
                .GetDiffBetweenDatesInDays(firstData, secondDate);

            Console.WriteLine(days);


        }
    }
}
