using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Learning_App.Lesson17.Delegate;
using Learning_App.Lesson17.Dictionary;
using Learning_App.Lesson17.EventHomeWork;
using Learning_App.Lesson17.EventTask;
using Learning_App.Lesson17.LessonTasks;

namespace Learning_App.Lesson17
{
    class Lesson17
    {
        static void Main()
        {
            Bank mybank = new Bank("SwedBank", 1000);

            Sender sender = new Sender();

            // mybank.OnAnyTransavtion += sender.Ha



            //MyDelegateTask();

            ProcessBusinessLogic pBL = new ProcessBusinessLogic();
            pBL.EwentWorkInHome();
        }

        public void MyDelegateTask()
        {
            DoOperation operationSum = new DoOperation(MyMultiply);
            Console.WriteLine(operationSum(2, 6));
            operationSum += MySum;
            Console.WriteLine(operationSum(9, 8));

            operationSum -= MySum;
            Console.WriteLine(operationSum(9, 6));

        }

        public void DoStuff()
        {
            Console.WriteLine();
        }

        internal static int MyMultiply(int m1, int m2)
        {
            return m1 * m2;
        }

        internal static int MySum(int m1, int m2)
        {
            return m1 + m2;
        }

        private static void ThirdTask()
        {
            //TestDictionaryTest.FirstTask();

            //TestQueueAndStack.SecondTask();

            Table table = new Table();

            table.AddFood("Pie");

            table.DoAction(CustomAction);

            List<int> data = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8 };

            data.RemoveAll(TestOdd);
        }

        private static bool TestOdd(int data)
        {
            return data % 2 == 1;
        }

        private static int CustomAction(int x, int y, bool doSum)
        {
            return x + y;
        }
    }
}
