using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2Tuesday
{
    class DataTypesLab
    {
        static void Main()
        {
            Console.WriteLine("Data Type Lab");
            //If you get an error that the program contains more than 
            //one entry point, go into properties and select
            //which class to use. You will only be able to choose from
            //the files that have a Main().

            /*
            Declare and initialize 10 different data types 
            Use at least:
            1 string
            1 interger type
            1 floating point type
            1 bool
            1 char

            Display each of them with a Console.WriteLine();

            Aditionally, creat a variable that uses the min and
            max value for at least 1 interger type.
            */

            //Declare and Initalize

            int intNbr = 2468;
            char symbol = '$';
            bool canWeWin = true;
            float smallFraction = 24;
            string name = "Batman";
            byte byteNbr = 13;
            short shortNbr = 1982;
            sbyte sbyteNbr = -42;
            ushort ushortNbr = 0;
            ulong ulongNbr = 1000000000;

            Console.WriteLine("He saved " + intNbr + " chickens ");
            Console.WriteLine("He makes no " + symbol);
            Console.WriteLine("Will the Royals win the World Series again? " + canWeWin);
            Console.WriteLine("Half of 48 is, " + smallFraction);
            Console.WriteLine("Cody is really, " + name);
            Console.WriteLine("His lucky number is, " + byteNbr);
            Console.WriteLine("That old guy was born in, " + shortNbr);
            Console.WriteLine("The anti-answer to everything is, " + sbyteNbr);
            Console.WriteLine("Never divide by " + ushortNbr);
            Console.WriteLine("I wish I had " + ulongNbr);

            





        }
    }
}
