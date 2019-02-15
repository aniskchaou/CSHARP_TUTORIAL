using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


//A namespace is designed for providing a way to keep one set of names separate from another. 
//The class names declared in one namespace does not conflict with the same class names declared in another.

    namespace first_space
    {
        class first_class
        {
            public void func()
            {
                Console.WriteLine("first class inside first_space");
            }
        }
    }
    namespace second_space
    {
        class second_class
        {
            public void func()
            {
                Console.WriteLine("second class inside second_space");
            }
        }
    }
    class TestClass
    {
        static void Main(string[] args)
        {
            first_space.first_class fc = new first_space.first_class();
            second_space.second_class sc = new second_space.second_class();
            fc.func();
            sc.func();
            Console.ReadKey();
        }
    }

