using System;
using System.Collections.Generic;
using System.Text;

namespace Homework7App
{
    class Character
    {
        public char Char { get; set; }
        public int xPos { get; set; }
        public int yPos { get; set; }
        public bool isAlive { get; set; }
        public int health { get; set; }
        public int mana { get; set; }
        public Character()
        {
            Char = '☻';
            xPos = 0;
            yPos = 0;
            isAlive = true;
            health = 10;
            mana = 5;
        }
        public void Move(Cell[,] Map, int xPos, int yPos)
        {
            int Direction = 0;
            while (Direction == 0)
            {
                Direction = this.Direction(Map);
                switch (Direction)
                {
                    case 1:
                        {
                            if (IsPositionAvailable(Map, 0, -1))
                            {
                                SetToPosition(Map, 0, -1);
                                break;
                            }
                            else
                            {
                                Direction = 0;
                                continue;
                            }

                        }
                    case 2:
                        {

                            if (IsPositionAvailable(Map, -1, 0))
                            {
                                SetToPosition(Map, -1, 0);
                                break;
                            }
                            else
                            {
                                Direction = 0;
                                continue;
                            }

                        }
                    case 3:
                        {

                            if (IsPositionAvailable(Map, 0, 1))
                            {
                                SetToPosition(Map, 0, 1);
                                break;
                            }
                            else
                            {
                                Direction = 0;
                                continue;
                            }

                        }
                    case 4:
                        {

                            if (IsPositionAvailable(Map, 1, 0))
                            {
                                SetToPosition(Map, 1, 0);
                                break;
                            }
                            else
                            {
                                Direction = 0;
                                continue;
                            }

                        }
                }

            }

        }
        public bool IsPositionAvailable(Cell[,] Map, int xDelta, int yDelta)
        {
            bool isInBounds = true;

            int newPosX = xPos + xDelta;
            int newPosY = yPos + yDelta;

            if (xPos + xDelta < 0 || xPos + xDelta >= Map.GetLength(0) ||
                yPos + yDelta < 0 || yPos + yDelta >= Map.GetLength(1))
            {
                isInBounds = false;
            }
            return isInBounds && Map[newPosX, newPosY].CanMove;
        }
        public virtual void SetToPosition(Cell[,] Map, int xDelta, int yDelta)
        {
            int newPosX = xPos + xDelta;
            int newPosY = yPos + yDelta;

            Map[xPos, yPos].ResetEnemy();
            Map[newPosX, newPosY].SetEnemy(this.Char);

            xPos = newPosX;
            yPos = newPosY;
        }
        public virtual int Direction(Cell[,] Map)
        {
            Random rnd = new Random();
            int Direction = rnd.Next(1, 4);
            return Direction;
        }
    }
}
