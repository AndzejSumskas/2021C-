using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learning_App.GameSample.Game
{
    class Button : GuiObject
    {
        private Frame activateFrame;
        
        private Frame notActiveFrame;

        private TextLine textLine;

        private const char activeChar = '#';
        private const char notActiveChar = '+';

        public Button(int x, int y, int width, int height, string label) : base(x,y,width,height)
        {
            notActiveFrame = new Frame(x, y, width, height, activeChar);
            activateFrame = new Frame(x, y, width, height, notActiveChar);
            textLine = new TextLine(x + 1, y + height / 2, width, label);
        }

        public bool IsActive { get; set; }

        override public void Render()
        {
            if(IsActive)
            {
                activateFrame.Render();
            }
            else
            {
                notActiveFrame.Render();
            }
            textLine.Render();
        }

        public void SetActive()
        {
            IsActive = IsActive;
        }
    }
}
