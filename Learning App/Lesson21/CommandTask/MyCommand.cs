using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learning_App.Lesson21.CommandTask
{
    class MyCommand : Command
    {
        
        public override void Execute()
        {
            Console.WriteLine("My Command Execute");
        }
    }
}
