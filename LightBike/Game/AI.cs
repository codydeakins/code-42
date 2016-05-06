using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LightBike
{
    class AI
    {
        public static bool AIMove(Bike bike, List<LightPaths> deathArray, int difficulty)
        {
            bool[] validMoves = { false, false, false, false };
            //0 Up
            //1 Down
            //2 Right
            //3 Left
            int rnd = new Random(Environment.TickCount).Next(1, 101);
            bool canMoveUp = true;
            bool canMoveDown = true;
            bool canMoveRight = true;
            bool canMoveLeft = true;

            #region Up
            if (bike.direction == Directions.Dir.up)
            {
                canMoveUp = CanMoveUp(bike, deathArray);
                canMoveRight = CanMoveRight(bike, deathArray);
                canMoveLeft = CanMoveLeft(bike, deathArray);
                canMoveDown = false;


                if (canMoveUp == true && rnd < difficulty)
                    return true;
                else if (!canMoveUp && !canMoveDown && !canMoveLeft && !canMoveRight)
                {
                    return false;
                }

                validMoves[0] = canMoveUp;
                validMoves[1] = canMoveDown;
                validMoves[2] = canMoveRight;
                validMoves[3] = canMoveLeft;

                MakeRndMove(bike, validMoves);
                return true;
            }//end Up
            #endregion

            #region Down
            else if (bike.direction == Directions.Dir.down)
            {
                canMoveUp = false;
                canMoveDown = CanMoveDown(bike, deathArray);
                canMoveRight = CanMoveRight(bike, deathArray);
                canMoveLeft = CanMoveLeft(bike, deathArray);

                if (canMoveDown == true && rnd < difficulty)
                    return true;
                else if (!canMoveUp && !canMoveDown && !canMoveLeft && !canMoveRight)
                {
                    return false;
                }

                validMoves[0] = canMoveUp;
                validMoves[1] = canMoveDown;
                validMoves[2] = canMoveRight;
                validMoves[3] = canMoveLeft;

                MakeRndMove(bike, validMoves);
                return true;
                
            }//end down
            #endregion

            #region Right
            else if (bike.direction == Directions.Dir.right)
            {
                canMoveUp = CanMoveUp(bike, deathArray);
                canMoveDown = CanMoveDown(bike, deathArray);
                canMoveRight = CanMoveRight(bike, deathArray);
                canMoveLeft = false;

                if (canMoveRight == true && rnd < difficulty)
                    return true;
                else if (!canMoveUp && !canMoveDown && !canMoveLeft && !canMoveRight)
                {
                    return false;
                }

                validMoves[0] = canMoveUp;
                validMoves[1] = canMoveDown;
                validMoves[2] = canMoveRight;
                validMoves[3] = canMoveLeft;

                MakeRndMove(bike, validMoves);
                return true;
               
            }//end right
            #endregion

            #region Left
            else if (bike.direction == Directions.Dir.left)
            {
                canMoveUp = CanMoveUp(bike, deathArray);
                canMoveDown = CanMoveDown(bike, deathArray);
                canMoveRight = false;
                canMoveLeft = CanMoveLeft(bike, deathArray);

                if (canMoveLeft == true && rnd < difficulty)
                    return true;
                else if (!canMoveUp && !canMoveDown && !canMoveLeft && !canMoveRight)
                {
                    return false;
                }

                validMoves[0] = canMoveUp;
                validMoves[1] = canMoveDown;
                validMoves[2] = canMoveRight;
                validMoves[3] = canMoveLeft;

                MakeRndMove(bike, validMoves);
                return true;
            }//end Left
            #endregion

            return false;
        }

        public static void MakeRndMove (Bike bike, bool[] validMoves)
        {
            Random rndMove =new  Random(Environment.TickCount);
            rndMove.Next(0,4);
            rndMove.Next(0,4);
            int move = 0;
            while (true)
            {
                int rnd = rndMove.Next(0, 4);
                if (validMoves[rnd])
                {
                    move = rnd;
                    break;
                }
            }
            if (move  == 0)
            {
                bike.direction = Directions.Dir.up;
            }
            else if (move ==1)
            {
                bike.direction = Directions.Dir.down;
            }
            else if (move == 2)
            {
                bike.direction = Directions.Dir.right;
            }
            else if (move == 3)
            {
                bike.direction = Directions.Dir.left;
            }
        }

        public static bool CanMoveUp(Bike bike, List<LightPaths> deathArray)
        {
            bool canMove = true;
            foreach (var item in deathArray)
            {
                if (bike.yCoord - 1 == item.yCoord && bike.xCoord == item.xCoord)
                    canMove = false;
            }
                if (bike.yCoord - 1 <= 0)
                    canMove = false;
                return canMove;           
        }

        public static bool CanMoveDown(Bike bike, List<LightPaths> deathArray)
        {
            bool canMove = true;
            foreach (var item in deathArray)
            {
                if (bike.yCoord + 1 == item.yCoord && bike.xCoord == item.xCoord)
                    canMove = false;
            }
            if (bike.yCoord + 1 >= Console.WindowHeight - 1)
                canMove = false;
            return canMove;
        }

        public static bool CanMoveRight(Bike bike, List<LightPaths> deathArray)
        {
            bool canMove = true;
            foreach (var item in deathArray)
            {
                if (bike.xCoord + 1 == item.xCoord && bike.yCoord == item.yCoord)
                    canMove = false;
            }
            if (bike.xCoord + 1 >= Console.WindowWidth - 1)
                canMove = false;
            return canMove;
        }

        public static bool CanMoveLeft(Bike bike, List<LightPaths> deathArray)
        {
            bool canMove = true;
            foreach (var item in deathArray)
            {
                if (bike.xCoord - 1 == item.xCoord && bike.yCoord == item.yCoord)
                {


                    canMove = false;
                }
            }
            if (bike.xCoord - 1 <= 0)
                canMove = false;
            return canMove;
        }
    }
}
