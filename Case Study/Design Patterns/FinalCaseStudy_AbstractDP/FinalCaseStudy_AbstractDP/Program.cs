using System;

namespace FinalCaseStudy_AbstractDP
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            ChannelFactory factory = FactoryProducer.GetFactory(Channel.E_Commerce);
            factory.GetOrder(Product.Electronic);
            factory.GetOrder(Product.Furniture);

            factory = FactoryProducer.GetFactory(Channel.TeleCallerAgents);
            factory.GetOrder(Product.Toys);
            Console.ReadLine();
        }
    }


    #region Enums
    public enum Product
    {
        Electronic, Toys, Furniture
    }
    public enum Channel
    {
        E_Commerce, TeleCallerAgents
    }
    #endregion
}
