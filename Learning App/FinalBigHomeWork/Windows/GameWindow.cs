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
        public List<TextLine> textLines = new List<TextLine>();

        //Testing

        

        public GameWindow() : base(0, 0, 100, 30, "GameWindow", '▓')
        {
            textLines.Add(new TextLine(44, 25, 12, "▓▓▓▓▓▓▓▓▓▓▓▓"));
            textLines.Add(new TextLine(44, 26, 12, "▓▓        ▓▓"));
            textLines.Add(new TextLine(44, 27, 12, "▓▓        ▓▓"));
            textLines.Add(new TextLine(44, 28, 12, "▓▓        ▓▓"));
            textLines.Add(new TextLine(44, 16, 12, "▓▓▓▓▓▓▓▓▓▓▓▓"));
            textLines.Add(new TextLine(44, 17, 12, "▓▓▓▓▓▓▓▓▓▓▓▓")); 
            textLines.Add(new TextLine(44, 18, 12, "▓▓▓▓▓▓▓▓▓▓▓▓"));
            textLines.Add(new TextLine(44, 19, 12, "▓▓▓▓▓▓▓▓▓▓▓▓"));
            textLines.Add(new TextLine(10, 24, 26, "▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓"));
            textLines.Add(new TextLine(64, 24, 26, "▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓")); 
            textLines.Add(new TextLine(10, 5, 26, "▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓"));
            textLines.Add(new TextLine(64, 5, 26, "▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓"));
            textLines.Add(new TextLine(37, 10, 26, "▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓"));
            textLines.Add(new TextLine(10, 19, 26, "▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓"));
            textLines.Add(new TextLine(64, 19, 26, "▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓"));
            textLines.Add(new TextLine(2, 11, 8, "▓▓▓▓▓▓▓▓"));
            textLines.Add(new TextLine(2, 12, 8, "▓▓▓▓▓▓▓▓"));
            textLines.Add(new TextLine(2, 13, 8, "▓▓▓▓▓▓▓▓"));
            textLines.Add(new TextLine(2, 14, 8, "▓▓▓▓▓▓▓▓"));
            textLines.Add(new TextLine(90, 11, 8, "▓▓▓▓▓▓▓▓"));
            textLines.Add(new TextLine(90, 12, 8, "▓▓▓▓▓▓▓▓"));
            textLines.Add(new TextLine(90, 13, 8, "▓▓▓▓▓▓▓▓"));
            textLines.Add(new TextLine(90, 14, 8, "▓▓▓▓▓▓▓▓"));

        }

        public override void Render()
        {
            
            //base.Render();
            foreach (var textLine in textLines)
            {
                textLine.Render();
            }
        }

        //public List<TextLine> GetListOfObjects()
        //{
        //    textLines;
        //}
    }
}
