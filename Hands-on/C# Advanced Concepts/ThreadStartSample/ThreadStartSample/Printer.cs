using System;
using System.Threading;

namespace ThreadStartSample
{
    public class Printer
    {
        public void PrintNumbers()
        {
            Console.WriteLine($"-> {Thread.CurrentThread.Name} is executing PrintNumbers()");
            //PrintNumbers
            Console.WriteLine("Your Number");
            for (int i = 0; i < 10; i++)
            {
                Console.Write($"{i} ");
                Thread.Sleep(2000);
            }
            Console.WriteLine();
        }
    }
}
