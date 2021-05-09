using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Learning_App.GameSample.Game;

namespace Learning_App.GameSample.Game
{
    class GameController
    {
        public void StartGame()
        {
            GameScreen gameScreen = new GameScreen(120, 30);
            gameScreen.SetHero(new Hero("Rand al'Thor", 5, 5));

            Hero hero = gameScreen.GetHero();

            hero.MovementOfHero();
           

           


            


            int uniqueId = 0;
            Random rnd = new Random();
            for (int i = 0; i < 10; i++)
            {
                gameScreen.AddEnemy(new Enemy(uniqueId, "EnemyNr" + uniqueId, rnd.Next(0, 10), rnd.Next(0, 100)));
                uniqueId++;
            }

            //gameScreen.Render();

            //gameScreen.MoveHeroLeft();
            //gameScreen.MoveAllEnemiesDown();

            //gameScreen.GetEnemyById(2).MoveDown();

            //gameScreen.Render();
        }
    }
}
