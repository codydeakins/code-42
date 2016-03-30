using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2Tuesday
{
    class NamingConventions
    {
        //Not that this class has no Main() method.
        //It could never be a start up object for a console
        //application. It would just be a helper file. 

        //IF this file was in a special project called a Dynameic Link
        //Library (aka Class Library) it would build as a .dll instead of a .exe;

        /*
        Naming conventions are rules on how to make things. 
        Breaking them won't cause build errors (generally), 
        but they can be helpful to stick to. 

        

        lowercase
        Example: thisislowercase

        - This HAS TO BE USED with keywords(bright blue) (This is a rule, and not a convention.)
        - We could use this convention elsewhere, but generally we don't.

        UPPERCASE
        Example: THISISUPPERCASE

        -Used rarely, most typically with constants, to make them stand out.
        -Use an _ in place of a 'space'.
        Example: const int ONE_RING = 1;

        camelCase
        Example: thisIsCamelCase, employeeName

        -Uses lowercase letters for the first word in the variable name
        and capitolized first letter for all subsequent words.
        -Typically this is used for variables and parameters.

        PascalCase
        -Uses capitolized first letter for every "word".
        Example: 
        ThisIsPascalCase
        NamingConvention
        CastingLab

        -ClassNames are PascalCase
        -Methods use PascalCase

        -Typically PascalCase is used for "everything else", i.e., \
        namespace, class, method, properties, etc.

        Hungarian or Lezinski convention:
        Example: intSomeBigNumber

        -Uses a lowercse prefix for the first few letters before the variable name starts. 
        All words in the name after the prefix have capitolized first letter.

        
        Above shows an int as a prefix for an int, then the variable name.
         The prefix in this case is the datatype.

        We will use Hungarian mostly in ASP
        btnClick (a button)
        lblDisplay (a label)
        */




    }
}
