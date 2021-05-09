using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learning_App.GameSample.Game
{
    class Hero : Unit
    {
        private GameWindow gameWindow = new GameWindow();
        private ConsoleKeyInfo input;
        private string shapeOfHero = "<^>";
        public Hero(string name, int x, int y) : base(name, x, y)
        {           
        }

        public void MoveRight()
        {
            X++;
        }

        public void MoveLeft()
        {
            X--;
        }

        public void MoveUp()
        {
            Y--;
        }

        public void MoveDown()
        {
            Y++;
        }

        public string GetHeroShape()
        {
            return shapeOfHero;
        }

        public void PrintHeroShape()
        {
            char[] heroShape = GetHeroShape().ToArray();
            Console.SetCursorPosition(X-1, Y);

            foreach (var item in heroShape)
            {
                Console.Write(item);
            }
        }

        public void MovementOfHero()
        {
            do
            {
                gameWindow.Render();
                PrintHeroShape();
                input = Console.ReadKey();
                if ((input.Key == ConsoleKey.LeftArrow) && X > gameWindow.X +1)
                {
                    X--;
                }
                else if (input.Key == ConsoleKey.UpArrow && Y > gameWindow.Y +2)
                {
                    Y--;
                }
                else if (input.Key == ConsoleKey.RightArrow && X < gameWindow.X+gameWindow.Width -3)
                {
                    X++;
                }
                else if (input.Key == ConsoleKey.DownArrow && Y < gameWindow.Y + gameWindow.Height - 2)
                {
                    Y++;
                }
                else if (input.Key == ConsoleKey.Enter)
                {
                   

                }
                else if (input.Key == ConsoleKey.Escape)
                {
                   
                }
                else if (input.Key == ConsoleKey.Escape)
                {
                    
                }
               

            } while (input.Key != ConsoleKey.Escape);
        }
    }
}
