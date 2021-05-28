using Learning_App.BigHomeWork4Task.Constatnts;
using Learning_App.BigHomeWork4Task.Windows;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learning_App.BigHomeWork4Task
{
    /// <summary>
    /// Will manage window and handle user input.
    /// </summary>
    class GuiManager
    {
        private MenuWindow menuWindow = new MenuWindow();

        private CreditWindow creditWindow = new CreditWindow();

        private bool isApliciationRunning = true;

        private WindowType currentActiveWindow = WindowType.None;

        public void StartAplication()
        {
            Console.Clear();
            ShowMenu();
            StartHandlingInput();
        }

        private void StartHandlingInput()
        {
            do
            {
                while(Console.KeyAvailable)
                {
                    var key = Console.ReadKey(true);
                    switch (currentActiveWindow)
                    {
                        case WindowType.Menu:
                            switch (key.Key)
                            {
                                case ConsoleKey.LeftArrow:
                                    menuWindow.GoToPrieviousMenuItem();
                                    menuWindow.Render();
                                    break;
                                case ConsoleKey.RightArrow:
                                    menuWindow.GoToNextMenuItem();
                                    menuWindow.Render();
                                    break;
                                case ConsoleKey.Enter:
                                    switch(menuWindow.GetActiveButtonType())
                                    {
                                        case ButtonType.Game:
                                            break;
                                        case ButtonType.Credits:
                                            ShowCredits();
                                            break;
                                        case ButtonType.Quit:
                                            isApliciationRunning = false;
                                            break;

                                    }
                                    break;
                                case ConsoleKey.Escape:
                                    break;
                                default:
                                    break;
                            }
                            break;
                        case WindowType.Credit:
                            switch(key.Key)
                            {
                                case ConsoleKey.Enter:
                                case ConsoleKey.Escape:
                                    ShowMenu();
                                    break;
                            }
                            break;
                        
                    }
                }
            } while (isApliciationRunning);
        }

        private void ShowCredits()
        {
            currentActiveWindow = WindowType.Credit;
            creditWindow.Render();
        }

        private void ShowMenu()
        {
            currentActiveWindow = WindowType.Menu;
            menuWindow.Render();
        }
    }
}
