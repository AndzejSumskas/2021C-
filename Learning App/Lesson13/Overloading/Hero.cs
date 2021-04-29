using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learning_App.Lesson13.Overloading
{
    class Hero
    {
        private string name { get; set; }

        private string country { get; set; }

        private int age { get; set; }

        private string power { get; set; }

        public Hero()
        {
            
        }
        public Hero(string name)
        {
            this.name = name;
        }
        public Hero(string name, string country)
        {
            this.name = name;
            this.country = country;
        }
        public Hero(string name, string country, int age)
        { 
            this.name = name;
            this.country = country;
            this.age = age;      
        }

        public Hero(string name, string country, int age, string power)
        {
            this.name = name;
            this.country = country;
            this.age = age;
            this.power = power;
        }

        public void Move()
        {
            Console.WriteLine(name + " are moving!");
        }

        public void PrintInfo()
        {
            string ageToString = Convert.ToString(age);
            if (age <= 0)
            {
                ageToString = Convert.ToString("");
            }
          

            Console.WriteLine(name+ " " + country + " " + ageToString + " " + power);
        }

        public void DoAllThings()
        {
            Move();
            PrintInfo();
        }
    }
}
