using Learning_App.Lesson12.InterfaceTask.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learning_App.Lesson12.InterfaceTask.Objects
{
    class Ghost : IPrintable, IMovable, IGlows, IRenderable, ISpeaks
    {
        public int X { get; set; }
        public int Y { get; set; }
        public int glowPower { get; set; } = 5;

        public void Glow()
        {
            Console.WriteLine("Ghost glow is " + glowPower);
        }

        public void Move()
        {
            Console.WriteLine("Ghost move!");
        }

        public void Print()
        {
            Console.WriteLine("Ghost print!");
        }

        public void Render()
        {
            Console.WriteLine("Ghost render!");
        }

        public void Speak()
        {
            Console.WriteLine("UUUUUAAAAAA!");
        }
    }
}
