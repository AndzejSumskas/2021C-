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

        internal  Player GetPlayer()
        {
            return player;
        }

        internal int[,] GetBoardGameArray()
        {
            GameAreaDataToStartGame();
            return boardGameArray;
        }

        internal List<Enemy> GetEnemies()
        {
            return enemies;
        }

        public Player player = new Player(36, 26, "Thomas");

        public int[,] boardGameArray = new int[batleAreaHeight, batleAreaHWidth];

        //public int[,] UpgradeBoardGameArray(Player player, List<Enemy> enemyList, int[,] boardGameArray)
        //{
        //    for (int i = 0; i < 6; i++)
        //    {
        //        for (int j = 0; j < 3; j++)
        //        {
        //            boardGameArray[player.Y + j, player.X + i] = 8;
        //            foreach (var enemy in enemyList)
        //            {
        //                boardGameArray[enemy.Y + j, enemy.X + i] = 9;
        //            }
        //        }
        //    }
        //    return boardGameArray;
        //}

        public void GameAreaDataToStartGame()
        {
            foreach (var enemy in enemies)
            {
                enemy.currentTankModel = enemy.tankModel[3];
            }
            player.currentTankModel = player.tankModel[2];
            BatleAreaFrame();
            AddOtherStructures();
            //AllTanksRender(boardGameArray);
            //Render(); //ForTesting
        }

        //public void AllTanksRender(int[,] boardGameArray)
        //{ 
        //    for (int i = 0; i < 6; i++)
        //    {
        //        for (int j = 0; j < 3; j++)
        //        {
        //            boardGameArray[player.Y + j, player.X + i] = 8;
        //            foreach (var enemy in enemies)
        //            {
        //                boardGameArray[enemy.Y + j, enemy.X + i] = 9;
        //            }
        //        }
        //    }
        //}
        //public void AllTanksRender(Player player, List<Enemy> enemyList)
        //{
        //    for (int i = 0; i < 6; i++)
        //    {
        //        for (int j = 0; j < 3; j++)
        //        {
        //            boardGameArray[player.Y + j, player.X + i] = 8;
        //            foreach (var enemy in enemyList)
        //            {
        //                boardGameArray[enemy.Y + j, enemy.X + i] = 9;
        //            }
        //        }
        //    }
        //}


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
