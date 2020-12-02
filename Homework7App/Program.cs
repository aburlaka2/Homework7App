using System;

namespace Homework7App
{
    class Program
    {
        static PlayerCharacter Player = new PlayerCharacter();
        static Enemy Enemy = new Enemy();
        static Enemy Enemy2 = new Enemy();
        static Enemy Enemy3 = new Enemy();
        static Cell[,] Map = new Cell[15, 15];
        static int turnCount = 0;

        static void Main(string[] args)
        {
            GenerateMap();
            // set player to init position
            Map[1, 1].SetPlayer(Player.Char);
            Map[10, 10].SetEnemy(Enemy.Char);
            Map[3, 10].SetEnemy(Enemy.Char);
            Map[10, 3].SetEnemy(Enemy.Char);
            Player.xPos = 1;
            Player.yPos = 1;
            RenderMap();
            Enemy.xPos = 3;
            Enemy.yPos = 10;
            RenderMap();
            Enemy2.xPos = 10;
            Enemy2.yPos = 10;
            RenderMap();
            Enemy3.xPos = 10;
            Enemy3.yPos = 3;
            RenderMap();
            PlayerInfo(Player.health, Player.mana);

            while (Player.isAlive)
            {

                bool isInputSuccess=true;

                do
                {
                    Player.Move(Map, Player.xPos, Player.yPos);
                    Enemy.Move(Map, Enemy.xPos, Enemy.yPos);
                    Enemy2.Move(Map, Enemy2.xPos, Enemy2.yPos);
                    Enemy3.Move(Map, Enemy3.xPos, Enemy3.yPos);
                }
                while (!isInputSuccess);

                RenderMap();
                PlayerInfo(Player.health, Player.mana);
            }
        }

        static void GenerateMap()
        {
            for (int i = 0; i < Map.GetLength(0); i++)
            {
                for (int k = 0; k < Map.GetLength(1); k++)
                {
                    Map[i, k] = new Cell(i, k);
                }
            }
        }

        static void RenderMap()
        {
            Console.Clear();
            Console.WriteLine($"Turn count: {turnCount}");
            for (int i = 0; i < Map.GetLength(0); i++)
            {
                Console.WriteLine(new string('-', Map.GetLength(1) * 4 + 1));
                Console.Write("|");
                for (int k = 0; k < Map.GetLength(1); k++)
                {
                    if (Map[i, k].CellValue == '♠')
                    {
                        ToConsole(Map[i, k].ToString(), ConsoleColor.DarkGreen);
                        Console.Write("|");
                    }
                    else if (Map[i, k].CellValue == '♣')
                    {
                        ToConsole(Map[i, k].ToString(), ConsoleColor.Green);
                        Console.Write("|");
                    }
                    else if (Map[i, k].CellValue == '▲')
                    {
                        ToConsole(Map[i, k].ToString(), ConsoleColor.DarkRed);
                        Console.Write("|");
                    }
                    else if (Map[i, k].IsPlayerKeeper)
                    {
                        ToConsole(Map[i, k].ToString(), ConsoleColor.Yellow);
                        Console.Write("|");
                    }
                    else if (Map[i, k].IsEnemyKeeper)
                    {
                        ToConsole(Map[i, k].ToString(), ConsoleColor.Red);
                        Console.Write("|");
                    }
                    else
                    {
                        Console.Write($"{Map[i, k]}|");
                    }
                }
                Console.WriteLine();
            }
            Console.WriteLine(new string('-', Map.GetLength(1) * 4 + 1));
        }

        /// <summary>
        /// Use before calling SetPlayerToPosition
        /// </summary>
        /// <param name="mDelta"></param>
        /// <param name="nDelta"></param>
        /// <returns></returns>
        static bool IsPositionAvailable(int xDelta, int yDelta)
        {
            bool isInBounds = true;

            int newPosX = Player.xPos + xDelta;
            int newPosY = Player.yPos + yDelta;

            if (Player.xPos + xDelta < 0 || Player.xPos + xDelta >= Map.GetLength(0) ||
                Player.yPos + yDelta < 0 || Player.yPos + yDelta >= Map.GetLength(1))
            {
                isInBounds = false;
            }
            return isInBounds && Map[newPosX, newPosY].CanMove;
        }

        /// <summary>
        /// Only for move actions, Exception if !IsPositionAvailable
        /// </summary>
        /// <param name="mDelta"></param>
        /// <param name="nDelta"></param>
        static void SetPlayerToPosition(int xDelta, int yDelta)
        {
            int newPosX = Player.xPos + xDelta;
            int newPosY = Player.yPos + yDelta;

            Map[Player.xPos, Player.yPos].Reset();
            Map[newPosX, newPosY].SetPlayer(Player.Char);

            Player.xPos = newPosX;
            Player.yPos = newPosY;
        }


        public static void ToConsole(string str, ConsoleColor color = ConsoleColor.White)
        {
            Console.ForegroundColor = color;
            Console.Write(str);
            Console.ResetColor();
        }
        public static void PlayerInfo(int health, int mana)
        {
            ToConsole(new string('♥', health), ConsoleColor.Red);
            Console.WriteLine();
            ToConsole(new string('*', mana), ConsoleColor.Blue);
        }
    }
}
