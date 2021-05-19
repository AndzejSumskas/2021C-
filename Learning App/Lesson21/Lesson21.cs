using Learning_App.Lesson21.CommandTask;
using Learning_App.Lesson21.ProxyTask;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learning_App.Lesson21
{
    class Lesson21
    {
        static void Main()
        {
            MyCommand myCommand = new MyCommand();

            myCommand.Execute();
            
        }
        public void ProxyTask()
        {
            Proxy myProxy = new Proxy(new RealObject());
            Proxy myProxy2;
            myProxy.DoStuff();
        }

        public void SingletonTask()
        {
            Singleton singleton1 = Singleton.Instance();
            Singleton singleton2 = Singleton.Instance();

            if (singleton1 == singleton2 && singleton1 != null)
            {
                Console.WriteLine("Viskas gerai!");
            }
            else
            {
                Console.WriteLine("Blogai, skirtingi objektai arba tusti!");
            }
        }
    }
}
