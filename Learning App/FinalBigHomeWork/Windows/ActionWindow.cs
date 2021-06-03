using Learning_App.FinalBigHomeWork.Data;
using Learning_App.FinalBigHomeWork.Units;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learning_App.FinalBigHomeWork.Windows
{
    class ActionWindow
    {
        GameData gameData = new GameData();

        public void Render()
        {
            gameData.GameAreaData();
            int[,] boardGameArrayCopy = gameData.GetBoardGameArray();
            int tempPlayerX = 0;
            int tempPlayerY = 0;
            for (int i = 0; i < gameData.GetBatleAreaHight(); i++)
            {
                for (int j = 0; j < gameData.GetBatleAreaWidth(); j++)
                {
                    if (boardGameArrayCopy[i, j] == 2)
                    {
                        Console.Write("▓");
                    }
                    if (boardGameArrayCopy[i, j] == 1)
                    {
                        Console.Write("▓");
                    }
                    if (boardGameArrayCopy[i, j] == 0)
                    {
                        Console.Write(" ");
                    }
                    if (boardGameArrayCopy[i, j] == 9)
                    {
                        tempPlayerX = j;
                        tempPlayerY = i;
                        Console.Write(" ");
                    }
                }
                Console.WriteLine();     
            }
            //gameData.player.Render();
        }
    }
}
