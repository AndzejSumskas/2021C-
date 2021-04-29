using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learning_App.Lesson13.Classes
{
    class FourthlClass1
    {
        private string Name { get; set; }

        private int Age { get; set; }

        private FourthlClass1(string name, int age)
        {
            Name = name;
            Age = age;
        }

        public static FourthlClass1 BuildObject()
        {
            string name = Convert.ToString(Console.ReadLine());
            int age = Convert.ToInt32(Console.ReadLine());

            return new FourthlClass1(name, age);
        }

        public void GetNameAndaAge()
        {
            Console.WriteLine($"Name {Name} Age {Age}");
        }
            
        
    }
}
