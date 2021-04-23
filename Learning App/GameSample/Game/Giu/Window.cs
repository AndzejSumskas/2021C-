using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learning_App.GameSample.Game
{
    class Window : GuiObject
    {
        private Frame border;

        public Window(int x, int y, int width, int height, char borderChar) : base(x, y, width, height)
        {
            X = x;
            Y = y;
            base.width = width;
            base.height = height;


            border = new Frame(x, Y, width, height, borderChar);
        }

       
        public void Render()
        {
            border.Render();
        }
    }
}
