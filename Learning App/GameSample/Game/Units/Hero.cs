using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learning_App.GameSample.Game
{
    class Hero : Unit
    {
        public Hero(int x, int y, string name) : base(x, y, name)
        {
            
        }

        public void MoveRight()
        {
            X += 1;
        }

        public void MoveLeft()
        {
            X -= 1;
        }
    }
}
