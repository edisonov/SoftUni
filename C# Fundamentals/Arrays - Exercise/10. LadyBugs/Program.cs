using System;
using System.Linq;

namespace _10._LadyBugs
{
    class Program
    {
        /*
         
        Получавате размер на полето и индексите на калинките в полето.
        След това на всеки нов ред, докато не бъде дадена командата "end", 
        калинка променя позицията си отляво или отдясно с дадена дължина на мухата.
        Команда към калинка изглежда така: "0 вдясно 1". 
        Това означава, че малкото насекомо, поставено върху индекс 0, трябва да лети с един индекс вдясно. 
        Ако калинката кацне върху друга калинка, тя продължава да лети в същата посока със същата дължина на мухата.
        Ако калинката излети извън полето, тя я няма.
        Например, представете си, че ви е дадено поле с размер 3 и калинки на индекси 0 и 1.
        Ако калинката на индекс 0 трябва да отлети вдясно с дължината 1 (0 вдясно 1),
        тя ще се опита да кацне на индекс 1 но тъй като има друга калинка там, 
        тя ще продължи по-надясно с допълнителна дължина 1, кацайки на индекс 2.
        След това, ако същата калинка трябва да лети вдясно с дължината 1 (2 вдясно 1),
        ще кацне някъде извън полето, така че отлети:
        Ако ви бъде даден индекс на калинки, в който там няма калинка, нищо не се случва. 
        Ако ви се даде индекс на калинка, който е извън полето, нищо не се случва.
        Вашата работа е да създадете програмата, симулирайки калинките, които летят наоколо, без да правят нищо.
        В края отпечатайте всички клетки в полето, разделени с празни интервали. 
        За всяка клетка, на която има калинка, отпечатайте „1“, а за всяка празна клетка отпечатайте „0“. 
        За горния пример изходът трябва да бъде „0 1 0“.
        Input
        • On the first line you will receive an integer - the size of the field
        • On the second line you will receive the initial indexes of all ladybugs separated by a blank space. The given indexes may or may not be inside the field range
        • On the next lines, until you get the "end" command you will receive commands in the format: "{ladybug index} {direction} {fly length}"
        Output
        • Print the all cells within the field in format: "{cell} {cell} … {cell}"
        ◦ If a cell has ladybug in it, print '1'
        ◦ If a cell is empty, print '0' 
        */
        static void Main(string[] args)
        {
            int fieldSize = int.Parse(Console.ReadLine());

            int[] initialIndex = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();
            int[] field = new int[fieldSize];

            for (int i = 0; i < initialIndex.Length; i++)
            {
                int currentIndex = initialIndex[i];

                if (currentIndex >= 0 && currentIndex < field.Length)
                {
                   field[currentIndex] = 1;
                }
            }

            string command = string.Empty;

            while ((command = Console.ReadLine()) != "end")
            {
                string[] element = command.Split();
                int ladyBugIndex = int.Parse(element[0]);
                string direction = element[1];
                int flyLength = int.Parse(element[2]);

                if (ladyBugIndex < 0 || ladyBugIndex > field.Length - 1 || field[ladyBugIndex] == 0)
                {
                    continue;
                }

                field[ladyBugIndex] = 0;

                if (direction == "right")
                {
                    int landIndex = ladyBugIndex + flyLength;
                    if (landIndex > field.Length - 1)
                    {
                        continue;
                    }
                    if (field[landIndex] ==1)
                    {
                        while (field[landIndex] == 1)
                        {
                            landIndex += flyLength;
                            if (landIndex > field.Length - 1)
                            {
                                break;
                            }
                        }
                    }
                    if (landIndex >= 0 && landIndex <= field.Length - 1)
                    {
                        field[landIndex] = 1;
                    }
                }
                else if (direction == "left")
                {
                    int landIndex = ladyBugIndex - flyLength;

                    if (landIndex < 0)
                    {
                        continue;
                    }

                    if (field[landIndex] == 1)
                    {
                        while (field[landIndex] == 1)
                        {
                            landIndex -= flyLength;
                            if (landIndex < 0)
                            {
                                break;
                            }
                        }
                    }
                    if (landIndex >= 0 && landIndex <= field.Length - 1)
                    {
                        field[landIndex] = 1;
                    }

                }
            }
            Console.WriteLine(string.Join(' ', field));
        }
    }
}
