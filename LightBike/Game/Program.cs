using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LightBike
{
    class Program
    {
        public int Speed { get; set; }
        public int RandomBar { get; set; }
        public char BikeChar { get; set; }
        public int timesDied { get; set; }


        public void RunGame()
        {
            


            List<LightPaths> deathArray = new List<LightPaths>();
            
            Console.SetWindowSize(81, 41);


            Console.ForegroundColor = ConsoleColor.Cyan;
            DrawMap.drawMap();
            
            Console.ForegroundColor = ConsoleColor.Blue;

            Bike aiBike1 = new Bike();
            aiBike1.xCoord = 45;
            aiBike1.yCoord = 1;
            aiBike1.direction = Directions.Dir.down;
            aiBike1.player = "ai1";
            aiBike1.DrawBike();

            Bike aiBike2 = new Bike();
            aiBike2.xCoord = 79;
            aiBike2.yCoord = 20;
            aiBike2.direction = Directions.Dir.left;
            aiBike2.player = "ai2";
            aiBike2.DrawBike();

            Bike aiBike3 = new Bike();
            aiBike3.xCoord = 1;
            aiBike3.yCoord = 20;
            aiBike3.direction = Directions.Dir.right;
            aiBike3.player = "ai3";
            aiBike3.DrawBike();

            bool ai1Alive = true;
            bool ai2Alive = true;
            bool ai3Alive = true;

            int difficulty = this.RandomBar;

            bool userWin = true;
            Bike newBike = new Bike(BikeChar);
            newBike.DrawBike();
            Console.SetWindowPosition(0, 0);

            Console.SetCursorPosition(30, 20);
            Console.Write("Press any key to start. . .");
            Console.ReadKey();
            Console.SetCursorPosition(30, 20);
            Console.Write("                            ");


            bool crash = false;
            while (!IsGameOver.isGameOver(newBike, deathArray) && userWin && !crash )
            {                
                Input.GetKey(newBike);
                newBike.MoveBike();
                newBike.DrawBike();
                newBike.DrawLight(deathArray);
                if (ai1Alive)
                {
                    ai1Alive = AI.AIMove(aiBike1, deathArray, difficulty);
                    aiBike1.MoveBike();
                    if (aiBike1.xCoord == newBike.xCoord && aiBike1.yCoord == newBike.yCoord)
                    {
                        crash = true;
                    }
                    
                    aiBike1.DrawBike();
                    aiBike1.DrawLight(deathArray);

                    if (Bike.CollisionCheck(aiBike1, aiBike2))
                    {
                        ai1Alive = false;
                        ai2Alive = false;
                    }
                    if (Bike.CollisionCheck(aiBike1, aiBike3))
                    {
                        ai1Alive = false;
                        ai3Alive = false;
                    }
                    
                }
                

                if (ai2Alive)
                {
                    ai2Alive = AI.AIMove(aiBike2, deathArray, difficulty);
                    aiBike2.MoveBike();
                    if (aiBike2.xCoord == newBike.xCoord && aiBike2.yCoord == newBike.yCoord)
                    {
                        crash = true;
                    }
                    aiBike2.DrawBike();
                    aiBike2.DrawLight(deathArray);

                    if (Bike.CollisionCheck(aiBike1, aiBike2))
                    {
                        ai1Alive = false;
                        ai2Alive = false;
                    }
                    if (Bike.CollisionCheck(aiBike2, aiBike3))
                    {
                        ai2Alive = false;
                        ai3Alive = false;
                    }
                }

                if (ai3Alive)
                {
                    ai3Alive = AI.AIMove(aiBike3, deathArray, difficulty);
                    aiBike3.MoveBike();
                    if (aiBike3.xCoord == newBike.xCoord && aiBike3.yCoord == newBike.yCoord)
                    {
                        crash = true;
                    }
                    aiBike3.DrawBike();
                    aiBike3.DrawLight(deathArray);

                    if(Bike.CollisionCheck(aiBike3, aiBike2))
                    {
                        ai3Alive = false;
                        ai2Alive = false;
                    }
                    if (Bike.CollisionCheck(aiBike1, aiBike3))
                    {
                        ai1Alive = false;
                        ai3Alive = false;
                    }
                }

               

                if (!ai1Alive && !ai2Alive && !ai3Alive)
                {
                    userWin = false;
                }
                System.Threading.Thread.Sleep(this.Speed);
                
            }

            Console.ReadLine();
            Console.ForegroundColor = ConsoleColor.Green;

            if (!userWin)
            {
                Console.Clear();
                Console.WriteLine("You Won the Game!!!");

            }
            else if(crash)
            {
                Console.Clear();
                Console.WriteLine("Oh no! You crashed into another bike!");
                this.timesDied++;
            }
            else
            {
                Console.Clear();
                Console.WriteLine("You have lost the match and paid with your life. . .");
                this.timesDied++;
            }
            Console.ReadKey();
        }
    }
}
