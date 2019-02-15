using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c_sharp_tutorial
{
    // The System.IO namespace has various classes that are used for performing numerous operations with files, 
    //such as creating and deleting files, reading from or writing to a file, closing a file etc.
    class Program
    {
        static void Main(string[] args)
        {
            FileStream F = new FileStream("test.dat", FileMode.OpenOrCreate,
               FileAccess.ReadWrite);

            for (int i = 1; i <= 20; i++)
            {
                F.WriteByte((byte)i);
            }
            F.Position = 0;
            for (int i = 0; i <= 20; i++)
            {
                Console.Write(F.ReadByte() + " ");
            }
            F.Close();
            Console.ReadKey();
        }
    }



}
