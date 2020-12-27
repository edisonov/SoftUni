using System;
using System.Linq;

namespace _01._Train
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             
            Ще ви бъде даден брой вагони във влак n. 
            На следващите n реда ще получите колко хора ще се качат на всеки вагон.
            В края отпечатайте целия влак и след това, на следващия ред, сумата от хората във влака.
             */
            int n = int.Parse(Console.ReadLine());
            int[] train = new int[n];
            int sum = 0;
            for (int i = 0; i < train.Length; i++)
            {
                train[i] = int.Parse(Console.ReadLine());
            }
            sum = train.Sum();
            Console.WriteLine(string.Join(' ', train));
            Console.WriteLine(sum);
        }
    }
}
