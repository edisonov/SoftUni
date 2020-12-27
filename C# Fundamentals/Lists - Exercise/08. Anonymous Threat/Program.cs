using System;
using System.Collections.Generic;
using System.Linq;

namespace _08._Anonymous_Threat
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            Анонимните създадоха кибер хипервирус, който краде данни от ЦРУ. 
            Вие, като водещ разработчик на сигурността в ЦРУ,
            сте натоварени да анализирате софтуера на вируса и да наблюдавате действията му върху данните.
            Вирусът е известен със своята иновативна и невероятно умна техника за обединяване и разделяне на данни
            на дялове.
            Ще получите един ред за въвеждане, съдържащ низове, разделени с интервали. 
            Низовете могат да съдържат всеки ASCII символ, с изключение на празно пространство,
            след което ще започнете да получавате команди в един от следните формати:
                • merge {startIndex} {endIndex}
                • divide {index} {partitions}
            много време, когато получите командата за сливане, трябва да обедините всички елементи от startIndex,
            до endIndex. С други думи, трябва да ги обедините.
            Пример: {abc, def, ghi} -> обединяване 0 1 -> {abcdef, ghi}
            Ако някой от дадените индекси е извън масива, трябва да вземете само диапазона, който е вътре в масива,
            и да го обедините.
            Всеки път, когато получите командата за разделяне, 
            трябва да разделите елемента на дадения индекс на няколко малки подниза с еднаква дължина.
            Броят на поднизовете трябва да бъде равен на дадените дялове.
            Пример: {abcdef, ghi, jkl} -> разделяне 0 3 -> {ab, cd, ef, ghi, jkl}
            Ако низът не може да бъде точно разделен на дадените дялове, направете всички дялове с изключение на последния с еднакви дължини и направете последния - най-дълъг.
            Пример: {abcd, efgh, ijkl} -> разделяне 0 3 -> {a, b, cd, efgh, ijkl}
            Входът приключва, когато получите командата “3: 1”.
            В този момент трябва да отпечатате получените елементи, свързани с интервал.

            Input
            • The first input line will contain the array of data.
            • On the next several input lines you will receive commands in the format specified above.
            • The input ends when you receive the command "3:1".

            Output
            • As output you must print a single line containing the elements of the array, joined by a space.
             */
            List<string> data = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).ToList();

            string input = Console.ReadLine();

            while (input != "3:1")
            {
                string[] commandElement = input.Split();
                string command = commandElement[0];

                if (command == "merge")
                {
                    int startIndex = int.Parse(commandElement[1]);
                    int endIndex = int.Parse(commandElement[2]);

                    string concatData = string.Empty;

                    if (startIndex < 0)
                    {
                        if (endIndex >= 0 && endIndex <= data.Count - 1)
                        {
                            startIndex = 0;
                        }
                    }
                    if (endIndex > data.Count - 1)
                    {
                        if (startIndex >= 0 && startIndex <= data.Count - 1)
                        {
                            endIndex = data.Count - 1;
                        }
                    }

                    if ((startIndex >= 0 && startIndex <= data.Count - 1)
                        && (endIndex >= 0 && endIndex <= data.Count - 1))
                    {
                        for (int i = startIndex; i <= endIndex; i++)
                        {
                            concatData += data[i];
                        } 

                        data.RemoveRange(startIndex, endIndex - startIndex + 1);
                        data.Insert(startIndex, concatData);

                    }
                 
                }
                else if (command == "divide")
                {
                    int index = int.Parse(commandElement[1]);
                    int partitions = int.Parse(commandElement[2]);

                    if (index >= 0 && index <= data.Count - 1)
                    {
                        string word = data[index];
                        List<string> dividetWord = new List<string>();
                        int stringLenghtToAdd = word.Length / partitions;
                        int startIndex = 0;

                        for (int i = 0; i < partitions; i++)
                        {
                            if (i == partitions - 1)
                            {
                                dividetWord.Add(word.Substring(startIndex, word.Length - startIndex));
                            }
                            else
                            {
                                dividetWord.Add(word.Substring(startIndex, stringLenghtToAdd));
                                startIndex += stringLenghtToAdd;
                            }
                        }

                        data.RemoveAt(index);
                        data.InsertRange(index, dividetWord);
                    }
                }

                input = Console.ReadLine();
            }
            Console.WriteLine(string.Join(' ', data));
        }
    }
}
