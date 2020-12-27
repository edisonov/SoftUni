using System;

namespace _01._The_Imitation_Game
{
    class Program
    {
        static void Main(string[] args)
        {
            string message = Console.ReadLine();
            string input = Console.ReadLine();

            while (input != "Decode")
            {
                var cmdArgs = input.Split("|");
                var command = cmdArgs[0];

                switch (command)
                {
                    case "Move":
                        var substring = message.Substring(0, int.Parse(cmdArgs[1]));
                        message = message.Remove(0, int.Parse(cmdArgs[1]));
                        message += substring;
                        break;
                    case "Insert":
                        int index = int.Parse(cmdArgs[1]);
                        string element = cmdArgs[2];

                        message = message.Insert(index, element);
                        break;
                    case "ChangeAll":
                        char oldName = char.Parse(cmdArgs[1]);
                        char newName = char.Parse(cmdArgs[2]);

                        message = message.Replace(oldName, newName);
                        break;
                }

                input = Console.ReadLine();
            }

            Console.WriteLine($"The decrypted message is: {message}");
        }
    }
}
