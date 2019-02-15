//#define lets you define a symbol such that, by using the symbol as the expression passed to the #if directive, the expression evaluates to true.
#define PI
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



//The preprocessor directives give instruction to the compiler to preprocess the information before actual compilation starts.

//All preprocessor directives begin with #, and only white-space characters may appear before a preprocessor directive on a line. 
//Preprocessor directives are not statements, so they do not end with a semicolon (;).

//C# compiler does not have a separate preprocessor; however, the directives are processed as if there was one.
//In C# the preprocessor directives are used to help in conditional compilation. Unlike C and C++ directives, they are not used to create macros. 
//A preprocessor directive must be the only instruction on a line.
namespace c_sharp_tutorial
{
    class DirectivePreprocessor
    {
        static void Main(string[] args)
        {
            #if (PI)
            Console.WriteLine("PI is defined");
            #else
            Console.WriteLine("PI is not defined");
             #endif
            Console.ReadKey();
        }

    }



    //#define :It defines a sequence of characters, called symbol.

    //#undef: It allows you to undefine a symbol.

    //#if : It allows testing a symbol or symbols to see if they evaluate to true.

    //#else : It allows to create a compound conditional directive, along with #if.

    //#elif  It allows creating a compound conditional directive.

    //#endif  Specifies the end of a conditional directive.

    //#line It lets you modify the compiler's line number and (optionally) the file name output for errors and warnings.

    //#error It allows generating an error from a specific location in your code.

    //#warning It allows generating a level one warning from a specific location in your code.

    //#region It lets you specify a block of code that you can expand or collapse when using the outlining feature of the Visual Studio Code Editor. 	

    //#endregion It marks the end of a #region block.
}
