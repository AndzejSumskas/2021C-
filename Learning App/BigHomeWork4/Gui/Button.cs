using Learning_App.BigHomeWork4.Constants;
using Learning_App.BigHomeWork4.Game;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learning_App.BigHomeWork4.Gui
{
    class Button : GuiObject
    {
        private Frame activateFrame;

        private Frame notActiveFrame;

        private TextLine textLine;

        private const char activeChar = '*';
        private const char notActiveChar = '#';

        public ButtonType Type { get; }

        public ButtonPlayersCount TypeP { get; }

        public Dice6 TypeD { get; }

        public ButtonGameOver TypeGO{get;}

        public Button(ButtonType type, int x, int y, int width, int height, string label) : base(x, y, width, height)
        {
            notActiveFrame = new Frame(x, y, width, height, activeChar);
            activateFrame = new Frame(x, y, width, height, notActiveChar);
            textLine = new TextLine(x + 1, y + height / 2, width, label);
            Type = type;
        }
        public Button(ButtonPlayersCount type, int x, int y, int width, int height, string label) : base(x, y, width, height)
        {
            notActiveFrame = new Frame(x, y, width, height, activeChar);
            activateFrame = new Frame(x, y, width, height, notActiveChar);
            textLine = new TextLine(x + 1, y + height / 2, width, label);
            TypeP = type;
        }

        public Button(Dice6 type, int x, int y, int width, int height, string label) : base(x, y, width, height)
        {
            notActiveFrame = new Frame(x, y, width, height, activeChar);
            activateFrame = new Frame(x, y, width, height, notActiveChar);
            textLine = new TextLine(x + 1, y + height / 2, width, label);
            TypeD = type;
        }

        public Button(ButtonGameOver type, int x, int y, int width, int height, string label) : base(x, y, width, height)
        {
            notActiveFrame = new Frame(x, y, width, height, activeChar);
            activateFrame = new Frame(x, y, width, height, notActiveChar);
            textLine = new TextLine(x + 1, y + height / 2, width, label);
            TypeGO = type;
        }

        public bool IsActive { get; set; }

        override public void Render()
        {
            if (IsActive)
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
