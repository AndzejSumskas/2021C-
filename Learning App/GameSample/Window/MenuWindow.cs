using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learning_App.GameSample.Game
{
    class MenuWindow : Window
    {
        //private Button startButton;
        //private Button creditsButton;
        //private Button quitButton;
        private TextBlock titleTextBlock;

        private List<Button> buttonList = new List<Button>();

        public MenuWindow() : base(0, 0, 120, 30, "Game menu!", '%')
        {
            titleTextBlock = new TextBlock(10, 5, 100, new List<string> { "Super duper zaidimas", "Herojus gali vakstineti visomis kriptimis remeliuose!", "Made in Vilnius Coding School!" });

            buttonList.Add(new Button(20, 13, 18, 5, "Start"));
            buttonList.Add(new Button(50, 13, 18, 5, "Credits"));
            buttonList.Add(new Button(80, 13, 18, 5, "Quit"));

            buttonList[0].IsActive = true;
            buttonList[1].IsActive = true;
            buttonList[2].IsActive = true;
        }

        public override void Render()
        {
            base.Render();
            titleTextBlock.Render();

            for (int i = 0; i < buttonList.Count; i++)
            {
                buttonList[i].Render();
            }
        }

        public Button GetButton(int numberOfButton)
        {
            return buttonList[numberOfButton];
        }
        
        public int GetButtonCenterX(int numberOfButton)
        {
            return buttonList[numberOfButton].X + (buttonList[numberOfButton].Width / 2) ;
        }

        public int GetButtonCenterY(int numberOfButton)
        {
            return buttonList[numberOfButton].Y + (buttonList[numberOfButton].Height / 2);
        }
    }
}
