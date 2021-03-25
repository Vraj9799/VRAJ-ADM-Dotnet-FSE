using System;

namespace PracticeCaseStudyDP
{
    public class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");
            //CarFactory factory = new ConcreteFactory();
            //CarClient client = new CarClient(factory);
            //client.BuildMicroCar(Location.USA);
            //client.BuildMiniCar(Location.INDIA);
            //client.BuildLuxuryCar(Location.DEFAULT);

            //Proper Approach
            Console.WriteLine("Factory Methods");
            ConcreteCarFactory carFactory = FactoryProducer.GetFactory(Location.INDIA);
            carFactory.BuildCar(CarType.LUXURY);
            carFactory.BuildCar(CarType.MINI);
            carFactory = FactoryProducer.GetFactory(Location.USA);
            carFactory.BuildCar(CarType.MICRO);
            Console.ReadLine();
        }
    }





    #region Enums
    public enum CarType
    {
        MICRO, MINI, LUXURY
    }
    public enum Location
    {
        DEFAULT, INDIA, USA
    }

    #endregion
}
