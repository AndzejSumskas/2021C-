using Learning_App.FinalBigHomeWork.Units;
using Learning_App.FinalBigHomeWork.Windows;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learning_App.FinalBigHomeWork.Gui
{
    class Unit : GuiObject
    {
        public List<char[]> tankModel = new List<char[]> {
            new char[]{ '▒', '▒', '▒', '▒', '▒', '▒', ' ', ' ', '█', '█', '=', '=', '▒', '▒', '▒', '▒', '▒', '▒' },
            new char[]{ '▒', '▒', '▒', '▒', '▒', '▒', '=', '=', '█', '█', ' ', ' ', '▒', '▒', '▒', '▒', '▒', '▒' },
            new char[]{ '▒', '▒', '¦', '¦', '▒', '▒', '▒', '▒', '█', '█', '▒', '▒', '▒', '▒', ' ', ' ', '▒', '▒' },
            new char[]{ '▒', '▒', ' ', ' ', '▒', '▒', '▒', '▒', '█', '█', '▒', '▒', '▒', '▒', '¦', '¦', '▒', '▒' }
        };

        
        public char[] currentTankModel { get; set; }

        public Unit(int x, int y) : base(x, y, 18, 3)
        {
        }
        public Unit() : base(0, 0, 18, 3)
        {
        }

        public override void Render()
        {
            Console.SetCursorPosition(X, Y);
            int counter = 0;
            for (int i = 0; i < currentTankModel.Length; i++)
            {
                if(i % 6 == 0 && i != 0)
                {
                    Y++;
                    counter++;
                    Console.SetCursorPosition(X, Y);
                }
                Console.Write(currentTankModel[i]);
            }
            Y -= counter;
            Console.WriteLine();
        }
    }
}
