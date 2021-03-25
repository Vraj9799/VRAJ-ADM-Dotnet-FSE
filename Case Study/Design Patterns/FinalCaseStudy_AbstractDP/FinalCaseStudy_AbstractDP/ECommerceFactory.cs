namespace FinalCaseStudy_AbstractDP
{
    public class ECommerceFactory : ChannelFactory
    {
        public override Order GetOrder(Product product)
        {
            switch (product)
            {
                case Product.Electronic:
                    return new ElectronicOrder(product, Channel.E_Commerce);
                case Product.Toys:
                    return new ToysOrder(product, Channel.E_Commerce);
                case Product.Furniture:
                    return new FurnitureOrder(product, Channel.E_Commerce);
                default:
                    return null;
            }
        }
    }
}
