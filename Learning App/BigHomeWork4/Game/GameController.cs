using Learning_App.BigHomeWork4.Gui;
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

        private Player winner = new Player("Zero", new List<Dice>());

        private Random rnd = new Random();

        public List<string> actions = new List<string>();

        public Player GetWinner()
        {
            return winner;
        }

        public int diceLenght { get; set; }
        public int numberOfPlayers{get;set;}
        public void StartGame()
        {
            sumOfDices.Clear();
            actions.Clear();
            players.Clear();

            
            for (int i = 0; i < numberOfPlayers; i++)
            {
                players.Add(new Player($"Player{i+1}", new List<Dice>()));
                for (int j = 0; j < diceLenght; j++)
                {
                    players[i].AddDiceToDiceList(new Dice(rnd.Next(1,6)));    
                }      
            }
            Render();
            isTwoOrMoreMaxNumbers = true;
            Winer();
            TextBlock textBlock = new TextBlock(10, 2, 100, actions);
            textBlock.Render();
            Console.ReadKey();
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
                maxValue = 0;
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
                        actions.Add($"{item} = max value. Numbers of maxValus {numberOfMaxValueNumbers}");
                    }
                    else if (item == maxValue)
                    {
                        numberOfMaxValueNumbers++;
                        actions.Add($"{item} = max value. Numbers of maxValus {numberOfMaxValueNumbers}");
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
                            actions.Add("****************************************");
                            actions.Add($"The Winner is {winner.GetName()}. Dice sum value: {maxValue}");
                            actions.Add("****************************************");
                            isTwoOrMoreMaxNumbers = false;
                        }
                    }
                }
            }
        }

        private void Rematch()
        {
            actions.Add(" ");
            actions.Add($"{numberOfMaxValueNumbers} players has the highest sum of dices...");
            actions.Add($"We will have rematch between this players!!!");
            actions.Add(" ");
           
            for (int i = 0; i < sumOfDices.Count; i++)
            {
                if (sumOfDices[i] == maxValue)
                {
                    players[i].GetDiceList().Clear();
                    for (int j = 0; j < diceLenght; j++)
                    {
                        players[i].AddDiceToDiceList(new Dice(rnd.Next(1, 6)));
                    }

                    foreach (var dice in players[i].GetDiceList())
                    {
                        sumOfDiceInt += dice.GetDiceValue();
                    }
                    sumOfDiceInt = 0;
                    string act = $"{players[i].GetName()}: ";
                    
                    foreach (var dice in players[i].GetDiceList())
                    {
                        int nr = dice.GetDiceValue();
                        //System.Threading.Thread.Sleep(200);
                        act += $"[{nr}] ";
                    }
                    actions.Add(act);
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
            actions.Add($"Players will have {players[1].GetDiceList().Count} dice :");
            foreach (var player in players)
            {
                //System.Threading.Thread.Sleep(200);
                string act = $"{player.GetName()}: ";
               
                foreach (var dice in player.GetDiceList())
                {
                    int nr = dice.GetDiceValue();
                    //System.Threading.Thread.Sleep(200);
                    act += $"[{nr}] ";                 
                }
                actions.Add(act);
                Console.WriteLine();
                act = "";
            }
        }

    }
}
