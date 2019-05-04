using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpProgram
{
    class GenericClass
    {
        public void Show<T>(T msg)
        {
            Console.WriteLine(msg);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            GenericClass genC = new GenericClass();
            genC.Show("This is generic method");
            genC.Show(101);
            genC.Show('I');
        }
    }
}
