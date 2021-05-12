using Learning_App.Lesson18;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learning_App.Lesson19
{
    class Program19
    {
        static void Main()
        {
            IList<Student> students = new List<Student>
            {
                new Student(){Id = 0, Name = "Kestas", Age = 30, AvarageMark = 7.2, IsGettingTuition = true},
                new Student(){Id = 1, Name = "Ona", Age = 25, AvarageMark = 4.2, IsGettingTuition = false},
                new Student(){Id = 2, Name = "Petras", Age = 21, AvarageMark = 8.2, IsGettingTuition = true},
                new Student(){Id = 3, Name = "Gabija", Age = 19, AvarageMark = 4.2, IsGettingTuition = false},
                new Student(){Id = 4, Name = "Jonas", Age = 17, AvarageMark = 9.2, IsGettingTuition = true},
                new Student(){Id = 5, Name = "Biata", Age = 15, AvarageMark = 10, IsGettingTuition = false},
                new Student(){Id = 6, Name = "Kestutis", Age = 30, AvarageMark = 7.2, IsGettingTuition = true},
                new Student(){Id = 7, Name = "Onute", Age = 25, AvarageMark = 4.2, IsGettingTuition = false},
                new Student(){Id = 8, Name = "Jonukas", Age = 21, AvarageMark = 8.2, IsGettingTuition = true},
                new Student(){Id = 9, Name = "Galina", Age = 19, AvarageMark = 4.2, IsGettingTuition = false},
                new Student(){Id = 10, Name = "Simas", Age = 17, AvarageMark = 9.2, IsGettingTuition = true},
                new Student(){Id = 11, Name = "Beata", Age = 15, AvarageMark = 10, IsGettingTuition = false}
            };

            var result = from s in students
                         group s by s.Age;

            foreach (var studentsByAge in result)
            {
                Console.WriteLine("*****************************************");
                Console.WriteLine($"Students {studentsByAge.Key} years old:");

                foreach (var student in studentsByAge)
                {

                    Console.WriteLine($"Name:{student.Name}, Age: {student.Age}");
                }
            }


            var result2 = students.GroupBy(gr => gr.IsGettingTuition);

            foreach(var studentsByGroup in result2)
            {
                Console.WriteLine("*****************************************");
                Console.WriteLine($"{studentsByGroup.Key}");

                foreach (var student in studentsByGroup)
                {

                    Console.WriteLine($"Name:{student.Name}, Age: {student.Age}, IsGettingTuition: {student.IsGettingTuition}");
                }
            }


            var group = from s in students
                        group s by new { age = s.Age / 10, isGettingTuition = s.IsGettingTuition };

            var result3 = students.GroupBy(s => new {age = s.Age/10, isGettingTuition = s.IsGettingTuition });

            foreach (var studentss in result3)
            {
                Console.WriteLine("*****************************************");
                Console.WriteLine($"{studentss.Key}");

                foreach (var student in studentss)
                {

                    Console.WriteLine($"Name:{student.Name}, Age: {student.Age}");
                }
            }




        }

        private void FirstTask()
        {
            IList<Student> students = new List<Student>
            {
                new Student(){Id = 0, Name = "Kestas", Age = 30, AvarageMark = 7.2, IsGettingTuition = true},
                new Student(){Id = 1, Name = "Ona", Age = 25, AvarageMark = 4.2, IsGettingTuition = false},
                new Student(){Id = 2, Name = "Petras", Age = 21, AvarageMark = 8.2, IsGettingTuition = true},
                new Student(){Id = 3, Name = "Gabija", Age = 19, AvarageMark = 4.2, IsGettingTuition = false},
                new Student(){Id = 4, Name = "Jonas", Age = 17, AvarageMark = 9.2, IsGettingTuition = true},
                new Student(){Id = 5, Name = "Biata", Age = 15, AvarageMark = 10, IsGettingTuition = false}
            };

            Console.WriteLine("resultByAverageMark");
            var resultByAverageMark = from s in students
                                      orderby s.AvarageMark
                                      select s;

            foreach (var s in resultByAverageMark)
            {
                Console.WriteLine($"Name:{s.Name}, Average mark: {s.AvarageMark}");
            }

            Console.WriteLine();
            Console.WriteLine("resultFromolderToYounger");
            var resultFromolderToYounger = from s in students
                                           orderby s.Age descending
                                           select s;

            foreach (var s in resultFromolderToYounger)
            {
                Console.WriteLine($"Name:{s.Name}, Age: {s.Age}");
            }

            Console.WriteLine();
            Console.WriteLine("resultAgeAndAverageMark");
            var resultAgeAndAverageMark = students.OrderBy(s => s.Age).ThenByDescending(s => s.AvarageMark);

            foreach (var s in resultAgeAndAverageMark)
            {
                Console.WriteLine($"Name:{s.Name}, Age: {s.Age}, Average mark: {s.AvarageMark}");
            }

            Console.WriteLine();
            Console.WriteLine("query");

            var data = from s in students
                       orderby s
                       select s;

            foreach (var s in data)
            {
                Console.WriteLine($"Name:{s.Name}, Age: {s.Age}");
            }
        }

        private void PreLessonTask()
        {
            PreLessonTask p = new PreLessonTask();
            p.MethoMain();
        }
    }
}
