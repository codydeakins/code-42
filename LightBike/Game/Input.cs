using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LightBike
{
    class  Input
    {
        public static void GetKey(Bike bike)
        {
            if(Console.KeyAvailable == true)
            {
                ConsoleKeyInfo key = Console.ReadKey(true);
                //if (bike.direction == Directions.Dir.left)
                
                switch (key.Key)

                {
                    case ConsoleKey.UpArrow:
                        if (bike.direction != Directions.Dir.down)
                        {
                            bike.direction = Directions.Dir.up;
                        }
                        break;
                    case ConsoleKey.DownArrow:
                        if (bike.direction != Directions.Dir.up)
                        {
                            bike.direction = Directions.Dir.down;
                        }
                        break;
                    case ConsoleKey.RightArrow:
                        if (bike.direction != Directions.Dir.left)
                        {
                            bike.direction = Directions.Dir.right;
                        }
                        break;
                    case ConsoleKey.LeftArrow:
                        if (bike.direction != Directions.Dir.right)
                        {
                            bike.direction = Directions.Dir.left;
                        }
                        break;
                    default:
                        break;
                }
            }

        }
    }
}
