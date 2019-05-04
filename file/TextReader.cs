using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextReaderExample
{
    class Program
    {
        static void Main(string[] args)
        {
            using (TextReader tr = File.OpenText("e:\\f.txt"))
            {
                Console.WriteLine(tr.ReadLine());
            }
        }
    }
}
