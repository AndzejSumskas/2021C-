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
        public int[,] boardGameArray;
        Player player;
        public List<Enemy> enemies;
        private int enemyWasDestroyed = 0;
        private int playerWasDestroyed = 0;
        GameOverWindow gameOverWindow = new GameOverWindow();


        public void StartAplication()
        {
            player = gameData.GetPlayer();
            boardGameArray = gameData.GetBoardGameArray();
            enemies = gameData.GetEnemies();
            Console.Clear();  
            gameData.player.currentTankModel = gameData.player.tankModel[2];
            tankDirection = Directions.Notrh;
            //gameData.GameAreaDataToStartGame();
            TankHandling();

            Console.ReadKey();
        }

        private Bullet bullet = new Bullet(0,0);

        private int loopCounter = 0;

        private void TankHandling()
        {
            do
            {    
                while (Console.KeyAvailable)
                 {
                   
                    var key = Console.ReadKey(true);
                    
                    switch (key.Key)
                    {
                        case ConsoleKey.Escape:
                            applicationIsRunning = false;
                            gameOverWindow.GameOverUpgrade(enemyWasDestroyed, playerWasDestroyed);
                            gameOverWindow.Render();
                            break;
                        case ConsoleKey.LeftArrow:
                            if (player.currentTankModel == player.tankModel[1])
                            {
                                MovePlayerWest();
                            }
                            player.currentTankModel = player.tankModel[1];
                            tankDirection = Directions.West;
                            break;
                        case ConsoleKey.RightArrow:
                            if (player.currentTankModel == player.tankModel[0])
                            {
                                MovePlayerEast();
                            }
                            player.currentTankModel = player.tankModel[0];
                            tankDirection = Directions.East;
                            break;
                        case ConsoleKey.UpArrow:
                            if (player.currentTankModel == player.tankModel[2])
                            {
                                MovePlayerNorth();
                            }
                            player.currentTankModel = player.tankModel[2];
                            tankDirection = Directions.Notrh;
                            break;
                        case ConsoleKey.DownArrow:
                            if (player.currentTankModel == player.tankModel[3])
                            {
                                MovePlayerSouth();
                            }
                            player.currentTankModel = player.tankModel[3];
                            tankDirection = Directions.South;
                            break;
                        case ConsoleKey.P:
                            AddNewEnemy();
                            break;
                        case ConsoleKey.Spacebar:

                            switch (tankDirection)
                            {
                                case Directions.Notrh:
                                    bullet.listOfShootedBullets.Add(new Bullet(player.X + 2, player.Y - 1, $"{Directions.Notrh}", "Player"));
                                    break;
                                case Directions.South:
                                    bullet.listOfShootedBullets.Add(new Bullet(player.X + 2, player.Y + 3, $"{Directions.South}", "Player"));
                                    break;
                                case Directions.West:
                                    bullet.listOfShootedBullets.Add(new Bullet(player.X - 1, player.Y + 1, $"{Directions.West}", "Player"));
                                    break;
                                case Directions.East:
                                    bullet.listOfShootedBullets.Add(new Bullet(player.X + 6, player.Y + 1, $"{Directions.East}", "Player"));
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
                loopCounter++;

                if (loopCounter % 10 == 0)
                {
                    EnemyShoots(enemies);
                }
                Console.SetCursorPosition(0, 0);
                actionWindow.Render(boardGameArray);
                //Enemy Action

                //EnemiesChangeDirection();
                EnemyAction();
                player.Render();
                foreach (var enemie in enemies)
                {
                    enemie.Render();
                }  //Enemies Render()
                foreach (var bullet in bullet.listOfShootedBullets)
                {
                    bullet.Render();
                }
                 ShootTheBullet();

      
                //gameData.Render(boardGameArray);
                
                System.Threading.Thread.Sleep(50);
            } while (applicationIsRunning);
        }

        private void EnemyAction()
        {
            foreach (var enemy in enemies)
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

        private void EnemyShoots(List<Enemy> enemies)
        {
            foreach (var enemy in enemies)
            {
                if(enemy.currentTankModel == enemy.tankModel[1])
                {
                    bullet.listOfShootedBullets.Add(new Bullet(enemy.X - 1, enemy.Y + 1, $"{Directions.West}", "Enemy"));
                }
                if (enemy.currentTankModel == enemy.tankModel[0])
                {
                    bullet.listOfShootedBullets.Add(new Bullet(enemy.X + 6, enemy.Y + 1, $"{Directions.East}", "Enemy"));
                }
                if (enemy.currentTankModel == enemy.tankModel[2])
                {
                    bullet.listOfShootedBullets.Add(new Bullet(enemy.X + 2, enemy.Y - 1, $"{Directions.Notrh}", "Enemy"));
                }
                if (enemy.currentTankModel == enemy.tankModel[3])
                {
                    bullet.listOfShootedBullets.Add(new Bullet(enemy.X + 2, enemy.Y + 3, $"{Directions.South}", "Enemy"));
                }               
            }
        }

        
        internal void ShootTheBullet()
        {
            List<int> tempListOfBullets = new List<int>();
            int counter = 0;
            foreach (var bullet in bullet.listOfShootedBullets)
            {
                switch(bullet.GetBulletName())
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
                if (boardGameArray[bullet.Y, bullet.X] == 1 ||
                    boardGameArray[bullet.Y, bullet.X] == 2  )
                {
                    tempListOfBullets.Add(counter);
                    counter++;
                    bulletIsActive = false;
                    if(boardGameArray[bullet.Y, bullet.X] == 1)
                     {
                        if (numberOfBulletMoves == 3)
                        {
                            int tempbullet = -2;
                            for (int i = 0; i < 6; i++)
                            {
                                boardGameArray[bullet.Y, bullet.X + tempbullet + i] = 0;
                            }   
                        }
                        else
                        {
                            int tempbullet = -1;
                             for (int i = 0; i < 3; i++)
                            {
                                boardGameArray[bullet.Y + tempbullet + i, bullet.X] = 0;
                                boardGameArray[bullet.Y + tempbullet + i, bullet.X + numberOfExtraDestoyWall] = 0;
                            }
                        }
                    }
                }              
                else
                {
                    for (int i = 0; i < numberOfBulletMoves; i++)
                    {
                        bullet.Y += numberOfBulletMovementY;
                        bullet.X += numberOfBulletMovementX;
                        if (boardGameArray[bullet.Y, bullet.X] == 1 ||
                                 boardGameArray[bullet.Y, bullet.X] == 2)
                        {
                            i = numberOfBulletMoves;
                        }
                        for (int j = 0; j < enemies.Count; j++)
                        {         
                            if (enemies[j].X + 5 >= bullet.X && enemies[j].X < bullet.X + 6 && enemies[j].Y + 2 >= bullet.Y && enemies[j].Y < bullet.Y + 3)
                            {                              
                                for (int m = 0; m < 6; m++)
                                {
                                    for (int k = 0; k < 3; k++)
                                    {
                                        boardGameArray[enemies[j].Y + k, enemies[j].X + m] = 0;
                                    }
                                }
                                if (bullet.GetBulletType() != "Enemy")
                                {
                                    enemyWasDestroyed++;
                                    enemies.RemoveAt(j);
                                    tempListOfBullets.Add(counter);
                                }                                   
                            }
                        }
                        if(bullet.GetBulletType()== "Enemy")
                        {
                            if (player.X + 5 >= bullet.X && player.X < bullet.X + 6 && player.Y + 2 >= bullet.Y && player.Y < bullet.Y + 3)
                            {
                                player.currentTankModel = player.tankModel[2];
                                player.X = 36;
                                player.Y = 26;
                                playerWasDestroyed++;
                            }
                        }
                    }
                    counter++;
                    bulletIsActive = true;
                }
            }
            counter = 0;
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

        private int enemyCount = 4;

        private void AddNewEnemy()
        {
            int addEnemy = rnd.Next(1,4);
            switch(addEnemy)
            {
                case 1:
                    enemies.Add(new Enemy(3, 1, 1, $"Enemy{enemyCount++}"));                   
                    break;
                case 2:
                    enemies.Add(new Enemy(47, 1, 1, $"Enemy{enemyCount++}"));
                    break;
                case 3:
                    enemies.Add(new Enemy(91, 1, 1, $"Enemy{enemyCount++}"));
                    break;
            }
            foreach (var enemy in enemies)
            {
                if (enemy.GetName() == $"Enemy{enemyCount - 1}")
                {
                    enemy.currentTankModel = enemy.tankModel[3];
                }
            }
        }
    

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
                if (boardGameArray[enemy.Y + i, enemy.X] == 1 || boardGameArray[enemy.Y + i, enemy.X] == 8)
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
            enemy.X = enemy.X + 2;
            if (enemy.X > gameData.GetBatleAreaWidth() - 8)
            {
                enemy.X = gameData.GetBatleAreaWidth() - 8;
                EnemyChangeDirection(enemy);
            }
            for (int i = 0; i < 3; i++)
            {
                bool endOfRoad = false;
                if (boardGameArray[enemy.Y + i, enemy.X + 5] == 1 || boardGameArray[enemy.Y + i, enemy.X + 5] == 8)
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
                if (boardGameArray[enemy.Y, enemy.X + i] == 1 || boardGameArray[enemy.Y, enemy.X + i] == 8)
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
                if (boardGameArray[enemy.Y + 2, enemy.X + i] == 1 || boardGameArray[enemy.Y + 2, enemy.X + i] == 8)
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

        internal void MovePlayerWest()
        {
            player.X = player.X - 2;
            if (player.X < 2)
            {
                player.X = 2;
            }
            for (int i = 0; i < 3; i++)
            {
                if (boardGameArray[player.Y + i, player.X] == 1 || boardGameArray[player.Y + i, player.X] == 9)
                {
                    player.X = player.X + 2;
                }
            }
        }

        internal void MovePlayerEast()
        {
            player.X = player.X + 2;
            if (player.X > gameData.GetBatleAreaWidth() - 8)
            {
                player.X = gameData.GetBatleAreaWidth() - 8;
            }
            for (int i = 0; i < 3; i++)
            {
                if (boardGameArray[player.Y + i, player.X + 5] == 1 || boardGameArray[player.Y + i, player.X + 5] == 9)
                {
                    player.X = player.X - 2;
                }
            }
        }

        internal void MovePlayerNorth()
        {
            player.Y = player.Y - 1;
            if (player.Y < 1)
            {
                player.Y = 1;
            }
            for (int i = 0; i < 6; i++)
            {
                if (boardGameArray[player.Y, player.X + i] == 1 || boardGameArray[player.Y, player.X + i] == 9)
                {
                    player.Y = player.Y + 1;
                }
            }
        }

        internal void MovePlayerSouth()
        {
            player.Y = player.Y + 1;
            if (player.Y > gameData.GetBatleAreaHight() - 4)
            {
                player.Y = gameData.GetBatleAreaHight() - 4;
            }
            for (int i = 0; i < 6; i++)
            {
                if (boardGameArray[player.Y + 2, player.X + i] == 1 || boardGameArray[player.Y + 2, player.X + i] == 9)
                {
                    player.Y = player.Y - 1;
                }
            }
        }

    }
}