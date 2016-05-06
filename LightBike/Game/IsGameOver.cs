using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LightBike
{
    class IsGameOver
    {
        public static bool isGameOver(Bike bike, List<LightPaths> list)
        {
            if (bike.xCoord == 0 || bike.xCoord == 80)
                return true;
            if (bike.yCoord == 0 || bike.yCoord == 40)
                return true;
            foreach (var item in list)
            {
                if (bike.yCoord == item.yCoord && bike.xCoord == item.xCoord)
                    return true;
            }

            return false;
        }
    }
}
