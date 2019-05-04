using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
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
                    System.Threading.Thread.Sleep(100);
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
            System.Threading.Thread t1 = new System.Threading.Thread(new ThreadStart(p.PrintTable));
            System.Threading.Thread t2 = new System.Threading.Thread(new ThreadStart(p.PrintTable));
            t1.Start();
            t2.Start();
        }
    }
}

/*
output
1
1
2
2
3
3
4
4
5
5
6
6
7
7
8
8
9
9
10
10
*/