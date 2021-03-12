using System;
using System.Collections.Generic;
using System.Linq;

namespace _10.SoftUniCoursePlanning
{
    class Program
    {
        static void Main()
        {
            List<string> initialSchedule = Console.ReadLine().Split(", ").ToList();
            List<string> commands = Console.ReadLine().Split(":").ToList();

            while (commands[0] != "course start")
            {
                switch (commands[0])
                {
                    case "Add":
                        if (!initialSchedule.Contains(commands[1]))
                        {
                            initialSchedule.Add(commands[1]);
                        }
                        break;

                    case "Insert":
                        if (!initialSchedule.Contains(commands[1]))
                        {
                            initialSchedule.Insert(int.Parse(commands[2]), commands[1]);
                        }
                        break;

                    case "Remove":
                        if (initialSchedule.Contains(commands[1]))
                        {
                            initialSchedule.Remove(commands[1]);

                            if (initialSchedule.Contains($"{commands[1]}-Exercise"))
                            {
                                initialSchedule.Remove($"{commands[1]}-Exercise");
                            }
                        }
                        break;

                    case "Swap":
                        if (initialSchedule.Contains(commands[1]) && initialSchedule.Contains(commands[2]))
                        {
                            int firstLessonIndex = initialSchedule.IndexOf(commands[1]);
                            int secondLessonIndex = initialSchedule.IndexOf(commands[2]);
                            string firstLesson = initialSchedule[firstLessonIndex];
                            initialSchedule[firstLessonIndex] = initialSchedule[secondLessonIndex];
                            initialSchedule[secondLessonIndex] = firstLesson;

                            if (initialSchedule.Contains($"{commands[1]}-Exercise"))
                            {
                                string firstLessonExercise = initialSchedule[firstLessonIndex + 1];
                                initialSchedule.RemoveAt(initialSchedule.IndexOf($"{commands[1]}-Exercise"));
                                initialSchedule.Insert(firstLessonIndex + 1, firstLessonExercise);
                            }
                            if (initialSchedule.Contains($"{commands[2]}-Exercise"))
                            {
                                string secondLessonExercise = initialSchedule[secondLessonIndex + 1];
                                initialSchedule.RemoveAt(initialSchedule.IndexOf($"{commands[2]}-Exercise"));
                                initialSchedule.Insert(firstLessonIndex + 1, secondLessonExercise);
                            }
                        }
                        break;

                    case "Exercise":
                        if (initialSchedule.Contains(commands[1]))
                        {
                            if (!initialSchedule.Contains($"{commands[1]}-Exercise"))
                            {
                                int lessonIndex = initialSchedule.IndexOf(commands[1]);
                                initialSchedule.Insert(lessonIndex + 1, $"{commands[1]}-Exercise");
                            }
                        }
                        else
                        {
                            initialSchedule.Add(commands[1]);
                            initialSchedule.Add($"{commands[1]}-Exercise");
                        }
                        break;
                }

                commands = Console.ReadLine().Split(":").ToList();
            }

            int counter = 1;

            foreach (var lesson in initialSchedule)
            {
                Console.WriteLine($"{counter}.{lesson}");
                counter++;
            }
        }
    }
}
