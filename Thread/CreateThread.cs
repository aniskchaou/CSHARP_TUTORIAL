﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace c_sharp_tutorial
{
    
        class ThreadCreationProgram
        {
            public static void CallToChildThread()
            {
                Console.WriteLine("Child thread starts");
            }
            static void Main(string[] args)
            {
                ThreadStart childref = new ThreadStart(CallToChildThread);
                Console.WriteLine("In Main: Creating the Child thread");
                Thread childThread = new Thread(childref);
                childThread.Start();
                Console.ReadKey();
            }
        }
    
}
