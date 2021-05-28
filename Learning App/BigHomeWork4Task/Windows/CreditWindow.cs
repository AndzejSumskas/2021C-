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
    /// Shows credits.
    /// </summary>
    class CreditWindow : Window
    {
        private Button backButton;
        private TextBlock creditTextBlock;

        public CreditWindow() : base(28, 10, 60, 18, "Credits!", '@')
        {
            List<string> creditData = new List<string>();

            creditData.Add("");
            creditData.Add("Game design:");
            creditData.Add("Vardas Vardaitis");
            creditData.Add("");
            creditData.Add("Programuotojas:");
            creditData.Add("Vardas Vardaitis");
            creditData.Add("");
            creditData.Add("\'Art\':");
            creditData.Add("Vardas Vardaitis");
            creditData.Add("");
            creditData.Add("Marketingas:");
            creditData.Add("Vardas Vardaitis");
            creditData.Add("");

            creditTextBlock = new TextBlock(28 + 1, 10 + 1, 60 - 1, creditData);


            backButton = new Button(ButtonType.Quit, 28 + 20, 10 + 14, 18, 3, "Back");
            backButton.IsActive = true;
        }

        public override void Render()
        {
            base.Render();
            creditTextBlock.Render();
            backButton.Render();
        }
    }
}
