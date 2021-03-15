using System;

namespace Solid_Principles
{
    public class PhoneOrderRepair : IOrderRepair
    {
        public void ProcessAccessoryRepair(string accessoryType)
        {
            Console.WriteLine($"{accessoryType} repair accepted");
        }

        public void ProcessOrder(string modelName)
        {
            Console.WriteLine($"{modelName} order accepted!");
        }

        public void ProcessPhoneRepair(string modelName)
        {
            Console.WriteLine($"{modelName} repair accepted!");
        }
    }
}
