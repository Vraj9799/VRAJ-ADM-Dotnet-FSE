using System;

namespace FinalCaseStudy_AbstractDP
{
    public class FurnitureOrder : Order
    {
        public FurnitureOrder(Product product, Channel channel) : base(channel, Product.Furniture)
        {
            processOrder();
        }
        public override void processOrder()
        {
            Console.WriteLine("Got Furniture Order");
            Console.WriteLine(base.ToString());
        }
    }
}
