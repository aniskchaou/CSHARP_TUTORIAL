using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c_sharp_tutorial
{
    //C# allows using pointer variables in a function of code block when it is marked by the unsafe modifier. 
    //The unsafe code or the unmanaged code is a code block that uses a pointer variable.
    class UnsafeCodes
    {
        public unsafe void swap(int* p, int* q)
        {
            int temp = *p;
            *p = *q;
            *q = temp;
        }


        static unsafe void Main(string[] args)
        {
            int var = 20;
            int* p = &var;

            Console.WriteLine("Data is: {0} ", var);
            Console.WriteLine("Address is: {0}", (int)p);
            Console.ReadKey();


            unsafe
            {
                int var = 20;
                int* p = &var;

                Console.WriteLine("Data is: {0} ", var);
                Console.WriteLine("Data is: {0} ", p->ToString());
                Console.WriteLine("Address is: {0} ", (int)p);
            }
            Console.ReadKey();


            TestPointer p = new TestPointer();
            int var1 = 10;
            int var2 = 20;
            int* x = &var1;
            int* y = &var2;

            Console.WriteLine("Before Swap: var1:{0}, var2: {1}", var1, var2);
            p.swap(x, y);

            Console.WriteLine("After Swap: var1:{0}, var2: {1}", var1, var2);
            Console.ReadKey();
        }
    }



    }
}
