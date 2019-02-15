using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c_sharp_tutorial
{
    class Arrays
    {
        static void Main(string[] args)
        {
            int[] n = new int[10]; /* n is an array of 10 integers */
            int i, j;

            /* initialize elements of array n */
            for (i = 0; i < 10; i++)
            {
                n[i] = i + 100;
            }

            /* output each array element's value */
            for (j = 0; j < 10; j++)
            {
                Console.WriteLine("Element[{0}] = {1}", j, n[j]);
            }
            Console.ReadKey();


            int[] n = new int[10]; /* n is an array of 10 integers */

            /* initialize elements of array n */
            for (int i = 0; i < 10; i++)
            {
                n[i] = i + 100;
            }

            /* output each array element's value */
            foreach (int j in n)
            {
                int i = j - 100;
                Console.WriteLine("Element[{0}] = {1}", i, j);
            }
            Console.ReadKey();
        }

    }
}
