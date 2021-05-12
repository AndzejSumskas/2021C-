using Learning_App.Lesson19.PreLeesonTask;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learning_App.Lesson19
{
    class PreLessonTask
    {


        public void MethoMain()
        {
            Task93();


        }

        private void Task93()
        {
            // Student collection
            IList<Student> studentList = new List<Student>() {
                new Student() { StudentID = 1, StudentName = "John", Age = 18, StandardID = 2 } ,
                new Student() { StudentID = 2, StudentName = "Steve",  Age = 21, StandardID = 2 } ,
                new Student() { StudentID = 3, StudentName = "Bill",  Age = 18, StandardID = 1 } ,
                new Student() { StudentID = 4, StudentName = "Ram" , Age = 20, StandardID = 1 } ,
                new Student() { StudentID = 5, StudentName = "Ron" , Age = 21 }
            };

            IList<Standard> standardList = new List<Standard>() {
                new Standard(){ StandardID = 1, StandardName="Standard One"},
                new Standard(){ StandardID = 2, StandardName="Standard Two"},
                new Standard(){ StandardID = 3, StandardName="Standard Tree"}
            };

            var innerJoinResult = studentList.Join(// outer sequence 
                          standardList,  // inner sequence 
                          student => student.StandardID,    // outerKeySelector
                          standard => standard.StandardID,  // innerKeySelector
                          (student, standard) => new  // result selector
                      {
                              StudentName = student.StudentName,
                              StandardName = standard.StandardName
                          });

            foreach (var obj in innerJoinResult)
            {

                Console.WriteLine("{0} - {1}", obj.StudentName, obj.StandardName);
            }
        }

        private void Task92()
        {
            // Student collection
            IList<string> strList1 = new List<string>() {
            "One",
            "Two",
            "Three",
            "Four"
            };

            IList<string> strList2 = new List<string>() {
            "One",
            "Two",
            "Five",
            "Six"
            };

            var innerJoinResult = strList1.Join(// outer sequence 
                          strList2,  // inner sequence 
                          str => str,    // outerKeySelector
                          str2 => str2,  // innerKeySelector
                          (str1, str2) => str1);

            foreach (var str in innerJoinResult)
            {
                Console.WriteLine("{0} ", str);
            }
        }

        private void Task91()
        {
            IList<Student> studentList = new List<Student>() {
                new Student() { StudentID = 1, StudentName = "John", Age = 18 } ,
                new Student() { StudentID = 2, StudentName = "Steve",  Age = 15 } ,
                new Student() { StudentID = 3, StudentName = "Bill",  Age = 25 } ,
                new Student() { StudentID = 4, StudentName = "Ram" , Age = 20 } ,
                new Student() { StudentID = 5, StudentName = "Ron" , Age = 19 }
            };

            var thenByResult = studentList.OrderBy(s => s.StudentName).ThenBy(s => s.Age);

            var thenByDescResult = studentList.OrderBy(s => s.StudentName).ThenByDescending(s => s.Age);

            Console.WriteLine("ThenBy:");

            foreach (var std in thenByResult)
                Console.WriteLine("Name: {0}, Age:{1}", std.StudentName, std.Age);

            Console.WriteLine("ThenByDescending:");

            foreach (var std in thenByDescResult)
                Console.WriteLine("Name: {0}, Age:{1}", std.StudentName, std.Age);

        }

        private void Task9()
        {
            // Student collection
            IList<Student> studentList = new List<Student>() {
                new Student() { StudentID = 1, StudentName = "John", Age = 18 } ,
                new Student() { StudentID = 2, StudentName = "Steve",  Age = 15 } ,
                new Student() { StudentID = 3, StudentName = "Bill",  Age = 25 } ,
                new Student() { StudentID = 4, StudentName = "Ram" , Age = 20 } ,
                new Student() { StudentID = 5, StudentName = "Ron" , Age = 19 }
            };
            //Example: OrderBy in Query Syntax C#
            var orderByResult = from s in studentList
                                orderby s.StudentName //Sorts the studentList collection in ascending order
                                select s;

            var orderByDescendingResult = from s in studentList //Sorts the studentList collection in descending order
                                          orderby s.StudentName descending
                                          select s;

            Console.WriteLine("Ascending Order:");

            foreach (var std in orderByResult)
                Console.WriteLine(std.StudentName);

            Console.WriteLine("Descending Order:");

            foreach (var std in orderByDescendingResult)
                Console.WriteLine(std.StudentName);

            //Example: OrderBy in Method Syntax C#

            Console.WriteLine("Example: OrderBy in Method Syntax C#");

            var studndentInOrder = studentList.OrderBy(s => s.StudentName);

            var studentInDescOrder = studentList.OrderByDescending(s => s.StudentName);

            //Example: Multiple sorting in Query syntax C#
            Console.WriteLine("Example: Multiple sorting in Query syntax C#");
            var multiSortingResult = from s in studentList
                                     orderby s.StudentName, s.Age
                                     select s;

            foreach (var std in multiSortingResult)
                Console.WriteLine("Name: {0}, Age {1}", std.StudentName, std.Age);

        }

        private void Task8()
        {
            IList<Student> studentList = new List<Student>()
            {
                new Student() { StudentID = 1, StudentName = "John", Age = 13} ,
                new Student() { StudentID = 2, StudentName = "Moin",  Age = 21 } ,
                new Student() { StudentID = 3, StudentName = "Bill",  Age = 18 } ,
                new Student() { StudentID = 4, StudentName = "Ram" , Age = 20} ,
                new Student() { StudentID = 5, StudentName = "Ron" , Age = 15 }
            };

            //Example: Func Delegate in LINQ Method Syntax

            Func<Student, bool> isStudentTeenAger = s => s.Age > 12 && s.Age < 20;

            var teenAgerStudent = studentList.Where(isStudentTeenAger);

            Console.WriteLine("Teen age Students:");

            foreach (var std in teenAgerStudent)
            {
                Console.WriteLine(std.StudentName);
            }

            //Example: Func Delegate in LINQ Query Syntax

            var teenAgerStudentsQuery = from s in studentList
                                        where isStudentTeenAger(s)
                                        select s;

            Console.WriteLine("Teen age Students:");

            foreach (var std in teenAgerStudent)
            {
                Console.WriteLine(std.StudentName);
            }
        }

        private void Task7()
        {
            Func<Student, bool> isStudentTeenAger = s => s.Age > 12 && s.Age < 20;

            Student std = new Student { Age = 25, StudentName = "Tomas" };

            bool isTeen = isStudentTeenAger(std);

            Action<Student> PrintStudentDetails = s => Console.WriteLine($"Name: {s.StudentName}, Age: {s.Age}");

            PrintStudentDetails(std);
        }

        public delegate bool IsYoungerThan(Student stud, int youngAge);
        delegate void Print();

        private void Task6()
        {
            IsYoungerThan isYoungerThan = (s, youngAge) => s.Age < youngAge;

            Student stud = new Student() { Age = 25 };

            Console.WriteLine(isYoungerThan(stud,26));

            Print print = () => Console.WriteLine("This is parameter less lambda expression");

            print();
        }

        delegate bool IsTeenAger(Student stud);

        private void Task5Lambda()
        {
            IsTeenAger isTeenAger = delegate (Student s) { return s.Age > 12 && s.Age < 20; };

            Student stud = new Student() { Age = 25 };

            Console.WriteLine(isTeenAger(stud));
        }

        private void Task4()
        {
            IList<Student> studentList = new List<Student>() {
        new Student() { StudentID = 1, StudentName = "John", Age = 13} ,
        new Student() { StudentID = 2, StudentName = "Moin",  Age = 21 } ,
        new Student() { StudentID = 3, StudentName = "Bill",  Age = 18 } ,
        new Student() { StudentID = 4, StudentName = "Ram" , Age = 20} ,
        new Student() { StudentID = 5, StudentName = "Ron" , Age = 15 }
             };

            var teenAgerStudents = studentList.Where(s => s.Age > 12 && s.Age < 20).ToList<Student>();
        }

        private void Task3()
        {
            IList<string> stringList = new List<string>()
            {
                "C# Tutorials",
                "VB.NET Tutorials",
                "Learn C++",
                "MVC Tutorials" ,
                "Java"

            };

            var result = from s in stringList
                         where s.Contains("Tuto")
                         select s;

            var result2 = stringList.Where(s => s.Contains("Tutorials"));
        }

        public delegate bool FindStudent(Student std);

        public void Task2()
        {
            Student[] studentArray = {
            new Student() { StudentID = 1, StudentName = "John", Age = 18 } ,
            new Student() { StudentID = 2, StudentName = "Steve",  Age = 21 } ,
            new Student() { StudentID = 3, StudentName = "Bill",  Age = 25 } ,
            new Student() { StudentID = 4, StudentName = "Ram" , Age = 20 } ,
            new Student() { StudentID = 5, StudentName = "Ron" , Age = 31 } ,
            new Student() { StudentID = 6, StudentName = "Chris",  Age = 17 } ,
            new Student() { StudentID = 7, StudentName = "Rob",Age = 19  } ,
        };

            Student[] students = PreLessonTask.where(studentArray, delegate(Student std){
                return std.Age > 12 && std.Age < 20;
            });
            Student[] students2 = PreLessonTask.where(studentArray, delegate (Student std) {
                return std.StudentID == 2;
            });
            Student[] students1 = PreLessonTask.where(studentArray, delegate (Student std) {
                return std.StudentName == "Steve";
            });

            //Lambda exression

            Student[] teenAgerStudens = studentArray.Where(s => s.Age > 12 && s.Age < 20).ToArray();

            Student bill = studentArray.Where(s => s.StudentName == "Bill").FirstOrDefault();

            Student student5 = studentArray.Where(s => s.StudentID == 5).FirstOrDefault();

           

            var teenAgerStudentLINQ = from s in studentArray
                                      where s.Age > 12 && s.Age < 20
                                      select s;

            teenAgerStudens[0].Age = 66;
        }

        public static Student[] where(Student[]stdArray, FindStudent del)
        {
            int i = 0;
            Student[] result = new Student[stdArray.Length];
            foreach (Student std in stdArray)
            {
                if(del(std))
                {
                    result[i] = std;
                    i++;
                }
            }
            return result;
        }

        public void Task1()
        {
            string[] names = { "Tom", "Lauras", "Sim", "Tim", "Gerald" };


            var myLinqQuery = from name in names
                              where name.Contains('i')
                              select name;

            foreach (var name in myLinqQuery)
            {
                Console.Write(name + " ");
            }
        }
    }
}
