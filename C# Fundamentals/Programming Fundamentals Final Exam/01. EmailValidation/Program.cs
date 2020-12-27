using System;

namespace _01._EmailValidation
{
    class Program
    {
        static void Main(string[] args)
        {
            string email = Console.ReadLine();
            string command = Console.ReadLine();

            while (command != "Complete")
            {
                string[] split = command.Split();
                if (command == "Make Upper")
                {
                    email = email.ToUpper();
                    Console.WriteLine(email);
                }
                if (command == "Make Lower")
                {
                    email = email.ToLower();
                    Console.WriteLine(email);
                }
                if (command.Contains("GetDomain"))
                {
                    int count = int.Parse(split[1]);
                    string domain = email.Substring(email.Length - count, count);
                    Console.WriteLine(domain);
                }
                if (command == "Replace")
                {
                    char replace = char.Parse(split[1]);
                    email = email.Replace(replace, '-');
                    Console.WriteLine(email);
                }
                if (command.Contains("Encrypt"))
                {
                    for (int i = 0; i < email.Length; i++)
                    {
                        Console.Write($"{(int)email[i]} ");
                    }

                    Console.WriteLine();
                }
                if (command == "GetUsername")
                {
                    int index = command.IndexOf("@");
                    if (index < 0)
                    {
                        Console.WriteLine($"The email {email} doesn't contain the @ symbol.");
                    }
                    else
                    {
                        Console.WriteLine(email.Substring(0, index));
                    }
                }


                command = Console.ReadLine();
            }
        }
    }
}
