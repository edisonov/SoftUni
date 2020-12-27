using System;

namespace _10._Rage_Expenses
{
    class Program
    {
        static void Main(string[] args)
        {
            int lostGame = int.Parse(Console.ReadLine());
            double headsetPrice = double.Parse(Console.ReadLine());
            double mausePrice = double.Parse(Console.ReadLine());
            double keyboardPrice = double.Parse(Console.ReadLine());
            double displayPrice = double.Parse(Console.ReadLine());

            double money = headsetPrice * (lostGame / 2);
            money += mausePrice * (lostGame / 3);
            money += keyboardPrice * (lostGame / 6);
            money += displayPrice * (lostGame / 12);

            Console.WriteLine($"Rage expenses: {money:f2} lv.");

        }
    }
}
