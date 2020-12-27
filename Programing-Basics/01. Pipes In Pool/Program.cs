using System;

namespace _01._Pipes_In_Pool
{
    class Program
    {
        static void Main(string[] args)
        {
            //v = obem na baseina
            //p1 = debit na parvata traba v chas
            //p2 = debit na vtorata traba v chas
            //h = casove koito ocastva rabotnika 
            int v = int.Parse(Console.ReadLine());
            int p1 = int.Parse(Console.ReadLine());
            int p2 = int.Parse(Console.ReadLine());
            double h = double.Parse(Console.ReadLine());

            double whater = p1 * h + p2 * h;
            
            if (whater <= v)
            {
                Console.WriteLine($"The pool is {((whater / v)*100):f2}% full. Pipe 1: {p1 * h / whater * 100:f2}%. Pipe 2: {p2 * h / whater * 100:f2}%.");
                  
            }
            else
            {
                Console.WriteLine($"For {h:f2} hours the pool overflows with {whater - v:f2} liters.");
            }
        }
    }
}
