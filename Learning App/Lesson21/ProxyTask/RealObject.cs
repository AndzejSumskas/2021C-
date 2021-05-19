using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learning_App.Lesson21.ProxyTask
{
    class RealObject : IStuffDoer
    {
        public void DoStuff()
        {
            Console.WriteLine("Real Object!!!");
        }
    }
}
