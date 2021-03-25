namespace PracticeCaseStudyDP
{
    public class CarClient
    {
        private CarFactory _carFactory;

        public CarClient(CarFactory carFactory)
        {
            _carFactory = carFactory;
        }
        public void BuildMicroCar(Location location)
        {
            _carFactory.BuildMicroCar(location);
        }
        public void BuildLuxuryCar(Location location)
        {
            _carFactory.BuildLuxuryCar(location);
        }
        public void BuildMiniCar(Location location)
        {
            _carFactory.BuildMiniCar(location);
        }
    }

    public class ConcreteFactory : CarFactory
    {
        //public override Car BuildCar(CarType carType, Location location)
        //{
        //    Car car = null;
        //    if (carType == CarType.LUXURY)
        //    {
        //        switch (location)
        //        {
        //            case Location.DEFAULT:
        //                car = new LuxuxryCar(CarType.LUXURY, Location.DEFAULT);
        //                break;
        //            case Location.INDIA:
        //                car = new LuxuxryCar(CarType.LUXURY, Location.INDIA);
        //                break;
        //            case Location.USA:
        //                car = new LuxuxryCar(CarType.LUXURY, Location.USA);
        //                break;
        //            default:
        //                break;
        //        }
        //    }
        //    else if (carType == CarType.MICRO)
        //    {
        //        switch (location)
        //        {
        //            case Location.DEFAULT:
        //                car = new MicroCar(CarType.MICRO, Location.DEFAULT);
        //                break;
        //            case Location.INDIA:
        //                car = new MicroCar(CarType.MICRO, Location.INDIA);
        //                break;
        //            case Location.USA:
        //                car = new MicroCar(CarType.MICRO, Location.USA);
        //                break;
        //            default:
        //                break;
        //        }
        //    }
        //    else if (carType == CarType.MINI)
        //    {
        //        switch (location)
        //        {
        //            case Location.DEFAULT:
        //                car = new MiniCar(CarType.MINI, Location.DEFAULT);
        //                break;
        //            case Location.INDIA:
        //                car = new MiniCar(CarType.MINI, Location.INDIA);
        //                break;
        //            case Location.USA:
        //                car = new MiniCar(CarType.MINI, Location.USA);
        //                break;
        //            default:
        //                break;
        //        }
        //    }
        //    return car;
        //}

        public override Car BuildLuxuryCar(Location location)
        {
            switch (location)
            {
                case Location.DEFAULT:
                    return new LuxuxryCar(CarType.LUXURY, Location.DEFAULT);
                case Location.INDIA:
                    return new LuxuxryCar(CarType.LUXURY, Location.INDIA);
                case Location.USA:
                    return new LuxuxryCar(CarType.LUXURY, Location.USA);
                default:
                    return null;
            }
        }

        public override Car BuildMicroCar(Location location)
        {
            switch (location)
            {
                case Location.DEFAULT:
                    return new MicroCar(CarType.MICRO, Location.DEFAULT);
                case Location.INDIA:
                    return new MicroCar(CarType.MICRO, Location.INDIA);
                case Location.USA:
                    return new MicroCar(CarType.MICRO, Location.USA);
                default:
                    return null;
            }
        }

        public override Car BuildMiniCar(Location location)
        {
            switch (location)
            {
                case Location.DEFAULT:
                    return new MiniCar(CarType.MINI, Location.DEFAULT);
                case Location.INDIA:
                    return new MiniCar(CarType.MINI, Location.INDIA);
                case Location.USA:
                    return new MiniCar(CarType.MINI, Location.USA);
                default:
                    return null;
            }
        }
    }
}
