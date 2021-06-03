using Learning_App.FinalBigHomeWork.Constants;
using Learning_App.FinalBigHomeWork.Data;
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
        GameData gameData = new GameData();
        ActionWindow actionWindow = new ActionWindow();
        TankDirection tankDirection;
        private bool bulletIsActive;
        private bool applicationIsRunning = true;

        public void StartAplication()
        {
            Console.Clear();
            gameData.player.currentTankModel = gameData.player.tankModel[2];
            actionWindow.Render();
            TankHandling();

            Console.ReadKey();
        }

        private Bullet bullet = new Bullet(0,0);

        private void TankHandling()
        {  
            do
            {
                while (Console.KeyAvailable)
                 { 
                    var key = Console.ReadKey(true);
                    switch (key.Key)
                    {
                        case ConsoleKey.LeftArrow:
                            if (gameData.player.currentTankModel == gameData.player.tankModel[1])
                            {
                                gameData.MoveLeft();
                            }
                            gameData.player.currentTankModel = gameData.player.tankModel[1];
                            tankDirection = TankDirection.Left;
                            //gameData.player.Render();
                            break;
                        case ConsoleKey.RightArrow:
                            if (gameData.player.currentTankModel == gameData.player.tankModel[0])
                            {
                                gameData.MoveRight();
                            }
                            gameData.player.currentTankModel = gameData.player.tankModel[0];
                            tankDirection = TankDirection.Right;
                            break;
                        case ConsoleKey.UpArrow:
                            if (gameData.player.currentTankModel == gameData.player.tankModel[2])
                            {
                                gameData.MoveUp();
                            }
                            gameData.player.currentTankModel = gameData.player.tankModel[2];
                            tankDirection = TankDirection.Up;
                            break;
                        case ConsoleKey.DownArrow:
                            if (gameData.player.currentTankModel == gameData.player.tankModel[3])
                            {
                                gameData.MoveDown();
                            }
                            gameData.player.currentTankModel = gameData.player.tankModel[3];
                            tankDirection = TankDirection.Down;
                            break;
                            //case ConsoleKey.Spacebar:

                            //    switch (tankDirection)
                            //    {                                
                            //        case TankDirection.Up:
                            //            bullet.listOfBulletsShutUp.Add(new Bullet(player.X + 2, player.Y - 1));
                            //            break;
                            //        case TankDirection.Down:
                            //            bullet.listOfBulletsShutDown.Add(new Bullet(player.X + 2, player.Y + 3));
                            //            break;
                            //        case TankDirection.Left:
                            //            bullet.listOfBulletsShutLeft.Add(new Bullet(player.X - 1, player.Y + 1));
                            //            break;
                            //        case TankDirection.Right:
                            //            bullet.listOfBulletsShutRight.Add(new Bullet(player.X + 6, player.Y + 1));
                            //            break;
                            //    }
                            //    //bulletIsActive = true;
                            //    //foreach (var bullet in bullet.listOfBulletsShutUp)
                            //    //{
                            //    //    bullet.Render();
                            //    //}
                            //    //foreach (var bullet in bullet.listOfBulletsShutDown)
                            //    //{
                            //    //    bullet.Render();
                            //    //}
                            //    //foreach (var bullet in bullet.listOfBulletsShutLeft)
                            //    //{
                            //    //    bullet.Render();
                            //    //}
                            //    //foreach (var bullet in bullet.listOfBulletsShutRight)
                            //    //{
                            //    //    bullet.Render();
                            //    //}
                            //    //break;
                    }
                }
                Console.SetCursorPosition(0, 0);
                actionWindow.Render();
                gameData.player.Render();
                //gameWindow.Render();
                //player.Render();
                //if (bulletIsActive)
                //{
                //    bullet.BulletsShots();
                //    if (bullet.shotIsActive == false)
                //    {
                //        bulletIsActive = false;
                //    }
                //    foreach (var bullet in bullet.listOfBulletsShutUp)
                //    {
                //        bullet.Render();
                //    }
                //    foreach (var bullet in bullet.listOfBulletsShutDown)
                //    {
                //        bullet.Render();
                //    }
                //    foreach (var bullet in bullet.listOfBulletsShutLeft)
                //    {
                //        bullet.Render();
                //    }
                //    foreach (var bullet in bullet.listOfBulletsShutRight)
                //    {
                //        bullet.Render();
                //    }
                //}
                System.Threading.Thread.Sleep(10);


            } while (applicationIsRunning);
        }
    }
}
