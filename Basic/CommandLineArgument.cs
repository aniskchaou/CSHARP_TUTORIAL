using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c_sharp_tutorial.Basic
{
    
        class Programmm
        {
            // Main function, execution entry point of the program  
            static void Main(string[] args) // string type parameters  
            {
                // Command line arguments  
                Console.WriteLine("Argument length: " + args.Length);
                Console.WriteLine("Supplied Arguments are:");
                foreach (Object obj in args)
                {
                    Console.WriteLine(obj);
                }
            }
        }
    
}
