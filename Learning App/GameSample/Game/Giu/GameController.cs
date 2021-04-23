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

        internal void StartGame()
        {
            GameScreen gameScreen = new GameScreen(200, 80);


            gameScreen.SetHero(new Hero(5, 5, "Thor"));

            Hero hero = new Hero(5, 5, "Jack");
            Hero hero2 = new Hero(5, 5, "Leonidas");

            Unit unit1 = new Unit(6, 9, "Kongas");

            unit1.PrintInfo();


            hero.PrintInfo();
            hero.MoveRight();
            hero.PrintInfo();


            Random rng = new Random();
            int uniqyeId = 0;
            for (int i = 0; i < 10; i++)
            {
                gameScreen.AddEnemy(new Enemy(uniqyeId, rng.Next(0, 200), rng.Next(0, 80), ("EnemyNr" + uniqyeId)));
                uniqyeId++;
            }

            gameScreen.Render();

            gameScreen.MoveAllEnemiesDown();

            gameScreen.Render();
            gameScreen.MoveAllEnemiesUp();


            gameScreen.GetEnemyById(2).MoveDown();


            gameScreen.Render();
        }
    }
}
