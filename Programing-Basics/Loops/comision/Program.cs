using System;

namespace comision
{
    class Program
    {
        static void Main(string[] args)
        {
            var town = Console.ReadLine().ToLower();
            var sale = double.Parse(Console.ReadLine());
            var comission = -1.0;

            if (town == "sofia")
            {
                if (sale >= 0 && sale <= 500) comission = 0.05; // 5%
                else if (sale > 500 && sale <= 1000) comission = 0.07; // 7%
                else if (sale > 1000 && sale <= 10000) comission = 0.08; // 8%
                else if (sale > 10000) comission = 0.12; // 12%

                
            }
            else if (town == "varna")
            {
                if (sale >= 0 && sale <= 500) comission = 0.045; 
                else if (sale > 500 && sale <= 1000) comission = 0.075; 
                else if (sale > 1000 && sale <= 10000) comission = 0.10; 
                else if (sale > 10000) comission = 0.13; 

            }
            else if (town == "plovdiv")
            {
                if (sale >= 0 && sale <= 500) comission = 0.055; 
                else if (sale > 500 && sale <= 1000) comission = 0.08; 
                else if (sale > 1000 && sale <= 10000) comission = 0.12; 
                else if (sale > 10000) comission = 0.145; 

            }
            if (comission > 0)
            {
                Console.WriteLine("{0:f2}", comission * sale);
            }
            else
            {
                Console.WriteLine("error");
            }
                
        }
    }
}
