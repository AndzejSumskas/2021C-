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
            List<int> tempListOfNumbers = new List<int>();
            for (int i = 0; i < listOfBulletsShutRight.Count; i++)
            {
                if (listOfBulletsShutRight[i].X >= gameWindow.X + gameWindow.Width -3)
                {
                    tempListOfNumbers.Add(i);
                    shotIsActive = false;
                }
                else
                {
                    listOfBulletsShutRight[i].X+=6;
                    if(listOfBulletsShutRight[i].X >= gameWindow.X + gameWindow.Width - 3)
                    {
                        listOfBulletsShutRight[i].X = gameWindow.X + gameWindow.Width - 3;
                    }
                    shotIsActive = true;
                }
            }

            var tempList = from nr in tempListOfNumbers
                           orderby nr descending
                           select nr;
            foreach (var number in tempList)
            {
                listOfBulletsShutRight.RemoveAt(number);
            }
        }

        private void ShutLeft()
        {
            List<int> tempListOfNumbers = new List<int>();
            for (int i = 0; i < listOfBulletsShutLeft.Count; i++)
            {
                if (listOfBulletsShutLeft[i].X <= gameWindow.X + 2)
                {
                    tempListOfNumbers.Add(i);
                    shotIsActive = false;
                }
                else
                {
                    listOfBulletsShutLeft[i].X-=6;
                    if (listOfBulletsShutLeft[i].X <= gameWindow.X + 2)
                    {
                        listOfBulletsShutLeft[i].X = 2;
                    }
                    shotIsActive = true;
                }
            }

            var tempList = from nr in tempListOfNumbers
                           orderby nr descending
                           select nr;
            foreach (var number in tempList)
            {
                listOfBulletsShutLeft.RemoveAt(number);
            }
        }

        private void ShutDown()
        {
            List<int> tempListOfNumbers = new List<int>();
            for (int i = 0; i < listOfBulletsShutDown.Count; i++)
            {
                if (listOfBulletsShutDown[i].Y >= gameWindow.Y + gameWindow.Height -1)
                {
                    tempListOfNumbers.Add(i);
                    shotIsActive = false;
                }
                else
                {
                    listOfBulletsShutDown[i].Y+=3;
                    if (listOfBulletsShutDown[i].Y >= gameWindow.Y + gameWindow.Height - 1)
                    {
                        listOfBulletsShutDown[i].Y = gameWindow.Y + gameWindow.Height - 1;
                    }
                        shotIsActive = true;
                }
            }

            var tempList = from nr in tempListOfNumbers
                           orderby nr descending
                           select nr;
            foreach (var number in tempList)
            {
                listOfBulletsShutDown.RemoveAt(number);
            }
        }

        private void ShutUp()
        {
            List<int> tempListOfNumbers = new List<int>();
            for (int i = 0; i < listOfBulletsShutUp.Count; i++)
            {
                if (listOfBulletsShutUp[i].Y <= gameWindow.Y)
                {
                    tempListOfNumbers.Add(i);
                    shotIsActive = false;
                }
                else
                {
                    listOfBulletsShutUp[i].Y-=3;
                    if(listOfBulletsShutUp[i].Y <= gameWindow.Y)
                    {
                        listOfBulletsShutUp[i].Y = gameWindow.Y;
                    }
                    shotIsActive = true;
                }
            }

            var tempList = from nr in tempListOfNumbers
                           orderby nr descending
                           select nr;
            foreach (var number in tempList)
            {
                listOfBulletsShutUp.RemoveAt(number);
            }
        }
    }
}
