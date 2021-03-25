namespace PracticeCaseStudyDP
{
    public abstract class CarFactory
    {
        public abstract Car BuildLuxuryCar(Location location);
        public abstract Car BuildMicroCar(Location location);
        public abstract Car BuildMiniCar(Location location);
    }

    public abstract class ConcreteCarFactory
    {
        public abstract Car BuildCar(CarType carType);
    }


}
