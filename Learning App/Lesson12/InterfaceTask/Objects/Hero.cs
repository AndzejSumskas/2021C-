using Learning_App.Lesson12.InterfaceTask.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learning_App.Lesson12.InterfaceTask.Objects
{
    class Hero : IPrintable, ISpeaks, IMovable, IRenderable, IGlows
    {
        public int X { get; set; }
        public int Y { get; set; }
        public int glowPower { get; set; } = 8;

        public void Glow()
        {
            Console.WriteLine("Hero glow is " + glowPower);
        }

        public void Move()
        {
            Console.WriteLine("Hero move!");
        }

        public void Print()
        {
            Console.WriteLine("Hero print!");
        }

        public void Render()
        {
            Console.WriteLine("Hero render!");
        }

        public void Speak()
        {
            Console.WriteLine("Hero speaks!");
        }
    }
}
