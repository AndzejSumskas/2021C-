using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learning_App.Lesson15.FirstTask
{
    class ChangeData
    {
        public void changeData(MyStruct myStruct)
        {
            myStruct.Name = "Zilvinas";

            myStruct.MyInt = 9;

            myStruct.PrintData();
        }

        public void changeData(MyClass myClass)
        {
            myClass.ChangeName("Rokas");
            myClass.ChangeMyInt(659);

            myClass.PrintData();
        }

        
    }
}
