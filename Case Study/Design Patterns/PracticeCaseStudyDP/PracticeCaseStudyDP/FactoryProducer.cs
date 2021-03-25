namespace PracticeCaseStudyDP
{
    public class FactoryProducer
    {
        public static ConcreteCarFactory GetFactory(Location location)
        {
            switch (location)
            {
                case Location.DEFAULT:
                    return new DefaultCarFactory();
                case Location.INDIA:
                    return new IndiaCarFactory();
                case Location.USA:
                    return new USACarFactory();
                default:
                    return null;
            }
        }
    }

}
