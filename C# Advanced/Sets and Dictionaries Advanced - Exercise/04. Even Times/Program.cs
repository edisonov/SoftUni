using System;
using System.Collections.Generic;
using System.Linq;

namespace _04._Even_Times
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Dictionary<int, int> result = new Dictionary<int, int>();

            for (int i = 0; i < n; i++)
            {
                int num = int.Parse(Console.ReadLine());

                if (!result.ContainsKey(num))
                {
                    result.Add(num, 0);
                } 
                
                result[num]++;
               
            }

            //Dictionary<int, int> evenNumber = result
            //    .Where(x => x.Value % 2 == 0)
            //    .ToDictionary(x=>x.Key, x=> x.Value);

            KeyValuePair<int, int> kvp = result.First(kvp => kvp.Value % 2 == 0);
            Console.WriteLine(kvp.Key);
        }
    }
}
