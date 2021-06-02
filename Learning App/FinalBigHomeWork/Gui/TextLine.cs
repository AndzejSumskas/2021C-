using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learning_App.FinalBigHomeWork.Gui
{
    class TextLine : GuiObject
    {
        private string data;

        public TextLine(int x, int y, int width, string data) : base(x, y, width, 1)
        {
            this.data = data;
        }

        override public void Render()
        {
            if (data.Length > Width)
            {
                Console.SetCursorPosition(X, Y);
            }
            else
            {
                Console.SetCursorPosition(X + (Width - data.Length) / 2, Y);
            }
            Console.Write(data);
        }

        public string GetData()
        {
            return data;
        }
    }
}
