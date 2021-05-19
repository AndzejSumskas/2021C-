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
    class NumberOfPlayersWindow : Windoww
    {
        private TextBlock titleTextBlock;

        private List<Button> buttons = new List<Button>();

        private int activeButtonId = 0;


        public NumberOfPlayersWindow() : base(28, 10, 60, 19, "Number of Playes", '@')
        {
            buttons.Add(new Button(ButtonPlayersCount.P2, 43, 13, 15, 5, "P2"));
            buttons.Add(new Button(ButtonPlayersCount.P3, 58, 13, 15, 5, "P3"));
            buttons.Add(new Button(ButtonPlayersCount.P4, 43, 18, 15, 5, "P4"));
            buttons.Add(new Button(ButtonPlayersCount.P5, 58, 18, 15, 5, "P5"));
            buttons.Add(new Button(ButtonPlayersCount.P6, 43, 23, 15, 5, "P6"));
            buttons.Add(new Button(ButtonPlayersCount.P7, 58, 23, 15, 5, "P7"));

            buttons[activeButtonId].IsActive = true;
        }

        internal int GetItemId()
        {
            return activeButtonId += 2;
        }

        public override void Render()
        {
            base.Render();

            for (int i = 0; i < buttons.Count; i++)
            {
                buttons[i].Render();
            }
        }

        public ButtonPlayersCount GetActiveButtonType()
        {
            return buttons[activeButtonId].TypeP;
        }
        
        internal void GoToPreviousItem()
        {
            buttons[activeButtonId].IsActive = false;
            activeButtonId--;
            if (activeButtonId % 2 != 0) 
            {
                activeButtonId += 2;
            }
            buttons[activeButtonId].IsActive = true;
        }
        
        internal void GoToNextItem()
        {
            buttons[activeButtonId].IsActive = false;
            activeButtonId++;
            if(activeButtonId % 2 == 0)
            {
                activeButtonId -= 2;
            }
            buttons[activeButtonId].IsActive = true;
        }
        //Blogai
        internal void GoToBelowItem()
        {
            buttons[activeButtonId].IsActive = false;
            activeButtonId += 2;
            if (activeButtonId >= buttons.Count)
            {
                activeButtonId -=6;
            }
            buttons[activeButtonId].IsActive = true;
        }
        //Blogai
        internal void GoToUpperItem()
        {
            buttons[activeButtonId].IsActive = false;
            activeButtonId-=2;
            if (activeButtonId < 0)
            {
                activeButtonId += 6;
            }
            buttons[activeButtonId].IsActive = true;
        }
        
    }
}
