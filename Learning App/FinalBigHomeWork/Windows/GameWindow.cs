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
        private TextLine textLine;
        
        public GameWindow() : base(0, 0, 150, 50, "GameWindow", '▓')
        {
        }
    }
}
