using System;

namespace _08._Beer_Kegs
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string bigestKeg = string.Empty;
            double bigestVolume = 0;
            for (int i = 0; i < n; i++)
            {
                string model = Console.ReadLine();
                float radius = float.Parse(Console.ReadLine());
                int height = int.Parse(Console.ReadLine());

                double volume = Math.PI * Math.Pow(radius, 2) * height;

                if (volume > bigestVolume)
                {
                    bigestVolume = volume;
                    bigestKeg = model;
                }
            }
            Console.WriteLine(bigestKeg);

        }
    }
}
