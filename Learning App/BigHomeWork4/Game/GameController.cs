using Learning_App.BigHomeWork4.Units;
using Learning_App.BigHomeWork4.Window;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learning_App.BigHomeWork4.Game
{
    class GameController
    {
        private DiceSelectionWindow diceSelectionWindow = new DiceSelectionWindow();

        private NumberOfPlayersWindow numberOfPlayersWindow = new NumberOfPlayersWindow();

        private IList<Player> players = new List<Player>();

        private IList<Player> playersTemp = new List<Player>();

        public Player winner;

        private Random rnd = new Random();
        

        public void StartGame()
        {
            GameScreen gameScreen = new GameScreen(200, 40);

            int diceLenght = diceSelectionWindow.GetItemId();

            int numberOfPlayers = numberOfPlayersWindow.GetItemId();


            for (int i = 0; i < numberOfPlayers; i++)
            {
                players.Add(new Player($"Player{i+1}", new List<Dice>()));
                for (int j = 0; j < diceLenght; j++)
                {
                    players[i].AddDiceToDiceList(new Dice(rnd.Next(1,6)));
                   
                }      
            }
            Render();
            Winer();

        }

        private List<int> sumOfDices = new List<int>();
        private int maxValue = 0;
        private int numberOfMaxValueNumbers = 0;
        private int sumOfDiceInt = 0;
        private bool isTwoOrMoreMaxNumbers = true;
        public void Winer()
        {
            while(isTwoOrMoreMaxNumbers)
            {
                foreach (var player in players)
                {
                    foreach (var dice in player.GetDiceList())
                    {
                        sumOfDiceInt += dice.GetDiceValue();
                    }
                    sumOfDices.Add(sumOfDiceInt);
                    sumOfDiceInt = 0;
                }
                foreach (var item in sumOfDices)
                {
                    if (item > maxValue)
                    {
                        maxValue = item;
                        numberOfMaxValueNumbers = 1;
                        Console.WriteLine($"{item} = max value. Numbers of maxValus {numberOfMaxValueNumbers}");
                    }
                    else if (item == maxValue)
                    {
                        numberOfMaxValueNumbers++;
                    }
                }
                if (numberOfMaxValueNumbers > 1)
                {
                    Rematch();
                }
                else
                {
                    for (int i = 0; i < sumOfDices.Count; i++)
                    {
                        if (sumOfDices[i] == maxValue)
                        {
                            winner = players[i];

                            Console.WriteLine($"The Winner is {winner.GetName()}. Dice sum value: {maxValue}");
                            isTwoOrMoreMaxNumbers = false;
                        }
                    }
                }
            }
        }

        private void Rematch()
        {
            Console.WriteLine($"{numberOfMaxValueNumbers} players has the highest sum of dices..." +
                            $"We will have rematch between this players!!!");
            Console.WriteLine("*************************************");
            for (int i = 0; i < sumOfDices.Count; i++)
            {
                if (sumOfDices[i] == maxValue)
                {
                    players[i].GetDiceList().Clear();
                    for (int j = 0; j < diceSelectionWindow.GetItemId(); j++)
                    {
                        players[i].AddDiceToDiceList(new Dice(rnd.Next(1, 6)));
                    }

                    foreach (var dice in players[i].GetDiceList())
                    {
                        sumOfDiceInt += dice.GetDiceValue();
                    }
                    //sumOfDices.Add(sumOfDiceInt);
                    sumOfDiceInt = 0;                    
                    Console.Write($"{players[i].GetName()}: ");
                    foreach (var dice in players[i].GetDiceList())
                    {
                        int nr = dice.GetDiceValue();
                        //System.Threading.Thread.Sleep(200);
                        Console.Write($"[{nr}] ");
                    }
                    Console.WriteLine();
                }
               
                else
                {
                    players[i].GetDiceList().Clear();           
                }
            }
            maxValue = 0;
            numberOfMaxValueNumbers = 0;
            sumOfDices.Clear();
        }

        public void Render()
        {
            Console.WriteLine($"Players will have {players[0].GetDiceList().Count} dice :");
            foreach (var player in players)
            {
                //System.Threading.Thread.Sleep(200);
                Console.Write($"{player.GetName()}: ");
                foreach (var dice in player.GetDiceList())
                {
                    int nr = dice.GetDiceValue();
                    //System.Threading.Thread.Sleep(200);
                    Console.Write($"[{nr}] ");
                }
                Console.WriteLine();
            }
        }
    }
}
