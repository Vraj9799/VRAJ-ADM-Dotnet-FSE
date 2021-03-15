using System;
using System.Threading;

namespace ThreadStartSample
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("************ThreadStart Delegate App**********");
            Console.WriteLine("Do You Want [1] or [2] threads?");
            string threadCount = Console.ReadLine();
            //Name the current Thread
            Thread primaryThread = Thread.CurrentThread;
            primaryThread.Name = "Primary";
            //Display Thread Info
            Console.WriteLine("-> {0} is executing Main()", Thread.CurrentThread.Name);
            //Make Worker Class
            Printer p = new Printer();
            switch (threadCount)
            {
                case "2":
                    //now make the thread.
                    //give only method name
                    Thread backgroundThread = new Thread(new ThreadStart(p.PrintNumbers))
                    {
                        Name = "Secondary"
                    };
                    backgroundThread.Start();
                    //changes the state of current instance to ThreadState.Running

                    break;
                case "1":
                    p.PrintNumbers();
                    break;
                default:
                    Console.WriteLine("I don't know what you want... you get 1 Thread");
                    goto case "1";
            }
            Thread.Sleep(3000);
            //Do some additional work.
            Console.WriteLine("Hello this from main!");
            Console.ReadLine();
        }
    }
}
