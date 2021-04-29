using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learning_App.Lesson13.Classes
{
    class FirstClass
    {
        public static string name { get; set; }

        private static int age { get; set; } = 25;

        public static string GetName()
        {
            return name;
        }

        private static int GetAge()
        {
            return age;
        }

        public static int ReturnAge()
        {
            return GetAge();
        }

    }
}
