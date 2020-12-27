using System;

namespace _05._Travelling
{
    class Program
    {
        static void Main(string[] args)
        {
            string destination = Console.ReadLine();

            while (destination != "End")
            {
                double buget = double.Parse(Console.ReadLine());

                double savedMoney = double.Parse(Console.ReadLine());
                double totalMoney = savedMoney;

                while (totalMoney < buget)
                {
                    savedMoney = double.Parse(Console.ReadLine());
                    totalMoney += savedMoney;
                }
                Console.WriteLine($"Going to {destination}!");

                destination = Console.ReadLine();
            }
        }
    }
}
