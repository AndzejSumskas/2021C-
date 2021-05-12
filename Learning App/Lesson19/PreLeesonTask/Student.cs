using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learning_App.Lesson19.PreLeesonTask
{
    class Student
    {


        public int StudentID { get; set; }
        public String StudentName { get; set; }
        public int Age { get; set; }
        public int StandardID { get; internal set; }
    }

    public class Standard
    {

        public int StandardID { get; set; }
        public string StandardName { get; set; }
    }
}
