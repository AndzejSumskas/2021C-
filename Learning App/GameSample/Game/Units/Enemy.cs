using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Learning_App.GameSample;

namespace Learning_App.GameSample.Game
{
    class Enemy //: Unit
    {
        private int id;
        private int x;
        private int y;
        private string name;

        public Enemy(int id, string name, int x, int y)
        {
            this.id = id;
            this.name = name;
            this.x = x;
            this.y = y;
        }

        public void MoveDown()
        {
            y++;
        }

        public void PrintInfo()
        {
            Console.WriteLine($"Enemy {id} : {name} {x}*{y}");

        }
        public int GetId()
        {
            return id;
        }
    }

}

