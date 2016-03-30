using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2Tuesday
{
    class DataTypes
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Data Types: Bob Sure Is Loving 8-64");

            //Declare a variable
            byte byteNbr;

            //intialize the variable
            byteNbr = 0;

            //Reassign the value
            byteNbr = 255;

            //byteNbr = 1000;
            //The above was too big for a byte

            //Declare and initialize some other datatypes
            short shortNbr = -1234;
            int intNbr = 1239283;
            long longNbr = 64545482546;

            //The name of the variable can be anything you want. Ideal varialbe names are
            //Descriptive of what they are storing.
            //EX: sotre shoes in a shoebox.
            //Name your variables descriptive of what they are doing

            //Use the C# lesser-used integer variants
            sbyte sbyteNbr = -7;

            //MINI LAB!
            //Create a ushort, uint, and a ulong

            ushort ushortNbr = 25000;
            uint uintNbr = 100000;
            ulong ulongNbr = 5454845;

            //int someInt = 23.7;
            //DataType on the left, must match the datatype on the left
            //Without casting, we can't put this value into an int.
            //With casting, it would truncate to a whole number. What the means is,
            //when you cast it, it would just simply chop of the decimel and you would get 23.

            //Changing to floating points: 

            //Floating point types support non-whole numbers, aka decimel values.
            float smallFraction = 12;//A float value is 32 bits and will accept up to 45 digits
            double smallFraction2 = 12.9;//A double is 64 bit and supports up to 324 digits
            decimal samllFraction3 = 23;//A decimel is 128 bits and supports up to 29 digits


            //float floatNbr = 29.345;
            float floatNbr2 = 1268758543575.4564848F;
            //The above wors with either, and upper case 'F' or lower case 'f'. Case
            //Doesn't matter because .Net has a shortcut for both.

            decimal decimalNbr = 564878156.48945685m;
            //Add an 'm' on the end to balance it. Remember, 'm' for money. Stupid shit.

            double doubleNbr = 579646865.46546543;
            //No suffix needed, as it is the default for .Net, it sees a floating
            //Point value, as a double by default. 

            Console.WriteLine("Calculation result: " +
                (floatNbr2 / 2));


            bool isTheDoctor = false;

            Console.WriteLine("Are you the Doctor? " + isTheDoctor);

            //Bool accepts only values of true or false.
            //Do not use quotes, because could indicate
            //to the compiler that the value is a string.

            isTheDoctor = true;
            //Reassigned!

            Console.WriteLine("Are you the Doctor? " + isTheDoctor);

            /*
            String concatenation and making strings easy to read. 
            If you start a string on a line, you have to finish the string on that same line.

            To create a longer string that is easy to read, use concatenation.
            */

            string whatever = "akdjtahkllghatkdhtktgahtek" +
                "adkfhgkadfgkdkfkafgkadfk" +
                "afkdfjkdsjfkdafjskdlfksdjfklasdfjva" +
                "akdkdkdkdfaghekakdfkladfdkfhadfkfksfdfkkiebv";

            Console.WriteLine(whatever);

            string talk = "when you type in a string you can bring it up later in console." + 
                "I figured it out!";

            Console.WriteLine(talk);

            //Char datatype accepts exactly 1 character as a value
            //contained in single quotes.

            char letter = 'A';
            //char someChar = "A";
            //If you put the character is double quotes, the compiler sees it as a string, not a char.

            //char someChar2 = 'ABC';
            //You can only have 1 character at a time

            char symbol = '%';

            Console.WriteLine("Symbol is: " + symbol +
                " and Letter is: " + letter);

            //String accepts any number of characters in double quotes.

            string firstName = "James";
            Console.WriteLine(firstName);

            string lastName = "Bond";
            Console.WriteLine(lastName);

            //With some creative concatination, we can do a little formating
            //of our string outputs. 
            Console.WriteLine(firstName + " " + lastName);
            Console.WriteLine(firstName + ' ' + lastName);

            //Mini lab
            //Write to the screen the above varables in the way that
            //James Bond introduces himself.

            Console.WriteLine(lastName + ", " + firstName + ' ' + lastName);
            //Anything insdie double quotes is seen as a string and it will litterally
            //come out as a what is inside the quotes.








        }//end Main()
    }//end class
}//end namespace
