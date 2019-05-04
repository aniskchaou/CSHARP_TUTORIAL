using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c_sharp_tutorial.Basic
{
    namespace CallByValue
    {
        class Program
        {
            // User defined function  
            public void Show(int val)
            {
                val *= val; // Manipulating value  
                Console.WriteLine("Value inside the show function " + val);
                // No return statement  
            }
            // Main function, execution entry point of the program  
            static void Main(string[] args)
            {
                int val = 50;
                Program program = new Program(); // Creating Object  
                Console.WriteLine("Value before calling the function " + val);
                program.Show(val); // Calling Function by passing value            
                Console.WriteLine("Value after calling the function " + val);
            }
        }
    }

    namespace CallByReference
    {
        class Program
        {
            // User defined function  
            public void Show(ref int val)
            {
                val *= val; // Manipulating value  
                Console.WriteLine("Value inside the show function " + val);
                // No return statement  
            }
            // Main function, execution entry point of the program  
            static void Main(string[] args)
            {
                int val = 50;
                Program program = new Program(); // Creating Object  
                Console.WriteLine("Value before calling the function " + val);
                program.Show(ref val); // Calling Function by passing reference            
                Console.WriteLine("Value after calling the function " + val);
            }
        }

        //Output:

        //Value before calling the function 50
        //Value inside the show function 2500
        //Value after calling the function 2500
    }
}
