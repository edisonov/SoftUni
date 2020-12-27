using System;
using System.Linq;

namespace _09._Kamino_Factory
{
    class Program
    {
        /*
        Клониращата фабрика в Камино получи още една заповед за клониране на войски.
        Но този път имате задачата да намерите най-добрата ДНК последователност, която да използвате в производството.
        Ще получите дължината на ДНК и докато не получите командата "Клонирайте ги!" ще получите ДНК
        последователности от единици и нули, разделени на "!" (един или няколко).
        Трябва да изберете последователността с най-дългата последователност от тях.
        Ако има няколко последователности с еднаква дължина на последователност от тях, 
        отпечатайте тази с най-левия стартов индекс, ако има няколко последователности с еднаква дължина и начален индекс,
        изберете последователността с по-голямата сума от нейните елементи.
        След като получите последната команда "Клонирайте ги!"
        трябва да отпечатате събраната информация в следния формат:

        "Best DNA sample {bestSequenceIndex} with sum: {bestSequenceSum}."
        "{DNA sequence, joined by space}"

        Input / Constraints
        • The first line holds the length of the sequences – integer in range [1…100];
        • On the next lines until you receive "Clone them!" you will be receiving sequences (at least one) of ones and zeroes, split by "!" (one or several).
        Output
        The output should be printed on the console and consists of two lines in the following format:
        "Best DNA sample {bestSequenceIndex} with sum: {bestSequenceSum}."
        "{DNA sequence, joined by space}"
        */
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            string input = Console.ReadLine();

            int bestLength = 1;
            int bestStartIndex = 0;
            int bestSequseceSum = 0;
            int bestSequenceIndex = 0;
            int[] bestSequence = new int[n];

            int sequenceCounter = 0;

            while (input != "Clone them!")
            {
                int[] currentSequence = input
                    .Split('!', StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToArray();

                sequenceCounter++;

                int length = 1;
                int besetCurrentLength = 1;
                int startIndex = 0;
                int currentSequeceSum = 0;

                for (int i = 0; i < currentSequence.Length - 1; i++)
                {
                    if (currentSequence[i] == currentSequence[i + 1])
                    {
                        length++;
                    }
                    else
                    {
                        length = 1;
                    }

                    if (length > besetCurrentLength)
                    {
                        besetCurrentLength = length;
                        startIndex = i;
                    }
                    currentSequeceSum += currentSequence[i];
                }
                currentSequeceSum += currentSequence[n - 1];

                if (besetCurrentLength > bestLength)
                {
                    bestLength = besetCurrentLength;
                    bestStartIndex = startIndex;
                    bestSequseceSum = currentSequeceSum;
                    bestSequenceIndex = sequenceCounter;
                    bestSequence = currentSequence.ToArray();
                }
                else if (besetCurrentLength == bestLength)
                {
                    if (startIndex < bestStartIndex)
                    {
                        bestLength = besetCurrentLength;
                        bestStartIndex = startIndex;
                        bestSequseceSum = currentSequeceSum;
                        bestSequenceIndex = sequenceCounter;
                        bestSequence = currentSequence.ToArray();
                    }
                    else if (startIndex == bestStartIndex)
                    {
                        if (currentSequeceSum > bestSequseceSum)
                        {
                            bestLength = besetCurrentLength;
                            bestStartIndex = startIndex;
                            bestSequseceSum = currentSequeceSum;
                            bestSequenceIndex = sequenceCounter;
                            bestSequence = currentSequence.ToArray();
                        }
                    }
                }

                input = Console.ReadLine();
            }
            Console.WriteLine($"Best DNA sample {bestSequenceIndex} with sum: {bestSequseceSum}.");
            Console.WriteLine(string.Join(' ', bestSequence));
        }
    }
}
