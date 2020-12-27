using System;
using System.Linq;
using System.Text;

namespace _01._Secret_Chat
{
    class Program
    {
        static void Main(string[] args)
        {
            string message = Console.ReadLine();

            string command = Console.ReadLine();

            while (command != "Reveal")
            {
                string[] cmdArgs = command.Split(":|:", StringSplitOptions.RemoveEmptyEntries);
                string coman = cmdArgs[0];

                if (coman == "InsertSpace")
                {
                    int index = int.Parse(cmdArgs[1]);
                    message = message.Insert(index, " ");
                    Console.WriteLine(message);
                }
                else if (coman == "Reverse")
                {
                    string substring = cmdArgs[1];

                    if (message.Contains(substring))
                    {
                        message = message.Remove(message.IndexOf(substring), substring.Length);

                        var reverse = new string(substring.Reverse().ToArray());
                        //var reverse = String.Concat(substring.Reverse());
                        message += reverse;

                        Console.WriteLine(message);
                    }
                    else
                    {
                        Console.WriteLine("error");
                    }

                }
                else if (coman == "ChangeAll")
                {
                    var substringToChange = cmdArgs[1];
                    var replacement = cmdArgs[2];
                    
                    message = message.Replace(substringToChange, replacement);

                    Console.WriteLine(message);

                }

                command = Console.ReadLine();
            }

            Console.WriteLine($"You have a new text message: {message}");
        }
    }
}
