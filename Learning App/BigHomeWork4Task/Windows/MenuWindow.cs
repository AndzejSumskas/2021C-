using Learning_App.BigHomeWork4Task.Constatnts;
using Learning_App.BigHomeWork4Task.Gui;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learning_App.BigHomeWork4Task.Windows
{
    /// <summary>
    /// Show game menu.
    /// </summary>
    class MenuWindow : Window
    {
        private TextBlock titleTextBlock;
        private int activeButtonId = 0;

        private List<Button> buttons = new List<Button>();

        public MenuWindow() : base(0, 0, 120, 30, "Game menu!", '%')
        {
            titleTextBlock = new TextBlock(10, 5, 100, new List<string> { "Super duper zaidimas", "Vardas Pavardaitis kuryba!", "Made in Vilnius Coding School!" });
            buttons.Add(new Button(ButtonType.Game, 20, 13, 18, 5, "Start"));
            buttons.Add(new Button(ButtonType.Credits, 50, 13, 18, 5, "Credits"));
            buttons.Add(new Button(ButtonType.Quit, 80, 13, 18, 5, "Quit"));

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

        internal void GoToPrieviousMenuItem()
        {
            buttons[activeButtonId].IsActive = false;
            activeButtonId--;
            if(activeButtonId < 0)
            {
                activeButtonId = buttons.Count-1;
            }
            buttons[activeButtonId].IsActive = true;
        }

        internal void GoToNextMenuItem()
        {
            buttons[activeButtonId].IsActive = false;
            activeButtonId++;
            if(activeButtonId >= buttons.Count)
            {
                activeButtonId = 0;
            }
            buttons[activeButtonId].IsActive = true; ;
        }

        internal ButtonType GetActiveButtonType()
        {
            return buttons[activeButtonId].ButtonType;
        }
    }
}
