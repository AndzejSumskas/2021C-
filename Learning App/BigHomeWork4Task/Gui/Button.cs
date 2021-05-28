using Learning_App.BigHomeWork4Task.Constatnts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learning_App.BigHomeWork4Task.Gui
{
    class Button : GuiObject
    {
        private Frame acticeFrame;
        private Frame notActiveFrame;
        private TextLine textLine;

        private const char acticeChar = '#';
        private const char notActiveChar = '+';


        public Button(ButtonType buttonType, int x, int y, int width, int height, string label) : base(x, y, width, height)
        {
            acticeFrame = new Frame(x, y, width, height, acticeChar);
            notActiveFrame = new Frame(x, y, width, height, notActiveChar);
            textLine = new TextLine(x + 1, y + height / 2, width - 2, label);
            ButtonType = buttonType;
        }

        public bool IsActive { get; set; }
        public ButtonType ButtonType { get; }

        public override void Render()
        {
            if(IsActive)
            {
                acticeFrame.Render();
            }
            else
            {
                notActiveFrame.Render();
            }
            textLine.Render();
        }
    }
}
