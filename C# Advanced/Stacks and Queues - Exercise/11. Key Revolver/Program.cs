using System;
using System.Collections.Generic;
using System.Linq;

namespace _11._Key_Revolver
{
    class Program
    {
        static void Main(string[] args)
        {
            int priceBullet = int.Parse(Console.ReadLine());
            int receiveSizeGun = int.Parse(Console.ReadLine());
            var receiveBulet = Console.ReadLine().Split().Select(int.Parse).ToArray();
            var locks = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int intelligenceValue = int.Parse(Console.ReadLine());

            Queue<int> GunsBullet = new Queue<int>(locks);
            Stack<int> stack = new Stack<int>(receiveBulet);
            int count = 0;
            int cunter = 0;

            foreach (var item in receiveBulet.Reverse())
            {

                if (item >= GunsBullet.Peek())
                {
                    Console.WriteLine("Ping!");
                    stack.Pop();
                    cunter++;
                }
                else
                {
                    GunsBullet.Dequeue();
                    Console.WriteLine("Bang!");
                    stack.Pop();
                    cunter++;
                }

                count++;
                if (receiveSizeGun == count)
                {
                    Console.WriteLine("Reloading!");
                    count = 0;
                }

                if (!GunsBullet.Any())
                {
                    int moneyEarned = cunter * priceBullet;
                    intelligenceValue -= moneyEarned;
                    Console.WriteLine($"{stack.Count} bullets left. Earned ${intelligenceValue}");
                    break;
                }

                if (!stack.Any())
                {
                    Console.WriteLine($"Couldn't get through. Locks left: {GunsBullet.Count}");
                    break;
                }
            }


        }
    }
}
