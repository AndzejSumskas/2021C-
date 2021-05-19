using Learning_App.BigHomeWork4.Game;
using Learning_App.BigHomeWork4.Window;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learning_App.BigHomeWork4
{
    class ProgramBigHomeWork4
    {
        static void Main()
        {
            //GuiManager guiManager = new GuiManager();
            //guiManager.StartAplication();

            //DiceSelectionWindow dsw = new DiceSelectionWindow();

            //dsw.Render();

            GameController gameController = new GameController();

            GameOverWindow gameOverWindow = new GameOverWindow();

            gameController.StartGame();
            //gameOverWindow.Render();

            Console.ReadKey();
        }
    }
}
