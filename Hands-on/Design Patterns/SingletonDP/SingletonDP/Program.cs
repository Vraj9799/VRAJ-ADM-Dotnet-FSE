using System;

namespace SingletonDP
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            DBConn instance1 = DBConn.getInstance();
            DBConn instance2 = DBConn.getInstance();
            if (instance1 == instance2)
                Console.WriteLine($"Both the instance are same with \n instance1 hash value {instance1.GetHashCode()} \n instance2 hash value {instance2.GetHashCode()}");
            Console.ReadLine();
        }
    }
}
