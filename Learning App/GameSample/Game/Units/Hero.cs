using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learning_App.GameSample.Game
{
    class Hero //: Unit
    {
        private int x;
        private int y;
        private string name;

        public Hero(string name, int x, int y)
        {
            this.name = name;
            this.x = x;
            this.y = y;
        }

        public void MoveRight()
        {
            x++;
        }

        public void MoveLeft()
        {
            x--;
        }

        public void PrintInfo()
        {
            Console.WriteLine($"Hero : {name} {x}*{y}");
        }
    }
}
