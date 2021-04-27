using Learning_App.Lesson12.Lesson12Tasks.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learning_App.Lesson12.Lesson12Tasks.Gui
{
    class Image : GuiElement, IRenderable
    {
        public void Render()
        {
            Console.WriteLine("  *  ");
            Console.WriteLine(" *** ");
            Console.WriteLine("*****");
            Console.WriteLine("  *  ");
            Console.WriteLine("  *  ");
            Console.WriteLine("  *  ");
            Console.WriteLine("*****");
        }
    }
}
