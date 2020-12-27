using System;
using System.Linq;

namespace _01._Problem
{
    class Program
    {
        static void Main(string[] args)
        {
            string email = Console.ReadLine();

            string input = Console.ReadLine();

            while (input != "Complete")
            {
                var cmdArgs = input.Split();
                var command = cmdArgs[0];

                switch (command)
                {
                    case "Make":
                        if (cmdArgs[1] == "Upper")
                        {
                            email = email.ToUpper();
                            Console.WriteLine(email);
                        }
                        else
                        {
                            email = email.ToLower();
                            Console.WriteLine(email);
                        }
                        break;
                    case "GetDomain":
                        int count = int.Parse(cmdArgs[1]);
                        string domain = email.Substring(email.Length - count, count);
                        Console.WriteLine(domain);
                        break;
                    case "GetUsername":
                        int index = email.IndexOf("@");
                        if (index < 0)
                        {
                            Console.WriteLine($"The email {email} doesn't contain the @ symbol.");
                        }
                        else
                        {
                            Console.WriteLine(email.Substring(0, index));
                        }
                        break;
                    case "Replace":
                        char replace = char.Parse(cmdArgs[1]);
                        email = email.Replace(replace, '-');
                        Console.WriteLine(email);
                        break;
                    case "Encrypt":
                        for (int i = 0; i < email.Length; i++)
                        {
                            Console.Write($"{(int)email[i]} ");
                        }

                        Console.WriteLine();
                        break;
                    
                }

                input = Console.ReadLine();
            }
        }
    }
}
