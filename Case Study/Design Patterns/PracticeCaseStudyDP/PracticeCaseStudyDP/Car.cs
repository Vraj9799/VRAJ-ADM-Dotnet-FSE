namespace PracticeCaseStudyDP
{

    public abstract class Car
    {
        public Car(CarType carType, Location location)
        {
            CarType = carType;
            Location = location;
        }

        public CarType CarType { get; set; }
        public Location Location { get; set; }
        public abstract void Construct();

        public override string ToString()
        {
            return $"CarModel - {CarType.ToString()} located in {Location.ToString()}";
        }
    }
}
