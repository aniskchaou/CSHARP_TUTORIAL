using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c_sharp_tutorial
{
    //Delegates are especially used for implementing events and the call-back methods.All delegates are implicitly derived from the System.Delegate class.


    //Delegate declaration determines the methods that can be referenced by the delegate. A delegate can refer to a method, which has the same 
    //signature as that of the delegate.
    //For example, consider a delegate −
    //public delegate int MyDelegate(string s);
    //The preceding delegate can be used to reference any method that has a single string parameter and returns an int type variable.

    delegate int NumberChanger(int n);
    namespace DelegateAppl
    {

        class TestDelegate
        {
            static int num = 10;

            public static int AddNum(int p)
            {
                num += p;
                return num;
            }
            public static int MultNum(int q)
            {
                num *= q;
                return num;
            }
            public static int getNum()
            {
                return num;
            }
            static void Main(string[] args)
            {
                //create delegate instances
                NumberChanger nc1 = new NumberChanger(AddNum);
                NumberChanger nc2 = new NumberChanger(MultNum);

                //calling the methods using the delegate objects
                nc1(25);
                Console.WriteLine("Value of Num: {0}", getNum());
                nc2(5);
                Console.WriteLine("Value of Num: {0}", getNum());
                Console.ReadKey();
            }
        }


        //output
        //Value of Num: 35
        //Value of Num: 175
    }
