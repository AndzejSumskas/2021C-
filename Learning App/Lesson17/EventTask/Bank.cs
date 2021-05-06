using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learning_App.Lesson17.EventTask
{
    class Bank
    {
        private string bankName;
        private int moneyIn;

        public Bank(string bankName, int moneyIn)
        {
            this.bankName = bankName;
            this.moneyIn = moneyIn;
        }
    }
}
