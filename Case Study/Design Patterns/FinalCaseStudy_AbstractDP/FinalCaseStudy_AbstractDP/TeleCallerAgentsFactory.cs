namespace FinalCaseStudy_AbstractDP
{
    public class TeleCallerAgentsFactory : ChannelFactory
    {
        public override Order GetOrder(Product product)
        {
            switch (product)
            {
                case Product.Electronic:
                    return new ElectronicOrder(product, Channel.TeleCallerAgents);
                case Product.Toys:
                    return new ToysOrder(product, Channel.TeleCallerAgents);
                case Product.Furniture:
                    return new FurnitureOrder(product, Channel.TeleCallerAgents);
                default:
                    return null;
            }
        }
    }
}
