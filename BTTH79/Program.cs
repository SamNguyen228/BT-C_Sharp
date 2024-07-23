using System;
using System.Threading;
class Program
{
    static void Main()
    {
        // Queue a task to the ThreadPool
        ThreadPool.QueueUserWorkItem(new WaitCallback(DoWork));
        // Main thread continues to run
        for (int i = 0; i < 5; i++)
        {
            Console.WriteLine("Main thread: " + i);
            Thread.Sleep(100);
        }
        // Give some time for the ThreadPool thread to complete the work
        Thread.Sleep(1000);
    }
    static void DoWork(Object stateInfo)
    {
        for (int i = 0; i < 5; i++)
        {
            Console.WriteLine("ThreadPool thread: " + i);
            Thread.Sleep(100);
        }
    }
}
