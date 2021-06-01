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

        

        private GameWindow gameWindow = new GameWindow();

        public char[] currentTankModel { get; set; }

        public Unit(int x, int y) : base(x, y, 15, 3)
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

        internal void MoveDown()
        {
            
            if (Y + 5> gameWindow.Y + gameWindow.Height) { }
            else
            {
                Y++;
            }
        }

        internal void MoveUp()
        {
            if (Y-1 <= gameWindow.Y) { }
            else
            {
                Y--;
            }
        }

        internal void MoveLeft()
        {
            if(X -2  <= gameWindow.X) { }
            else
            {
                X -= 2;
            }
        }

        internal void MoveRight()
        {
            if (X + 9 > gameWindow.X + gameWindow.Width)  { }
            else
            {
                X += 2;
                //if(true)
                //{
                //    X -= 2;
                //}
            }

        }
    }
}
