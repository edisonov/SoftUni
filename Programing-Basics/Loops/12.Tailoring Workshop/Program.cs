using System;

namespace _12.Tailoring_Workshop
{
    class Program
    {
        static void Main(string[] args)
        {
            double tabel = double.Parse(Console.ReadLine());
            double leaght = double.Parse(Console.ReadLine());
            double width = double.Parse(Console.ReadLine());

            double areatable = tabel * (leaght + 2 * 0.30) * (width + 2 * 0.30);
            double area = tabel * (leaght / 2) * (leaght / 2);
            double dolar = areatable * 7 + area * 9;
            double lev = dolar * 1.85;
            Console.WriteLine($"{dolar:F2} USD");
            Console.WriteLine($"{lev:F2} BGN");
        }
    }
}
