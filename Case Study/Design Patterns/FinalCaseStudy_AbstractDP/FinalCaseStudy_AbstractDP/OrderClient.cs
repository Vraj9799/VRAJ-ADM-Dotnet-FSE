namespace FinalCaseStudy_AbstractDP
{
    public class OrderClient
    {
        private ChannelFactory _channelFactory;

        public OrderClient(ChannelFactory channelFactory)
        {
            _channelFactory = channelFactory;
        }

        public void GetElectronicOrder(Channel channel)
        {
            switch (channel)
            {
                case Channel.E_Commerce:
                    _channelFactory = new ECommerceFactory();
                    _channelFactory.GetOrder(Product.Electronic);
                    break;
                case Channel.TeleCallerAgents:
                    _channelFactory = new TeleCallerAgentsFactory();
                    _channelFactory.GetOrder(Product.Electronic);
                    break;
                default:
                    break;
            }
        }
        public void GetToysOrder(Channel channel)
        {
            switch (channel)
            {
                case Channel.E_Commerce:
                    _channelFactory = new ECommerceFactory();
                    _channelFactory.GetOrder(Product.Toys);
                    break;
                case Channel.TeleCallerAgents:
                    _channelFactory = new TeleCallerAgentsFactory();
                    _channelFactory.GetOrder(Product.Toys);
                    break;
                default:
                    break;
            }
        }
        public void GetFurnitureOrder(Channel channel)
        {
            switch (channel)
            {
                case Channel.E_Commerce:
                    _channelFactory = new ECommerceFactory();
                    _channelFactory.GetOrder(Product.Furniture);
                    break;
                case Channel.TeleCallerAgents:
                    _channelFactory = new TeleCallerAgentsFactory();
                    _channelFactory.GetOrder(Product.Furniture);
                    break;
                default:
                    break;
            }
        }
    }
}
