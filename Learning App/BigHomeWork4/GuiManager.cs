using Learning_App.BigHomeWork4.Constants;
using Learning_App.BigHomeWork4.Game;
using Learning_App.BigHomeWork4.Window;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learning_App.BigHomeWork4
{
    /// <summary>
    /// Will mange winow and handel user input
    /// </summary>
    class GuiManager
    {
        private MenuWindow menuWindow = new MenuWindow();

        private NumberOfPlayersWindow numberOfPlayersWindow = new NumberOfPlayersWindow();

        private DiceSelectionWindow diceSelectionWindow = new DiceSelectionWindow();

        private GameOverWindow gameOverWindow = new GameOverWindow();

        private GameWindow gameWindow = new GameWindow();

        private GameController gameController = new GameController();

        private bool isApplicationRunning = true;

        private bool windowsIsRunning = true;

        private WindowType currentActiveWindow = WindowType.None;

        public void StartAplication()
        {
            Console.CursorVisible = false;
            Console.Clear();
            ShowMenu();
            StartHandlingInput();
        }



        internal void ShowMenu()
        {
            currentActiveWindow = WindowType.Menu;
            menuWindow.Render();
        
        }

        private void StartHandlingInput()
        {
            do
            {
                
                while (Console.KeyAvailable)
                {
                    var key = Console.ReadKey(true);

                    switch (currentActiveWindow)
                    {
                        case WindowType.None:
                            break;
                        case WindowType.Game:
                            gameWindow.Render();
                            gameController.StartGame();
                            System.Threading.Thread.Sleep(4000);
                            currentActiveWindow = WindowType.GameOver;
                            gameOverWindow.Render();
                            break;
                        case WindowType.GameOver:
                            gameWindow.Render();
                            GameOverMenu();
                            break;
                        case WindowType.PlayesCount:
                            numberOfPlayersWindow.Render();
                            SelectNumberOfPlayers();
                            currentActiveWindow = WindowType.Dice;
                            diceSelectionWindow.Render();
                            break;
                        case WindowType.Menu:
                            switch (key.Key)
                            {
                                case ConsoleKey.LeftArrow:
                                    menuWindow.GoToPreviousItem();
                                    menuWindow.Render();
                                    break;
                                case ConsoleKey.RightArrow:
                                    menuWindow.GoToNextItem();
                                    menuWindow.Render();
                                    break;
                                case ConsoleKey.Enter:
                                    switch(menuWindow.GetActiveButtonType())
                                    {
                                        case ButtonType.Game:
                                            currentActiveWindow = WindowType.PlayesCount;
                                            numberOfPlayersWindow.Render();
                                            break;
                                        case ButtonType.Quit:
                                            isApplicationRunning = false;
                                            break;
                                        default:
                                            break;
                                    }       
                                    break;
                                case ConsoleKey.P:
                                    currentActiveWindow = WindowType.PlayesCount;
                                    numberOfPlayersWindow.Render();
                                    //startgame
                                    break;
                                case ConsoleKey.Q:
                                    isApplicationRunning = false;
                                    break;
                                default:
                                    break;
                            }
                            break;
                        case WindowType.Dice:
                            diceSelectionWindow.Render();
                            SelectNumberOfDice();
                            currentActiveWindow = WindowType.Game;
                            break;
                        default:
                            break;
                    }
                   
                }
            } while (isApplicationRunning);
        }

        public void GameOverMenu()
        {
            windowsIsRunning = true;
            while (windowsIsRunning)
            {
                while (Console.KeyAvailable)
                {
                    var key = Console.ReadKey(true);
                    switch (key.Key)
                    {
                        case ConsoleKey.UpArrow:
                            gameOverWindow.GoToUpperItem();
                            gameOverWindow.Render();
                            break;
                        case ConsoleKey.DownArrow:
                            gameOverWindow.GoToBelowItem();
                            gameOverWindow.Render();
                            break;
                        case ConsoleKey.Enter:
                            windowsIsRunning = false;
                            switch (gameOverWindow.GetActiveButtonType()) 
                            {
                                case ButtonGameOver.Replay:
                                    currentActiveWindow = WindowType.Game;
                                    gameWindow.Render();
                                    break;
                                case ButtonGameOver.Menu:
                                    currentActiveWindow = WindowType.Menu;
                                    menuWindow.Render();
                                    break;
                                case ButtonGameOver.Quit:
                                    isApplicationRunning = false;
                                    break;
                            }
                            break;
                    }
                }
            }
        }
    

        public void SelectNumberOfDice()
        {
            windowsIsRunning = true;
            while (windowsIsRunning)
            {
                while (Console.KeyAvailable)
                {
                    var key = Console.ReadKey(true);
                    switch (key.Key)
                    {
                        case ConsoleKey.UpArrow:
                            diceSelectionWindow.GoToUpperItem();
                            diceSelectionWindow.Render();
                            break;
                        case ConsoleKey.DownArrow:
                            diceSelectionWindow.GoToBelowItem();
                            diceSelectionWindow.Render();
                            break;
                        case ConsoleKey.Enter:
                            currentActiveWindow = WindowType.Dice;
                            windowsIsRunning = false;
                            diceSelectionWindow.Render();
                            break;
                    }
                }
            }
        }

        public void SelectNumberOfPlayers()
        {
            while(windowsIsRunning)
            {
                while (Console.KeyAvailable)
                {
                    var key = Console.ReadKey(true);
                    switch (key.Key)
                    {
                        case ConsoleKey.LeftArrow:
                            numberOfPlayersWindow.GoToPreviousItem();
                            numberOfPlayersWindow.Render();
                            break;
                        case ConsoleKey.RightArrow:
                            numberOfPlayersWindow.GoToNextItem();
                            numberOfPlayersWindow.Render();
                            break;
                        case ConsoleKey.UpArrow:
                            numberOfPlayersWindow.GoToUpperItem();
                            numberOfPlayersWindow.Render();
                            break;
                        case ConsoleKey.DownArrow:
                            numberOfPlayersWindow.GoToBelowItem();
                            numberOfPlayersWindow.Render();
                            break;
                        case ConsoleKey.Enter:
                            currentActiveWindow = WindowType.Dice;
                            diceSelectionWindow.Render();
                            windowsIsRunning = false;               
                            break;
                        default:
                            break;
                    }
                }
                
            }
           
        }
    }
}
