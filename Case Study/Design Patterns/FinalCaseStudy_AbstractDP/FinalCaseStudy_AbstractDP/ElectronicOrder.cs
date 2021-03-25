using System;

namespace FinalCaseStudy_AbstractDP
{
    public class ElectronicOrder : Order
    {
        public ElectronicOrder(Product product, Channel channel) : base(channel, Product.Electronic)
        {
            processOrder();

        }
        public override void processOrder()
        {
            Console.WriteLine("Got Electronic Order");
            Console.WriteLine(base.ToString());
        }
    }
}
