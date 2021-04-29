using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learning_App.Lesson13.Classes
{
    class ThirdClass
    {
        public static string name { get; set; }

        private static int age { get; set; }

        public string Color { get; set; }

        private int Size { get; set; }

        public static string GetName()
        {
            return name;
        }

        public void SetAge(int number)
        {
            age = number;
        }

        private static int GetAge()
        {
            return age;
        }
        public static int ReturnAge()
        {
            return GetAge();
        }

        

        public string GetColor()
        {
            return Color;
        }

        public void SetSize(int size)
        {
           Size = size;
        }

        private int GetSize()
        {
            return Size;
        }

        public int ReturnSize()
        {
            return GetSize();
        }
    }
}
