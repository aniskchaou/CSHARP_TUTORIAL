using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c_sharp_tutorial.Basic
{
    class Program
    {
        // User defined function  
        public void Show(params int[] val) // Params Paramater  
        {
            for (int i = 0; i < val.Length; i++)
            {
                Console.WriteLine(val[i]);
            }
        }

        // User defined function  
        public void Show2(params object[] items) // Params Paramater  
        {
            for (int i = 0; i < items.Length; i++)
            {
                Console.WriteLine(items[i]);
            }
        }


        // Main function, execution entry point of the program  
        static void Main(string[] args)
        {
            Program program = new Program(); // Creating Object  
            program.Show(2, 4, 6, 8, 10, 12, 14); // Passing arguments of variable length  

            Program program2 = new Program(); // Creating Object  
            program2.Show2("Ramakrishnan Ayyer", "Ramesh", 101, 20.50, "Peter", 'A');
        }


    }

   
   
}
