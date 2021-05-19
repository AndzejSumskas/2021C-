using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learning_App.BigHomeWork4.Units
{
    class Dice
    {
        private int number;

        public Dice(int number)
        {
            this.number = number;
        }

        public int GetDiceValue()
        {
            return number;
        }
    }
}
