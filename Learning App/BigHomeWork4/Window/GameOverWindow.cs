using Learning_App.BigHomeWork4.Constants;
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

        private Dice6 dide6 = new Dice6();


        public GameOverWindow() : base(30, 0, 60, 30, "Game Over!", '%')
        {
            titleTextBlock = new TextBlock(10, 2, 100, new List<string> { "How many dices you want to roll?" });

            buttons.Add(new Button(Dice6.Dice1, 50, 4, 20, 3, "1 Dice"));
            buttons.Add(new Button(Dice6.Dice2, 50, 8, 20, 3, "2 Dice"));
            buttons.Add(new Button(Dice6.Dice3, 50, 12, 20, 3, "3 Dice"));
            buttons.Add(new Button(Dice6.Dice4, 50, 16, 20, 3, "4 Dice"));
            buttons.Add(new Button(Dice6.Dice5, 50, 20, 20, 3, "5 Dice"));
            buttons.Add(new Button(Dice6.Dice6, 50, 24, 20, 3, "6 Dice"));

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
    }
}
