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
        public List<Bullet> listOfBullets = new List<Bullet>();

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

        internal void ShotUp()
        {
            shotIsActive = true;
            if (Y <= gameWindow.Y + 1)
            { 
                shotIsActive = false; 
            }

            else
            {
                Y--;
            }
        }
    }
}
