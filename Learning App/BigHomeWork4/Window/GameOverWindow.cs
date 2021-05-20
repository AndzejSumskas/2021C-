using Learning_App.BigHomeWork4.Constants;
using Learning_App.BigHomeWork4.Game;
using Learning_App.BigHomeWork4.Gui;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learning_App.BigHomeWork4.Window
{
    class GameOverWindow : Windoww
    {
        private TextBlock titleTextBlock;

        private List<Button> buttons = new List<Button>();

        private int activeButtonId = 0;

        GameController gameController = new GameController(); 

        public GameOverWindow() : base(30, 0, 60, 30, "Game Over!", '%')
        {
            titleTextBlock = new TextBlock(10, 2, 100, new List<string> { $"The winner is: {NameOfWinner()}" });

            buttons.Add(new Button(ButtonGameOver.Replay, 50, 10, 20, 3, "R - Replay"));
            buttons.Add(new Button(ButtonGameOver.Menu, 50, 15, 20, 3, "M - Menu"));
            buttons.Add(new Button(ButtonGameOver.Quit, 50, 20, 20, 3, "Q - Quit"));

            buttons[activeButtonId].IsActive = true;
        }

        public override void Render()
        {
            base.Render();
            titleTextBlock.Render();

            for (int i = 0; i < buttons.Count; i++)
            {
                buttons[i].Render();
            }
        }

        public void GoToUpperItem()
        {
            buttons[activeButtonId].IsActive = false;
            activeButtonId--;
            if (activeButtonId < 0)
            {
                activeButtonId = (int)ButtonGameOver.Quit;
            }
            buttons[activeButtonId].IsActive = true;
        }

        public void GoToBelowItem()
        {
            buttons[activeButtonId].IsActive = false;
            activeButtonId++;
            if (activeButtonId > (int)ButtonGameOver.Quit)
            {
                activeButtonId = (int)ButtonGameOver.Replay;
            }
            buttons[activeButtonId].IsActive = true;
        }

        internal ButtonGameOver GetActiveButtonType()
        {
            return buttons[activeButtonId].TypeGO;
        }

        public string NameOfWinner()
        {
            string name = gameController.GetWinner().GetName();
            return name;
        }
    }
}
