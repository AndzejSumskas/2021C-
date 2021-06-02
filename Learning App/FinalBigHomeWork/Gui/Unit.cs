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

        private int[,] boardArray = new int[30,100];
        private GameWindow gameWindow = new GameWindow();

        private BoardGame boardGame = new BoardGame();

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
            if (boardGame.GetBalteAreaArray()[Y+3,X] == 1 || boardGame.GetBalteAreaArray()[Y + 3, X] == 2 || boardGame.GetBalteAreaArray()[Y + 3, X+5] == 1)
            {  
            }
            else
            {
                Y++;
            }
        }

        internal void MoveUp()
        {
            if (boardGame.GetBalteAreaArray()[Y-1, X] == 1 || boardGame.GetBalteAreaArray()[Y-1, X] == 2 || boardGame.GetBalteAreaArray()[Y-1, X + 5] == 1)
            {
            }
            else
            {
                Y--;
            }
        }

        internal void MoveLeft()
        {
            if (boardGame.GetBalteAreaArray()[Y, X-1] == 1 || boardGame.GetBalteAreaArray()[Y, X-1] == 2 || boardGame.GetBalteAreaArray()[Y+2, X-1] == 1)
            {
            }
            else
            {
                X--;
            }
        }

        internal void MoveRight()
        {
            if (boardGame.GetBalteAreaArray()[Y, X +6] == 1 || boardGame.GetBalteAreaArray()[Y, X +6] == 2 || boardGame.GetBalteAreaArray()[Y + 2, X+6] == 1)
            {
            }
            else
            {
                X++;
            } 
        }

        public void SetBatleBoard(int[,] array)
        {
            boardArray = array;
        }
    }
}
