using Learning_App.FinalBigHomeWork.Constants;
using Learning_App.FinalBigHomeWork.Gui;
using Learning_App.FinalBigHomeWork.Units;
using Learning_App.FinalBigHomeWork.Windows;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learning_App.FinalBigHomeWork
{
    class GuiController
    {
        GameWindow gameWindow = new GameWindow();
        Player player = new Player(10, 10, "Lukas");
        TankDirection tankDirection;
        private bool bulletIsActive;
        private bool applicationIsRunning = true;

        public void StartAplication()
        {
            Console.Clear();
            gameWindow.Render();
            TankHandling();

            Console.ReadKey();

        }

        private Bullet bullet = new Bullet(0,0);

        private void TankHandling()
        {
            player.currentTankModel = player.tankModel[2];
            player.Render();
            do
            {
                if (bulletIsActive)
                {
                    bullet.ShotUp();
                    if(bullet.shotIsActive == false)
                    {
                        bulletIsActive = false;
                    }
                }

                while (Console.KeyAvailable)
                 {
                    
                    var key = Console.ReadKey(true);
                    switch (key.Key)
                    {
                        case ConsoleKey.LeftArrow:
                            if(player.currentTankModel == player.tankModel[1])
                            {
                                player.MoveLeft();
                            }
                            player.currentTankModel = player.tankModel[1];
                            tankDirection = TankDirection.Left;
                            break;
                        case ConsoleKey.RightArrow:
                            if(player.currentTankModel == player.tankModel[0])
                            {
                                player.MoveRight();
                            }
                            player.currentTankModel = player.tankModel[0];
                            tankDirection = TankDirection.Right;
                            break;
                        case ConsoleKey.UpArrow:
                            if(player.currentTankModel == player.tankModel[2])
                            {
                                player.MoveUp();
                            }
                            player.currentTankModel = player.tankModel[2];
                            tankDirection = TankDirection.Up;
                            break;
                        case ConsoleKey.DownArrow:
                            if (player.currentTankModel == player.tankModel[3])
                            {
                                player.MoveDown();
                            }
                            player.currentTankModel = player.tankModel[3];
                            tankDirection = TankDirection.Down;
                            break;
                        case ConsoleKey.Spacebar:
                           
                            switch (tankDirection)
                            {                                
                                case TankDirection.Up:
                                    bullet.listOfBullets.Add(new Bullet(player.X + 2, player.Y - 1));
                                    bullet.X = player.X + 2;
                                    bullet.Y = player.Y - 1;
                                    break;
                                case TankDirection.Down:
                                    break;
                                case TankDirection.Left:
                                    break;
                                case TankDirection.Right:
                                    break;
                            }
                            bulletIsActive = true;
                            bullet.Render();
                            break;
                    }  
                }
                System.Threading.Thread.Sleep(50);
                gameWindow.Render();
                player.Render();
                if(bulletIsActive)
                {
                    bullet.Render();
                }

            } while (applicationIsRunning);
        }
    }
}
