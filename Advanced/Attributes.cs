using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c_sharp_tutorial
{
    //An attribute is a declarative tag that is used to convey information to runtime about the behaviors of various elements like classes, methods, structures, enumerators, assemblies etc.
    //in your program. You can add declarative information to a program by using an attribute.
    //Attributes are used for adding metadata, such as compiler instruction and other information such as comments, 
    //description, methods and classes to a program. The .Net Framework provides two types of attributes: the pre-defined attributes and custom built attributes.

    class Attributes
    {

        //AttributeUsage

        //The pre-defined attribute AttributeUsage describes how a custom attribute class can be used.It specifies the types 
        //of items to which the attribute can be applied.

        [AttributeUsage(
   AttributeTargets.Class |
   AttributeTargets.Constructor |
   AttributeTargets.Field |
   AttributeTargets.Method |
   AttributeTargets.Property,
   AllowMultiple = true)]


        //Conditional

        //This predefined attribute marks a conditional method whose execution depends on a specified preprocessing identifier.

        // It causes conditional compilation of method calls, depending on the specified value such as Debug or Trace.For example,
        //it displays the values of the variables while debugging a code.

        public class Myclass
        {
            [Conditional("DEBUG")]

            public static void Message(string msg)
            {
                Console.WriteLine(msg);
            }
        }
        class Test
        {
            static void function1()
            {
                Myclass.Message("In Function 1.");
                function2();
            }
            static void function2()
            {
                Myclass.Message("In Function 2.");
            }
            public static void Main()
            {
                Myclass.Message("In Main function.");
                function1();
                Console.ReadKey();
            }

        }
        //output
        // In Main function
        //In Function 1
        //In Function 2



        //Obsolete

        // This predefined attribute marks a program entity that should not be used.It enables you to inform the compiler 
        //to discard a particular target element. For example, when a new method is being used in a class and if you still want to 
        //retain the old method in the class, you may mark it as obsolete by displaying a message the new method should be used, instead of the old method.

        [Obsolete("Don't use OldMethod, use NewMethod instead", true)]

        static void OldMethod()
        {
            Console.WriteLine("It is the old method");
        }
        static void NewMethod()
        {
            Console.WriteLine("It is the new method");
        }
        public static void Main()
        {
            OldMethod();
        }

        //output
        // Don't use OldMethod, use NewMethod instead
    }
