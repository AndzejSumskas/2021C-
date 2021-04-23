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
            //TextLine text1 = new TextLine(0, 0, 0, "Super Duper Zaidimas");
            //text1.Render();

            //TextLine text4 = new TextLine(0, 1, 0, "*                             *");
            //text4.Render();

            //TextLine text2 = new TextLine(0, 10, 0, "********************************");
            //text2.Render();

            //TextLine text3 = new TextLine(30, 50, 0, "There???");
            //text3.Render();

            Window windowBoarder = new Window(0, 0, 120, 30, '%');
            windowBoarder.Render();

            Button button1 = new Button(5, 20, 20, 5, "Start!");
            button1.Render();

            Button button2 = new Button(50, 20, 20, 5, "Credit!");
            button2.Render();

            Button button3 = new Button(95, 20, 20, 5, "Quit!");
            button3.SetActive();
            button3.Render();


            //GameController myGame = new GameController();
            //myGame.StartGame();

            Console.ReadKey();
        }
    }
}
