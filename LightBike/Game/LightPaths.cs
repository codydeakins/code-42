using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LightBike
{
    class LightPaths
    {
        public int xCoord { get; set; }
        public int yCoord { get; set; }

        public LightPaths (int x, int y)
        {
            this.xCoord = x;
            this.yCoord = y;
        }
    }
}
