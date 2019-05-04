using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c_sharp_tutorial.Thread
{
    class Printer
    {
        public void PrintTable()
        {
            lock (this)
            {
                for (int i = 1; i <= 10; i++)
                {
                    Thread.Sleep(100);
                    Console.WriteLine(i);
                }
            }
        }
    }
    class Program
    {
        public static void Main(string[] args)
        {
            Printer p = new Printer();
            Thread t1 = new Thread(new ThreadStart(p.PrintTable));
            Thread t2 = new Thread(new ThreadStart(p.PrintTable));
            t1.Start();
            t2.Start();
        }
    }
}

/*
//ouput
1
2
3
4
5
6
7
8
9
10
1
2
3
4
5
6
7
8
9
10
*/