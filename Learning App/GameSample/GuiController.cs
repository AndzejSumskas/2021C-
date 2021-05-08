using Learning_App.GameSample.Game;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learning_App.GameSample
{
    class GuiController
    {
        private CreditWindow creditWindow = new CreditWindow();
        private MenuWindow menuWindow = new MenuWindow();

        private GameController gameController;

        public GuiController(MenuWindow menuWindow, CreditWindow creditWindo )
        {
            this.creditWindow = creditWindow;
            this.menuWindow = menuWindow;
        }

        internal void ShowMenu()
        {
            menuWindow.Render();
        }
        private int cursorPositionX = 15;
        private int cursorPositionY = 15;
        private bool moveCursor = true;
        private ConsoleKeyInfo input;
        private MenuWindow MW = new MenuWindow();
        


        public void MoveCursoPosition()
        {
            int maxValueX = MW.X + MW.Width;
            int maxValueY = MW.Y + MW.Height;

            do
            {
                Console.SetCursorPosition(cursorPositionX, cursorPositionY);
                input = Console.ReadKey();
                if ((input.Key == ConsoleKey.LeftArrow) && cursorPositionX > 0)
                {
                    cursorPositionX--;
                }
                else if (input.Key == ConsoleKey.UpArrow && cursorPositionY > 0)
                {
                    cursorPositionY--;
                }
                else if (input.Key == ConsoleKey.RightArrow && cursorPositionX < maxValueX)
                {
                    cursorPositionX++;
                }
                else if (input.Key == ConsoleKey.DownArrow && cursorPositionY < maxValueY)
                {
                    cursorPositionY++;
                }
                else if (input.Key == ConsoleKey.Enter)
                {
                    EnterClickButton();
                    
                }
                else if (input.Key == ConsoleKey.Escape && creditWindow.GetBackButton().IsActive == false)
                {
                    moveCursor = false;
                }
                else if (input.Key == ConsoleKey.Escape && creditWindow.GetBackButton().IsActive == true)
                {
                    ShowMenu(); ShowMenu();
                    menuWindow.GetButton(0).IsActive = true;
                    menuWindow.GetButton(1).IsActive = true;
                    menuWindow.GetButton(2).IsActive = true;
                }
                Console.SetCursorPosition(cursorPositionX, cursorPositionY);

            } while (moveCursor);
        }


        private void EnterClickButton()
        {
            Button buttonBack = creditWindow.GetBackButton();
            Button buttonStart = menuWindow.GetButton(0);
            Button buttonCredits = menuWindow.GetButton(1);
            Button buttonQuit = menuWindow.GetButton(2);

            if (cursorPositionX >= buttonStart.X && cursorPositionX <= buttonStart.X + buttonStart.Width && cursorPositionY >= buttonStart.Y && cursorPositionY <= buttonStart.Y + buttonStart.Height && buttonStart.IsActive == true)
            {

            }
            else if (cursorPositionX >= buttonCredits.X && cursorPositionX <= buttonCredits.X + buttonCredits.Width && cursorPositionY >= buttonCredits.Y && cursorPositionY <= buttonCredits.Y + buttonCredits.Height && buttonCredits.IsActive == true)
            {
                creditWindow.Render();
                buttonStart.IsActive = false;
                buttonCredits.IsActive = false;
                buttonQuit.IsActive = false;
                buttonBack.IsActive = true;
            }
            else if (cursorPositionX >= buttonQuit.X && cursorPositionX <= buttonQuit.X + buttonQuit.Width && cursorPositionY >= buttonQuit.Y && cursorPositionY <= buttonQuit.Y + buttonQuit.Height && buttonQuit.IsActive == true)
            {
                moveCursor = false;
            }

            else if (cursorPositionY >= buttonBack.Y && cursorPositionY <= buttonBack.Y + buttonBack.Height && cursorPositionX >= buttonBack.X && cursorPositionX <= buttonBack.Width + buttonBack.X && buttonBack.IsActive == true)
            {
                ShowMenu();
                buttonBack.IsActive = false;
                buttonCredits.IsActive = true;
                buttonQuit.IsActive = true;
                buttonStart.IsActive = true;
            }
            
        }

        public void StartGame()
        {
            gameController.StartGame();
        }
    }
}
