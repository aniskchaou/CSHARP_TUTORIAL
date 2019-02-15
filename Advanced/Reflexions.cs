using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c_sharp_tutorial
{
    //Reflection objects are used for obtaining type information at runtime. The classes that give access to the metadata of a running program are in the System.Reflection namespace.

    //The System.Reflection namespace contains classes that allow you to obtain information about the application and to dynamically add types, values, and objects to the application.


    //The MemberInfo object of the System.Reflection class needs to be initialized for discovering the attributes associated with a class. 
    //To do this, you define an object of the target class

    [AttributeUsage(AttributeTargets.All)]
    public class HelpAttribute : System.Attribute
    {
        public readonly string Url;

        public string Topic   // Topic is a named parameter {
      get {
         return topic;
      }
    set {
         topic = value;
      }
   }
   public HelpAttribute(string url)   // url is a positional parameter {
      this.Url = url;
   }
private string topic;
}

[HelpAttribute("Information on the class MyClass")]
class MyClass
{

}

namespace AttributeAppl
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Reflection.MemberInfo info = typeof(MyClass);
            object[] attributes = info.GetCustomAttributes(true);

            for (int i = 0; i < attributes.Length; i++)
            {
                System.Console.WriteLine(attributes[i]);
            }
            Console.ReadKey();
        }
    }
}

}
