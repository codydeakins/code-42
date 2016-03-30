using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2Tuesday
{
    class Casting
    {
        static void Main()
        {
            Console.WriteLine("Casting!!!");
            #region Casting Notes
            /*
            Casting is when you take a value from on variable of
            one type and copy it to a variable of a different, 
            but similar type.

            IMPLICIT casting: Copies the contents from a smaller container
            to a larger container (aka data type)
             
            */
            #endregion

            byte toothpasteBox = 1;
            short shoeBox = 200;
            int movieBox = 32261;
            long fridgeBox;


            fridgeBox = toothpasteBox;
            //The above line of code is implicit casting (byte to a long).
            //This always fits with no issues.
            //.Net just tacks on extra 0's
            //fridgeBox is bigger than toothpasteBox, so it fits in there. 

            Console.WriteLine("Fridgebox has a value of: " + fridgeBox);

            long secondFridgeBox = fridgeBox;//This is not casting. We are just assigning
            //the value of a variable from one container
            //to another container of the same datatype.

            Console.WriteLine("The second fridgebox has a value of: " + secondFridgeBox);

            //toothpastBox = shoeBox;
            /*
            EXPLICIT casting: Going from a larger to a smaller container. This requires
            extra work.

            You ahve to explicityly state the datatype you're casting to.
            This can be messy if it won't fit.


            Explicit = Explain (we have to explain what we are doing to our compiliers.)

       
            */

            toothpasteBox = (byte)shoeBox;
            //Casting shoeBox to toothpasteBox explicitly.

            Console.WriteLine("Toothpast Box has a value of: " + toothpasteBox);
            Console.WriteLine("Shoe box remains the vaule of: " + shoeBox);

            /*
            If you explicity cast a larger value to a small container
            you get a mess. (truncation)

            Above we set movingBox to 32261. What happens if 
            we copy that value to a byte?
            */

            toothpasteBox = (byte)movieBox;
            //toohpasteBox is equal to the byte version of movingBox.
            Console.WriteLine("Toothpaste box is now: " + toothpasteBox);
            Console.WriteLine("Moving box is still: " + movieBox);

            //long into an int
            movieBox = (int)fridgeBox;//right to left thinking

            decimal dec1 = 4.3m;
            decimal dec2 = (decimal)4.3;

            //both of the above lines are the same.
            //m or M is a shorcut for explicityly casting
            //a double to a decimal.

            decimal deathStars = 1.75m;

            //An example of when you might what to intinally
            //truncate a value:

            int completedDs = (int)deathStars;
            Console.WriteLine("Out of " + deathStars +
                " Death Stars, only " + completedDs + " was completed");

            


        }//end Main()
    }//end class
}//end namespace

