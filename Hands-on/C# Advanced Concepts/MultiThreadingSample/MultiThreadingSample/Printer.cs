using System;
using System.Threading;

namespace MultiThreadingSample
{
    public class Printer
    {
        private object lockToken = new object();

        public void PrintNumbers()
        {
            lock (lockToken)
            {
                //Display Thread Info
                Console.WriteLine($"Thread -> {Thread.CurrentThread.ManagedThreadId} started {DateTime.Now.ToLongDateString()} and executing PrintNumbers() method");
                Console.WriteLine("Your Numbers:");
                for (int i = 0; i < 10; i++)
                {
                    Console.Write($"{i} ");
                    Thread.Sleep(1000);
                }
                Console.WriteLine();
            }
        }
    }
}
