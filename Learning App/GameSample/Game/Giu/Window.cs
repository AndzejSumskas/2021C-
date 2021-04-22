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

        public Window(int x, int y, int width, int height, Frame border) : base(x, y, width, height)
        {
            this.border = border;
        }

        public void Render()
        {

        }
    }
}
