using System;
using System.Linq;
using System.Collections.Generic;

namespace midExam_demo
{
    class Program
    {
        static void Main(string[] args)
        {
            
            string elementInput = Console.ReadLine();
            List<string> stringText = elementInput.Split(", ").ToList();

            string element = Console.ReadLine();

            while (element != "Craft!")
            {
                var cmdArgs = element.Split(" - ");
                var command = cmdArgs[0];

                switch (command)
                {
                    case "Collect":
                        if (!stringText.Contains(cmdArgs[1]))
                        {
                            stringText.Add(cmdArgs[1]);
                        }
                        break;
                    case "Drop":
                        if (stringText.Contains(cmdArgs[1]))
                        {
                            stringText.Remove(cmdArgs[1]);
                        }
                        break;
                    case "Combine Items":
                        var splitElement = cmdArgs[1].Split(":");
                        var oldElement = splitElement[0];
                        var newElement = splitElement[1];

                        if (stringText.Contains(oldElement))
                        {
                            var index = stringText.IndexOf(oldElement);
                            stringText.Insert(index + 1, newElement);

                        }
                        break;
                    case "Renew":
                        if (stringText.Contains(cmdArgs[1]))
                        {
                            stringText.Remove(cmdArgs[1]);
                            stringText.Add(cmdArgs[1]);
                        }
                        break;
                }


                element = Console.ReadLine();
            }

            Console.WriteLine(string.Join(", ", stringText));
        }
    }
}
