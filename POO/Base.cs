using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c_sharp_tutorial.POO
{
    public class Animal
    {
        public string color = "white";
    }
    public class Dog : Animal
    {
        string color = "black";
        public void showColor()
        {
            Console.WriteLine(base.color);
            Console.WriteLine(color);
        }

    }
    public class TestBase
    {
        public static void Main()
        {
            Dog d = new Dog();
            d.showColor();
        }
    }
}
