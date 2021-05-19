using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learning_App.BigHomeWork4.Gui
{
    class Windoww : GuiObject
    {
        private Frame border;
        private TextLine titleText;

        public Windoww(int x, int y, int width, int height, string title, char borderChar) : base(x, y, width, height)
        {
            border = new Frame(x, y, width, height, borderChar);
            titleText = new TextLine(x + 3, y, title.Length + 2, $" {title} ");
        }

        override public void Render()
        {
            border.Render();
            titleText.Render();
        }
    }
}
