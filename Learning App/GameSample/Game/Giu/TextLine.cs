﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learning_App.GameSample.Game
{
    class TextLine : GuiObject
    {
        private string data;

        public TextLine(int x, int y, int width, string data) : base(x, y, width, 0)
        {
            this.data = data;
        }

        public void Render()
        {
            Console.SetCursorPosition(X, Y);

            if(width > data.Length)
            {
                int offset = (width - data.Length) / 2;
                for (int i = 0; i < offset; i++)
                {
                    Console.WriteLine(' ');
                }
            }
            Console.Write(data);
        }
    }
}
