using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2Tuesday
{
    class CastingLab
    {
        static void Main()
        {
            Console.WriteLine("Casting Lab");

            //Some variables to use
            byte puddle = 100;
            short pond = 29456;
            int lake = 100000;
            long ocean = 5;

            //for each casting, incluse a comment categorizing it as:
            //implicit casting
            //explicit casting
            //explicit casting with truncation

            //REMEMBER....Right TO left thinking...

            //1. cast the value of lake into ocean and display it
            //2. cast the value of pond into puddle and display it
            //3. cast the value of pond into ocean and display it
            //4. cast the value of ocean into lake and display it.

            ocean = lake;
            Console.WriteLine("Ocean has a value of: " + lake);//
                
        
        }
    }
}
