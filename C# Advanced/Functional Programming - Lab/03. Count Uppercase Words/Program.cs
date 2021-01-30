using System;
using System.Linq;

namespace _03._Count_Uppercase_Words
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] text = Console.ReadLine().Split().Where(x=> x != x.ToLower()).ToArray();

            Console.WriteLine(string.Join(Environment.NewLine, text));
        }
    }
}
