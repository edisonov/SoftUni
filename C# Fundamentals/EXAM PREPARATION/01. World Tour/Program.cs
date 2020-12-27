using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace _01._World_Tour
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * On the first line you will be given a string containing all of your stops.
             * Until you receive the command "Travel", you will be given some commands to manipulate that initial string.
             * The commands can be:
             * 
             * Switch:{old_string}:{new_string} – if the old string is in the initial string, replace it with the new one.
             * (all occurrences)
             * 
             * 
             */
            string world = Console.ReadLine();

            string command = Console.ReadLine();

            List<char> cmdArgs = world.ToList();
            var wordList = cmdArgs.Select(c => c.ToString().ToList());

            //foreach (var item in cmdArgs)
            //{
            //    wordList.Add(item.ToString());
           // }


            while (command != "Travel")
            {
                string[] arrCommand = command.Split(' ', ':');
                

                if (arrCommand[0] == "Add")
                {
                    int index = int.Parse(arrCommand[2]);

                    foreach (var item in arrCommand[3].Reverse())
                    {
                        //wordList.Insert(index, item.ToString());
                    }

                    Console.WriteLine(string.Join("",wordList));

                    world = wordList.ToString();
                    
                }
                else if (arrCommand[0] == "Remove")
                {
                    int firstIndex = int.Parse(arrCommand[2]);
                    int endIndex = int.Parse(arrCommand[3]);

                  //  if (firstIndex > 0 && endIndex < wordList.Count - 1)
                    {
                        for (int i = firstIndex; i <= endIndex; i++)
                        {
                          //  wordList.RemoveAt(firstIndex);
                        }

                        Console.WriteLine(string.Join("", wordList));

                        world = wordList.ToString();
                    }
                }
                else if (arrCommand[0] == "Switch")
                {
                    string old = arrCommand[1];
                    string newName = arrCommand[2];

                    List<string> words = world.Split(' ').ToList();

                    
                    

                }
                
                command = Console.ReadLine();
            }
        }
    }
}
