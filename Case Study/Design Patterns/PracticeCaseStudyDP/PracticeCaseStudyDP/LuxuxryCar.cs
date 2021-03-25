using System;

namespace PracticeCaseStudyDP
{

    public class LuxuxryCar : Car
    {
        public LuxuxryCar(CarType carType, Location location) : base(CarType.LUXURY, location)
        {
            Construct();
        }

        public override void Construct()
        {
            Console.WriteLine("Connecting to Luxury Car");
            Console.WriteLine(base.ToString());
        }
    }
}
