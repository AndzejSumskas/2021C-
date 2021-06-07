using Learning_App.FinalBigHomeWork.Gui;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learning_App.FinalBigHomeWork.Units
{
    class Enemy : Unit
    {
        private int Id { get; set; }
        private string name{ get;set;}

        public Enemy(int x, int y, int id, string name) : base(x, y)
        {
            Id = id;
            this.name = name;
        }
        public override void Render()
        {
            base.Render();
        }
        public string GetName()
        {
            return name;
        }
    }
}
