using Learning_App.Lesson12.InterfaceTask.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learning_App.Lesson12.InterfaceTask.Objects
{
    class House : IPrintable, IRenderable
    {
        public void Print()
        {
            Console.WriteLine("House print!");
        }

        public void Render()
        {
            Console.WriteLine("House render!");
        }
    }
}
