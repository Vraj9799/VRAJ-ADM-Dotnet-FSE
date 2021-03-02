using System;
using System.Threading;

namespace MultiThreadingSample
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"*****MultiThreading Program*****");
            Console.WriteLine($"Main Thread Started. Thread Id = {Thread.CurrentThread.ManagedThreadId}");
            Printer p = new Printer();
            WaitCallback workItem = new WaitCallback(PrintTheNumbers);
            for (int i = 0; i < 10; i++)
            {
                ThreadPool.QueueUserWorkItem(workItem, p);
            }
            Console.WriteLine("All task queued");
            Console.ReadLine();
        }
        public static void PrintTheNumbers(object state)
        {
            Printer task = (Printer)state;
            task.PrintNumbers();
        }
    }
}
