using Learning_App.Lesson15.Enum;
using Learning_App.Lesson15.ErrorHandling;
using Learning_App.Lesson15.Exceptions;
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
            //Error exception ismetimas!!!

            //ErrorTest errorTest = new ErrorTest();

            //errorTest.DoSomethingBad();

            int[] masyvas = new int[3];
            try
            {
                int test = Convert.ToInt32(Console.ReadLine());
                masyvas[6] = test;
            }
            catch (FormatException exception)
            {
                Console.WriteLine(exception.Message);
            }
            catch (IndexOutOfRangeException rangeException)
            {
                Console.WriteLine("Blogai naudojamas masyvas!");
            }
            catch(MySuperException myException)
            {
                Console.WriteLine("Something go wrong!!!");
                Console.WriteLine(myException.Message);
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

        static void EnumTask()
        {
            //Enum uzduotys

            EducationLevel ed = new EducationLevel(EnumLvl.Elementary);

            EducationLevel.WriteEducationLevel(ed);

        }

        static void EnumButton()
        {
            ConsoleKeyInfo key = Console.ReadKey();

            switch (key.Key)
            {
                case ConsoleKey.Backspace:
                    break;
                case ConsoleKey.Tab:
                    break;
                case ConsoleKey.Clear:
                    break;
                case ConsoleKey.Enter:
                    break;
                case ConsoleKey.Pause:
                    break;
                case ConsoleKey.Escape:
                    break;
                case ConsoleKey.Spacebar:
                    break;
                case ConsoleKey.PageUp:
                    break;
                case ConsoleKey.PageDown:
                    break;
                case ConsoleKey.End:
                    break;
                case ConsoleKey.Home:
                    break;
                case ConsoleKey.LeftArrow:
                    break;
                case ConsoleKey.UpArrow:
                    break;
                case ConsoleKey.RightArrow:
                    break;
                case ConsoleKey.DownArrow:
                    break;
                case ConsoleKey.Select:
                    break;
                case ConsoleKey.Print:
                    break;
                case ConsoleKey.Execute:
                    break;
                case ConsoleKey.PrintScreen:
                    break;
                case ConsoleKey.Insert:
                    break;
                case ConsoleKey.Delete:
                    break;
                case ConsoleKey.Help:
                    break;
                case ConsoleKey.A:
                    break;
                case ConsoleKey.B:
                    break;
                case ConsoleKey.C:
                    break;
                case ConsoleKey.D:
                    break;
                case ConsoleKey.E:
                    break;
                case ConsoleKey.F:
                    break;
                case ConsoleKey.G:
                    break;
                case ConsoleKey.H:
                    break;
                case ConsoleKey.I:
                    break;
                case ConsoleKey.J:
                    break;
                case ConsoleKey.K:
                    break;
                case ConsoleKey.L:
                    break;
                case ConsoleKey.M:
                    break;
                case ConsoleKey.N:
                    break;
                case ConsoleKey.O:
                    break;
                case ConsoleKey.P:
                    break;
                case ConsoleKey.Q:
                    break;
                case ConsoleKey.R:
                    break;
                case ConsoleKey.S:
                    break;
                case ConsoleKey.T:
                    break;
                case ConsoleKey.U:
                    break;
                case ConsoleKey.V:
                    break;
                case ConsoleKey.W:
                    break;
                case ConsoleKey.X:
                    break;
                case ConsoleKey.Y:
                    break;
                case ConsoleKey.Z:
                    break;
            }
            //Kiekvienas mygtukas turi savo nueri

            int keyCode = (int)ConsoleKey.Escape;
        }

        static void TastStruct()
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