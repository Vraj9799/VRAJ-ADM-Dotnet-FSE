using System;
using System.Threading;
using System.Threading.Tasks;

namespace AsyncAwait1
{
    class Program
    {
        static void Main(string[] args)
        {
            string res = FirstMethod().Result;
            Console.WriteLine(res);
            Console.ReadLine();
        }
        public static async Task<string> FirstMethod()
        {
            return await SecondMethod();
        }
        public static async Task<string> SecondMethod()
        {
            return await Task.Run(() =>
            {
                Thread.Sleep(5000);
                return "Hello World";
            });
        }
    }
}
