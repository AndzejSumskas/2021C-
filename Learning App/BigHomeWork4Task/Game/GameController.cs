using Learning_App.BigHomeWork4Task.Units;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learning_App.BigHomeWork4Task.Game
{
    class GameController
    {
        public void StartGame()
        {
            GameScreen gameScreen = new GameScreen(200, 40);
            gameScreen.SetHero(new Hero(100, 38, "Spiderman"));

            int uniqueId = 0;
            Random rnd = new Random();
            for (int i = 0; i < 10; i++)
            {
                gameScreen.AddEnemy(new Enemy(uniqueId, rnd.Next(0, 10), rnd.Next(0, 100), "EnemyNr" + uniqueId));
                uniqueId++;
            }

            gameScreen.Render();

            gameScreen.MoveHeroLeft();
            gameScreen.MoveAllEnemiesDown();

            gameScreen.GetEnemyById(5).MoveDown();
            Console.WriteLine("***********************************");
            gameScreen.Render();

        }

        
    }
}
