namespace FinalCaseStudy_AbstractDP
{
    public class FactoryProducer
    {
        public static ChannelFactory GetFactory(Channel channel)
        {
            switch (channel)
            {
                case Channel.E_Commerce:
                    return new ECommerceFactory();
                case Channel.TeleCallerAgents:
                    return new TeleCallerAgentsFactory();
                default:
                    return null;
            }

        }
    }
}
