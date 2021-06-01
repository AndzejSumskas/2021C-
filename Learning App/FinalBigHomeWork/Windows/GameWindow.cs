using Learning_App.FinalBigHomeWork.Gui;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learning_App.FinalBigHomeWork.Windows
{
    class GameWindow : Window
    {
        private List<TextLine> textLines = new List<TextLine>();

        public GameWindow() : base(0, 0, 150, 50, "GameWindow", '▓')
        {
            textLines.Add(new TextLine(70, 45, 12, "▓▓▓▓▓▓▓▓▓▓▓▓"));
            textLines.Add(new TextLine(70, 45, 12, "▓▓▓▓▓▓▓▓▓▓▓▓"));
            textLines.Add(new TextLine(70, 46, 12, "▓▓        ▓▓"));
            textLines.Add(new TextLine(70, 47, 12, "▓▓        ▓▓"));
            textLines.Add(new TextLine(70, 48, 12, "▓▓        ▓▓"));
        }

        public override void Render()
        {
            base.Render();
            foreach (var textLine in textLines)
            {
                textLine.Render();
            }
        }
    }
}
