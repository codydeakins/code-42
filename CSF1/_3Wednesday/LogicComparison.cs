using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3Wednesday
{
    class LogicComparison
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Logical and Comparison Operators");

            //Comparison Operators
            //"Relational" and "Equality" operator compare
            //2 different values and result in a bool answer
            //of true or false


            /*
            > is for greater than
            < is for less than
            >= is for great than or equal to
            <= is for less than or equal to
            */

            int ceoPayGrade = 20;
            int mgrPayGrade = 12;
            int mailRoomPayGrade = 2;

            bool isCEOPayHigher = (ceoPayGrade > mgrPayGrade);
            Console.WriteLine("is CEO Greater than MGR? " + isCEOPayHigher);

            Console.WriteLine("Is MGR greater than CEO? " + (mgrPayGrade > ceoPayGrade));

            Console.WriteLine("Is mailroom less than or equal to CEO? " + (mailRoomPayGrade <= ceoPayGrade));

            Console.WriteLine("Is 5 less than or equal to 6? " + (5 <= 6));

            Console.WriteLine("Is mailroom less than or equal to the number 1? "+ (mailRoomPayGrade <= 1));

            //write 5 equations using comparison operators.
            //Print them to the screen.

            int itPayGrade = 1;
            int bossPayGrade = 15;
            int bigBossPayGrade = 100;

            bool isBigBossPayHigher = (bigBossPayGrade > bossPayGrade);
            Console.WriteLine("is Big boss greater than boss? " + isCEOPayHigher);

            Console.WriteLine("Is Boss greater than Big boss? " + (bigBossPayGrade > bigBossPayGrade));

            Console.WriteLine("Is IT less than Boss? " + (itPayGrade < bossPayGrade));

            Console.WriteLine("Is Big boss greater than or equal to IT? " + (bigBossPayGrade >= itPayGrade));

            Console.WriteLine("Is Boss less than or equal to Big boss? " + (bigBossPayGrade >= bossPayGrade));

            //a single = is assignment, so to
            //test equality we use ==
            Console.WriteLine("Is MGR equal to CEO? " + (mgrPayGrade == ceoPayGrade));

            //for not equal we have to use !=
            //In C#, !, generally means 'NOT'

            Console.WriteLine("Is MGR different than CEO? " + (mgrPayGrade != ceoPayGrade));

            //Comparing strings...
            string b = "Batman";
            string b2 = "BATMAN";

            Console.WriteLine("Is b equal to b2? " + (b == b2));

            //C# is a case sensitive language, so these are NOT equal.

            //To explore somethign in intellisense, use a period.
            Console.WriteLine("Case INSENSITIVE, is b equal to b2? " + (b.ToUpper() == b2));

            //All methods (purple boxes in intellesense), must have parens

            //Basic overview of C# methods - a mehod is a group of statements that together preform a task. 
            //Every C# program, has at least 1 class with a method. (Called Main)
            //() = Method
            //We will go over thse in great detail next week. 

            //Logical operator combine two comparison operators.
            // && is used for AND 
            // || is used for OR
            //They still compare just two values, but in this case
            //those values must be bools.

            bool someComplicatedThing =
                (ceoPayGrade < mgrPayGrade) && (ceoPayGrade > mailRoomPayGrade);

            Console.WriteLine("Is CEO less than manager and greater than mailroom? " + (someComplicatedThing));

            Console.WriteLine("Is MGR greater than mailroom AND " +
                "ceoPayGrade greater than MGR? " + (mgrPayGrade > mailRoomPayGrade && ceoPayGrade > mgrPayGrade));

            Console.WriteLine("Is 15 less than 5 and equal to 15? " + (15 < 5 && 15==15));






        }//end Main()
    }//end class
}//end namespace
