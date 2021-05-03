using Learning_App.Lesson15.Enum;
using Learning_App.Lesson15.FirstTask;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learning_App.Lesson15
{
    class Lesson15
    {
        public static object MyClass { get; private set; }

        static void Main()
        {

            int[] masyvas = new int[3];
            try
            {    
                int test = Convert.ToInt32(Console.ReadLine());
                masyvas[5] = test;
            }
            catch(FormatException exception)
            {
                Console.WriteLine(exception.Message);
            }
            catch (IndexOutOfRangeException rangeException)
            {
                Console.WriteLine("Blogai naudojamas masyvas!");
            }
            catch (Exception eN)
            {
                Console.WriteLine(eN.Message);
            }
            finally
            {
                Console.WriteLine("Always do it!");
            }


        }


        public void TastStruct()
        {
            MyStruct myStruct = new MyStruct(1, "Petras");


            MyClass myClass = new MyClass(1, "Jonas");

            myStruct.PrintData();
            myClass.PrintData();


            myStruct.Name = "Leonas";

            myClass.ChangeName("Justas");
            Console.WriteLine("**************");

            myStruct.PrintData();
            myClass.PrintData();

            myStruct.changeData(myStruct);

            myClass.changeData(myClass);
            Console.WriteLine("**************");

            myStruct.PrintData();
            myClass.PrintData();
            Console.WriteLine("**************");

            ChangeData changedata = new ChangeData();

            changedata.changeData(myClass);

            changedata.changeData(myStruct);

            myStruct.PrintData();
            myClass.PrintData();
        }
    }
}
