﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learning_App.BigHomeWork4Task.Gui
{
    class TextLine : GuiObject
    {
        private string data;

        public TextLine(int x, int y, int width, string data) : base(x, y, width, 1)
        {
            this.data = data;
        }

        public override void Render()
        {
           if(data.Length>=Width)
            {
                data = data.Substring(0, Width);
                Console.SetCursorPosition(X, Y);
            }
            else
            {
                Console.SetCursorPosition(X + (Width - data.Length) / 2, Y);
            }
            Console.Write(data);
        }

        internal int GetX()
        {
            return X;
        }

        internal IEnumerable<char> GetData()
        {
            return data;
        }
    }
}
