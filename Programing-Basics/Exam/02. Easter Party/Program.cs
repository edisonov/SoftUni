using System;

namespace _02._Easter_Party
{
    class Program
    {
        static void Main(string[] args)
        {
            double numberPeople = double.Parse(Console.ReadLine());
            double praceKuvert = double.Parse(Console.ReadLine());
            double praceDesi = double.Parse(Console.ReadLine());

            double procent = 0;

            if (numberPeople < 10)
            {
                procent += praceKuvert;
            }
            else if (numberPeople >= 10 && numberPeople <= 15)
            {
                procent = praceKuvert - (praceKuvert * 0.15);

            }
            else if (numberPeople > 15 && numberPeople <= 20)
            {
                procent = praceKuvert - (praceKuvert * 0.20);
            }
            else if (numberPeople > 20)
            {
                procent = praceKuvert - (praceKuvert * 0.25);
            }
            double praceTorta = praceDesi / 10;
            double totalParty = numberPeople * procent + praceTorta;
            if (totalParty <= praceDesi)
            {
                Console.WriteLine("It is party time! {0:f2} leva left.", praceDesi - totalParty);
            }
            else
            {
                Console.WriteLine("No party! {0:f2} leva needed.", totalParty - praceDesi);
            }
        }
    }
}
