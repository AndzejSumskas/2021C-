using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learning_App.FinalBigHomeWork.Units
{
    class BoardGame
    {
        private int[,] boardGameArray = new int[48, 146];

        public void arrayChangeArray()
        {
            for (int i = 0; i < 48; i++)
            {
                for (int j = 0; j < 146; j++)
                {
                    boardGameArray[i, j] = 0;
                }
            }
        }
    }
}
