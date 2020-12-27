using System;

namespace _06._Triples_of_Latin_Letters
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());

            for (int firstSymbol = 0; firstSymbol < number; firstSymbol++)
            {
                for (int secondSymbol = 0; secondSymbol < number; secondSymbol++)
                {
                    for (int thirdSymbol = 0; thirdSymbol < number; thirdSymbol++)
                    {
                        char firstChar = (char)(97 + firstSymbol);
                        char secondChar = (char)(97 + secondSymbol);
                        char thirdChar = (char)(97 + thirdSymbol);

                        Console.WriteLine($"{firstChar}{secondChar}{thirdChar}");
                    }
                }
            }
        }
    }
}
