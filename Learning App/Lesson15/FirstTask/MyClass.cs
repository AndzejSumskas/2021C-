using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learning_App.Lesson15.FirstTask
{
    class MyClass : IPrintData
    {
        private int myInt { get; set; }
        private string name { get; set; }

        private List<int> listTest;

        private bool isDateReady { get; set; }

        public MyClass(int myInt, string name)
        {
            this.myInt = myInt;
            this.name = name;
            listTest = new List<int>() { 1, 2, 3, 4, 5, 6, 7 };

            this.isDateReady = true ;
        }

        public void PrintData()
        {
            Console.WriteLine($"{myInt} {name}");
            foreach (var item in listTest)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
        }

        public void ChangeName(string name)
        {
            this.name = name;
        }

        public void ChangeMyInt(int myInt)
        {
            this.myInt = myInt;
        }

        public void changeData(MyClass myClass)
        {
            myClass.ChangeName("Gedas");
            myClass.ChangeMyInt(17);

            myClass.PrintData();
        }
    }
}
