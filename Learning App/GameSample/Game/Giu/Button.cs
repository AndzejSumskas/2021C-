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
        private bool isActive = false;
        private Frame notActiveFrame;
        private TextLine textLine;

        public Button(int x, int y, int width, int height, string label) : base(x,y,width,height)
        {
            notActiveFrame = new Frame(x, y, width, height, '+');
            activateFrame = new Frame(x, y, width, height, '#');
            textLine = new TextLine(x + 1, y + height / 2, width, label);
        }

        public void Render()
        {
            if(isActive)
            {
                activateFrame.Render();
            }
            else
            {
                notActiveFrame.Render();
            }
        }

        public void SetActive()
        {
            isActive = isActive;
        }
    }
}
