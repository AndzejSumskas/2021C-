using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learning_App.Lesson21.ProxyTask
{
    class Proxy : IStuffDoer
    {
        private RealObject realObject;
        
        public Proxy(RealObject realObject)
        {
            this.realObject = realObject;
        }
        public void DoStuff()
        {
            realObject.DoStuff();
            Console.WriteLine("DoingStuff");
        }

       
    }
}
