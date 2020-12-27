using System;
using System.Collections.Generic;
using System.Linq;

namespace _03._School_Library
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> books = Console.ReadLine().Split('&').ToList();

            string command = Console.ReadLine();

            while (command != "Done")
            {
                string[] cmdArr = command.Split(" | ");

                string commandBook = cmdArr[0];

                if (commandBook == "Add Book")
                {
                    if (!books.Contains(cmdArr[1]))
                    {
                        books.Insert(0, cmdArr[1]);
                    }
                }
                else if (commandBook == "Take Book")
                {
                    if (books.Contains(cmdArr[1]))
                    {
                        books.Remove(cmdArr[1]);
                    }
                }
                else if (commandBook == "Swap Books")
                {
                    string firstBook = cmdArr[1];
                    string secondtBook = cmdArr[2];
                    int firstIndex = 0;
                    int secondIndex = 0;

                    if (books.Contains(firstBook) && books.Contains(secondtBook))
                    {
                        for (int i = 0; i < books.Count; i++)
                        {
                            if (books[i] == firstBook)
                            {
                                firstIndex = i;
                            }
                            else if (books[i] == secondtBook)
                            {
                                secondIndex = i;
                            }
                        }

                        var change = books[firstIndex];
                        books[firstIndex] = books[secondIndex];
                        books[secondIndex] = change;

                    }
                }
                else if (commandBook == "Insert Book")
                {
                    books.Add(cmdArr[1]);
                }
                else if (commandBook == "Check Book")
                {
                    int index = int.Parse(cmdArr[1]);

                    if (index >= 0 && index < books.Count)
                    {
                        if (books.Contains(books[index]))
                        {
                            Console.WriteLine(books[index]);
                        }
                    }
                 
                } 
                    

                command = Console.ReadLine();
            }

            Console.WriteLine(string.Join(", ", books));
        }
    }
}
