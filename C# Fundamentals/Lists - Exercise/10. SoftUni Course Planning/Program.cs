using System;
using System.Collections.Generic;
using System.Linq;

namespace _10._SoftUni_Course_Planning
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             
            На първия ред ще получите първоначалния график на уроците и упражненията, 
            които ще бъдат част от следващия курс, 
            разделени със запетая и интервал ",". Но преди началото на курса, трябва да се направят някои промени.
            Докато не получите „старт на курса“, ще ви бъдат дадени някои команди за промяна на графика на курса.
            Възможните команди са:
            Добавяне: {chapterTitle} - добавете урока в края на графика, ако не съществува.
            Вмъкване: {chapterTitle}: {index} - вмъкнете урока в дадения индекс, ако той не съществува.
            Премахване: {chapterTitle} - премахване на урока, ако той съществува.
            Размяна: {LectureTitle}: {LectureTitle} - променете мястото на двата урока, ако те съществуват.
            Упражнение: {chapterTitle} - добавете упражнение в графика веднага след индекса на урока, 
            ако урокът съществува и вече няма упражнение, в следния формат „{chapterTitle} -Exercise“.
            Ако урокът не съществува, добавете урока в края на графика на курса, последван от Упражнението.
            Всеки път, когато сменяте или премахвате урок, трябва да направите същото с Упражненията, ако има такива,
            които следват уроците

            Input / Constraints
            • first line – the initial schedule lessons – strings, separated by comma and space ", "
            • until "course start" you will receive commands in the format described above

            Output
            • Print the whole course schedule, each lesson on a new line with its number(index) in the schedule: 
            "{lesson index}.{lessonTitle}"
            • Allowed working time / memory: 100ms / 16MB.
             */
            List<string> lesseons = Console.ReadLine()
                .Split(", ")
                .ToList();

            string command = Console.ReadLine();

            while (command != "course start")
            {
                string[] cmdArds = command.Split(":").ToArray();
                string firstCommand = cmdArds[0];
                string lesseonTitle = cmdArds[1];

                if (firstCommand == "Add")
                {
                    if (!lesseons.Contains(lesseonTitle))
                    {
                        lesseons.Add(lesseonTitle);
                    }
                }
                else if (firstCommand == "Insert")
                {
                    int index = int.Parse(cmdArds[2]);

                    if (!lesseons.Contains(lesseonTitle))
                    {
                        lesseons.Insert(index, lesseonTitle);
                    }
                }
                else if (firstCommand == "Remove")
                {
                    lesseons.Remove(lesseonTitle);
                }
                else if (firstCommand == "Swap")
                {
                    string secondLessonTitle = cmdArds[2];

                    int indexOfFirstLesson = lesseons.IndexOf(lesseonTitle);
                    int indexOfSecondLesson = lesseons.IndexOf(secondLessonTitle);

                    if (indexOfFirstLesson != -1 && indexOfSecondLesson != -1)
                    {
                        lesseons[indexOfFirstLesson] = secondLessonTitle;
                        lesseons[indexOfSecondLesson] = lesseonTitle;

                        string firstLessonExercise = $"{lesseonTitle}-Exercise";
                        int indexOfFirstExercise = indexOfFirstLesson + 1;

                        if (indexOfFirstLesson < lesseons.Count &&
                             lesseons[indexOfFirstExercise] == firstLessonExercise)
                        {
                            lesseons.RemoveAt(indexOfFirstExercise);
                            indexOfFirstExercise = lesseons.IndexOf(lesseonTitle);
                            lesseons.Insert(indexOfFirstExercise, firstLessonExercise);
                        }

                        string secondLessonExercise = $"{secondLessonTitle}-Exercise";
                        int indexOfSecondExercise = indexOfSecondLesson + 1;

                        if (indexOfSecondExercise < lesseons.Count &&
                             lesseons[indexOfSecondExercise] == secondLessonExercise)
                        {
                            lesseons.RemoveAt(indexOfSecondExercise + 1);
                            indexOfSecondLesson = lesseons.IndexOf(secondLessonTitle);
                            lesseons.Insert(indexOfSecondLesson + 1, secondLessonExercise);
                        }
                    }
                }
                else if (firstCommand == "Exercise")
                {
                    int index = lesseons.IndexOf(lesseonTitle);
                    string exercise = $"{lesseonTitle}-Exercise";

                    bool isThereAreLesson = lesseons.Contains(lesseonTitle);
                    bool isThereAreExercise = lesseons.Contains(exercise);

                    if (isThereAreLesson && !isThereAreExercise)
                    {
                        lesseons.Insert(index + 1, exercise);
                    }
                    else if (!isThereAreLesson)
                    {
                        lesseons.Add(lesseonTitle);
                        lesseons.Add(exercise);
                    }

                }


                command = Console.ReadLine();
            }

            for (int i = 0; i < lesseons.Count; i++)
            {
                Console.WriteLine($"{i + 1}.{lesseons[i]}");
            }
        }
    }
}
