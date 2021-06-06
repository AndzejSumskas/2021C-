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
        Directions tankDirection;
        private bool bulletIsActive;
        private bool applicationIsRunning = true;

        public void StartAplication()
        {
            Console.Clear();  
            gameData.player.currentTankModel = gameData.player.tankModel[2];
            tankDirection = Directions.Notrh;
            gameData.GameAreaDataToStartGame();
            TankHandling();

            Console.ReadKey();
        }

        private Bullet bullet = new Bullet(0,0);

        private int loopCounter = 0;

        private void TankHandling()
        {
            do
            {
                loopCounter++;
                while (Console.KeyAvailable)
                 { 
                    var key = Console.ReadKey(true);
                    switch (key.Key)
                    {
                        case ConsoleKey.LeftArrow:
                            if (gameData.player.currentTankModel == gameData.player.tankModel[1])
                            {
                                gameData.MovePlayerWest();
                            }
                            gameData.player.currentTankModel = gameData.player.tankModel[1];
                            tankDirection = Directions.West;
                            break;
                        case ConsoleKey.RightArrow:
                            if (gameData.player.currentTankModel == gameData.player.tankModel[0])
                            {
                                gameData.MovePlayerEast();
                            }
                            gameData.player.currentTankModel = gameData.player.tankModel[0];
                            tankDirection = Directions.East;
                            break;
                        case ConsoleKey.UpArrow:
                            if (gameData.player.currentTankModel == gameData.player.tankModel[2])
                            {
                                gameData.MovePlayerNorth();
                            }
                            gameData.player.currentTankModel = gameData.player.tankModel[2];
                            tankDirection = Directions.Notrh;
                            break;
                        case ConsoleKey.DownArrow:
                            if (gameData.player.currentTankModel == gameData.player.tankModel[3])
                            {
                                gameData.MovePlayerSouth();
                            }
                            gameData.player.currentTankModel = gameData.player.tankModel[3];
                            tankDirection = Directions.South;
                            break;
                        case ConsoleKey.Spacebar:

                            switch (tankDirection)
                            {
                                case Directions.Notrh:
                                    bullet.listOfShootedBullets.Add(new Bullet(gameData.player.X + 2, gameData.player.Y - 1, $"{Directions.Notrh}"));
                                    break;
                                case Directions.South:
                                    bullet.listOfShootedBullets.Add(new Bullet(gameData.player.X + 2, gameData.player.Y + 3, $"{Directions.South}"));
                                    break;
                                case Directions.West:
                                    bullet.listOfShootedBullets.Add(new Bullet(gameData.player.X - 1, gameData.player.Y + 1, $"{Directions.West}"));
                                    break;
                                case Directions.East:
                                    bullet.listOfShootedBullets.Add(new Bullet(gameData.player.X + 6, gameData.player.Y + 1, $"{Directions.East}"));
                                    break;
                            }
                            bulletIsActive = true;
                            foreach (var bullet in bullet.listOfShootedBullets)
                            {
                                bullet.Render();
                            }
                            break;
                    }
                }
                Console.SetCursorPosition(0, 0);
                actionWindow.Render(gameData.boardGameArray);
                //Enemy Action

                //EnemiesChangeDirection();
                EnemyAction();




                //
                gameData.player.Render();
                foreach (var enemie in gameData.enemies)
                {
                    enemie.Render();
                }  //Enemies Render()
                foreach (var bullet in bullet.listOfShootedBullets)
                {
                    bullet.Render();
                }
                if (bulletIsActive)
                {
                    ShootTheBullet();
                }
                System.Threading.Thread.Sleep(50);
            } while (applicationIsRunning);
        }

        private void EnemyAction()
        {
            foreach (var enemy in gameData.enemies)
            {
                if(enemy.currentTankModel == enemy.tankModel[1])
                {
                    //left
                    MoveEnemyWest(enemy);
                }
                else if (enemy.currentTankModel == enemy.tankModel[0])
                {
                    //right
                    MoveEnemyEast(enemy);
                }
                else if (enemy.currentTankModel == enemy.tankModel[2])
                {
                    //up
                    MoveEnemyNorth(enemy);
                }
                else if (enemy.currentTankModel == enemy.tankModel[3])
                {
                    //down
                    MoveEnemySouth(enemy);
                }
            }
        }

        
        internal void ShootTheBullet()
        {
            List<int> tempListOfBullets = new List<int>();
            int counter = 0;
            foreach (var bullet in bullet.listOfShootedBullets)
            {
                switch(bullet.GetName())
                {
                    case "Notrh":
                        numberOfBulletMovementX = 0;
                        numberOfBulletMovementY = -1;
                        numberOfBulletMoves = 3;
                        
                        break;
                    case "South":
                        numberOfBulletMovementX = 0;
                        numberOfBulletMovementY = 1;
                        numberOfBulletMoves = 3;
                        break;
                    case "West":
                        numberOfBulletMovementX = -1;
                        numberOfBulletMovementY = 0;
                        numberOfBulletMoves = 6;
                        numberOfExtraDestoyWall = -1; 
                        break;
                    case "East":
                        numberOfBulletMovementX = 1;
                        numberOfBulletMovementY = 0;
                        numberOfBulletMoves = 6;
                        numberOfExtraDestoyWall = +1;  
                        break;
                }
                if (gameData.GetBalteAreaArray()[bullet.Y, bullet.X] == 1 ||
                    gameData.GetBalteAreaArray()[bullet.Y, bullet.X] == 2)
                {
                    tempListOfBullets.Add(counter);
                    counter++;
                    bulletIsActive = false;
                    if(gameData.GetBalteAreaArray()[bullet.Y, bullet.X] == 1)
                     {
                        if (numberOfBulletMoves == 3)
                        {
                            int tempbullet = -2;
                            for (int i = 0; i < 6; i++)
                            {
                                gameData.boardGameArray[bullet.Y, bullet.X + tempbullet + i] = 0;
                            }   
                        }
                        else
                        {
                            int tempbullet = -1;
                             for (int i = 0; i < 3; i++)
                            {
                                gameData.boardGameArray[bullet.Y + tempbullet + i, bullet.X] = 0;
                                gameData.boardGameArray[bullet.Y + tempbullet + i, bullet.X + numberOfExtraDestoyWall] = 0;
                            }
                        }
                    }
                }
                else   if(gameData.GetBalteAreaArray()[bullet.Y, bullet.X] == 9)
                {
                    for (int i = 0; i < gameData.enemies.Count; i++)
                    {
                        if (gameData.enemies[i].X + 5 >= bullet.X && gameData.enemies[i].X < bullet.X + 6 && gameData.enemies[i].Y+2 >= bullet.Y && gameData.enemies[i].Y < bullet.Y + 3)
                        {
                            for (int j = 0; j < 6; j++)
                            {
                                for (int k = 0; k < 3; k++)
                                {
                                    gameData.boardGameArray[gameData.enemies[i].Y+k, gameData.enemies[i].X+j] = 0;
                                }
                            }
                            gameData.enemies.RemoveAt(i);
                        }
                    }
                    
                }
                else
                {
                    for (int j = 0; j < numberOfBulletMoves; j++)
                    {
                        bullet.Y += numberOfBulletMovementY;
                        bullet.X += numberOfBulletMovementX;
                        if (gameData.GetBalteAreaArray()[bullet.Y, bullet.X] == 1 ||
                    gameData.GetBalteAreaArray()[bullet.Y, bullet.X] == 2)
                        {
                            j = numberOfBulletMoves;
                        }
                    }
                    bulletIsActive = true;
                }
            }
              var tempList = from nr in tempListOfBullets
                           orderby nr descending
                           select nr;
            foreach (var number in tempList)
            {
                 bullet.listOfShootedBullets.RemoveAt(number);
            }
        }
        private int numberOfBulletMovementX = 0;
        private int numberOfBulletMovementY = 0;
        private int numberOfBulletMoves = 0;
        private int numberOfExtraDestoyWall = 0;

        public void MoveEnemyWest(Enemy enemy)
        {
            enemy.X = enemy.X - 2;
            if (enemy.X < 2)
            {
                enemy.X = 2;
                EnemyChangeDirection(enemy);
            }
            for (int i = 0; i < 3; i++)
            {
                bool endOfRoad = false;
                if (gameData.boardGameArray[enemy.Y + i, enemy.X] == 1 || gameData.boardGameArray[enemy.Y + i, enemy.X] == 8)
                {
                    enemy.X = enemy.X + 2;
                    endOfRoad = true;
                }
                if (endOfRoad == true)
                {
                    EnemyChangeDirection(enemy);
                }
            }
        }

        internal void MoveEnemyEast(Enemy enemy)
        {
            enemy.Render();
            enemy.X = enemy.X + 2;
            if (enemy.X > gameData.GetBatleAreaWidth() - 8)
            {
                enemy.X = gameData.GetBatleAreaWidth() - 8;
                EnemyChangeDirection(enemy);
            }
            for (int i = 0; i < 3; i++)
            {
                bool endOfRoad = false;
                if (gameData.boardGameArray[enemy.Y + i, enemy.X + 5] == 1 || gameData.boardGameArray[enemy.Y + i, enemy.X + 5] == 8)
                {
                    enemy.X = enemy.X - 2;
                    endOfRoad = true;
                }
                if (endOfRoad == true)
                {
                    EnemyChangeDirection(enemy);
                }
            }
        }

        internal void MoveEnemyNorth(Enemy enemy)
        {
            enemy.Y = enemy.Y - 1;

            if (enemy.Y < 1)
            {
                enemy.Y = 1;
                EnemyChangeDirection(enemy);
            }

            for (int i = 0; i < 6; i++)
            {
                bool endOfRoad = false;
                if (gameData.boardGameArray[enemy.Y, enemy.X + i] == 1 || gameData.boardGameArray[enemy.Y, enemy.X + i] == 8)
                {
                    enemy.Y = enemy.Y + 1;
                    endOfRoad = true;
                }
                if (endOfRoad == true)
                {
                    EnemyChangeDirection(enemy);
                }
            }
        }

        internal void MoveEnemySouth(Enemy enemy)
        {
            enemy.Y = enemy.Y + 1;
            if (enemy.Y > gameData.GetBatleAreaHight() - 4)
            {
                enemy.Y = gameData.GetBatleAreaHight() - 4;
                EnemyChangeDirection(enemy);
            }
            for (int i = 0; i < 6; i++)
            {
                bool endOfRoad = false;
                if (gameData.boardGameArray[enemy.Y + 2, enemy.X + i] == 1 || gameData.boardGameArray[enemy.Y + 2, enemy.X + i] == 8)
                {
                    enemy.Y = enemy.Y - 1;
                    endOfRoad = true;
                }
                if (endOfRoad == true)
                {
                    EnemyChangeDirection(enemy);
                }
            }
        }

        private void EnemyChangeDirection(Enemy enemy)
        {
            int direction = rnd.Next(1, 5);
            switch (direction)
            {
                case 1:
                    enemy.currentTankModel = enemy.tankModel[1];
                    break;
                case 2:
                    enemy.currentTankModel = enemy.tankModel[0];
                    break;
                case 3:
                    enemy.currentTankModel = enemy.tankModel[2];
                    break;
                case 4:
                    enemy.currentTankModel = enemy.tankModel[3];
                    break;
            }

        }


        private Random rnd = new Random();
    }
}