using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learning_App.Lesson15.FirstTask
{
    struct MyStruct : IPrintData
    {
        public int MyInt;
        public string Name;

        public List<int> listTest;

        public bool IsDateReady { get; set; }

        public MyStruct(int myInt, string name)
        {
            MyInt = myInt;
            Name = name;
            listTest = new List<int>() {1,2,3,4,5,6,7,8,9 };

            IsDateReady = false;
        }

        public void PrintData()
        {
            Console.WriteLine($"{MyInt} {Name}");

            foreach (var item in listTest)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
        }

        public void changeData(MyStruct myStruct)
        {
            myStruct.Name = "Gediminas";

            myStruct.MyInt = 5;

            myStruct.PrintData();
        }
    }
}
