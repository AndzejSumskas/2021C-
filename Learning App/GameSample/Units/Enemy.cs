using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Learning_App.GameSample;

namespace Learning_App.GameSample.Game
{
    class Enemy : Unit
    {
        private int id;
        private const string shapeOfEnemy = "(:)";
       
        public Enemy(int id, string name, int x, int y) : base(name, x, y)
        {
            this.id = id;
        }

        public void MoveDown()
        {
            Y++;
        }
        public int GetId()
        {
            return id;
        }
    }
}

