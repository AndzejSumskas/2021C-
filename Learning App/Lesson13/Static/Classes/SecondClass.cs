using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learning_App.Lesson13.Classes
{
    class SecondClass
    {
        public string name { get; set; }

        private int age { get; set; }


        public void SetAge(int number)
        {
            age = number;
        }
        public string GetName()
        {
            return name;
        }

        private int GetAge()
        {
            return age;
        }

        public int ReturnAge()
        {
            return GetAge();
        }
    }
}
