using Learning_App.FinalBigHomeWork.Gui;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learning_App.FinalBigHomeWork.Windows
{
    class GameOverWindow : Window
    {
        
        List<TextLine> gameOverData;
        private TextLine textLine;
        public GameOverWindow() : base(0, 0, 30, 15, "Game Over", '#')
        {
            gameOverData = new List<TextLine>();
            gameOverData.Add(new TextLine(0, 3, 30, "GAME OVER"));
            gameOverData.Add(new TextLine(0, 6, 30, "Zaidejas sunaikino:"));            
            gameOverData.Add(new TextLine(0, 11, 30, $"Zaidejas buvo sunaikintas:"));
            
       }

        public override void Render()
        {
            base.Render();
            foreach (var data in gameOverData)
            {
                data.Render();
            }
        }
        public void Render(int DestroyedEnemies, int DestroyedPlayer)
        {
            base.Render();
            foreach (var data in gameOverData)
            {
                data.Render();
            }
        }

        public void GameOverUpgrade(int numberOfDestroyedEnemies, int numberOfDestroyedPlayer)
        {
            gameOverData.Add(new TextLine(0, 8, 30, $"{numberOfDestroyedEnemies} priesus!"));
            gameOverData.Add(new TextLine(0, 13, 30, $"{numberOfDestroyedPlayer} kartus!"));
        }
    }
}
