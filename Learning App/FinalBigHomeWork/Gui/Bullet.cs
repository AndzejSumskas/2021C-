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

        public List<Bullet> listOfShootedBullets = new List<Bullet>();

        public List<Bullet> listOfBulletsToBoardGame = new List<Bullet>();

        private string name { get; set; }
        public Bullet() : base(0, 0, 1, 1)
        {
        }

        public Bullet(int x, int y) : base(x, y, 1, 1)
        {
        }
        public Bullet(int x, int y, string name) : base(x, y, 1, 1)
        {
            this.name = name;
        }

        private char bullet = '☻';

           internal string GetName()
        {
            return name;
        }

        public override void Render()
        {
            Console.SetCursorPosition(X, Y);
            Console.Write(bullet);
        }
    }
}
