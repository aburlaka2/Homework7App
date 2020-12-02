using System;
using System.Collections.Generic;
using System.Text;

namespace Homework7App
{
    class PlayerCharacter:Character
    {
        public override int Direction(Cell[,]Map)
        {
            ConsoleKey key = Console.ReadKey().Key;
            bool isInputSuccess = true;
            int Direction=0;
            switch (key)
            {
                case ConsoleKey.A:
                    {
                        if (IsPositionAvailable(Map, 0, -1))
                        {
                            Direction = 1;
                            Console.WriteLine(Direction);
                        }
                        else
                        {
                            Console.WriteLine("Position is unavailable");
                            isInputSuccess = false;
                        }
                        break;
                    }
                case ConsoleKey.W:
                    {

                        if (IsPositionAvailable(Map, -1, 0))
                        {
                            Direction = 2;
                            Console.WriteLine(Direction);
                        }
                        else
                        {
                            Console.WriteLine("Position is unavailable");
                            isInputSuccess = false;
                        }
                        break;
                    }
                case ConsoleKey.D:
                    {

                        if (IsPositionAvailable(Map, 0, 1))
                        {
                            Direction = 3;
                            Console.WriteLine(Direction);
                        }
                        else
                        {
                            Console.WriteLine("Position is unavailable");
                            isInputSuccess = false;
                        }
                        break;
                    }
                case ConsoleKey.S:
                    {

                        if (IsPositionAvailable(Map, 1, 0))
                        {
                            Direction = 4;
                            Console.WriteLine(Direction);
                        }
                        else
                        {
                            Console.WriteLine("Position is unavailable");
                            isInputSuccess = false;
                        }
                        break;
                    }
                default:
                    {
                        Console.WriteLine("Wrong key, use \"W,A,S,D\"");
                        isInputSuccess = false;
                        break;
                    }
            }
            return Direction;
        }
        public override void SetToPosition(Cell[,] Map, int xDelta, int yDelta)
        {
            int newPosX = xPos + xDelta;
            int newPosY = yPos + yDelta;

            Map[xPos, yPos].Reset();
            Map[newPosX, newPosY].SetPlayer(this.Char);

            xPos = newPosX;
            yPos = newPosY;
        }
    }
}
