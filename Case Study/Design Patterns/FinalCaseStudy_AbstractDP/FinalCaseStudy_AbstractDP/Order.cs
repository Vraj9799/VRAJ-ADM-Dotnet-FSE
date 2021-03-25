namespace FinalCaseStudy_AbstractDP
{
    public abstract class Order
    {
        protected Order(Channel channel, Product product)
        {
            Channel = channel;
            Product = product;
        }

        public Channel Channel { get; set; }
        public Product Product { get; set; }

        public abstract void processOrder();
        public override string ToString()
        {
            return $"Product - {Product} is order through {Channel}";
        }
    }
}
