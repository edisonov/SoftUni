using System;
using System.Collections.Generic;
using System.Linq;

namespace TheFightForGondor
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            Queue<int> argon = new Queue<int>(Console.ReadLine().Split().Select(int.Parse));


            for (int i = 0; i < n; i++)
            {
                Stack<int> powerOrc = new Stack<int>
                    (Console.ReadLine().Split().Select(int.Parse));



                if (i == 2)
                {
                    argon.Enqueue(int.Parse(Console.ReadLine()));
                }

                int firstElement = argon.Peek();


                while (true)
                {
                    if (firstElement < powerOrc.Peek())
                    {
                        int resul = powerOrc.Peek() - firstElement;
                        argon.Dequeue();
                        powerOrc.Pop();

                        powerOrc.Push(resul);

                        Console.WriteLine("The orcs successfully destroyed the Gondor's defense.");
                        Console.WriteLine($"Orcs left: {string.Join(", ", powerOrc)}");
                        return;
                    }

                    if (firstElement <= 0)
                    {
                        argon.Dequeue();
                        break;
                    }
                    else
                    {

                        firstElement -= powerOrc.Peek();
                        powerOrc.Pop();
                    }

                   
                   
                }

            }

            Console.WriteLine("The people successfully repulsed the orc's attack.");
            Console.WriteLine($"Plates left: {string.Join(", ", argon)}");
        }
    }
}
