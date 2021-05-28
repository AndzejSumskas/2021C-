using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learning_App.BigHomeWork4Task.Gui
{
    abstract class GuiObject
    {
        protected int X { get; set; }
        protected int Y { get; set; }
        protected int Width { get; set; }
        protected int Height { get; set; }

        protected GuiObject(int x, int y, int width, int height)
        {
            X = x;
            Y = y;
            Width = width;
            Height = height;
        }

        abstract public void Render();


    }
}
