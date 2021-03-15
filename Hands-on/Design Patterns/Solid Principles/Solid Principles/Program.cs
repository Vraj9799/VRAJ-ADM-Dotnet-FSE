using System;

namespace Solid_Principles
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.WriteLine("Welcome to our site. Would you like to order or repair?");
            string processOption = Console.ReadLine().ToLower().Trim();
            //PhoneOrderRepair phoneOrderRepair = new PhoneOrderRepair();
            PhoneOrder phoneOrder = new PhoneOrder();
            Repair repair = new Repair();
            string productDetail = string.Empty;
            switch (processOption)
            {
                case "order":
                    Console.WriteLine($"Please provide the phone model name");
                    productDetail = Console.ReadLine().Trim();
                    phoneOrder.ProcessOrder(productDetail);
                    break;
                case "repair":
                    Console.WriteLine($"Is it the phone or the accessory that you want to be repaired?");
                    string productType = Console.ReadLine().ToLower();
                    if (productType.Equals("phone"))
                    {
                        Console.WriteLine($"Please provide the phone model name");
                        productDetail = Console.ReadLine().Trim();
                        repair.ProcessPhoneRepair(productDetail);
                    }
                    else
                    {
                        Console.WriteLine($"Please provide the accessory detail, the headphone, tempered glass");
                        productDetail = Console.ReadLine().Trim();
                        repair.ProcessAccessoryRepair(productDetail);
                    }
                    break;
                default:
                    break;
            }
            Console.WriteLine("Thanks for choosing us. Have a great day.");
            Console.ReadLine();
        }
    }
}
