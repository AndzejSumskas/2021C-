using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Learning_App.GameSample;
using Learning_App.GameSample.Game;

namespace Learning_App.GameSample.Game
{
    class GameScreen
    {
        private int Width;
        private int Height;
        private Hero hero;

        private List<Unit> units = new List<Unit>();

        private List<Enemy> enemies = new List<Enemy>();

        public GameScreen(int width, int height)
        {
            Width = width;
            Height = height;
        }

        public void SetHero(Hero hero)
        {
            this.hero = hero;
        }

        public void MoveHeroRight(Hero hero)
        {
            hero.MoveRight();
        }
        public void MoveHeroLeft(Hero hero)
        {
            hero.MoveLeft();
        }

        public void AddEnemy(Enemy enemy)
        {
            enemies.Add(enemy);
        }

        public void MoveAllEnemiesDown()
        {
            foreach (Enemy enemy in enemies)
            {
                enemy.MoveDown();
            }
        }

        public void MoveAllEnemiesUp()
        {
            foreach (Enemy enemy in enemies)
            {
                enemy.MoveUp();
            }
        }

        public Enemy GetEnemyById(int id)
        {
            foreach(Enemy enemy in enemies)
            {
                if(enemy.GetId() == id)
                {
                    return enemy;
                }
            }
            return null;
        }

        public void Render()
        {
            hero.PrintInfo();

            foreach(Enemy enemy in enemies)
            {
                enemy.PrintInfo();
            }
        }

        
    }
}
