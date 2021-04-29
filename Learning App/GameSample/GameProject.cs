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
            GameController gameController = new GameController();
            gameController.StartGame();
        }
    }
}
