using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learning_App.BigHomeWork4Task.Gui
{
    sealed class TextBlock : GuiObject
    {
        private List<TextLine> textBlock = new List<TextLine>();

        public TextBlock(int x, int y, int width,List<string>textList) : base(x, y, width, 0)
        {
            for (int i = 0; i < textList.Count; i++)
            {
                textBlock.Add(new TextLine(x, y + i, width, textList[i]));
            }
        }

        public override void Render()
        {
            for (int i = 0; i < textBlock.Count; i++)
            {
                textBlock[i].Render();
            }
        }
    }
}
