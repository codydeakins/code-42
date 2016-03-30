using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1Monday
{
    class Variables
    {
        static void Main(string[] args)
        {

            // Adding // at the start of a line allows
            // for a comment. This is a single line comment.
            // When you compile your code, comments are ignored.

            // The Main Method is where the program starts to run. 

            // In VS, the Solution si the collection/portfolio of projects
            // The projects are the key componets. The solution is more of
            // a roadmap detailing how things relate.

            // .NEt supports 3 types of applications: 
            // 1. Windows - Console Applications are waht we will be using.
            // 2. Web applications - This is where the majority of the track will focus.
            // 3. Web Services - These are what are called distributed applications. Page 9 of the
            // Wrox book goes into more detail.

            // There are 3 steps to running a program:
            // 1. Save - CTRL + S
            // 2. Build/Compile - CTRL + SHIFT + B
            // 3. Run It - CTRL + F5
            // Fortunately, CTRL + F5 does all 3 for us!

            Console.WriteLine("My first line of code! Hello, World!");

            //The compiler ignores white space, EXCEPT for the inside of a string,
            //which means you CANNOT intuitively break a string into 2 lines.

            /*
            We also have multi-line comments. 

            A variable is a container. It's contents CAN be changed.
            All variables must be of "type" something.  
            SYNTAX:
            datatype name;

            The datatype CANNOT be changed programmatically (type safe)

            Declaration vs. Initialization vs. Assignment

            Declaration means creating the variable. 

            Initialization means giving the variable a value for the first time. 

            Assignment means giving it a value anytime.
            */

            int firstExample; //We declared an int named firstExample.

            //string firstExample;

            firstExample = 1; //Initalizing the variable.

            firstExample = 2; //Reassinged the value to now be 2.

            //Usually, we declare and initalize on the same line.

            string name = "Cody Deakins";

            Console.WriteLine(name);

            name = "Deadpool";

            Console.WriteLine(name); //reassignment

            int bigNbr; // Declared a new variable

            bigNbr = 55321;
            //Don't use commas for larger number! Commas are only for formatting.

            Console.WriteLine(bigNbr);
            Console.WriteLine(55321);
            Console.WriteLine("55321");
            // All 3 of these do the same thing, but all are different.
            // Only bigNbr can be used more than once.

            // What's the difference between a string and an int?
            Console.WriteLine("Adding 2 strings:");
            Console.WriteLine("17" + "23");

            Console.WriteLine("Adding 2 ints:");
            Console.WriteLine(17 + 23);

            //Adding 2 strings together is called "Concatenation"

            int kuBasketballPts = 1068;
            int muBasketballPts = 1003;

            Console.WriteLine("KU has scored " + kuBasketballPts + " points in 15 games.");
            Console.WriteLine("Total KU & MU points for the 2015 season: "
                + (kuBasketballPts + muBasketballPts));

            /*
            Concatenation is adding strings and objects together. 
            The () around the numeric operations trumps the order of 
            operations and makes sure the concatenation happens
            AFTER the calculation.
            */

            #region Variable Name Requirements
            /*
            Variable names can only begin with alphabtic characters or underscores.

            They CANNOT contain spaces. 
            They MUST contain at least 1 alpha or numeric character.
            They CANNOT be a C# reserved keyword (blue font).
            They MUST be unique within their scope.
            */
            #endregion

            //int kuBasketballPts = 1168; 

            //The previous line of code is no good.
            //Either:
            //A. you were trying to create a new variable with the same name, or
            //B. you were trying to reassign kuBasketballPts witha  new value.
            //If it was B., you would do it like this:

            kuBasketballPts = 1168;

                //Constants are variables taht MUST be assigned when declared and 
                //CANNOT be reassigned later. 

            const int CURRENT_YEAR = 2016;

            //You can still use a const in your code like you can, any variable.

            Console.WriteLine("The Kansas City Royals will win the " +
                CURRENT_YEAR + " World Series!");

            //If you are creatign multiple variables, some syntax works better than others.

            //Declare all variables, but initialize them individually:
            int steves, endermen, pigs, creepers, zombies;

            //You MUST initialize a variable before you can use it.
            //Now we need to initialize all of the above variables.
            //The initialization order does not matter as long as a variable
            //is initialized before you use it.

            steves = 1;
            endermen = 4;
            pigs = 5;
            creepers = 11;
            zombies = 2;

            //Declare all variables, but only initialize some:

            int pizzas, tacos, beefJerkies = 10;
            //Only beefJerkies have been initialized with a value of 10.
            Console.WriteLine(beefJerkies);

            //Declare all and initialize all:
            int coaches = 2;
            int players = 10; 
            int cheerleaders = 16;

            //When declaring multiple variables, you CANNOT mix datatypes:
            //int mlsTeams = 19, mlsChampions = "Sporting KC"
            //int mlsTeams = 19, string mlsChampions "Sporting KC";
            int mlsTeams = 19; string mlsChampions = "Sporting KC";

            //MINI LAB - Write a sentence using both variables above with concatenation

             //Console.WriteLine("Of the top" + mlsTeams + mlsChampions, "are the champions. ");

            Console.WriteLine("There are " + mlsTeams + "Major League Socer  teams. "
                + mlsChampions + " is the best team in the legue. ");

            
              







        }//end Main()
    }//end class
}//end namespace
