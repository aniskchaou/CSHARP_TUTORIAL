

//The using keyword states that the program is using the names in the given namespace. 
//For example, we are using the System namespace in our programs.
using System;
using first_space;
using second_space;

namespace first_space
{
    class abc
    {
        public void func()
        {
            Console.WriteLine("Inside first_space");
        }
    }
}
namespace second_space
{
    class efg
    {
        public void func()
        {
            Console.WriteLine("Inside second_space");
        }
    }
}
class TestClass
{
    static void Main(string[] args)
    {
        abc fc = new abc();
        efg sc = new efg();
        fc.func();
        sc.func();
        Console.ReadKey();
    }
}
