using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//When creating a class, instead of writing completely new data members and member functions, the programmer can designate that the new 
//class should inherit the members of an existing class. This existing class is called the base class, and the new class is referred to as the derived class.

//The idea of inheritance implements the IS-A relationship.For example, mammal IS A animal, dog IS-A mammal hence dog IS-A animal as well, and so on.
//A class can be derived from more than one class or interface, which means that it can inherit data and functions from multiple base classes or interfaces.
namespace c_sharp_tutorial
{
    class Shape
    {
        public void setWidth(int w)
        {
            width = w;
        }
        public void setHeight(int h)
        {
            height = h;
        }
        protected int width;
        protected int height;
    }

    // Derived class
    class Rectangle : Shape
    {
        public int getArea()
        {
            return (width * height);
        }
    }
    class RectangleTester
    {
        static void Main(string[] args)
        {
            Rectangle Rect = new Rectangle();

            Rect.setWidth(5);
            Rect.setHeight(7);

            // Print the area of the object.
            Console.WriteLine("Total area: {0}", Rect.getArea());
            Console.ReadKey();
        }
    }
}
