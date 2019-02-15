//The.Net framework consists of an enormous library of codes used by the client languages such as C#. 
//Following are some of the components of the .Net framework −

//Common Language Runtime(CLR)
// The.Net Framework Class Library
// Common Language Specification
// Common Type System
// Metadata and Assemblies
// Windows Forms
// ASP.Net and ASP.Net AJAX
//ADO.Net
// Windows Workflow Foundation (WF)
// Windows Presentation Foundation
//  Windows Communication Foundation(WCF)
//  LINQ



//the using keyword is used to include the System namespace in the program.
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


//A namespace is a collection of classes. The HelloWorldApplication namespace contains the class HelloWorld.
namespace c_sharp_tutorial
{

    //Unlike Java, program file name could be different from the class name.
    class FIrstApp
    {
        static void Main(string[] args)
        {
            //WriteLine is a method of the Console class defined in the System namespace. This statement causes the message "Hello, World!" 
            //to be displayed on the screen.
            Console.WriteLine("Hello World");
            //This makes the program wait for a key press and it prevents the screen from running and closing quickly when the program is 
            //launched from Visual Studio .NET.
            Console.ReadKey();
        }
    }
}
