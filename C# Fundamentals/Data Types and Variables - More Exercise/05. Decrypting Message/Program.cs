using System;
using System.ComponentModel;

namespace _05._Decrypting_Message
{
    class Program
    {
        static void Main(string[] args)
        {
            int key = int.Parse(Console.ReadLine());
            int lines = int.Parse(Console.ReadLine());

            string sumMessage = "";

            while (lines > 0)
            {
                sumMessage += ((char)(char.Parse(Console.ReadLine()) + key)).ToString();
                lines--;
            }
            Console.WriteLine(sumMessage);
        }
    }
}
