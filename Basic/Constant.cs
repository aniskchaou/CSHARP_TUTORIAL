using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c_sharp_tutorial
{
    class Constant
    {
        
        public static void main(String[] args)
        {
            // \\ 	\ character
            //\' 	' character
            //\" 	" character
            //\? 	? character
            //\a Alert or bell
            //\b Backspace
            //\f Form feed
            //\n Newline
            //\r Carriage return
            //\t Horizontal tab
            //\v Vertical tab

            Console.WriteLine("Hello\tWorld\n\n");
            Console.ReadLine();
            const double pi = 3.14159;
            Console.Write(pi);
        }
    }
}
