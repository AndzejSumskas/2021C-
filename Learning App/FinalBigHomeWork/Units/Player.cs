using Learning_App.FinalBigHomeWork.Gui;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learning_App.FinalBigHomeWork.Units
{
    class Player : Unit
    {
        private string name { get; set; }

        public Player(int x, int y, string name) : base(x, y)
        {
            this.name = name;
        }
        public override void Render()
        {
            base.Render();
        }
    }
}
