using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LightBike
{
    class DrawMap
    {
        public static void drawMap()
        {
            for (int i = 0; i < Console.WindowWidth; i++)
            {
                Console.Write('*');
            }
            Console.Write("\n");
            for (int i = 1; i < Console.WindowHeight; i++)
            {
                Console.SetCursorPosition(0, i);
                Console.Write("*");
                Console.SetCursorPosition(Console.WindowWidth - 1, i);
                Console.Write("*");
            }
            Console.SetCursorPosition(0, Console.WindowHeight - 1);
            for (int i = 0; i < Console.WindowWidth; i++)
            {
                Console.Write("*");
            }
        }
    }
}
