using System;

namespace _01._Activation_Keys
{
    class Program
    {
        static void Main(string[] args)
        {
            string activationkey = Console.ReadLine();

            string input = Console.ReadLine();

            while (input != "Generate")
            {
                string[] arr = input.Split(">>>", StringSplitOptions.RemoveEmptyEntries);

                switch (arr[0])
                {
                    case "Contains":
                        if (activationkey.IndexOf(arr[1]) != -1)
                        {
                            Console.WriteLine($"{activationkey} contains {arr[1]}");
                        }
                        else
                        {
                            Console.WriteLine($"Substring not found!");
                        }
                        break;
                    case "Flip":
                        int startIndex = int.Parse(arr[2]);
                        int endIndex = int.Parse(arr[3]);
                        string firstPart = activationkey.Substring(0, startIndex);
                        string secondPart = activationkey.Substring(startIndex, endIndex - startIndex);
                        string thirdPart = activationkey.Substring(endIndex);

                        if (arr[1].ToUpper() == "UPPER")
                        {
                            secondPart = secondPart.ToUpper();
                        }
                        else
                        {
                            secondPart = secondPart.ToLower();
                        }

                        activationkey = firstPart + secondPart + thirdPart;
                        Console.WriteLine(activationkey);
                        break;
                    case "Slice":
                        startIndex = int.Parse(arr[1]);
                        endIndex = int.Parse(arr[2]);

                        activationkey = activationkey.Remove(startIndex, endIndex - startIndex);
                        Console.WriteLine(activationkey);
                        break;
                }


                input = Console.ReadLine();
            }

            Console.WriteLine($"Your activation key is: {activationkey}");
        }
    }
}
