using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learning_App.BigHomeWork4.Units
{
    class Player
    {
        private string name;

        private List<Dice> diceList;

        public Player(string name, List<Dice> diceList)
        {
            this.name = name;
            this.diceList = diceList;
        }

        public List<Dice> GetDiceList()
        {
            return this.diceList;
        }

        public void AddDiceToDiceList(Dice dice)
        {
            diceList.Add(dice);
        }

        internal string GetName()
        {
            return name;
        }
    }
}
