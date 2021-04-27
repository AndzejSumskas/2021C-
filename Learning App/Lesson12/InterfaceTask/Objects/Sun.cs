using Learning_App.Lesson12.InterfaceTask.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learning_App.Lesson12.InterfaceTask.Objects
{
    class Sun : IPrintable, IMovable, IRenderable, IGlows
    {
        public void Print()
        {
            Console.WriteLine("Sun print!");
        }
        public int X { get; set; }
        public int Y { get; set; }
        public int glowPower { get; set; } = 10;

        public void Glow()
        {
            Console.WriteLine("Sun glow is " + glowPower);
        }

        public void Move()
        {
            Console.WriteLine("Ghost move!");
        }
                
        public void Render()
        {
            Console.WriteLine("Sun render!");
        }

       
    }
}
