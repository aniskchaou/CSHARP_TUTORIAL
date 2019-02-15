using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c_sharp_tutorial
{
    //Value Type
   // Value type variables can be assigned a value directly.They are derived from the class System.ValueType.
    class DataType
    {

        static void Main(string[] args)
        {
            // bool Boolean value True or False   False
            bool b = true;
            // byte 	8-bit unsigned integer 	0 to 255 	0
            byte by = 254;
            // char 	16-bit Unicode character U +0000 to U +ffff 	'\0'
            char ch = 'A' ;
            // decimal 	128-bit precise decimal values with 28-29 significant digits(-7.9 x 1028 to 7.9 x 1028) / 100 to 28 	0.0M
            decimal dec = 29;




            //  int 	32-bit signed integer type 	-2,147,483,648 to 2,147,483,647 	0
            int i = 2000000;
            // long 	64-bit signed integer type 	-9,223,372,036,854,775,808 to 9,223,372,036,854,775,807 	0L
            long l = 9707869876987687;
            //  sbyte 	8-bit signed integer type 	-128 to 127 	0
            sbyte sb = -4;
            //  short 	16-bit signed integer type 	-32,768 to 32,767 	0*/
            short sh = -100;



            //unsigned types    
            //uint 	32-bit unsigned integer type 	0 to 4,294,967,295 	0
            uint ui = 4000000000;
            //ulong 	64-bit unsigned integer type 	0 to 18,446,744,073,709,551,615 	0
            ulong ul = 1800000000000000;
            //ushort 	16-bit unsigned integer type 	0 to 65,535 	0
            ushort us = 9998;


            //  float 	32-bit single-precision floating point type 	-3.4 x 1038 to + 3.4 x 1038 	0.0F
            float f=3.00f;
            // double 	64-bit double-precision floating point type(+/-)5.0 x 10-324 to(+/-)1.7 x 10308 	0.0D
            double d = 4.88888d;


            //To get the exact size of a type or a variable on a particular platform, you can use the sizeof method.
            Console.WriteLine("Size of int: {0}", sizeof(int));

            //Reference Type
            //The reference types do not contain the actual data stored in a variable, but they contain a reference to the variables.

            
            
            
            
            //Object Type
            //The Object Type is the ultimate base class for all data types in C# Common Type System (CTS). Object is an alias for System.Object class.

            //The object types can be assigned values of any other types, value types, reference types, predefined or user-defined types.However, 
            //before assigning values, it needs type conversion.

            //When a value type is converted to object type, it is called boxing and on the other hand, when an object type is converted to a value type, 
            //it is called unboxing.

            object obj;
            obj = 100; // this is boxing

            
            
            
            //Dynamic Type
            //You can store any type of value in the dynamic data type variable.Type checking for these types of variables takes place at run - time.
            //Syntax for declaring a dynamic type is −

            dynamic dinamic = 20;

            //Dynamic types are similar to object types except that type checking for object type variables takes place at compile time,
            //whereas that for the dynamic type variables takes place at run time.

            //String Type
            //The String Type allows you to assign any string values to a variable.The string type is an alias for the System.String class. 
            //It is derived from object type.The value for a string type can be assigned using string literals in two forms: quoted and @quoted.

            String str = "Tutorials Point";
            str=@"Tutorials Point";

            //Pointer Type
            //Pointer type variables store the memory address of another type. Pointers in C# have the same capabilities as the pointers in C or C++.
            char* cptr;
            int* iptr;


        }

    }
}
