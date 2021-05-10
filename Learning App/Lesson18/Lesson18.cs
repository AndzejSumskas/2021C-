using Learning_App.Lesson18.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learning_App.Lesson18
{
    class Lesson18
    {
        static void Main()
        {
            List<Student> students = new List<Student>
            {
                new Student(){Id = 0, Name = "Kestas", Age = 30, AvarageMark = 7.2, IsGettingTuition = true},
                new Student(){Id = 1, Name = "Ona", Age = 25, AvarageMark = 4.2, IsGettingTuition = false},
                new Student(){Id = 2, Name = "Petras", Age = 21, AvarageMark = 8.2, IsGettingTuition = true},
                new Student(){Id = 3, Name = "Gabija", Age = 19, AvarageMark = 4.2, IsGettingTuition = false},
                new Student(){Id = 4, Name = "Jonas", Age = 17, AvarageMark = 9.2, IsGettingTuition = true},
                new Student(){Id = 5, Name = "Biata", Age = 15, AvarageMark = 10, IsGettingTuition = false}
            };

            var result = from s in students
                         where s.Age > 21
                         select s;
            

            var result2 = from s in students
                         where s.AvarageMark > 8 && s.IsGettingTuition == true
                         select s;
            
            var result3 = from s in students
                         where s.AvarageMark<4 || s.Name.Length <8
                         select s;
           


            List<string> studenList = (from s in students
                                        where s.AvarageMark > 8 && s.IsGettingTuition == true
                                        select s.Name).ToList();


            var result4 = (from s in students
                          where s.AvarageMark > 4 || s.Name.Length < 8
                          select s.Id).ToArray();

        }

        public void LessonTaskExtension()
        {
            int sk = 5;

            int sk2 = 75;

            sk2 = sk2.PowerTwo();
            Console.WriteLine(sk.PowerTwo());
        }

        

        public void LesoonTaskLambada()
        {
            // Lambada Expressions Task

            List<Student> students = new List<Student>
            {
                new Student(){Id = 0, Name = "Kestas", Age = 30, AvarageMark = 7.2, IsGettingTuition = true},
                new Student(){Id = 1, Name = "Ona", Age = 25, AvarageMark = 4.2, IsGettingTuition = false},
                new Student(){Id = 2, Name = "Petras", Age = 21, AvarageMark = 8.2, IsGettingTuition = true},
                new Student(){Id = 3, Name = "Gabija", Age = 19, AvarageMark = 4.2, IsGettingTuition = false},
                new Student(){Id = 4, Name = "Jonas", Age = 17, AvarageMark = 9.2, IsGettingTuition = true},
                new Student(){Id = 5, Name = "Biata", Age = 15, AvarageMark = 10, IsGettingTuition = false}
            };



            List<Student> studentCanDrink = students.FindAll(student => student.Age > 20);


            foreach (var item in studentCanDrink)
            {
                Console.WriteLine(item);
            }


        }
    }
}
