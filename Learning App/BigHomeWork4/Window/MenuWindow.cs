using Learning_App.BigHomeWork4;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Learning_App.BigHomeWork4.Gui;
using Learning_App.BigHomeWork4.Constants;

namespace Learning_App.BigHomeWork4.Window
{
    class MenuWindow : Windoww
    {
        /// <summary>
        /// Show menu window.
        /// </summary>
       
        private TextBlock titleTextBlock;

        private List<Button> buttons = new List<Button>();

        private int activeButtonId = 0;


        public MenuWindow() : base(0, 0, 120, 30, "Menu window!", '%')
        {
            titleTextBlock = new TextBlock(10, 5, 100, new List<string> { "Dice Roll Game", "Made in Vilnius Coding School!" });

            buttons.Add(new Button(ButtonType.Game, 20, 13, 18, 5, "P - Play"));           
            buttons.Add(new Button(ButtonType.Quit, 80, 13, 18, 5, "Q - Quit"));

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

        public Button GetButton(int numberOfButton)
        {
            return buttons[numberOfButton];
        }

        public int GetButtonCenterX(int numberOfButton)
        {
            return buttons[numberOfButton].X + (buttons[numberOfButton].Width / 2);
        }

        internal void GoToPreviousItem()
        {
            buttons[activeButtonId].IsActive = false;
            activeButtonId--;
            if (activeButtonId < 0)
            {
                activeButtonId = buttons.Count -1;
            }
            buttons[activeButtonId].IsActive = true;
        }

        internal void GoToNextItem()
        {
            buttons[activeButtonId].IsActive = false;
            activeButtonId++;
            if (activeButtonId >= buttons.Count)
            {
                activeButtonId = 0;
            }
            buttons[activeButtonId].IsActive = true;
       }

        internal ButtonType GetActiveButtonType()
        {
            return buttons[activeButtonId].Type;
        }

        internal int GetActiveId()
        {
            return activeButtonId;
        }

        public int GetButtonCenterY(int numberOfButton)
        {
            return buttons[numberOfButton].Y + (buttons[numberOfButton].Height / 2);
        }
    }
}
