using System;

namespace _08._Scholarship
{
    class Program
    {
        static void Main(string[] args)
        {
            double dohod = double.Parse(Console.ReadLine());
            double ocenka = double.Parse(Console.ReadLine());
            double zapalata = double.Parse(Console.ReadLine());

            double Uspeh = 0;
            double Social = 0;


            if (ocenka >= 4.5 && zapalata > dohod)
            {
                Social = zapalata * 0.35;
            }
            if (ocenka >= 5.5)
            {
                Uspeh = ocenka * 25;
            }
            if (Social != 0 || Uspeh != 0)
            {
                double rezultat = Math.Max(Social, Uspeh);
                Console.WriteLine(rezultat == Social ? "You get a Social scholarship {0} BGN" : "You get" +
                    " a scholarship for excellent results {1} BGN",(Math.Floor(Social)),(Math.Floor(Uspeh)));
            }
            else
            {
                Console.WriteLine("You cannot get a scholarship!");
            }
            
             
            
        }
    }
}
