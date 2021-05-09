using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learning_App.GameSample.Game
{
    class GameWindow : Window
    {
        private bool Alive = true;

        public GameWindow() : base(0, 0, 120, 30, "Don't die!", '*')
        {
           
        }
        public override void Render()
        {
            base.Render();

        }
    }
}
