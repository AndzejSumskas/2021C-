using Learning_App.GameSample.Game;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learning_App.GameSample
{
    class GameProject
    {
        static void Main()
        {
            //GameController gameController = new GameController();
            //gameController.StartGame();

            //Console.CursorVisible = false;

            MenuWindow gameWindow = new MenuWindow();
           

            CreditWindow creditWindow = new CreditWindow();
           

            GuiController guiController = new GuiController(gameWindow, creditWindow);

           guiController.ShowMenu();
           guiController.MoveCursoPosition();

            


            Console.ReadKey();
        }
    }
}

