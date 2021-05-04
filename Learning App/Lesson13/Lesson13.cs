
using Learning_App.Lesson13.Classes;
using Learning_App.Lesson13.Overloading;
using Learning_App.Lesson13.Tools;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Learning_App.Lesson13.PrintHelper;

namespace Learning_App.Lesson13
{
    class Lesson13
    {
        
        static void Main()
        {
            //PrintHelper.PrintHelper.Print("Menesiai", "Sausis", "Vasaris", 3, '4', "Geguze" + 1);

            PrintHelper.PrintHelper.PrintTable(1, "asdasd", 664, '*');
                
           
        }

        public static void Print(string message, string[] args)
        { 
            Console.Write(message + ": ");
            for (int i = 0; i < args.Length; i++)
            {
                string item = Convert.ToString(args[i]);
                Console.WriteLine(item + " ");
               
            }
        }

        public static void SimpleTask()
        {
            object number = 5;
            object text = "dsfsdf";
            Overloading();
        }

        public override string ToString()
        {
            return " bla lba";
        }

        public static void Overloading()
        {
            Hero hero = new Hero();
            Hero hero1 = new Hero("Thor");
            Hero hero2 = new Hero("Hulk", "USA");
            Hero hero3 = new Hero("Nemo", "uknown", 5);
            Hero hero4 = new Hero("Cheburashka", "Russia", 6, "Extra Hearing");

            hero.PrintInfo();
            hero1.PrintInfo();
            hero2.PrintInfo();
            hero3.PrintInfo();
            hero4.PrintInfo();

            hero.Move();
            hero1.Move();

            hero4.DoAllThings();
        }

        private static void DoStuff()
        {
          
        }
        private static void DoStuff(int number)
        {
           
        }

        static void StaticUzduotys()
        {
            FirstClass person1 = new FirstClass();
            string vardas = FirstClass.name = "Adas";

            Console.WriteLine(vardas + FirstClass.ReturnAge());

            SecondClass person2 = new SecondClass();

            person2.name = "Tomas";
            person2.SetAge(65);

            Console.WriteLine(person2.name + person2.ReturnAge());

            ThirdClass person3 = new ThirdClass();

            ThirdClass.name = "ThirdClass";
            person3.Color = "red";
            person3.SetAge(25);
            ThirdClass.ReturnAge();
            person3.SetSize(43);
            person3.ReturnSize();

            Console.WriteLine(ThirdClass.name + " " + ThirdClass.ReturnAge() + " " + person3.ReturnSize() + " " + person3.Color);

            FourthlClass1 person4 = FourthlClass1.BuildObject();

            person4.GetNameAndaAge();

        }

        static void TaskWithClient()
        {
            Client2 client = new Client2();
            Client2 client2 = new Client2();
            Client2 client3 = new Client2();
            Client2 client4 = new Client2();
            Client2 client5 = new Client2();

            Console.WriteLine(Client2.GetClientCount());
        }

        static void ClassTasks()
        {
            string data = "Hello world. how are you todauy?";

            string[] dataSplit = StringUtils.SplitTextToWords(data);

            foreach (var item in dataSplit)
            {
                Console.WriteLine(item);
            }
        }
    }
}
