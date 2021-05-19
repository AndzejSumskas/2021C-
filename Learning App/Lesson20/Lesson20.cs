using Learning_App.Lesson18;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learning_App.Lesson20
{
    class Lesson20
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
                         where s.Name.Length > 5
                         select new { s.Id, s.Name, Status = GetStatusFromMark(s.AvarageMark) }
                              into studentStatusObject
                              group studentStatusObject by studentStatusObject.Status;
        }

        private static StudentStatus GetStatusFromMark(double avarageMark)
        {
            if (avarageMark < 5)
                return StudentStatus.Bad;
            else if (avarageMark > 8)
                return StudentStatus.Good;
            else
                return StudentStatus.Ok;
        }

        public void Task2()
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
            var task2rasul1 = from s in students
                              where s.Age > 20
                              orderby s.Name
                              select new { s.Id, s.Name };

            foreach (var st in task2rasul1)
            {
                Console.WriteLine(st.Id + st.Name);
            }

            var task2Result2 = from s in students
                               where s.IsGettingTuition
                               select new { Name = s.Name, GoodStudent = s.AvarageMark > 8 };

            foreach (var st in task2Result2)
            {
                Console.WriteLine(st.Name + " " + st.GoodStudent);
            }

        }


        public void Task1()
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
            var studentsList = from s in students
                               select s.Name;


            foreach (var item in studentsList)
            {
                Console.WriteLine(item);
            }

            var result2 = from s in students
                          where s.Age > 20 && s.Age < 35
                          select s;


            var result3 = from s in students
                          where s.AvarageMark > 5 && s.IsGettingTuition == false
                          orderby s.Age
                          select s;
            Console.WriteLine("where s.AvarageMark > 5 && s.IsGettingTuition == false");

            foreach (var st in result3)
            {
                Console.WriteLine($"Name:{st.Name} Average mark:{st.AvarageMark} Is getting tuition:{st.IsGettingTuition}");
            }
        }
    }
}
