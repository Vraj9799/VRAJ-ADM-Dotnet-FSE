namespace PracticeCaseStudyDP
{

    public class USACarFactory : ConcreteCarFactory
    {
        public override Car BuildCar(CarType carType)
        {
            switch (carType)
            {
                case CarType.LUXURY:
                    return new LuxuxryCar(CarType.LUXURY, Location.USA);
                case CarType.MINI:
                    return new MiniCar(CarType.MINI, Location.USA);
                case CarType.MICRO:
                    return new MicroCar(CarType.MICRO, Location.USA);
                default:
                    return null;
            }
        }
    }
}
