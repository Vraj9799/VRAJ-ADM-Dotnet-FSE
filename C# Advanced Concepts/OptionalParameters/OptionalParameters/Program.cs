using System;

namespace OptionalParameters
{
    class Program
    {
        static void Main(string[] args)
        {
            Program obj = new Program();
            obj.OrderDetails("Vraj Shah", "Laptop");
            obj.OrderDetails("Vraj Shah", "Laptop", 100, false);
            Console.ReadLine();
        }
        public void OrderDetails(string sellerName, string productName, int quantity = 1, bool isReturnable = true)
        {
            Console.WriteLine($"Here is the order detail - {quantity} number of {productName} by {sellerName} is ordered. It's returnable status is {isReturnable}.");
        }
    }
}
