using System;

namespace demo
{
    class Program
    {
        static void Main(string[] args)
        {
            string start = Console.ReadLine();
            string end = Console.ReadLine();

            for (int i = start[0]; i <= end[0]; i++)
            {
                for (int j = start[1]; j <= end[1]; j++)
                {
                    for (int k = start[2]; k <= end[2]; k++)
                    {
                        for (int l = start[3]; l <= end[3]; l++)
                        {
                            if (i % 2 != 0 && j % 2 != 0 && k % 2 != 0 && l % 2 != 0)
                            {
                                Console.Write("{0}{1}{2}{3} ", i, j, k, l);
                            }
                        }
                    }
                }
            }
        }
    }
}
