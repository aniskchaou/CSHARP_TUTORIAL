using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c_sharp_tutorial
{

    //C# allows you to create abstract classes that are used to provide partial class implementation of an interface. 
    //Implementation is completed when a derived class inherits from it. Abstract classes contain abstract methods, which are implemented by 
    //the derived class. The derived classes have more specialized functionality.

    abstract class Shape
    {
        public abstract int area();
    }

    class Rectangle : Shape
    {
        private int length;
        private int width;

        public Rectangle(int a = 0, int b = 0)
        {
            length = a;
            width = b;
        }
        public override int area()
        {
            Console.WriteLine("Rectangle class area :");
            return (width * length);
        }
    }
    class RectangleTester
    {
        static void Main(string[] args)
        {
            Rectangle r = new Rectangle(10, 7);
            double a = r.area();
            Console.WriteLine("Area: {0}", a);
            Console.ReadKey();
        }
    }

    //output
    //Rectangle class area :
    // Area: 70

}
