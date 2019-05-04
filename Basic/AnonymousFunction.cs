using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnonymousMethods
{
    class Program
    {
        public delegate void AnonymousFun();
        static void Main(string[] args)
        {
            AnonymousFun fun = delegate () {
                Console.WriteLine("This is anonymous function");
            };
            fun();
        }
    }
}
