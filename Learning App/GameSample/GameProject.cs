using Learning_App.GameSample.Game;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Learning_App.GameSample.Game;

namespace Learning_App.GameSample
{
    class GameProject
    {
        static void Main()
        {
            TextLine text1 = new TextLine(0, 0, 0, "*******************************");
            text1.Render();

            TextLine text4 = new TextLine(0, 1, 0, "*                             *");
            text4.Render();

            TextLine text2 = new TextLine(0, 10, 0, "********************************");
            text2.Render();

            //TextLine text3 = new TextLine(30, 50, 0, "There???");
            //text3.Render();

            Console.ReadKey();


            //GameController myGame = new GameController();
            //myGame.StartGame();
        }
    }
}
