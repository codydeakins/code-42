using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2Tuesday
{
    class Operators
    {
        static void Main()
        {
            Console.WriteLine("The Awesome Operators");

            //Operators are typically things like;+,-,*,/

            Console.WriteLine(3 + 5);
            Console.WriteLine(10 / 5);
            Console.WriteLine(3 * 21);
            Console.WriteLine(8 - 4);

            Console.WriteLine();

            int legos = 15 + 25;
            Console.WriteLine("We have " + legos + " legos.");
            //The compiler figures out what is on the right of the =
            //and then puts that information into the box on the left.

            //We can make a lego car with 9 pieces. How many lego
            //cars can we make?

            int legoCars = legos / 9;
            Console.WriteLine("We can make " + legoCars + " cars. ");

            Console.WriteLine();

            //What if we do want to see the fraction answer?
            //Example: We have 40 pies and 9 people
            int pies = 40;
            decimal piePortions = pies / 9m;
            //An int divided by an int gives you an int,
            //but if we change one of the numbers above to a decimal,
            //we will get a decimal value back.


            Console.WriteLine("Everyone gets " + piePortions + " pieces of pie. ");

            //Modulus acts like division but only returns the remainder.

            //If everyone ONLY got whole pies, how many would they get
            //and how many would be left over?
            int numberFullPies = pies / 9;
            int numberLeftOver = pies % 9;
            //% is the symbol for moudulus

            Console.WriteLine("Everyone got " + numberFullPies + " full pies, and there were " + numberLeftOver
                + " left over. ");

            Console.WriteLine();

            //We have 75 nails. It takes 30 nails to make a dresser.
            //How many dresser can we make and how many nails would be left over?

            int nails = 75;
            int dressersMade = nails / 30;
            int nailsLeftOver = nails % 30;
            //For both varialbes, we ask the same question.
            //but we requested a different piece of the answer.

            Console.WriteLine("We made " + dressersMade + " dressers and have " + nailsLeftOver + 
                " nails left over. ");

            //MINI LAB!!
            //There are 100 cookies and 47 students.
            //How many cookies does each student get and how many are left over?

            int cookies = 100;
            int cookiesAte = cookies / 47;
            int cookiesLeftOver = cookies % 47;

            Console.WriteLine("We ate " + cookiesAte + " each, and had " + cookiesLeftOver +
                " left over. ");

            Console.WriteLine();

            //Unary operators are for use to quickly
            //increment or decrement a value;
            int hobbits = 2;
            Console.WriteLine("We have " + hobbits + " hobbits. ");

            //To add one the long way, we would write it like this:
            hobbits = hobbits + 1;
            Console.WriteLine("Hobbits is now " + hobbits);
            //short cut (Unary operator)
            hobbits++;
            Console.WriteLine("Hobbits is now " + hobbits);
            hobbits++;
            Console.WriteLine("Hobbits is now " + hobbits);

            //To decrease the long way:
            hobbits = hobbits - 1;
            Console.WriteLine("Hobbits is now " + hobbits);
            //unary operator
            hobbits--;
            Console.WriteLine("Hobbits is now " + hobbits);

            //The order of ++ or -- makes a big difference!
            //variable++ is a POST-Fix incrementer (happens LAST)
            //++variable is a PRE-Fix incrementer (happens FIRST)


            Console.WriteLine();

            int xboxGames = 12, psGames = 1;
            int games = xboxGames + psGames++;
            Console.WriteLine("Games was assigned BEFORE psGames " + "became two: " + games);
            Console.WriteLine("psGames became two AFTER game " + "was assigned: " + psGames);
            Console.WriteLine();

            int goblins = 12, orcs = 1;
            int monsters = goblins + ++orcs;
            Console.WriteLine("Monsters was assigned AFTER orcs " +
                "became two: " + monsters);
            Console.WriteLine("Orcs became two BEFORE monsters " +
                "was assigned: " + orcs);

            Console.WriteLine();

            //Assignment operators
            //= assigns the value on the right to the variable on the left.
            //when used with a mathmatical operator, they are shortcuts
            //to the equation with a variable to itself.

            int players = 2;
            Console.WriteLine(players);

            //examples of assignment operators:
            //+=, *=, /=, %=, -=

            //Long way to add 4 to players:
            players = players + 4;

            Console.WriteLine(players);

            //Assignment operator shortcut
            players += 4;
            Console.WriteLine(players);

            //multiply by 3 the long way
            players = players * 3;
            Console.WriteLine(players);

            //shortcut
            players *= 3;
            Console.WriteLine(players);

            //MINI LAB

            //Divide by 3 both the long and short way
            //print the answer each time.

            //Then subtract by 8 both long and short way
            //and print each answer.

            //Finally, Modulus by 2 using the shortcut only.

            players /= 3;
            Console.WriteLine(players);

            players = players / 3;
            Console.WriteLine(players);

            players = players - 8;
            Console.WriteLine(players);

            players -= 8;
            Console.WriteLine(players);

            players %= 2;
            Console.WriteLine(players);












        }//end Main()
    }//end class
}//end namespace
