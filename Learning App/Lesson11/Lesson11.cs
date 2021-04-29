using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learning_App.Lesson11
{
    class Lesson11
    {
        static void Main()
        {
            //Person person = new Person();

            //Console.WriteLine(person.name);
            //Console.WriteLine(person.city);
            //Console.WriteLine(person.school);
            //Console.WriteLine(person.college);
            //person.name = "Petras";
            //person.city = "Kaunas";
            //person.school = "Staneviciaus";
            //person.college = "vgtu";
            //Console.WriteLine(person.name);
            //Console.WriteLine(person.city);
            //Console.WriteLine(person.school);
            //Console.WriteLine(person.college);


            //Person person2 = new Person();
            //Console.WriteLine(person2.Vardas);
            //Console.WriteLine(person2.Miestas);
            //Console.WriteLine(person2.Kolegija);
            //person2.Vardas = "Lauras";
            ////person2.Miestas = "Marijampolis";
            //person2.Mokykla = "Zemynos";
            //person2.Kolegija = "Kauno";
            //Console.WriteLine(person2.Vardas);
            //Console.WriteLine(person2.Miestas);
            //Console.WriteLine(person2.Kolegija);

        }

        static void Exercise1()
        {

            Parent parent = new Parent();
            Console.WriteLine("parent");

            parent.Funkcija();
            parent.Funkcija2();
            parent.Funkcija3();

            Child1 child = new Child1();
            Console.WriteLine("child");
            child.Funkcija();
            child.Funkcija2();
            child.Funkcija3();

            Child1 child2 = new Child1();

            Parent parent2 = child2;
            Console.WriteLine("parent2");
            parent2.Funkcija();
            parent2.Funkcija2();
            parent2.Funkcija3();
        }
        static void Student()
        {
            Student student = new Student("Petras");

            Console.WriteLine(student.Name);

            student.Name = "Antanas";

            List<int> test = new List<int>();
            int sk = test.Count;
            student.Age = 19;

            student.Age = 58;

            Console.WriteLine(student.Name);
        }
    }
}
