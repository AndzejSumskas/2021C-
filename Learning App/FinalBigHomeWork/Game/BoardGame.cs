using Learning_App.FinalBigHomeWork.Gui;
using Learning_App.FinalBigHomeWork.Windows;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learning_App.FinalBigHomeWork.Units
{
    class BoardGame
    {
        private GameWindow gameWindow = new GameWindow();
        private int[,] boardGameArray = new int[30, 100];

        public void gameController()
        {
            BatleArea();
            GameBoardFrame();
            OtherStructures();

            //Render();
        }

        private void OtherStructures()
        {
            foreach (var line in gameWindow.textLines)
            {
                int xCounter = line.X;
                foreach (char symbol in line.GetData())
                {
                    if (symbol == '▓')
                    {
                        boardGameArray[line.Y, xCounter] = 1;
                    }
                    xCounter++;
                }
            }
        }

        private void BatleArea()
        {
            for (int i = 0; i < gameWindow.Height; i++)
            {
                for (int j = 0; j < gameWindow.Width; j++)
                {
                    boardGameArray[i, j] = 0;
                }
            }            
        }
        private void GameBoardFrame()
        {
            for (int i = 0; i < gameWindow.Height; i++)
            {
                for (int j = 0; j < gameWindow.Width; j++)
                {
                    if (i == 0 || i == gameWindow.Height - 1)
                    {
                        boardGameArray[i, j] = 2;
                    }

                    if(j == gameWindow.X || j == gameWindow.X+1 || j == gameWindow.X + gameWindow.Width-2 || j == gameWindow.X + gameWindow.Width - 1)
                    {
                        boardGameArray[i, j] = 2;
                    }
                }
            }
        }
        public void Render()
        {
            for (int i = 0; i < gameWindow.Height; i++)
            {
                for (int j = 0; j < gameWindow.Width; j++)
                {
                    Console.Write($"{boardGameArray[i, j]}");
                }
                Console.WriteLine();
            }
        }

        public int[,] GetBalteAreaArray()
        {
            BatleArea();
            GameBoardFrame();
            OtherStructures();
            return boardGameArray;
        }
    }
}
