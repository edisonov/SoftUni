using System;
using System.Collections.Generic;
using System.Linq;

namespace _07._The_V_Logger
{
    class Program
    {
        static void Main(string[] args)
        {
            //Dictionary<string, int[]> asdw = new Dictionary<string, int[]>();
            //Dictionary<string, SortedSet<string>[]> asd = new Dictionary<string, SortedSet<string>[]>();
            //var userData = new[] {new SortedSet<string>(), new SortedSet<string>()};
            //asd.Add("User one", userData);
            //SortedSet<string>[] data = asd["User one"];
            //asd["User one"][0].Add("User two");

            Dictionary<string, Dictionary<string, SortedSet<string>>> app =
                new Dictionary<string, Dictionary<string, SortedSet<string>>>();

            //app.Add("User one", new Dictionary<string, SortedSet<string>>());
            //app["User one"].Add("following", new SortedSet<string>());
            //app["User one"].Add("followers", new SortedSet<string>());

            string input = Console.ReadLine();

            while (input != "Statistics")
            {
                string[] command = input.Split();
                string vloggerName = command[0];
                string commandData = command[1];

                if (commandData == "joined")
                {
                    if (!app.ContainsKey(vloggerName))
                    {
                        app.Add(vloggerName, new Dictionary<string, SortedSet<string>>());
                        app[vloggerName].Add("following", new SortedSet<string>());
                        app[vloggerName].Add("followers", new SortedSet<string>());
                    }
                }
                else if (commandData == "followed")
                {
                    string vloggerTwoName = command[2];

                    if (app.ContainsKey(vloggerName) && app.ContainsKey(vloggerTwoName) &&
                        vloggerName != vloggerTwoName)
                    {
                        app[vloggerName]["following"].Add(vloggerTwoName);
                        app[vloggerTwoName]["followers"].Add(vloggerName);
                    }
                }

                input = Console.ReadLine();
            }

            Console.WriteLine($"The V-Logger has a total of {app.Count} vloggers in its logs.");
            int counter = 0;

            foreach (var item in app
                .OrderByDescending(x=> x.Value["followers"].Count)
                .ThenBy(x=>x.Value["following"].Count))
            {
                int followersCount = item.Value["followers"].Count;
                int followingCount = item.Value["following"].Count;

                Console.WriteLine($"{++counter}. {item.Key} : {followersCount} followers, {followingCount} following");

                if (counter == 1)
                {
                    foreach (var followers in item.Value["followers"])
                    {
                        Console.WriteLine($"* {followers}");
                    }
                }
            }
        }
    }
}
