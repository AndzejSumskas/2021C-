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
            GameController gameController = new GameController();
            //gameController.StartGame();

            

            //GameOverWindow gameOverWindow = new GameOverWindow();

            GuiManager me = new GuiManager();

            //gameOverWindow.Render();
            //me.GameOverMenu();

            me.StartAplication();

            Console.ReadKey();
           
        }
    }
}
