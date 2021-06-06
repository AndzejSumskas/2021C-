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
        public List<Enemy> enemies = new List<Enemy>() { 
            //{ new Enemy(3,26,1,"Enemy1")},
            //{ new Enemy(91,26,1,"Enemy1")},
            //{ new Enemy(15,15,1,"Enemy1")},
            //{ new Enemy(10,10,1,"Enemy1")},
            { new Enemy(3,1,1,"Enemy1")},
            { new Enemy(47,1,1,"Enemy2")},
            { new Enemy(91,1,1,"Enemy3")}};



        public Player player = new Player(36, 26, "Thomas");

        public int[,] boardGameArray = new int[batleAreaHeight, batleAreaHWidth];

        public void UpgradeBoardGameArray(Player player, List<Enemy> enemyList)
        {
            AllTanksRender(player, enemyList);
        }

        public void GameAreaDataToStartGame()
        {
            foreach (var enemy in enemies)
            {
                enemy.currentTankModel = enemy.tankModel[3];
            }
            player.currentTankModel = player.tankModel[2];
            BatleAreaFrame();
            AddOtherStructures();
            AllTanksRender();
            //Render(); //ForTesting
        }

        public void AllTanksRender()
        { 
            for (int i = 0; i < 6; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    boardGameArray[player.Y + j, player.X + i] = 8;
                    foreach (var enemy in enemies)
                    {
                        boardGameArray[enemy.Y + j, enemy.X + i] = 9;
                    }
                }
            }
        }
        public void AllTanksRender(Player player, List<Enemy> enemyList)
        {
            for (int i = 0; i < 6; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    boardGameArray[player.Y + j, player.X + i] = 8;
                    foreach (var enemy in enemyList)
                    {
                        boardGameArray[enemy.Y + j, enemy.X + i] = 9;
                    }
                }
            }
        }


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




        internal void MovePlayerWest()
        {
            player.X = player.X - 2;
            if (player.X < 2) 
            {
                player.X = 2;
            }
            for (int i = 0; i < 3; i++)
            {
                if (boardGameArray[player.Y + i, player.X] == 1 || boardGameArray[player.Y + i, player.X] == 9)
                {
                    player.X = player.X + 2;
                }
            }           
        }

        internal void MovePlayerEast()
        {
            player.X = player.X + 2;
            if (player.X > batleAreaHWidth -8)
            {
                player.X = batleAreaHWidth -8;
            }
            for (int i = 0; i < 3; i++)
            {
                if (boardGameArray[player.Y + i, player.X + 5] == 1 || boardGameArray[player.Y + i, player.X + 5] == 9)
                {
                    player.X = player.X - 2;
                }
            }
        }

        internal void MovePlayerNorth()
        {
            player.Y = player.Y - 1;
            if (player.Y < 1)
            {
                player.Y = 1;
            }
            for (int i = 0; i < 6; i++)
            {
                if (boardGameArray[player.Y, player.X + i] == 1 || boardGameArray[player.Y, player.X + i] == 9)
                {
                    player.Y = player.Y + 1;
                }
            }       
        }

        internal void MovePlayerSouth()
        {
            player.Y = player.Y + 1;
            if (player.Y > batleAreaHeight - 4)
            {
                player.Y = batleAreaHeight - 4;
            }
            for (int i = 0; i < 6; i++)
            {
                if (boardGameArray[player.Y + 2, player.X + i] == 1 || boardGameArray[player.Y + 2, player.X + i] == 9)
                {
                    player.Y = player.Y - 1;
                }
            }
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

        public int[,] GetBalteAreaArray()
        {
            return boardGameArray;
        } // return array to not exit from the frame of the game

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
