
using System;
using System.Collections.Generic;
using System.Linq;

namespace _08._Company_Users
{
    class Program
    {
        static void Main(string[] args)
        {
            var information = new Dictionary<string, List<string>>();

            string input = Console.ReadLine();

            while (input != "End")
            {
                string[] arr = input.Split();

                string compani = arr[0];
                string idNumber = arr[2];

                if (!information.ContainsKey(compani))
                {
                    information.Add(compani, new List<string>() {idNumber});
                }
                else
                {
                    if (!information[compani].Contains(idNumber))
                    {
                        information[compani].Add(idNumber);
                    }
                }

                input = Console.ReadLine();
            }

            foreach (var item in information.OrderBy(x=>x.Key))
            {
                Console.WriteLine($"{item.Key}");
                foreach (var itemCourses in item.Value)
                {
                    Console.WriteLine($"-- {itemCourses}");
                }
            }
        }
    }
}
