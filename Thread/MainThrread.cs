using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c_sharp_tutorial
{
    //Threads are lightweight processes. One common example of use of thread is implementation of concurrent programming by modern operating systems. 
    //Use of threads saves wastage of CPU cycle and increase efficiency of an application.

   // The life cycle of a thread starts when an object of the System.Threading.Thread class is created and ends when the thread is terminated or completes execution.

    //Following are the various states in the life cycle of a thread −

    //The Unstarted State − It is the situation when the instance of the thread is created but the Start method is not called.

   // The Ready State − It is the situation when the thread is ready to run and waiting CPU cycle.

     //The Not Runnable State − A thread is not executable, when
        //Sleep method has been called
       // Wait method has been called
       // Blocked by I/O operations

    //The Dead State − It is the situation when the thread completes execution or is aborted.

    class MainThrread
    {
        //The first thread to be executed in a process is called the main thread.

        //When a C# program starts execution, the main thread is automatically created. 
        //The threads created using the Thread class are called the child threads of the main thread. You can access a thread
        //using the CurrentThread property of the Thread class.

        static void Main(string[] args)
        {
            Thread th = Thread.CurrentThread;
            th.Name = "MainThread";

            Console.WriteLine("This is {0}", th.Name);
            Console.ReadKey();
        }
    }
}
