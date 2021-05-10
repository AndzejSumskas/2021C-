using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learning_App.Lesson18
{
    class Student
    {
        public int Id { get; set; }

        public string Name{ get; set; }

        public int Age { get; set; }

        public double AvarageMark { get; set; }

        public bool IsGettingTuition { get; set; }

        public Student(int id, string name, int age, double avarageMark, bool isGettingTuition)
        {
            Id = id;
            Name = name;
            Age = age;
            AvarageMark = avarageMark;
            IsGettingTuition = isGettingTuition;
        }

        public Student()
        {
        }
    }
}
