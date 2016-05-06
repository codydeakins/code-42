using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LightBike
{
    class Bike
    {
        public int xCoord { get; set; }
        public int yCoord { get; set; }
        public Directions.Dir direction { get; set; }
        public string player { get; set; }
        public char BikeChar { get; set; }

        public Bike()
        {
            this.xCoord = 35;
            this.yCoord = 39;
            this.direction = Directions.Dir.up;
            this.player = "player";
            this.BikeChar = '@';

        }

        public Bike(char letter)
        {
            this.xCoord = 35;
            this.yCoord = 39;
            this.direction = Directions.Dir.up;
            this.player = "player";
            this.BikeChar = letter;
        }

        public void DrawBike()
        {
            if (this.player == "ai1")
            {
                Console.ForegroundColor = ConsoleColor.Red;
            }
            else if (this.player == "ai2")
            {
                Console.ForegroundColor = ConsoleColor.Green;
            }
            else if (this.player == "ai3")
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
            }
            Console.SetCursorPosition(this.xCoord, this.yCoord);
            Console.Write(this.BikeChar);
            Console.ForegroundColor = ConsoleColor.Blue;
        }

        public void MoveBike()
        {
            if (this.direction == Directions.Dir.up)
            {
                this.yCoord--;
            }
            else if (this.direction == Directions.Dir.down)
            {
                this.yCoord++;
            }
            else if (this.direction == Directions.Dir.right)
            {
                this.xCoord++;
            }
            else if (this.direction == Directions.Dir.left)
            {
                this.xCoord--;
            }
        }

        public void DrawLight(List<LightPaths> list)
        {
            int move = 0;
            if (this.player == "ai1")
            {
                Console.ForegroundColor = ConsoleColor.Red;
            }
            else if (this.player == "ai2")
            {
                Console.ForegroundColor = ConsoleColor.Green;
            }
            else if (this.player == "ai3")
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
            }

            if (this.direction == Directions.Dir.up)
            {
                Console.SetCursorPosition(this.xCoord, this.yCoord + 1);
                list.Add(new LightPaths(this.xCoord, this.yCoord + 1));
                Console.Write("*");
            }
            else if (this.direction == Directions.Dir.down)
            {
                Console.SetCursorPosition(this.xCoord, this.yCoord - 1);
                list.Add(new LightPaths(this.xCoord, this.yCoord - 1));
                Console.Write("*");
            }
            else if (this.direction == Directions.Dir.right)
            {
                Console.SetCursorPosition(this.xCoord - 1, this.yCoord);
                list.Add(new LightPaths(this.xCoord - 1, this.yCoord));
                Console.Write("*");
            }
            else if (this.direction == Directions.Dir.left)
            {
                Console.SetCursorPosition(this.xCoord + 1, this.yCoord);
                list.Add(new LightPaths(this.xCoord + 1, this.yCoord));
                Console.Write("*");
            }
            Console.ForegroundColor = ConsoleColor.Blue;
        }

        public static bool CollisionCheck(Bike bike1, Bike bike2)
        {
            if (bike1.xCoord == bike2.xCoord && bike1.yCoord == bike2.yCoord)
                return true;
            return false;
        }
        
    }
}
