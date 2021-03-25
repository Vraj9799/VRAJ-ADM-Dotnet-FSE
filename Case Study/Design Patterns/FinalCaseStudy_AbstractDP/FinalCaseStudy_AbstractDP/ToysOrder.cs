using System;

namespace FinalCaseStudy_AbstractDP
{
    public class ToysOrder : Order
    {
        public ToysOrder(Product product, Channel channel) : base(channel, Product.Toys)
        {
            processOrder();
        }
        public override void processOrder()
        {
            Console.WriteLine("Got Toys Order");
            Console.WriteLine(base.ToString());
        }
    }
}
