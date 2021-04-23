using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learning_App.GameSample.Game
{
    class GuiObject
    {
        protected int X;
        protected int Y;
        protected int width;
        protected int height;

        public GuiObject(int x, int y, int width, int height)
        {
            X = x;
            Y = y;
            this.width = width;
            this.height = height;
        }
    }
}
