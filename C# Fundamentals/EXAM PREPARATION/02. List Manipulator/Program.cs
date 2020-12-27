using System;
using System.Collections.Generic;
using System.Linq;

namespace _02._List_Manipulator
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> friends = Console.ReadLine()
                .Split(",", StringSplitOptions.RemoveEmptyEntries)
                .ToList();

            List<string> total = friends.ToList();

            List<string> blackList = new List<string>();

                int lost = 0;
                int blacklis = 0;

            string command = Console.ReadLine();

            while(command != "Report")
            {
                string[] cmdArgs = command.Split();


                switch (cmdArgs[0])
                {
                    case "Blacklist":

                        string bList = cmdArgs[1];
                        
                        if (friends.Contains(bList))
                        {
                            blackList.Add(bList);
                            for (int i = 0; i < friends.Count; i++)
                            {
                                if (friends[i] == bList)
                                {
                                   friends[i] = "Blacklisted";
                                    blacklis++;
                                }
                            }
                            Console.WriteLine($"{bList} was blacklisted.");
                        }
                        else
                        {
                            Console.WriteLine($"{bList} was not found.");
                        }
                        break;
                    case "Error":
                        int index = int.Parse(cmdArgs[1]);

                        if (blackList.Contains(total[index]))
                        {
                            break;
                        }
                        else
                        {
                            friends.FindIndex(x => x == "Lost");
                           
                               
                                    
                                    lost++;
                                Console.WriteLine($"{total[index]} was lost due to an error.");
                              
                           
                        }
                        break;
                    case "Change":
                        int indexChange = int.Parse(cmdArgs[1]);

                        if (indexChange < 0 && indexChange > friends.Count - 1)
                        {
                            break;
                        }
                        else
                        {
                            Console.WriteLine($"{friends[indexChange]} changed his username to {cmdArgs[2]}.");
                            friends[indexChange] = cmdArgs[2];
                        }
                        break;
                    
                }
                
                command = Console.ReadLine();
            }

            Console.WriteLine($"Blacklisted names: {blacklis}");
            Console.WriteLine($"Lost names: {lost}");
            Console.WriteLine(string.Join(" ",friends));
        }
    }
}
