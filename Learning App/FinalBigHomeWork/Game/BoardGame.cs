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
        private List<Bullet> explodedBulletsList = new List<Bullet>();

        public void AddToexplodedBulletsList(Bullet bulet)
        {
            explodedBulletsList.Add(bulet);
        }

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

        //Make changes in game window
        //private int explodeX;  ///aasdasdasdasasdasd
        //private int explodeY; //dasdasdasdasdasdasdas

        public void MakeChange()
        {
            int explodeX = 0;
            int explodeY = 0;
         

            //Gauname isautus sviedinius kurie susprogo prie objektu
            foreach (var bullet in explodedBulletsList)
            {
                //Gauname koordinates sprogimo
                explodeX = bullet.X;
                explodeY = bullet.Y;
                //Gauname krypti, kuria sviedinys skriejo                
                switch (bullet.GetName())
                {
                    case "ShutUp":
                        break;
                    case "ShutDown":
                        break;
                    case "ShutLeft":
                        break;
                    case "ShutRight":
                        break;
                    default:
                        break;



                }

                //
                for (int i = 0; i < gameWindow.textLines.Count; i++)
                {
                    if (explodeY == bullet.Y)
                    {
                        if (bullet.X >= explodeX && bullet.X <= explodeX + gameWindow.textLines[i].Width)
                        {
                            Console.WriteLine(456464554);
                        }
                    }
                }
                foreach (var line in gameWindow.textLines)
                {
                    if(bullet.Y == line.Y)
                    {
                        if (bullet.X >= line.X && bullet.X <= line.X + line.Width)
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

                }
            }


        }
    }
}
