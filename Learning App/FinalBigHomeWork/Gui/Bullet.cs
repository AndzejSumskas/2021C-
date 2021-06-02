using Learning_App.FinalBigHomeWork.Units;
using Learning_App.FinalBigHomeWork.Windows;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learning_App.FinalBigHomeWork.Gui
{
    class Bullet : GuiObject
    {
        BoardGame boardGame = new BoardGame();
        GameWindow gameWindow = new GameWindow();
        public List<Bullet> listOfBulletsShutUp = new List<Bullet>();
        public List<Bullet> listOfBulletsShutDown = new List<Bullet>();
        public List<Bullet> listOfBulletsShutLeft = new List<Bullet>();
        public List<Bullet> listOfBulletsShutRight = new List<Bullet>();


        public bool shotIsActive;

        public Bullet(int x, int y) : base(x, y, 1, 1)
        {
        }
        private char bullet = '☻';

        public override void Render()
        {
            Console.SetCursorPosition(X, Y);
            Console.Write(bullet);
        }

        internal void BulletsShots()
        {
            ShutUp();
            ShutDown();
            ShutLeft();
            ShutRight();
        }

        private void ShutRight()
        {
            List<int> tempListOfBullets = new List<int>();
            for (int i = 0; i < listOfBulletsShutRight.Count; i++)
            {
                if(boardGame.GetBalteAreaArray()[listOfBulletsShutRight[i].Y, listOfBulletsShutRight[i].X] == 1 || boardGame.GetBalteAreaArray()[listOfBulletsShutRight[i].Y, listOfBulletsShutRight[i].X] == 2)
                {
                    tempListOfBullets.Add(i);
                    shotIsActive = false;
                }
                else
                {
                    for (int j = 0; j < 6; j++)
                    {
                        listOfBulletsShutRight[i].X += 1;
                        if (boardGame.GetBalteAreaArray()[listOfBulletsShutRight[i].Y, listOfBulletsShutRight[i].X - 1] == 1 || boardGame.GetBalteAreaArray()[listOfBulletsShutRight[i].Y, listOfBulletsShutRight[i].X - 1] == 2)
                        {
                            listOfBulletsShutRight[i].X -= 1;
                        }
                        shotIsActive = true;
                    } 
                }
            }

            var tempList = from nr in tempListOfBullets
                           orderby nr descending
                           select nr;
            foreach (var number in tempList)
            {
                listOfBulletsShutRight.RemoveAt(number);
            }
        }

        private void ShutLeft()
         {
            List<int> tempListOfBullets = new List<int>();
            for (int i = 0; i < listOfBulletsShutLeft.Count; i++)
            {
                if (boardGame.GetBalteAreaArray()[listOfBulletsShutLeft[i].Y, listOfBulletsShutLeft[i].X] == 1 || boardGame.GetBalteAreaArray()[listOfBulletsShutLeft[i].Y, listOfBulletsShutLeft[i].X] == 2)
                {
                    tempListOfBullets.Add(i);
                    shotIsActive = false;
                }
                else
                {
                    for (int j = 0; j < 6; j++)
                    {
                        listOfBulletsShutLeft[i].X -= 1;
                        if (boardGame.GetBalteAreaArray()[listOfBulletsShutLeft[i].Y, listOfBulletsShutLeft[i].X + 1] == 1 || boardGame.GetBalteAreaArray()[listOfBulletsShutLeft[i].Y, listOfBulletsShutLeft[i].X + 1] == 2)
                        {
                            listOfBulletsShutLeft[i].X += 1;
                        }
                        shotIsActive = true;
                    }
                }
            }

            var tempList = from nr in tempListOfBullets
                           orderby nr descending
                           select nr;
            foreach (var number in tempList)
            {
                listOfBulletsShutLeft.RemoveAt(number);
            }
        }

        private void ShutDown()
         {
            List<int> tempListOfBullets = new List<int>();
            for (int i = 0; i < listOfBulletsShutDown.Count; i++)
            {
                 if (boardGame.GetBalteAreaArray()[listOfBulletsShutDown[i].Y  , listOfBulletsShutDown[i].X] == 1 || boardGame.GetBalteAreaArray()[listOfBulletsShutDown[i].Y , listOfBulletsShutDown[i].X] == 2)
                {
                    tempListOfBullets.Add(i);
                    shotIsActive = false;
                }
                else
                {
                    for (int j = 0; j < 3; j++)
                    {
                        listOfBulletsShutDown[i].Y += 1;
                        if (boardGame.GetBalteAreaArray()[listOfBulletsShutDown[i].Y - 1, listOfBulletsShutDown[i].X] == 1 || boardGame.GetBalteAreaArray()[listOfBulletsShutDown[i].Y -1, listOfBulletsShutDown[i].X] == 2)
                        {
                            listOfBulletsShutDown[i].Y -= 1;
                        }
                        shotIsActive = true;
                    }
                }
            }

            var tempList = from nr in tempListOfBullets
                           orderby nr descending
                           select nr;
            foreach (var number in tempList)
            {
                listOfBulletsShutDown.RemoveAt(number);
            }
        }

        private void ShutUp()
        {
            List<int> tempListOfBullets = new List<int>();
            for (int i = 0; i < listOfBulletsShutUp.Count; i++)
            {
                if (boardGame.GetBalteAreaArray()[listOfBulletsShutUp[i].Y, listOfBulletsShutUp[i].X] == 1 || boardGame.GetBalteAreaArray()[listOfBulletsShutUp[i].Y, listOfBulletsShutUp[i].X] == 2)
                {
                    tempListOfBullets.Add(i);
                    shotIsActive = false;
                }
                else
                {
                    for (int j = 0; j < 3; j++)
                    {
                        listOfBulletsShutUp[i].Y -= 1;
                        if (boardGame.GetBalteAreaArray()[listOfBulletsShutUp[i].Y + 1, listOfBulletsShutUp[i].X] == 1 || boardGame.GetBalteAreaArray()[listOfBulletsShutUp[i].Y + 1, listOfBulletsShutUp[i].X] == 2)
                        {
                            listOfBulletsShutUp[i].Y += 1;
                        }
                        shotIsActive = true;
                    }
                }
            }

            var tempList = from nr in tempListOfBullets
                           orderby nr descending
                           select nr;
            foreach (var number in tempList)
            {
                listOfBulletsShutUp.RemoveAt(number);
            }
        }
    }
}
