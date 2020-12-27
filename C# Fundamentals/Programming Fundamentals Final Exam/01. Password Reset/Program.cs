using System;
using System.Linq;
using System.Text;

namespace _01._Password_Reset
{
    class Program
    {
        static void Main(string[] args)
        {
            string password = Console.ReadLine();

            string input = Console.ReadLine();

            while (input != "Done")
            {
                string[] command = input.Split(" ",StringSplitOptions.RemoveEmptyEntries);

                string cmdArgs = command[0];


                switch (cmdArgs)
                {
                    case "TakeOdd":

                        StringBuilder sb = new StringBuilder();

                        for (int i = 0; i < password.Length; i++)
                        {
                            if (i % 2 != 0)
                            {
                                sb.Append(password[i]);
                            }
                        }

                        password = sb.ToString();
                        Console.WriteLine(password);

                        break;
                    case "Cut":
                        int index = int.Parse(command[1]);
                        int length = int.Parse(command[2]);

                        password = password.Remove(index, length);
                        Console.WriteLine(password);
                        break;
                    case "Substitute":
                        string substring = command[1];
                        string substitute = command[2];

                        if (password.Contains(substring))
                        {
                            password = password.Replace(substring, substitute);
                            
                            Console.WriteLine(password);
                        }
                        else
                        {
                            Console.WriteLine("Nothing to replace!");
                        }
                        break;
                }

                input = Console.ReadLine();
            }

            Console.WriteLine($"Your password is: {password}");
        }
    }
}
