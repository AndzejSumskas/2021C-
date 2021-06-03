using Learning_App.FinalBigHomeWork.Units;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learning_App.FinalBigHomeWork.Data
{
    class GameData
    {
        Structures structures = new Structures();

        //Battle area width and hight
        private const int batleAreaHeight = 30;
        private const int batleAreaHWidth = 100;
        public Player player = new Player(35, 25, "Thomas");

        private int[,] boardGameArray = new int[batleAreaHeight, batleAreaHWidth];



        public void GameAreaData()
        {
            player.currentTankModel = player.tankModel[2];
            BatleAreaFrame();
            AddOtherStructures();
            RefreshPlayer();
            //Render(); //ForTesting
        }

        private void RefreshPlayer()
        {
            boardGameArray[player.Y, player.X] = 9;
        } //Add player

        private void BatleAreaFrame()
        {
            for (int i = 0; i < batleAreaHeight; i++)
            {
                for (int j = 0; j < batleAreaHWidth; j++)
                {
                    if (i == 0 || i == batleAreaHeight - 1)
                    {
                        boardGameArray[i, j] = 2;
                    }

                    if (j == 0 || j == 1 || j == batleAreaHWidth - 2 || j == batleAreaHWidth - 1)
                    {
                        boardGameArray[i, j] = 2;
                    }
                }
            }
        }  //Make game area frame

        internal void MoveLeft()
        {
            boardGameArray[player.Y, player.X] = 0;
            player.X = player.X - 2;
            if (player.X < 2) 
            {
                player.X = 2;
            }
            RefreshPlayer();
        }

        private void AddOtherStructures()
        {
            foreach (var line in structures.textLines)
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
        } //Add other structures from list in Structures class

        internal void MoveRight()
        {
            boardGameArray[player.Y, player.X] = 0;
            player.X = player.X + 2;
            if (player.X > batleAreaHWidth -8)
            {
                player.X = batleAreaHWidth -8;
            }
            RefreshPlayer();
        }

        internal void MoveUp()
        {
            boardGameArray[player.Y, player.X] = 0;
            player.Y = player.Y - 1;
            if (player.Y < 1)
            {
                player.Y = 1;
            }
            RefreshPlayer();
        }

        internal void MoveDown()
        {
            boardGameArray[player.Y, player.X] = 0;
            player.Y = player.Y + 1;
            if (player.Y > batleAreaHeight - 4)
            {
                player.Y = batleAreaHeight - 4;
            }
            RefreshPlayer();
        }

        public void Render()
        {
            for (int i = 0; i < batleAreaHeight; i++)
            {
                for (int j = 0; j < batleAreaHWidth; j++)
                {
                    Console.Write($"{boardGameArray[i, j]}");
                }
                Console.WriteLine();
            }
        } //For testing

        internal int[,] GetBalteAreaArray()
        {
            return boardGameArray;
        } // return array to not exit from the frame of the game

        internal int[,] GetBoardGameArray()
        {
            return boardGameArray;
        }

        internal int GetBatleAreaWidth()
        {
            return batleAreaHWidth;
        }

        internal int GetBatleAreaHight()
        {
            return batleAreaHeight;
        }
    }
}
