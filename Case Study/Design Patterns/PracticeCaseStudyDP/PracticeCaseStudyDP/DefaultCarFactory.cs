namespace PracticeCaseStudyDP
{

    public class DefaultCarFactory : ConcreteCarFactory
    {
        public override Car BuildCar(CarType carType)
        {
            switch (carType)
            {
                case CarType.LUXURY:
                    return new LuxuxryCar(CarType.LUXURY, Location.DEFAULT);
                case CarType.MINI:
                    return new MiniCar(CarType.MINI, Location.DEFAULT);
                case CarType.MICRO:
                    return new MicroCar(CarType.MICRO, Location.DEFAULT);
                default:
                    return null;
            }
        }
    }
}
