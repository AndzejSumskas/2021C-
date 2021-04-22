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
        private int Id;


        public Enemy(int id, int x, int y, string name) : base(x, y, name)
        {
            Id = id;
           
        }

        public void MoveUp()
        {
            Y--;
        }

        public void MoveDown()
        {
            Y++;
        }

        public int GetId()
        {
            return Id;
        }
       
    }
}
