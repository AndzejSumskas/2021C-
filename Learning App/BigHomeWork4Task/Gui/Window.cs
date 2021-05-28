using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learning_App.BigHomeWork4Task.Gui
{
    class Window : GuiObject
    {
        private Frame border;
        private TextLine titleText;

        public Window(int x, int y, int width, int height, string title, char boarderChar) : base(x, y, width, height)
        {
            border = new Frame(x, y, width, Height, boarderChar);
            titleText = new TextLine(x + 3, y, title.Length + 2, $" {title} ");
        }

        public override void Render()
        {
            border.Render();
            titleText.Render();
        }
    }
}
