using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learning_App.Lesson11
{
    class Student
    {
        private string name;
        private int age = 15;

        public string avgScore{ get; set; }

        public string avgScore2
        {
            set
            {
                avgScore2 = value;
            }
        }

        public int Age { get { return age; } set 
            {
            if(value>=0)
                {
                    age = value;
                }
            else
                {
                    throw new ArgumentException("error, bad value");
                    age = 0;
                }
            } 
        }       //Auto implemented properties

        public string Name
        {
            get
            {
                return name;
            }
            set {
                if(value.Length>15)
                {
                    Console.WriteLine("Error. Name is too long!!!");
                }
                name = value;
            }
        }

        public Student(string name)
        {
            this.name = name;
        }

        //public string GetName()
        //{
        //    return name;
        //}

        //public void Setname(string name)
        //{
        //    this.name = name;
        //}
    }
}
