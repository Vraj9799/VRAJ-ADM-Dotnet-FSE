namespace PracticeCaseStudyDP
{

    public class IndiaCarFactory : ConcreteCarFactory
    {

        public override Car BuildCar(CarType carType)
        {
            switch (carType)
            {
                case CarType.LUXURY:
                    return new LuxuxryCar(carType, Location.INDIA);
                case CarType.MICRO:
                    return new MicroCar(CarType.MICRO, Location.INDIA);
                case CarType.MINI:
                    return new MiniCar(CarType.MINI, Location.INDIA);
                default:
                    return null;
            }
        }
    }
}
