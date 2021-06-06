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
        private bool useOnlyOneToIinitializateField = true;
        public void Render()
        {    
            if(useOnlyOneToIinitializateField)
            {
                gameData.GameAreaDataToStartGame();
            }
          
            for (int i = 0; i < gameData.GetBatleAreaHight(); i++)
            {
                for (int j = 0; j < gameData.GetBatleAreaWidth(); j++)
                {
                    if (gameData.GetBalteAreaArray()[i, j] == 2)
                    {
                        Console.Write("▓");
                    }
                    if (gameData.GetBalteAreaArray()[i, j] == 1)
                    {
                        Console.Write("▓");
                    }
                    if (gameData.GetBalteAreaArray()[i, j] == 0)
                    {
                        Console.Write(" ");
                    }
                    if (gameData.GetBalteAreaArray()[i, j] == 9)
                    {
                        Console.Write(" ");
                    }
                }
                Console.WriteLine();     
            }
        }

        public void Render(int[,] boardGameArray)
        {
            for (int i = 0; i < gameData.GetBatleAreaHight(); i++)
            {
                for (int j = 0; j < gameData.GetBatleAreaWidth(); j++)
                {
                    if (boardGameArray[i, j] == 2)
                    {
                        Console.Write("▓");
                    }
                    if (boardGameArray[i, j] == 1)
                    {
                        Console.Write("▓");
                    }
                    if (boardGameArray[i, j] == 0)
                    {
                        Console.Write(" ");
                    }
                    if (boardGameArray[i, j] == 9)
                    {              
                        Console.Write(" ");
                    }
                    if (boardGameArray[i, j] == 8)
                    {
                        Console.Write(" ");
                    }
                }
                Console.WriteLine();
            }
        }
    }
}
