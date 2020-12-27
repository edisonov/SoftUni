using System;

namespace _03._Personal_Titles
{
    class Program
    {
        static void Main(string[] args)
        {
            double age = double.Parse(Console.ReadLine());
            string gander = Console.ReadLine();

            if (gander == "m")
            {
                if (age < 16)
                {
                    Console.WriteLine("Master");
                }
                else
                {
                    Console.WriteLine("Mr.");
                }
                
            }
            else if (gander == "f")
            {
                if (age < 16)
                {
                    Console.WriteLine("Miss");
                }
                else
                {
                    Console.WriteLine("Ms.");
                }
            }

        }
    }
}
